﻿using NotDefteri;

namespace NotDefteri
{
    partial class YardimForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YardimForm));
            Yardim yardim1 = new Yardim();
            SuspendLayout();
            // 
            // yardim1
            // 
            yardim1.Location = new System.Drawing.Point(12, 12);
            yardim1.Name = "yardim1";
            yardim1.Size = new System.Drawing.Size(364, 165);
            yardim1.TabIndex = 0;
            // 
            // YardimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 190);
            this.Controls.Add(this.yardim1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "YardimForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YardimForm";
            this.Load += new System.EventHandler(this.YardimForm_Load);
            this.ResumeLayout(false);

        }
        private Yardim yardim1;
        #endregion


    }
}