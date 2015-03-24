namespace Game_Ortografia
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.wybor_przypadku1 = new System.Windows.Forms.RadioButton();
            this.wybor_przypadku2 = new System.Windows.Forms.RadioButton();
            this.wybor_przypadku3 = new System.Windows.Forms.RadioButton();
            this.wybor_trybu_2 = new System.Windows.Forms.RadioButton();
            this.wybor_trybu_1 = new System.Windows.Forms.RadioButton();
            this.panel_etapu = new System.Windows.Forms.Panel();
            this.panel_wypadkow = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel_etapu.SuspendLayout();
            this.panel_wypadkow.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(193, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Open Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(81, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 75);
            this.button1.TabIndex = 1;
            this.button1.Text = "B1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Open Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(336, 255);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 75);
            this.button2.TabIndex = 2;
            this.button2.Text = "B2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(517, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(186, 332);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 45);
            this.button3.TabIndex = 4;
            this.button3.Text = "Graj";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // wybor_przypadku1
            // 
            this.wybor_przypadku1.AutoSize = true;
            this.wybor_przypadku1.Checked = true;
            this.wybor_przypadku1.Location = new System.Drawing.Point(17, 16);
            this.wybor_przypadku1.Name = "wybor_przypadku1";
            this.wybor_przypadku1.Size = new System.Drawing.Size(56, 17);
            this.wybor_przypadku1.TabIndex = 8;
            this.wybor_przypadku1.TabStop = true;
            this.wybor_przypadku1.Text = "RZ - Ż";
            this.wybor_przypadku1.UseVisualStyleBackColor = true;
            // 
            // wybor_przypadku2
            // 
            this.wybor_przypadku2.AutoSize = true;
            this.wybor_przypadku2.Location = new System.Drawing.Point(17, 39);
            this.wybor_przypadku2.Name = "wybor_przypadku2";
            this.wybor_przypadku2.Size = new System.Drawing.Size(54, 17);
            this.wybor_przypadku2.TabIndex = 9;
            this.wybor_przypadku2.Text = "CH -H";
            this.wybor_przypadku2.UseVisualStyleBackColor = true;
            // 
            // wybor_przypadku3
            // 
            this.wybor_przypadku3.AutoSize = true;
            this.wybor_przypadku3.Location = new System.Drawing.Point(17, 62);
            this.wybor_przypadku3.Name = "wybor_przypadku3";
            this.wybor_przypadku3.Size = new System.Drawing.Size(50, 17);
            this.wybor_przypadku3.TabIndex = 10;
            this.wybor_przypadku3.Text = "U - Ó";
            this.wybor_przypadku3.UseVisualStyleBackColor = true;
            // 
            // wybor_trybu_2
            // 
            this.wybor_trybu_2.Appearance = System.Windows.Forms.Appearance.Button;
            this.wybor_trybu_2.AutoSize = true;
            this.wybor_trybu_2.Location = new System.Drawing.Point(28, 39);
            this.wybor_trybu_2.Name = "wybor_trybu_2";
            this.wybor_trybu_2.Size = new System.Drawing.Size(45, 23);
            this.wybor_trybu_2.TabIndex = 11;
            this.wybor_trybu_2.TabStop = true;
            this.wybor_trybu_2.Text = "Ćwicz";
            this.wybor_trybu_2.UseVisualStyleBackColor = true;
            this.wybor_trybu_2.CheckedChanged += new System.EventHandler(this.wybor_trybu_2_CheckedChanged);
            // 
            // wybor_trybu_1
            // 
            this.wybor_trybu_1.Appearance = System.Windows.Forms.Appearance.Button;
            this.wybor_trybu_1.AutoSize = true;
            this.wybor_trybu_1.Location = new System.Drawing.Point(12, 10);
            this.wybor_trybu_1.Name = "wybor_trybu_1";
            this.wybor_trybu_1.Size = new System.Drawing.Size(74, 23);
            this.wybor_trybu_1.TabIndex = 12;
            this.wybor_trybu_1.TabStop = true;
            this.wybor_trybu_1.Text = "Sprawdź się";
            this.wybor_trybu_1.UseVisualStyleBackColor = true;
            this.wybor_trybu_1.CheckedChanged += new System.EventHandler(this.wybor_trybu_1_CheckedChanged);
            // 
            // panel_etapu
            // 
            this.panel_etapu.Controls.Add(this.wybor_trybu_1);
            this.panel_etapu.Controls.Add(this.wybor_trybu_2);
            this.panel_etapu.Location = new System.Drawing.Point(202, 135);
            this.panel_etapu.Name = "panel_etapu";
            this.panel_etapu.Size = new System.Drawing.Size(103, 72);
            this.panel_etapu.TabIndex = 13;
            this.panel_etapu.Visible = false;
            // 
            // panel_wypadkow
            // 
            this.panel_wypadkow.Controls.Add(this.wybor_przypadku3);
            this.panel_wypadkow.Controls.Add(this.wybor_przypadku2);
            this.panel_wypadkow.Controls.Add(this.wybor_przypadku1);
            this.panel_wypadkow.Location = new System.Drawing.Point(319, 135);
            this.panel_wypadkow.Name = "panel_wypadkow";
            this.panel_wypadkow.Size = new System.Drawing.Size(112, 95);
            this.panel_wypadkow.TabIndex = 14;
            this.panel_wypadkow.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 431);
            this.Controls.Add(this.panel_wypadkow);
            this.Controls.Add(this.panel_etapu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Red;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_etapu.ResumeLayout(false);
            this.panel_etapu.PerformLayout();
            this.panel_wypadkow.ResumeLayout(false);
            this.panel_wypadkow.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton wybor_przypadku1;
        private System.Windows.Forms.RadioButton wybor_przypadku2;
        private System.Windows.Forms.RadioButton wybor_przypadku3;
        private System.Windows.Forms.RadioButton wybor_trybu_2;
        private System.Windows.Forms.RadioButton wybor_trybu_1;
        private System.Windows.Forms.Panel panel_etapu;
        private System.Windows.Forms.Panel panel_wypadkow;
    }
}

