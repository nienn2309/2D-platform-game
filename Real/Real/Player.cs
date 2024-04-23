namespace Real
{
    public class Player : GameObject
    {
        bool right, left, jump, directionPressed, playingAction = false, climbale = false, isTakingDamage = false;
        internal bool isDisable1 = false, isDisable2 = false;

        int playerspeed = 4;
        internal int score = 0;
        int gravity = 17;
        int force;
        int actionStrength = 0;

        string currentDirection;

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
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }
        public int Health { get; private set; }

        public Player(string name, string description, int x, int y, int width, int height, int health) : base(name, description)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
            Health = health;
            SetPlayerAnimation("__Idle.gif");
        }

        private void SetUpAnimation()
        {
            ImageAnimator.Animate(Image, this.OnFrameChangedHandler);
        }

        private void OnFrameChangedHandler(object? sender, EventArgs e)
        {
            ImageAnimator.UpdateFrames(Image);
        }

        private void MovePlayerAnimation(string direction)
        {
            if (direction == "left")
            {
                left = true;
                currentDirection = "left";
                Image = Image.FromFile("__RunL.gif");
            }
            if (direction == "right")
            {
                right = true;
                currentDirection = "right";
                Image = Image.FromFile("__Run.gif");
            }

            directionPressed = true;
            playingAction = false;
            SetUpAnimation();
        }

        private void SetPlayerAction(string animation, int strength)
        {
            Image = Image.FromFile(animation);
            actionStrength = strength;
            SetUpAnimation();
            playingAction = true;
        }

        private void SetPlayerAnimation(string animation)
        {
            Image = Image.FromFile(animation);
            SetUpAnimation();
        }

        public void HandleKeyDown(KeyEventArgs e)
        {
            if(!isTakingDamage)
            {
                if (e.KeyCode == Keys.Left && !directionPressed)
                {
                    MovePlayerAnimation("left");
                }
                if (e.KeyCode == Keys.Right && !directionPressed)
                {
                    MovePlayerAnimation("right");
                }

                if (jump != true && climbale == false)
                {
                    if (e.KeyCode == Keys.Up)
                    {
                        Jump();
                    }
                }
                else if (climbale)
                {
                    if (e.KeyCode == Keys.Up)
                    {
                        Y -= 3;
                    }
                }

                if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
                {
                    Sit();
                }

                if (e.KeyCode == Keys.Space)
                {
                    Attack();
                }
            }
        }

        private void Attack()
        {
            if (currentDirection == "right")
            {
                SetPlayerAction("__AttackR.gif", 5);
            }else if (currentDirection == "left")
            {
                SetPlayerAction("__AttackL.gif", 5);
            }

            System.Windows.Forms.Timer attackTimer = new System.Windows.Forms.Timer();
            attackTimer.Interval = 350;
            attackTimer.Tick += (sender, e) =>
            {
                if (currentDirection == "right")
                {
                    SetPlayerAnimation("__Idle.gif");
                    playingAction = false;
                }
                else if (currentDirection == "left")
                {
                    SetPlayerAnimation("__IdleL.gif");
                    playingAction = false;
                }
                attackTimer.Stop();
                attackTimer.Dispose();
            };
            attackTimer.Start();
        }

        public void HandleKeyUp(KeyEventArgs e)
        {
            if (!isTakingDamage)
            {
                if (e.KeyCode == Keys.Right)
                {
                    right = false;
                    directionPressed = false;
                    SetPlayerAnimation("__Idle.gif");
                    playingAction = false;
                }
                else if (e.KeyCode == Keys.Left)
                {
                    left = false;
                    directionPressed = false;
                    SetPlayerAnimation("__IdleL.gif");
                    playingAction = false;
                }
                if (e.KeyCode == Keys.Down)
                {
                    StandUp();
                }
            }
        }

        public void Jump()
        {
            jump = true;
            force = gravity;
        }

        private void Sit()
        {
            if (!jump)
            {
                SetPlayerAnimation("__Crouch.gif");
                playingAction = false;
            }
        }

        private void StandUp()
        {
            SetPlayerAction("__Idle.gif", 0);
            playingAction = false;
        }

        public void TakeDamage(int damage, bool direction)
        {
            if (!isTakingDamage && Health > 0)
            {
                isTakingDamage = true;
                if (direction == false)
                {
                    SetPlayerAnimation("__TakeDamageR.gif");
                }
                else if(direction == true)
                {
                    SetPlayerAnimation("__TakeDamageL.gif");
                }

                System.Windows.Forms.Timer damageTimer = new System.Windows.Forms.Timer();
                damageTimer.Interval = 600;
                damageTimer.Tick += (sender, e) =>
                {
                    if (direction == false)
                    {
                        SetPlayerAnimation("__IdleL.gif");
                    }
                    else if (direction == true)
                    {
                        SetPlayerAnimation("__Idle.gif");
                    }
                    damageTimer.Stop();
                    damageTimer.Dispose();
                    isTakingDamage = false;
                };

                damageTimer.Start();
                Health -= damage;
            }
            if (Health <= 0)
            {
                isTakingDamage = true;
                isDisable2 = true;
                if (direction == false)
                {
                    SetPlayerAnimation("__TakeDamageR.gif");
                }
                else if (direction == true)
                {
                    SetPlayerAnimation("__TakeDamageL.gif");
                }
            }
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

        public void Update(List<Platform> platforms, Size GameArea)
        {

            if (right == true)
            {
                X += playerspeed;
            }
            if (left == true)
            {
                X -= playerspeed;
            }

            if (jump == true)
            {
                Y -= force;
                force -= 1;
            }

            if (Y + Height >= GameArea.Height)
            {
                Y = GameArea.Height - Height;
                jump = false;
            }
            else
            {
                if(climbale == false)
                {
                    Y += 5;
                }
            }

            foreach (Platform platform in platforms)
            {
                if (X + Width > platform.PB.Left && X < platform.PB.Right && Y + Height >= platform.PB.Top && Y < platform.PB.Top)
                {
                    Y = platform.PB.Top - Height;
                    force = 0;
                    jump = false;
                }

                if (X + Width > platform.PB.Left && X + Width < platform.PB.Left + platform.PB.Width + Width && Y - platform.PB.Bottom <= 10 && Y - platform.PB.Top > -10)
                {
                    force = -1;
                }
                if (X + Width > platform.PB.Left && X < platform.PB.Left + Width && Y + Height > platform.PB.Top && Y < platform.PB.Bottom)
                {
                    X = platform.PB.Left - Width;
                }

                if (X < platform.PB.Right && X + Width > platform.PB.Right && Y + Height > platform.PB.Top && Y < platform.PB.Bottom)
                {
                    X = platform.PB.Right;
                }
            }

        }

        public void Update2(Enemy enemy, List<InteractableObject> objects)
        {
            bool collision = enemy.DetectCollision(X, Y, Width, Height, enemy.X, enemy.Y, enemy.Width, enemy.Height);

            if (collision && playingAction)
            {
                enemy.SetNewHealth(actionStrength, objects);
            }
        }

        public void Update3(List<InteractableObject> objects)
        {
            List<InteractableObject> objectsToAdd = new List<InteractableObject>();

            foreach (InteractableObject obj in objects)
            {
                bool collision = obj.DetectCollision(X, Y, Width, Height, obj.X, obj.Y, obj.Width, obj.Height);
                if (collision && playingAction)
                {
                    if (obj is Chest chest)
                    {
                        chest.Interact(objectsToAdd);
                    }
                }

                if (obj is Ladder)
                {
                    bool secondcollision = obj.DetectAvailableZone(X, obj.X, obj.Width);
                    bool thirdcollision = obj.DetectAvailableHeight(Y, obj.Y, obj.Height);
                    if (secondcollision && thirdcollision)
                    {
                        climbale = true;
                    }
                    else
                    {
                        climbale = false;
                    }
                }

                if (obj is Coin coin)
                {
                    bool fourthcollision = obj.DetectCollision(X, Y, Width, Height, obj.X, obj.Y, obj.Width, obj.Height);
                    if (fourthcollision)
                    {
                        if (!coin.isInteracted && !coin.touchedByPlayer)
                        {
                            coin.Interact();
                            score += 1;
                        }
                    }
                }

                if (obj is Flag flag)
                {
                    bool fifthcollision = obj.DetectCollision(X, Y, Width, Height, obj.X, obj.Y, obj.Width, obj.Height);
                    if (fifthcollision && score == 7)
                    {
                        flag.Interact();
                        isDisable1 = true;
                    }
                }
            }
            objects.AddRange(objectsToAdd);
        }
    }
}