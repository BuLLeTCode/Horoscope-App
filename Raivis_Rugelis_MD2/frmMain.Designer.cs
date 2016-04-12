namespace Raivis_Rugelis_MD2
{
    partial class frmMain
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
            this.lblTitle_frmMain = new System.Windows.Forms.Label();
            this.lblZodiac_frmMain = new System.Windows.Forms.Label();
            this.cmbZotiac_frmMain = new System.Windows.Forms.ComboBox();
            this.lblTodayZodiac_frmMain = new System.Windows.Forms.Label();
            this.tbTodayZodiac_frmMain = new System.Windows.Forms.TextBox();
            this.lblTomorrowZodiac_frmMain = new System.Windows.Forms.Label();
            this.tbTomorrowZodiac_frmMain = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.failsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izietToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTodayDate_frmMain = new System.Windows.Forms.Label();
            this.btnOpenZodiacDescription = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle_frmMain
            // 
            this.lblTitle_frmMain.AutoSize = true;
            this.lblTitle_frmMain.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle_frmMain.Location = new System.Drawing.Point(291, 67);
            this.lblTitle_frmMain.Name = "lblTitle_frmMain";
            this.lblTitle_frmMain.Size = new System.Drawing.Size(108, 29);
            this.lblTitle_frmMain.TabIndex = 1;
            this.lblTitle_frmMain.Text = "Horoskops";
            // 
            // lblZodiac_frmMain
            // 
            this.lblZodiac_frmMain.AutoSize = true;
            this.lblZodiac_frmMain.Location = new System.Drawing.Point(15, 136);
            this.lblZodiac_frmMain.Name = "lblZodiac_frmMain";
            this.lblZodiac_frmMain.Size = new System.Drawing.Size(175, 17);
            this.lblZodiac_frmMain.TabIndex = 2;
            this.lblZodiac_frmMain.Text = "Izvēlies savu Zodiaka zīmi:";
            // 
            // cmbZotiac_frmMain
            // 
            this.cmbZotiac_frmMain.FormattingEnabled = true;
            this.cmbZotiac_frmMain.Location = new System.Drawing.Point(209, 133);
            this.cmbZotiac_frmMain.Name = "cmbZotiac_frmMain";
            this.cmbZotiac_frmMain.Size = new System.Drawing.Size(190, 24);
            this.cmbZotiac_frmMain.TabIndex = 3;
            this.cmbZotiac_frmMain.SelectedIndexChanged += new System.EventHandler(this.cmbZotiac_frmMain_SelectedIndexChanged);
            // 
            // lblTodayZodiac_frmMain
            // 
            this.lblTodayZodiac_frmMain.AutoSize = true;
            this.lblTodayZodiac_frmMain.Location = new System.Drawing.Point(15, 244);
            this.lblTodayZodiac_frmMain.Name = "lblTodayZodiac_frmMain";
            this.lblTodayZodiac_frmMain.Size = new System.Drawing.Size(137, 17);
            this.lblTodayZodiac_frmMain.TabIndex = 4;
            this.lblTodayZodiac_frmMain.Text = "Šodienas horoskops";
            // 
            // tbTodayZodiac_frmMain
            // 
            this.tbTodayZodiac_frmMain.Location = new System.Drawing.Point(18, 277);
            this.tbTodayZodiac_frmMain.Multiline = true;
            this.tbTodayZodiac_frmMain.Name = "tbTodayZodiac_frmMain";
            this.tbTodayZodiac_frmMain.Size = new System.Drawing.Size(318, 213);
            this.tbTodayZodiac_frmMain.TabIndex = 5;
            // 
            // lblTomorrowZodiac_frmMain
            // 
            this.lblTomorrowZodiac_frmMain.AutoSize = true;
            this.lblTomorrowZodiac_frmMain.Location = new System.Drawing.Point(366, 244);
            this.lblTomorrowZodiac_frmMain.Name = "lblTomorrowZodiac_frmMain";
            this.lblTomorrowZodiac_frmMain.Size = new System.Drawing.Size(141, 17);
            this.lblTomorrowZodiac_frmMain.TabIndex = 6;
            this.lblTomorrowZodiac_frmMain.Text = "Rītdienas horoskops:";
            // 
            // tbTomorrowZodiac_frmMain
            // 
            this.tbTomorrowZodiac_frmMain.Location = new System.Drawing.Point(369, 277);
            this.tbTomorrowZodiac_frmMain.Multiline = true;
            this.tbTomorrowZodiac_frmMain.Name = "tbTomorrowZodiac_frmMain";
            this.tbTomorrowZodiac_frmMain.Size = new System.Drawing.Size(306, 213);
            this.tbTomorrowZodiac_frmMain.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.failsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(693, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // failsToolStripMenuItem
            // 
            this.failsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izietToolStripMenuItem});
            this.failsToolStripMenuItem.Name = "failsToolStripMenuItem";
            this.failsToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.failsToolStripMenuItem.Text = "Fails";
            // 
            // izietToolStripMenuItem
            // 
            this.izietToolStripMenuItem.Name = "izietToolStripMenuItem";
            this.izietToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.izietToolStripMenuItem.Text = "Iziet";
            this.izietToolStripMenuItem.Click += new System.EventHandler(this.izietToolStripMenuItem_Click);
            // 
            // lblTodayDate_frmMain
            // 
            this.lblTodayDate_frmMain.AutoSize = true;
            this.lblTodayDate_frmMain.Location = new System.Drawing.Point(475, 39);
            this.lblTodayDate_frmMain.Name = "lblTodayDate_frmMain";
            this.lblTodayDate_frmMain.Size = new System.Drawing.Size(80, 17);
            this.lblTodayDate_frmMain.TabIndex = 9;
            this.lblTodayDate_frmMain.Text = "06.04.2016";
            // 
            // btnOpenZodiacDescription
            // 
            this.btnOpenZodiacDescription.Location = new System.Drawing.Point(18, 176);
            this.btnOpenZodiacDescription.Name = "btnOpenZodiacDescription";
            this.btnOpenZodiacDescription.Size = new System.Drawing.Size(155, 44);
            this.btnOpenZodiacDescription.TabIndex = 10;
            this.btnOpenZodiacDescription.Text = "Apskatīties zīmes raksturojumu";
            this.btnOpenZodiacDescription.UseVisualStyleBackColor = true;
            this.btnOpenZodiacDescription.Click += new System.EventHandler(this.btnOpenZodiacDescription_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 504);
            this.Controls.Add(this.btnOpenZodiacDescription);
            this.Controls.Add(this.lblTodayDate_frmMain);
            this.Controls.Add(this.tbTomorrowZodiac_frmMain);
            this.Controls.Add(this.lblTomorrowZodiac_frmMain);
            this.Controls.Add(this.tbTodayZodiac_frmMain);
            this.Controls.Add(this.lblTodayZodiac_frmMain);
            this.Controls.Add(this.cmbZotiac_frmMain);
            this.Controls.Add(this.lblZodiac_frmMain);
            this.Controls.Add(this.lblTitle_frmMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Zodiaka pasaule";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle_frmMain;
        private System.Windows.Forms.Label lblZodiac_frmMain;
        private System.Windows.Forms.ComboBox cmbZotiac_frmMain;
        private System.Windows.Forms.Label lblTodayZodiac_frmMain;
        private System.Windows.Forms.TextBox tbTodayZodiac_frmMain;
        private System.Windows.Forms.Label lblTomorrowZodiac_frmMain;
        private System.Windows.Forms.TextBox tbTomorrowZodiac_frmMain;
        private System.Windows.Forms.ToolStripMenuItem izietToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem failsToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lblTodayDate_frmMain;
        private System.Windows.Forms.Button btnOpenZodiacDescription;
    }
}