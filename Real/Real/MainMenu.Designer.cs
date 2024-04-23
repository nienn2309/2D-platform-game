namespace Real
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            play_button = new Button();
            description_button = new Button();
            exit_button = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // play_button
            // 
            play_button.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            play_button.Location = new Point(240, 188);
            play_button.Name = "play_button";
            play_button.Size = new Size(146, 45);
            play_button.TabIndex = 0;
            play_button.Text = "PLAY";
            play_button.UseVisualStyleBackColor = true;
            play_button.Click += play_button_Click;
            // 
            // description_button
            // 
            description_button.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            description_button.Location = new Point(240, 250);
            description_button.Name = "description_button";
            description_button.Size = new Size(146, 47);
            description_button.TabIndex = 1;
            description_button.Text = "INTRODUCTION";
            description_button.UseVisualStyleBackColor = true;
            description_button.Click += description_button_Click;
            // 
            // exit_button
            // 
            exit_button.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            exit_button.Location = new Point(240, 321);
            exit_button.Name = "exit_button";
            exit_button.Size = new Size(146, 47);
            exit_button.TabIndex = 2;
            exit_button.Text = "EXIT";
            exit_button.UseVisualStyleBackColor = true;
            exit_button.Click += exit_button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(201, 122);
            label1.Name = "label1";
            label1.Size = new Size(225, 32);
            label1.TabIndex = 3;
            label1.Text = "2D Platform Game";
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackgroundImage = Properties.Resources._1298880;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1184, 609);
            Controls.Add(label1);
            Controls.Add(exit_button);
            Controls.Add(description_button);
            Controls.Add(play_button);
            DoubleBuffered = true;
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button play_button;
        private Button description_button;
        private Button exit_button;
        private Label label1;
    }
}