namespace X_O_Game
{
    partial class Playing
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            panel5 = new Panel();
            button12 = new Button();
            button11 = new Button();
            button10 = new Button();
            panel4 = new Panel();
            libpl1 = new Label();
            libpl2 = new Label();
            lbl1 = new Label();
            lbl2 = new Label();
            panel3 = new Panel();
            btnTic9 = new Button();
            btnTic8 = new Button();
            btnTic7 = new Button();
            btnTic6 = new Button();
            btnTic5 = new Button();
            btnTic4 = new Button();
            btnTic3 = new Button();
            btnTic2 = new Button();
            btnTic1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1177, 85);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 35.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(451, -3);
            label1.Name = "label1";
            label1.Size = new Size(280, 84);
            label1.TabIndex = 0;
            label1.Text = "X O Game";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.InactiveCaption;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(1, 74);
            panel2.Name = "panel2";
            panel2.Size = new Size(1177, 492);
            panel2.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(button12);
            panel5.Controls.Add(button11);
            panel5.Controls.Add(button10);
            panel5.Location = new Point(631, 205);
            panel5.Name = "panel5";
            panel5.Size = new Size(438, 236);
            panel5.TabIndex = 3;
            // 
            // button12
            // 
            button12.BackColor = SystemColors.ControlLightLight;
            button12.Font = new Font("Segoe Print", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button12.Location = new Point(3, 122);
            button12.Name = "button12";
            button12.Size = new Size(148, 97);
            button12.TabIndex = 11;
            button12.Text = "Reset";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // button11
            // 
            button11.BackColor = SystemColors.ControlLightLight;
            button11.Font = new Font("Segoe Print", 39.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button11.Location = new Point(3, 15);
            button11.Name = "button11";
            button11.Size = new Size(428, 95);
            button11.TabIndex = 10;
            button11.Text = "New Game";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // button10
            // 
            button10.BackColor = SystemColors.ControlLightLight;
            button10.Font = new Font("Segoe Print", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.Location = new Point(164, 122);
            button10.Margin = new Padding(0);
            button10.Name = "button10";
            button10.Size = new Size(267, 97);
            button10.TabIndex = 9;
            button10.Text = "Save Score";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.InactiveCaption;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(libpl1);
            panel4.Controls.Add(libpl2);
            panel4.Controls.Add(lbl1);
            panel4.Controls.Add(lbl2);
            panel4.Font = new Font("Segoe Print", 39.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            panel4.Location = new Point(631, 15);
            panel4.Name = "panel4";
            panel4.Size = new Size(433, 174);
            panel4.TabIndex = 2;
            // 
            // libpl1
            // 
            libpl1.BackColor = SystemColors.ButtonHighlight;
            libpl1.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            libpl1.Location = new Point(206, 20);
            libpl1.Name = "libpl1";
            libpl1.Size = new Size(175, 54);
            libpl1.TabIndex = 3;
            libpl1.Text = "0";
            libpl1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // libpl2
            // 
            libpl2.BackColor = SystemColors.ControlLightLight;
            libpl2.BorderStyle = BorderStyle.Fixed3D;
            libpl2.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            libpl2.ImageAlign = ContentAlignment.TopRight;
            libpl2.Location = new Point(206, 97);
            libpl2.Name = "libpl2";
            libpl2.Size = new Size(175, 54);
            libpl2.TabIndex = 2;
            libpl2.Text = "0";
            libpl2.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1.Location = new Point(3, 20);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(175, 54);
            lbl1.TabIndex = 1;
            lbl1.Text = "Player 1";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2.Location = new Point(3, 97);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(175, 54);
            lbl2.TabIndex = 0;
            lbl2.Text = "Player 2";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.InactiveCaption;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(btnTic9);
            panel3.Controls.Add(btnTic8);
            panel3.Controls.Add(btnTic7);
            panel3.Controls.Add(btnTic6);
            panel3.Controls.Add(btnTic5);
            panel3.Controls.Add(btnTic4);
            panel3.Controls.Add(btnTic3);
            panel3.Controls.Add(btnTic2);
            panel3.Controls.Add(btnTic1);
            panel3.Location = new Point(40, 16);
            panel3.Name = "panel3";
            panel3.Size = new Size(526, 425);
            panel3.TabIndex = 1;
            // 
            // btnTic9
            // 
            btnTic9.BackColor = SystemColors.ControlLightLight;
            btnTic9.Font = new Font("Microsoft Sans Serif", 50.25F);
            btnTic9.Location = new Point(338, 292);
            btnTic9.Name = "btnTic9";
            btnTic9.Size = new Size(119, 112);
            btnTic9.TabIndex = 8;
            btnTic9.UseVisualStyleBackColor = false;
            btnTic9.Click += btnTic9_Click;
            // 
            // btnTic8
            // 
            btnTic8.BackColor = SystemColors.ControlLightLight;
            btnTic8.Font = new Font("Microsoft Sans Serif", 50.25F);
            btnTic8.Location = new Point(188, 292);
            btnTic8.Name = "btnTic8";
            btnTic8.Size = new Size(119, 112);
            btnTic8.TabIndex = 7;
            btnTic8.UseVisualStyleBackColor = false;
            btnTic8.Click += btnTic8_Click;
            // 
            // btnTic7
            // 
            btnTic7.BackColor = SystemColors.ControlLightLight;
            btnTic7.Font = new Font("Microsoft Sans Serif", 50.25F);
            btnTic7.Location = new Point(38, 292);
            btnTic7.Name = "btnTic7";
            btnTic7.Size = new Size(119, 112);
            btnTic7.TabIndex = 6;
            btnTic7.UseVisualStyleBackColor = false;
            btnTic7.Click += btnTic7_Click;
            // 
            // btnTic6
            // 
            btnTic6.BackColor = SystemColors.ControlLightLight;
            btnTic6.Font = new Font("Microsoft Sans Serif", 50.25F);
            btnTic6.Location = new Point(338, 168);
            btnTic6.Name = "btnTic6";
            btnTic6.Size = new Size(119, 112);
            btnTic6.TabIndex = 5;
            btnTic6.UseVisualStyleBackColor = false;
            btnTic6.Click += btnTic6_Click;
            // 
            // btnTic5
            // 
            btnTic5.BackColor = SystemColors.ControlLightLight;
            btnTic5.Font = new Font("Microsoft Sans Serif", 50.25F);
            btnTic5.Location = new Point(188, 168);
            btnTic5.Name = "btnTic5";
            btnTic5.Size = new Size(119, 112);
            btnTic5.TabIndex = 4;
            btnTic5.UseVisualStyleBackColor = false;
            btnTic5.Click += btnTic5_Click;
            // 
            // btnTic4
            // 
            btnTic4.BackColor = SystemColors.ControlLightLight;
            btnTic4.Font = new Font("Microsoft Sans Serif", 50.25F);
            btnTic4.Location = new Point(38, 168);
            btnTic4.Name = "btnTic4";
            btnTic4.Size = new Size(119, 112);
            btnTic4.TabIndex = 3;
            btnTic4.UseVisualStyleBackColor = false;
            btnTic4.Click += btnTic4_Click;
            // 
            // btnTic3
            // 
            btnTic3.BackColor = SystemColors.ControlLightLight;
            btnTic3.Font = new Font("Microsoft Sans Serif", 50.25F);
            btnTic3.ForeColor = SystemColors.ActiveCaptionText;
            btnTic3.Location = new Point(338, 38);
            btnTic3.Name = "btnTic3";
            btnTic3.Size = new Size(119, 112);
            btnTic3.TabIndex = 2;
            btnTic3.UseVisualStyleBackColor = false;
            btnTic3.Click += btnTic3_Click;
            // 
            // btnTic2
            // 
            btnTic2.BackColor = SystemColors.ControlLightLight;
            btnTic2.Font = new Font("Microsoft Sans Serif", 50.25F);
            btnTic2.Location = new Point(188, 38);
            btnTic2.Name = "btnTic2";
            btnTic2.Size = new Size(119, 112);
            btnTic2.TabIndex = 1;
            btnTic2.UseVisualStyleBackColor = false;
            btnTic2.Click += btnTic2_Click;
            // 
            // btnTic1
            // 
            btnTic1.BackColor = SystemColors.ControlLightLight;
            btnTic1.Font = new Font("Microsoft Sans Serif", 50.25F);
            btnTic1.Location = new Point(38, 38);
            btnTic1.Name = "btnTic1";
            btnTic1.Size = new Size(119, 112);
            btnTic1.TabIndex = 0;
            btnTic1.UseVisualStyleBackColor = false;
            btnTic1.Click += btnTic1_Click;
            // 
            // Playing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            BackgroundImage = Properties.Resources.download;
            ClientSize = new Size(1178, 550);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Playing";
            Text = "Form2";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Panel panel5;
        private Panel panel4;
        private Button btnTic1;
        private Button btnTic9;
        private Button btnTic8;
        private Button btnTic7;
        private Button btnTic6;
        private Button btnTic5;
        private Button btnTic4;
        private Button btnTic3;
        private Button btnTic2;
        private Button button12;
        private Button button11;
        private Button button10;
        private Label lbl1;
        private Label lbl2;
        private Label libpl1;
        private Label libpl2;
    }
}