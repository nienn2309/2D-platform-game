namespace Real
{
    partial class Description
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Description));
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkGray;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Azure;
            label1.Location = new Point(47, 350);
            label1.Name = "label1";
            label1.Size = new Size(1084, 240);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(47, 12);
            button1.Name = "button1";
            button1.Size = new Size(78, 33);
            button1.TabIndex = 1;
            button1.Text = "EXIT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Description
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.wallpaperflare_com_wallpaper;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1184, 609);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Description";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Description";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
    }
}