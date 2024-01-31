namespace X_O_Game
{
    partial class StartGame
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
            panel1 = new Panel();
            textBox1 = new TextBox();
            rb2 = new RadioButton();
            rb1 = new RadioButton();
            lblname1 = new Label();
            panel2 = new Panel();
            textBox2 = new TextBox();
            rb4 = new RadioButton();
            rb3 = new RadioButton();
            lblname2 = new Label();
            label1 = new Label();
            btnStartGame = new Button();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ScrollBar;
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(rb2);
            panel1.Controls.Add(rb1);
            panel1.Controls.Add(lblname1);
            panel1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(42, 241);
            panel1.Name = "panel1";
            panel1.Size = new Size(296, 175);
            panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(16, 115);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(258, 43);
            textBox1.TabIndex = 3;
            // 
            // rb2
            // 
            rb2.AutoSize = true;
            rb2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            rb2.Location = new Point(224, 55);
            rb2.Name = "rb2";
            rb2.Size = new Size(55, 41);
            rb2.TabIndex = 2;
            rb2.TabStop = true;
            rb2.Text = "O";
            rb2.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            rb1.AutoSize = true;
            rb1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            rb1.Location = new Point(141, 55);
            rb1.Name = "rb1";
            rb1.Size = new Size(53, 41);
            rb1.TabIndex = 1;
            rb1.TabStop = true;
            rb1.Text = "X";
            rb1.UseVisualStyleBackColor = true;
            // 
            // lblname1
            // 
            lblname1.AutoSize = true;
            lblname1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            lblname1.Location = new Point(16, 55);
            lblname1.Name = "lblname1";
            lblname1.Size = new Size(93, 37);
            lblname1.TabIndex = 0;
            lblname1.Text = "Name";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ScrollBar;
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(rb4);
            panel2.Controls.Add(rb3);
            panel2.Controls.Add(lblname2);
            panel2.Location = new Point(599, 241);
            panel2.Name = "panel2";
            panel2.Size = new Size(298, 175);
            panel2.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(12, 115);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(268, 43);
            textBox2.TabIndex = 3;
            // 
            // rb4
            // 
            rb4.AutoSize = true;
            rb4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            rb4.Location = new Point(213, 53);
            rb4.Name = "rb4";
            rb4.Size = new Size(55, 41);
            rb4.TabIndex = 2;
            rb4.TabStop = true;
            rb4.Text = "O";
            rb4.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            rb3.AutoSize = true;
            rb3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rb3.Location = new Point(122, 53);
            rb3.Name = "rb3";
            rb3.Size = new Size(53, 41);
            rb3.TabIndex = 1;
            rb3.TabStop = true;
            rb3.Text = "X";
            rb3.UseVisualStyleBackColor = true;
            // 
            // lblname2
            // 
            lblname2.AutoSize = true;
            lblname2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            lblname2.Location = new Point(12, 55);
            lblname2.Name = "lblname2";
            lblname2.Size = new Size(93, 37);
            lblname2.TabIndex = 0;
            lblname2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Script MT Bold", 50.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(408, 285);
            label1.Name = "label1";
            label1.Size = new Size(107, 81);
            label1.TabIndex = 2;
            label1.Text = "Vs";
            // 
            // btnStartGame
            // 
            btnStartGame.BackColor = SystemColors.ButtonHighlight;
            btnStartGame.Font = new Font("Segoe Print", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStartGame.Location = new Point(352, 456);
            btnStartGame.Name = "btnStartGame";
            btnStartGame.Size = new Size(228, 61);
            btnStartGame.TabIndex = 3;
            btnStartGame.Text = "Start Game";
            btnStartGame.UseVisualStyleBackColor = false;
            btnStartGame.Click += btnStartGame_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Font = new Font("Segoe Print", 50.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(266, 34);
            label2.Name = "label2";
            label2.Size = new Size(400, 118);
            label2.TabIndex = 4;
            label2.Text = "X O Game";
            // 
            // StartGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            BackgroundImage = Properties.Resources.images__1_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1001, 555);
            Controls.Add(label2);
            Controls.Add(btnStartGame);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "StartGame";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox textBox1;
        private RadioButton rb2;
        private RadioButton rb1;
        private Label lblname1;
        private TextBox textBox2;
        private RadioButton rb4;
        private RadioButton rb3;
        private Label lblname2;
        private Label label1;
        private Button btnStartGame;
        private Label label2;
    }
}
