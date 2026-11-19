namespace HomeBudget
{
    partial class FormHomeBudget
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
            menuStrip1 = new MenuStrip();
            справочникиToolStripMenuItem = new ToolStripMenuItem();
            операцииToolStripMenuItem = new ToolStripMenuItem();
            отчётыToolStripMenuItem = new ToolStripMenuItem();
            членыСемьиToolStripMenuItem = new ToolStripMenuItem();
            источникиДоходаToolStripMenuItem = new ToolStripMenuItem();
            доходыИРасходыToolStripMenuItem = new ToolStripMenuItem();
            доходыИРасходыToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { справочникиToolStripMenuItem, операцииToolStripMenuItem, отчётыToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // справочникиToolStripMenuItem
            // 
            справочникиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { членыСемьиToolStripMenuItem, источникиДоходаToolStripMenuItem });
            справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            справочникиToolStripMenuItem.Size = new Size(94, 20);
            справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // операцииToolStripMenuItem
            // 
            операцииToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { доходыИРасходыToolStripMenuItem, доходыИРасходыToolStripMenuItem1 });
            операцииToolStripMenuItem.Name = "операцииToolStripMenuItem";
            операцииToolStripMenuItem.Size = new Size(75, 20);
            операцииToolStripMenuItem.Text = "Операции";
            // 
            // отчётыToolStripMenuItem
            // 
            отчётыToolStripMenuItem.Name = "отчётыToolStripMenuItem";
            отчётыToolStripMenuItem.Size = new Size(60, 20);
            отчётыToolStripMenuItem.Text = "Отчёты";
            // 
            // членыСемьиToolStripMenuItem
            // 
            членыСемьиToolStripMenuItem.Name = "членыСемьиToolStripMenuItem";
            членыСемьиToolStripMenuItem.Size = new Size(180, 22);
            членыСемьиToolStripMenuItem.Text = "Члены семьи";
            // 
            // источникиДоходаToolStripMenuItem
            // 
            источникиДоходаToolStripMenuItem.Name = "источникиДоходаToolStripMenuItem";
            источникиДоходаToolStripMenuItem.Size = new Size(180, 22);
            источникиДоходаToolStripMenuItem.Text = "Источники дохода";
            // 
            // доходыИРасходыToolStripMenuItem
            // 
            доходыИРасходыToolStripMenuItem.Name = "доходыИРасходыToolStripMenuItem";
            доходыИРасходыToolStripMenuItem.Size = new Size(180, 22);
            доходыИРасходыToolStripMenuItem.Text = "Бюджетные планы";
            // 
            // доходыИРасходыToolStripMenuItem1
            // 
            доходыИРасходыToolStripMenuItem1.Name = "доходыИРасходыToolStripMenuItem1";
            доходыИРасходыToolStripMenuItem1.Size = new Size(180, 22);
            доходыИРасходыToolStripMenuItem1.Text = "Доходы и расходы";
            // 
            // FormHomeBudget
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormHomeBudget";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Семейный бюджет";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem справочникиToolStripMenuItem;
        private ToolStripMenuItem членыСемьиToolStripMenuItem;
        private ToolStripMenuItem источникиДоходаToolStripMenuItem;
        private ToolStripMenuItem операцииToolStripMenuItem;
        private ToolStripMenuItem доходыИРасходыToolStripMenuItem;
        private ToolStripMenuItem доходыИРасходыToolStripMenuItem1;
        private ToolStripMenuItem отчётыToolStripMenuItem;
    }
}
