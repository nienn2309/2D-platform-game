namespace Real
{
    public partial class GameForm : Form
    {
        private Player player;
        private List<Platform> platforms = new List<Platform>();
        private List<Decoration> decorations = new List<Decoration>();
        private List<InteractableObject> IObjects = new List<InteractableObject>();
        private Enemy enemy;
        private Platform ground1, ground2, ground3, ground4, ground5, ground6, ground7, ground8, ground9, ground10, ground11, ground12, ground13, ground14, ground15;
        private Decoration decoration1, decoration2, decoration3, decoration4, decoration5, decoration6, decoration7, decoration8, decoration9, decoration10, decoration11, decoration12;
        private AnimatedObject Adecoration1;
        private AnimatedObject AdecorationC1, AdecorationC2, AdecorationC3, AdecorationC4, AdecorationC5, AdecorationC6;
        private InteractableObject Iobject1;
        public GameForm()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true);

            player = new Player("player", "A handsome guy", 60, 90, 40, 40, 100);
            enemy = new Enemy("enemy", "Evil enemy", 230, 470, 40, 40, 50);
            ground1 = new Custom4(0, 352, 128, 96);
            ground2 = new East(0, 0, 64, 96);
            ground3 = new Custom1(0, 96, 96, 64);
            ground4 = new Custom2(0, 160, 160, 64);
            ground5 = new Custom3(0, 224, 96, 64);
            ground6 = new East(0, 288, 64, 64);
            ground7 = new Custom5(0, 448, 192, 32);
            ground8 = new North(224, 576, 416, 32);
            ground9 = new Custom6(0, 480, 224, 128);
            ground10 = new Custom7(640, 512, 160, 96);
            ground11 = new Custom8(864, 544, 128, 64);
            ground12 = new Custom8(1056, 384, 128, 224);
            ground13 = new Line(640, 352, 128, 32);
            ground14 = new Line(832, 320, 32, 32);
            ground15 = new Line(928, 352, 64, 32);
            decoration1 = new Willow(980, 202);
            decoration2 = new Tree(865, 395);
            decoration3 = new Bush(930, 521);
            decoration4 = new Ridge(940, 325);
            decoration5 = new Ridge0(700, 452);
            decoration6 = new Ridge1(650, 327);
            decoration7 = new PointerRight(840, 300);
            decoration8 = new PointerNorthRight(740, 492);
            decoration9 = new Box(700, 327);
            decoration10 = new Bush0(1060, 357);
            decoration11 = new Bush1(650, 488);
            decoration12 = new Willow0(90, 26);
            Adecoration1 = new Flag(1140, 336);
            AdecorationC1 = new Coin(760, 300);
            AdecorationC2 = new Coin(785, 280);
            AdecorationC3 = new Coin(820, 290);
            AdecorationC4 = new Coin(880, 300);
            AdecorationC5 = new Coin(920, 320);
            AdecorationC6 = new Chest(740, 321);
            Iobject1 = new Ladder(767, 352, 160);

            platforms.Add(ground1);
            platforms.Add(ground2);
            platforms.Add(ground3);
            platforms.Add(ground4);
            platforms.Add(ground5);
            platforms.Add(ground6);
            platforms.Add(ground7);
            platforms.Add(ground8);
            platforms.Add(ground9);
            platforms.Add(ground10);
            platforms.Add(ground11);
            platforms.Add(ground12);
            platforms.Add(ground13);
            platforms.Add(ground14);
            platforms.Add(ground15);
            decorations.Add(decoration1);
            decorations.Add(decoration2);
            decorations.Add(decoration3);
            decorations.Add(decoration4);
            decorations.Add(decoration5);
            decorations.Add(decoration6);
            decorations.Add(decoration7);
            decorations.Add(decoration8);
            decorations.Add(decoration9);
            decorations.Add(decoration10);
            decorations.Add(decoration11);
            decorations.Add(decoration12);
            IObjects.Add(Adecoration1);
            IObjects.Add(AdecorationC1);
            IObjects.Add(AdecorationC2);
            IObjects.Add(AdecorationC3);
            IObjects.Add(AdecorationC4);
            IObjects.Add(AdecorationC5);
            IObjects.Add(AdecorationC6);
            IObjects.Add(Iobject1);

            label1.Location = new Point(830, 11);
            label2.Location = new Point(750, 33);
            label1.Font = new Font(label1.Font, FontStyle.Bold);
            label1.ForeColor = Color.White;
        }

        public void OnFrameChangedHandler(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            player.HandleKeyDown(e);
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            player.HandleKeyUp(e);
        }
        private void KeyIsPress(object sender, KeyPressEventArgs e)
        {

        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            player.Update(platforms, this.ClientSize);
            player.Update2(enemy, IObjects);
            player.Update3(IObjects);
            enemy.Update(ground8, player);
            this.Invalidate();

            label1.Text = "Player's Health";
            label2.Text = "You must get 7 coin and touch the flag to complete the level\nYour score: " + player.score;
            progressBar1.Value = player.Health;
            if (player.isDisable1 == true)
            {
                gameTimer.Stop();
                exit_but.Visible = true;
                win.Visible = true;
            }

            if (player.isDisable2 == true)
            {
                gameTimer.Stop();
                logogameover.Visible = true;
                exit_but.Visible = true;
            }
        }

        private void FormPaintEvent(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            foreach (var obstacle in IObjects)
            {
                if (obstacle is InteractableObject)
                {
                    obstacle.Draw(canvas);
                }
            }

            foreach (var obstacle in platforms)
            {
                obstacle.Draw(canvas);
            }

            foreach (var obstacle in decorations)
            {
                if (obstacle is NormalDecation)
                {
                    obstacle.Draw(canvas);
                }
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            foreach (var objectt in IObjects)
            {
                if (objectt is AnimatedObject)
                {
                    lock (objectt.Image)
                    {
                        if (objectt is Coin coin && !coin.isInteracted)
                        {
                            g.DrawImage(objectt.Image, objectt.X, objectt.Y);
                        }

                        if (objectt is Chest)
                        {
                            g.DrawImage(objectt.Image, objectt.X, objectt.Y);
                        }

                        if (objectt is Flag)
                        {
                            g.DrawImage(objectt.Image, objectt.X, objectt.Y);
                        }
                    }
                }
            }

            lock (player.Image)
            {
                g.DrawImage(player.Image, player.X, player.Y);
            }

            lock (enemy.Image)
            {
                g.DrawImage(enemy.Image, enemy.X, enemy.Y);
            }

        }

        private void GameForm_Resize(object sender, EventArgs e)
        {
            this.Size = new Size(1200, 648);
        }

        private void exit_but_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu gameForm = new MainMenu();
            gameForm.FormClosed += (s, args) => this.Close();
            gameForm.Show();
        }
    }
}