﻿namespace X_O_Game
{
    partial class SaveScore
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
            label1 = new Label();
            contain = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)contain).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ScrollBar;
            label1.Font = new Font("Segoe Print", 39.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 32);
            label1.Name = "label1";
            label1.Size = new Size(652, 94);
            label1.TabIndex = 0;
            label1.Text = "Information Of Players";
            // 
            // contain
            // 
            contain.BackgroundColor = SystemColors.GradientInactiveCaption;
            contain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            contain.Location = new Point(12, 152);
            contain.Name = "contain";
            contain.Size = new Size(807, 412);
            contain.TabIndex = 1;
            // 
            // SaveScore
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 569);
            Controls.Add(contain);
            Controls.Add(label1);
            Name = "SaveScore";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)contain).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView contain;
    }
}