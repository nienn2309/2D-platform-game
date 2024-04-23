namespace Real
{
    partial class GameForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            gameTimer = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            progressBar1 = new ProgressBar();
            label2 = new Label();
            logogameover = new PictureBox();
            exit_but = new Button();
            win = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)logogameover).BeginInit();
            ((System.ComponentModel.ISupportInitialize)win).BeginInit();
            SuspendLayout();
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            gameTimer.Tick += gameTimer_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(900, 12);
            label1.Name = "label1";
            label1.Size = new Size(0, 21);
            label1.TabIndex = 0;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(954, 12);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(218, 18);
            progressBar1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(848, 36);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // logogameover
            // 
            logogameover.BackColor = Color.Transparent;
            logogameover.Image = Properties.Resources.pngegg;
            logogameover.Location = new Point(450, 162);
            logogameover.Name = "logogameover";
            logogameover.Size = new Size(226, 222);
            logogameover.TabIndex = 3;
            logogameover.TabStop = false;
            logogameover.Visible = false;
            // 
            // exit_but
            // 
            exit_but.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            exit_but.Location = new Point(526, 390);
            exit_but.Name = "exit_but";
            exit_but.Size = new Size(75, 32);
            exit_but.TabIndex = 4;
            exit_but.Text = "EXIT";
            exit_but.UseVisualStyleBackColor = true;
            exit_but.Visible = false;
            exit_but.Click += exit_but_Click;
            // 
            // win
            // 
            win.BackColor = Color.Transparent;
            win.Image = Properties.Resources._1;
            win.Location = new Point(413, 97);
            win.Name = "win";
            win.Size = new Size(295, 287);
            win.TabIndex = 5;
            win.TabStop = false;
            win.Visible = false;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImage = Properties.Resources.Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1184, 609);
            Controls.Add(win);
            Controls.Add(exit_but);
            Controls.Add(logogameover);
            Controls.Add(label2);
            Controls.Add(progressBar1);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "GameForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GameForm";
            Paint += FormPaintEvent;
            KeyDown += KeyIsDown;
            KeyPress += KeyIsPress;
            KeyUp += KeyIsUp;
            Resize += GameForm_Resize;
            ((System.ComponentModel.ISupportInitialize)logogameover).EndInit();
            ((System.ComponentModel.ISupportInitialize)win).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer gameTimer;
        private Label label1;
        private ProgressBar progressBar1;
        private Label label2;
        private PictureBox logogameover;
        private Button exit_but;
        private PictureBox win;
    }
}