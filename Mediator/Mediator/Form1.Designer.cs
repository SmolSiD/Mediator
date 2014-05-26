namespace Mediator
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.компаниюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отделToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.отправитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прочитатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сообщенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(11, 26);
            this.treeView1.Margin = new System.Windows.Forms.Padding(2);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(604, 193);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseHover += new System.Windows.Forms.TreeNodeMouseHoverEventHandler(this.treeView1_NodeMouseHover);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.DoubleClick += new System.EventHandler(this.treeView1_DoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 252);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.сообщенияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(639, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.компаниюToolStripMenuItem,
            this.отделToolStripMenuItem,
            this.сотрудникаToolStripMenuItem});
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // компаниюToolStripMenuItem
            // 
            this.компаниюToolStripMenuItem.Name = "компаниюToolStripMenuItem";
            this.компаниюToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.компаниюToolStripMenuItem.Text = "Компанию";
            this.компаниюToolStripMenuItem.Click += new System.EventHandler(this.компаниюToolStripMenuItem_Click_1);
            // 
            // отделToolStripMenuItem
            // 
            this.отделToolStripMenuItem.Name = "отделToolStripMenuItem";
            this.отделToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.отделToolStripMenuItem.Text = "Отдел";
            this.отделToolStripMenuItem.Click += new System.EventHandler(this.отделToolStripMenuItem_Click_1);
            // 
            // сотрудникаToolStripMenuItem
            // 
            this.сотрудникаToolStripMenuItem.Name = "сотрудникаToolStripMenuItem";
            this.сотрудникаToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.сотрудникаToolStripMenuItem.Text = "Сотрудника";
            this.сотрудникаToolStripMenuItem.Click += new System.EventHandler(this.сотрудникаToolStripMenuItem_Click_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отправитьToolStripMenuItem,
            this.прочитатьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(134, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // отправитьToolStripMenuItem
            // 
            this.отправитьToolStripMenuItem.Name = "отправитьToolStripMenuItem";
            this.отправитьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.отправитьToolStripMenuItem.Text = "Отправить";
            this.отправитьToolStripMenuItem.Click += new System.EventHandler(this.отправитьToolStripMenuItem_Click);
            // 
            // прочитатьToolStripMenuItem
            // 
            this.прочитатьToolStripMenuItem.Name = "прочитатьToolStripMenuItem";
            this.прочитатьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.прочитатьToolStripMenuItem.Text = "Прочитать";
            // 
            // сообщенияToolStripMenuItem
            // 
            this.сообщенияToolStripMenuItem.Name = "сообщенияToolStripMenuItem";
            this.сообщенияToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.сообщенияToolStripMenuItem.Text = "Сообщения";
            this.сообщенияToolStripMenuItem.Click += new System.EventHandler(this.сообщенияToolStripMenuItem_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 383);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem компаниюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отделToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникаToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem отправитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прочитатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сообщенияToolStripMenuItem;
    }
}

