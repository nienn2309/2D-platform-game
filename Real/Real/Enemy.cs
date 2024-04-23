using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Numerics;
using System.Windows.Forms;

namespace Real
{
    public class Enemy : GameObject
    {
        int currentFrame, walkingFrameCount;
        int walkingSpeed;
        int attackPower = 10;
        private DateTime lastAttackTime;
        private bool hasDealtDamage = false;
        public enum EnemyState
        {
            Spawning,
            Walking,
            Attack,
            Death,
            TakeDamage,
        }
        private Image image;
        public Image Image
        {
            get { return image; }
            private set
            {
                image = value;
                Width = image.Width;
                Height = image.Height;
            }
        }
        public EnemyState State { get; private set; }
        internal int Health { get; private set; }
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }
        private bool IsAttacking { get; set; } = false;
        private bool IsDamage { get; set; } = false;
        internal bool direction = false;
        private bool wakeup = false;
        private int initalX;
        private System.Windows.Forms.Timer attackTimer;
        private System.Windows.Forms.Timer TakeAttackTimer;

        public Enemy(string name, string description, int x, int y, int width, int height, int initialHealth) : base(name, description)
        {
            X = x;
            initalX = x;
            Y = y;
            Width = width;
            Height = height;
            Health = initialHealth;
            State = EnemyState.Spawning;
            LoadAnimation("skeleton_seeker_spawn.gif");
        }

        private void SetUpAnimation()
        {
            ImageAnimator.Animate(Image, this.OnFrameChangedHandler);
        }

        private void OnFrameChangedHandler(object? sender, EventArgs e)
        {
            if (wakeup)
            {
                ImageAnimator.UpdateFrames(Image);
            }
        }

        private void LoadAnimation(string imagePath)
        {
            Image = Image.FromFile(imagePath);
            SetUpAnimation();
            walkingFrameCount = Image.GetFrameCount(FrameDimension.Time);
        }

        public void SetNewHealth(int takedmg, List<InteractableObject> interactableObjects)
        {
            if(wakeup && Health > 0)
            {
                if (State != EnemyState.TakeDamage)
                {
                    Health -= takedmg;
                    State = EnemyState.TakeDamage;
                }
            }
            if (Health <= 0 && State != EnemyState.Death)
            {
                LoadAnimation("skeleton_seeker_death.gif");
                State = EnemyState.Death;

                Coin Coin = new Coin(X, Y);
                interactableObjects.Add(Coin);
            }

        }

        public void Update(Platform platform, Player p)
        {
            if (Math.Sqrt(Math.Pow(p.X - X, 2) + Math.Pow(p.Y - Y, 2)) < 200)
            {
                wakeup = true;
            }
            if (wakeup == true)
            {
                if (State == EnemyState.Spawning)
                {
                    if (currentFrame < walkingFrameCount)
                    {
                        ImageAnimator.UpdateFrames(Image);
                        currentFrame++;
                    }
                    else
                    {
                        State = EnemyState.Walking;
                        currentFrame = 0;
                        LoadAnimation("skeleton_seeker_walk.gif");
                    }
                }
                else if (State == EnemyState.Walking)
                {
                    if (X <= initalX)
                    {
                        walkingSpeed = 1;
                        LoadAnimation("skeleton_seeker_walk.gif");
                        direction = false;
                    }
                    else if (X >= platform.PB.Width + platform.PB.Left - Width)
                    {
                        walkingSpeed = -1;
                        LoadAnimation("skeleton_seeker_walk_flipped.gif");
                        direction = true;
                    }
                    X += walkingSpeed;
                    TimeSpan timeSinceLastAttack = DateTime.Now - lastAttackTime;
                    if (timeSinceLastAttack.TotalMilliseconds >= 2000)
                    {
                        if (Math.Abs(X - p.X) < 100 && Math.Abs(X - p.X) > 90 && direction == false && Y < p.Y && p.X > X)
                        {
                            if (!IsAttacking)
                            {
                                Attack("skeleton_seeker_attack.gif");
                            }
                        }
                        if (Math.Abs(X - p.X) < 15 && Math.Abs(X - p.X) > 5 && direction == true && Y < p.Y && p.X < X)
                        {
                            if (!IsAttacking)
                            {
                                Attack("skeleton_seeker_attack_flipped.gif");
                            }
                        }
                    }
                }
                else if (State == EnemyState.Attack)
                {
                    if (!IsAttacking)
                    {
                        State = EnemyState.Walking;
                        if (direction == true)
                        {
                            LoadAnimation("skeleton_seeker_walk_flipped.gif");
                        }
                        else if (direction == false)
                        {
                            LoadAnimation("skeleton_seeker_walk.gif");
                        }
                    }
                }
                else if (State == EnemyState.TakeDamage)
                {
                    if (!IsDamage && direction == false)
                    {
                        TakeDamage("skeleton_seeker_damage.gif");
                    }else if (!IsDamage && direction == true)
                    {
                        TakeDamage("skeleton_seeker_damage_flipped.gif");
                    }
                }
                else if (State == EnemyState.Death)
                {
                    
                }
            }
            if (Y + Height < platform.PB.Top)
            {
                Y = platform.PB.Top - Height;
            }

            bool collision = p.DetectCollision(X, Y, Width, Height, p.X, p.Y, p.Width, p.Height);
            if (IsAttacking)
            {
                TimeSpan timeSinceLastAttack = DateTime.Now - lastAttackTime;
                if (timeSinceLastAttack.TotalMilliseconds >= 600 && timeSinceLastAttack.TotalMilliseconds <= 800)
                {
                    if (!hasDealtDamage && collision)
                    {
                        p.TakeDamage(attackPower, direction);
                        hasDealtDamage = true;
                    }
                }
            }
            else
            {
                hasDealtDamage = false;
            }
        }

        private void Attack(string imagePath)
        {
            LoadAnimation(imagePath);
            IsAttacking = true;
            hasDealtDamage = false;

            attackTimer = new System.Windows.Forms.Timer();
            attackTimer.Interval = 800;
            lastAttackTime = DateTime.Now;
            attackTimer.Tick += (sender, e) =>
            {
                IsAttacking = false;
                attackTimer.Stop();
                attackTimer.Dispose();
            };
            attackTimer.Start();

            State = EnemyState.Attack;
        }

        private void TakeDamage(string imagePath)
        {
            LoadAnimation(imagePath);
            IsDamage = true;

            TakeAttackTimer = new System.Windows.Forms.Timer();
            TakeAttackTimer.Interval = 400;
            TakeAttackTimer.Tick += (sender, e) =>
            {
                IsDamage = false;

                TakeAttackTimer.Stop();
                TakeAttackTimer.Dispose();
            };
            TakeAttackTimer.Start();

            State = EnemyState.Attack;
        }

        internal bool DetectCollision(int object1X, int object1Y, int object1Width, int object1Height, int object2X, int object2Y, int object2Width, int object2Height)
        {
            if (object1X + object1Width <= object2X || object1X >= object2X + object2Width || object1Y + object1Height <= object2Y || object1Y >= object2Y + object2Height)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
