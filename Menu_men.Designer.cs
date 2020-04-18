namespace testWork
{
    partial class Menu_men
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ybrati1 = new System.Windows.Forms.Button();
            this.add_task = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ybrati2 = new System.Windows.Forms.Button();
            this.add_employee = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.view_task = new System.Windows.Forms.Button();
            this.update_task = new System.Windows.Forms.Button();
            this.update_employee = new System.Windows.Forms.Button();
            this.view_employee = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 48);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 402);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.update_task);
            this.tabPage1.Controls.Add(this.view_task);
            this.tabPage1.Controls.Add(this.ybrati1);
            this.tabPage1.Controls.Add(this.add_task);
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 376);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Задачи";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ybrati1
            // 
            this.ybrati1.Location = new System.Drawing.Point(170, 6);
            this.ybrati1.Name = "ybrati1";
            this.ybrati1.Size = new System.Drawing.Size(75, 23);
            this.ybrati1.TabIndex = 3;
            this.ybrati1.Text = "Убрать";
            this.ybrati1.UseVisualStyleBackColor = true;
            this.ybrati1.Click += new System.EventHandler(this.ybrati1_Click);
            // 
            // add_task
            // 
            this.add_task.Location = new System.Drawing.Point(89, 6);
            this.add_task.Name = "add_task";
            this.add_task.Size = new System.Drawing.Size(75, 23);
            this.add_task.TabIndex = 2;
            this.add_task.Text = "Добавить";
            this.add_task.UseVisualStyleBackColor = true;
            this.add_task.Click += new System.EventHandler(this.add_task_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 34);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(786, 339);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Отрасаль";
            this.columnHeader1.Width = 67;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Название задачи";
            this.columnHeader2.Width = 205;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Бригада";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.update_employee);
            this.tabPage2.Controls.Add(this.view_employee);
            this.tabPage2.Controls.Add(this.ybrati2);
            this.tabPage2.Controls.Add(this.add_employee);
            this.tabPage2.Controls.Add(this.listView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 376);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Сотрудники";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ybrati2
            // 
            this.ybrati2.Location = new System.Drawing.Point(170, 6);
            this.ybrati2.Name = "ybrati2";
            this.ybrati2.Size = new System.Drawing.Size(75, 23);
            this.ybrati2.TabIndex = 3;
            this.ybrati2.Text = "Убрать";
            this.ybrati2.UseVisualStyleBackColor = true;
            this.ybrati2.Click += new System.EventHandler(this.ybrati2_Click);
            // 
            // add_employee
            // 
            this.add_employee.Location = new System.Drawing.Point(89, 6);
            this.add_employee.Name = "add_employee";
            this.add_employee.Size = new System.Drawing.Size(75, 23);
            this.add_employee.TabIndex = 2;
            this.add_employee.Text = "Добавить";
            this.add_employee.UseVisualStyleBackColor = true;
            this.add_employee.Click += new System.EventHandler(this.add_employee_Click);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(3, 35);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(786, 338);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Фото";
            this.columnHeader4.Width = 58;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Фамилия";
            this.columnHeader5.Width = 109;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Имя";
            this.columnHeader6.Width = 109;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Отчество";
            this.columnHeader7.Width = 114;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Должность";
            this.columnHeader8.Width = 151;
            // 
            // view_task
            // 
            this.view_task.Location = new System.Drawing.Point(8, 6);
            this.view_task.Name = "view_task";
            this.view_task.Size = new System.Drawing.Size(75, 23);
            this.view_task.TabIndex = 4;
            this.view_task.Text = "Просмотр";
            this.view_task.UseVisualStyleBackColor = true;
            this.view_task.Click += new System.EventHandler(this.view_task_Click);
            // 
            // update_task
            // 
            this.update_task.Location = new System.Drawing.Point(251, 6);
            this.update_task.Name = "update_task";
            this.update_task.Size = new System.Drawing.Size(75, 23);
            this.update_task.TabIndex = 5;
            this.update_task.Text = "Изменить";
            this.update_task.UseVisualStyleBackColor = true;
            // 
            // update_employee
            // 
            this.update_employee.Location = new System.Drawing.Point(251, 6);
            this.update_employee.Name = "update_employee";
            this.update_employee.Size = new System.Drawing.Size(75, 23);
            this.update_employee.TabIndex = 7;
            this.update_employee.Text = "Изменить";
            this.update_employee.UseVisualStyleBackColor = true;
            // 
            // view_employee
            // 
            this.view_employee.Location = new System.Drawing.Point(8, 6);
            this.view_employee.Name = "view_employee";
            this.view_employee.Size = new System.Drawing.Size(75, 23);
            this.view_employee.TabIndex = 6;
            this.view_employee.Text = "Просмотр";
            this.view_employee.UseVisualStyleBackColor = true;
            this.view_employee.Click += new System.EventHandler(this.view_employee_Click);
            // 
            // Menu_men
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu_men";
            this.Text = "Menu_men";
            this.Load += new System.EventHandler(this.Menu_men_Load_1);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button add_task;
        private System.Windows.Forms.Button add_employee;
        private System.Windows.Forms.Button ybrati2;
        private System.Windows.Forms.Button ybrati1;
        private System.Windows.Forms.Button update_task;
        private System.Windows.Forms.Button view_task;
        private System.Windows.Forms.Button update_employee;
        private System.Windows.Forms.Button view_employee;
    }
}