namespace autoGUI
{
    partial class Form
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
            fogyasztásAdatokToolStripMenuItem = new ToolStripMenuItem();
            számolásToolStripMenuItem = new ToolStripMenuItem();
            kilépésToolStripMenuItem = new ToolStripMenuItem();
            lb1 = new Label();
            label1 = new Label();
            txtank = new TextBox();
            txfogy = new TextBox();
            btszam = new Button();
            gbuzem = new GroupBox();
            rbgazolaj = new RadioButton();
            rbpremium = new RadioButton();
            rb95 = new RadioButton();
            lbtank1 = new Label();
            lbtank2 = new Label();
            lbtank3 = new Label();
            menuStrip1.SuspendLayout();
            gbuzem.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fogyasztásAdatokToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(651, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fogyasztásAdatokToolStripMenuItem
            // 
            fogyasztásAdatokToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { számolásToolStripMenuItem, kilépésToolStripMenuItem });
            fogyasztásAdatokToolStripMenuItem.Name = "fogyasztásAdatokToolStripMenuItem";
            fogyasztásAdatokToolStripMenuItem.Size = new Size(115, 20);
            fogyasztásAdatokToolStripMenuItem.Text = "Fogyasztás adatok";
            // 
            // számolásToolStripMenuItem
            // 
            számolásToolStripMenuItem.Name = "számolásToolStripMenuItem";
            számolásToolStripMenuItem.Size = new Size(123, 22);
            számolásToolStripMenuItem.Text = "Számolás";
            számolásToolStripMenuItem.Click += számolásToolStripMenuItem_Click;
            // 
            // kilépésToolStripMenuItem
            // 
            kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            kilépésToolStripMenuItem.Size = new Size(123, 22);
            kilépésToolStripMenuItem.Text = "Kilépés";
            kilépésToolStripMenuItem.Click += kilépésToolStripMenuItem_Click;
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.Location = new Point(44, 64);
            lb1.Name = "lb1";
            lb1.Size = new Size(112, 15);
            lb1.TabIndex = 1;
            lb1.Text = "Tank mérete [liter]";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 100);
            label1.Name = "label1";
            label1.Size = new Size(124, 15);
            label1.TabIndex = 2;
            label1.Text = "Fogyasztás [l/100km]";
            // 
            // txtank
            // 
            txtank.Enabled = false;
            txtank.Location = new Point(226, 56);
            txtank.Name = "txtank";
            txtank.Size = new Size(122, 23);
            txtank.TabIndex = 3;
            // 
            // txfogy
            // 
            txfogy.Enabled = false;
            txfogy.Location = new Point(226, 92);
            txfogy.Name = "txfogy";
            txfogy.Size = new Size(122, 23);
            txfogy.TabIndex = 4;
            // 
            // btszam
            // 
            btszam.Enabled = false;
            btszam.ForeColor = Color.FromArgb(192, 0, 192);
            btszam.Location = new Point(382, 53);
            btszam.Name = "btszam";
            btszam.Size = new Size(203, 62);
            btszam.TabIndex = 5;
            btszam.Text = "Számolás";
            btszam.UseVisualStyleBackColor = true;
            btszam.Click += btszam_Click;
            // 
            // gbuzem
            // 
            gbuzem.Controls.Add(rbgazolaj);
            gbuzem.Controls.Add(rbpremium);
            gbuzem.Controls.Add(rb95);
            gbuzem.Enabled = false;
            gbuzem.ForeColor = Color.FromArgb(192, 0, 192);
            gbuzem.Location = new Point(62, 152);
            gbuzem.Name = "gbuzem";
            gbuzem.Size = new Size(200, 100);
            gbuzem.TabIndex = 6;
            gbuzem.TabStop = false;
            gbuzem.Text = "Üzemanyag";
            // 
            // rbgazolaj
            // 
            rbgazolaj.AutoSize = true;
            rbgazolaj.Location = new Point(20, 72);
            rbgazolaj.Name = "rbgazolaj";
            rbgazolaj.Size = new Size(129, 19);
            rbgazolaj.TabIndex = 2;
            rbgazolaj.TabStop = true;
            rbgazolaj.Text = "Gázolaj [583.9 Ft/l]";
            rbgazolaj.UseVisualStyleBackColor = true;
            // 
            // rbpremium
            // 
            rbpremium.AutoSize = true;
            rbpremium.Location = new Point(20, 47);
            rbpremium.Name = "rbpremium";
            rbpremium.Size = new Size(180, 19);
            rbpremium.TabIndex = 1;
            rbpremium.TabStop = true;
            rbpremium.Text = "Prémium benzin [615.9 Ft/l]";
            rbpremium.UseVisualStyleBackColor = true;
            // 
            // rb95
            // 
            rb95.AutoSize = true;
            rb95.Location = new Point(20, 22);
            rb95.Name = "rb95";
            rb95.Size = new Size(160, 19);
            rb95.TabIndex = 0;
            rb95.TabStop = true;
            rb95.Text = "95-ös benzin [579.9 Ft/l]";
            rb95.UseVisualStyleBackColor = true;
            // 
            // lbtank1
            // 
            lbtank1.AutoSize = true;
            lbtank1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbtank1.ForeColor = Color.FromArgb(0, 192, 192);
            lbtank1.Location = new Point(44, 289);
            lbtank1.Name = "lbtank1";
            lbtank1.Size = new Size(245, 21);
            lbtank1.TabIndex = 7;
            lbtank1.Text = "A tank megtöltésének díja: 0 Ft";
            lbtank1.Visible = false;
            // 
            // lbtank2
            // 
            lbtank2.AutoSize = true;
            lbtank2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbtank2.ForeColor = Color.FromArgb(0, 192, 192);
            lbtank2.Location = new Point(44, 327);
            lbtank2.Name = "lbtank2";
            lbtank2.Size = new Size(280, 21);
            lbtank2.TabIndex = 8;
            lbtank2.Text = "A teljes tankkal megtehető út: 0 km";
            lbtank2.Visible = false;
            // 
            // lbtank3
            // 
            lbtank3.AutoSize = true;
            lbtank3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbtank3.ForeColor = Color.FromArgb(0, 192, 192);
            lbtank3.Location = new Point(44, 362);
            lbtank3.Name = "lbtank3";
            lbtank3.Size = new Size(259, 21);
            lbtank3.TabIndex = 9;
            lbtank3.Text = "Az egy km-re eső benzin ára: 0 Ft";
            lbtank3.Visible = false;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(651, 425);
            Controls.Add(lbtank3);
            Controls.Add(lbtank2);
            Controls.Add(lbtank1);
            Controls.Add(gbuzem);
            Controls.Add(btszam);
            Controls.Add(txfogy);
            Controls.Add(txtank);
            Controls.Add(label1);
            Controls.Add(lb1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ForeColor = Color.Black;
            MainMenuStrip = menuStrip1;
            Name = "Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Autó fogyasztás";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            gbuzem.ResumeLayout(false);
            gbuzem.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fogyasztásAdatokToolStripMenuItem;
        private ToolStripMenuItem számolásToolStripMenuItem;
        private ToolStripMenuItem kilépésToolStripMenuItem;
        private Label lb1;
        private Label label1;
        private TextBox txtank;
        private TextBox txfogy;
        private Button btszam;
        private GroupBox gbuzem;
        private RadioButton rbgazolaj;
        private RadioButton rbpremium;
        private RadioButton rb95;
        private Label lbtank1;
        private Label lbtank2;
        private Label lbtank3;
    }
}
