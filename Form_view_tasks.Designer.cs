﻿namespace testWork
{
    partial class Form_view_tasks
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
            this.brigade = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.industry = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // brigade
            // 
            this.brigade.Location = new System.Drawing.Point(124, 119);
            this.brigade.Name = "brigade";
            this.brigade.Size = new System.Drawing.Size(264, 20);
            this.brigade.TabIndex = 12;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(124, 96);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(264, 20);
            this.name.TabIndex = 11;
            // 
            // industry
            // 
            this.industry.Location = new System.Drawing.Point(124, 70);
            this.industry.Name = "industry";
            this.industry.Size = new System.Drawing.Size(264, 20);
            this.industry.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Бригада";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Название задачи";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Отрасаль";
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(124, 41);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(264, 20);
            this.idBox.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "id";
            // 
            // Form_view_tasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 186);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.brigade);
            this.Controls.Add(this.name);
            this.Controls.Add(this.industry);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_view_tasks";
            this.Text = "Form_view_tasks";
            this.Load += new System.EventHandler(this.Form_view_tasks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox brigade;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox industry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label label4;
    }
}