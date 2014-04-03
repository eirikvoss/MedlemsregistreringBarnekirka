namespace medlemRegBarnekirka
{
    partial class mainFrame
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
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabReg = new System.Windows.Forms.TabPage();
            this.tabSok = new System.Windows.Forms.TabPage();
            this.groupChild = new System.Windows.Forms.GroupBox();
            this.labChildName = new System.Windows.Forms.Label();
            this.txtChildName = new System.Windows.Forms.TextBox();
            this.txtChildDate = new System.Windows.Forms.TextBox();
            this.txtChildAllergy = new System.Windows.Forms.TextBox();
            this.labChildDate = new System.Windows.Forms.Label();
            this.labAllergy = new System.Windows.Forms.Label();
            this.groupParent1 = new System.Windows.Forms.GroupBox();
            this.labParent1Name = new System.Windows.Forms.Label();
            this.txtParent1Name = new System.Windows.Forms.TextBox();
            this.txtParent1Address = new System.Windows.Forms.TextBox();
            this.txtParent1Zip = new System.Windows.Forms.TextBox();
            this.txtParent1Tlf = new System.Windows.Forms.TextBox();
            this.txtParent1Mail = new System.Windows.Forms.TextBox();
            this.txtParent1City = new System.Windows.Forms.TextBox();
            this.labParent1Address = new System.Windows.Forms.Label();
            this.labParent1Zip = new System.Windows.Forms.Label();
            this.labParent1Tlf = new System.Windows.Forms.Label();
            this.labParent1Mail = new System.Windows.Forms.Label();
            this.groupParent2 = new System.Windows.Forms.GroupBox();
            this.labParent2Mail = new System.Windows.Forms.Label();
            this.labParent2Tlf = new System.Windows.Forms.Label();
            this.labParent2Zip = new System.Windows.Forms.Label();
            this.labParent2Address = new System.Windows.Forms.Label();
            this.txtParent2City = new System.Windows.Forms.TextBox();
            this.txtParent2Mail = new System.Windows.Forms.TextBox();
            this.txtParent2Tlf = new System.Windows.Forms.TextBox();
            this.txtParent2Zip = new System.Windows.Forms.TextBox();
            this.txtParent2Address = new System.Windows.Forms.TextBox();
            this.txtParent2Name = new System.Windows.Forms.TextBox();
            this.labParent2Name = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.filToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMain.SuspendLayout();
            this.tabReg.SuspendLayout();
            this.groupChild.SuspendLayout();
            this.groupParent1.SuspendLayout();
            this.groupParent2.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabReg);
            this.tabMain.Controls.Add(this.tabSok);
            this.tabMain.Location = new System.Drawing.Point(12, 27);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(760, 522);
            this.tabMain.TabIndex = 0;
            // 
            // tabReg
            // 
            this.tabReg.Controls.Add(this.groupParent2);
            this.tabReg.Controls.Add(this.groupParent1);
            this.tabReg.Controls.Add(this.groupChild);
            this.tabReg.Controls.Add(this.menuStrip1);
            this.tabReg.Location = new System.Drawing.Point(4, 22);
            this.tabReg.Name = "tabReg";
            this.tabReg.Padding = new System.Windows.Forms.Padding(3);
            this.tabReg.Size = new System.Drawing.Size(752, 496);
            this.tabReg.TabIndex = 0;
            this.tabReg.Text = "Registrering";
            this.tabReg.UseVisualStyleBackColor = true;
            // 
            // tabSok
            // 
            this.tabSok.Location = new System.Drawing.Point(4, 22);
            this.tabSok.Name = "tabSok";
            this.tabSok.Padding = new System.Windows.Forms.Padding(3);
            this.tabSok.Size = new System.Drawing.Size(752, 511);
            this.tabSok.TabIndex = 1;
            this.tabSok.Text = "Søk";
            this.tabSok.UseVisualStyleBackColor = true;
            // 
            // groupChild
            // 
            this.groupChild.Controls.Add(this.labAllergy);
            this.groupChild.Controls.Add(this.labChildDate);
            this.groupChild.Controls.Add(this.txtChildAllergy);
            this.groupChild.Controls.Add(this.txtChildDate);
            this.groupChild.Controls.Add(this.txtChildName);
            this.groupChild.Controls.Add(this.labChildName);
            this.groupChild.Location = new System.Drawing.Point(7, 7);
            this.groupChild.Name = "groupChild";
            this.groupChild.Size = new System.Drawing.Size(330, 111);
            this.groupChild.TabIndex = 0;
            this.groupChild.TabStop = false;
            this.groupChild.Text = "Barn";
            // 
            // labChildName
            // 
            this.labChildName.AutoSize = true;
            this.labChildName.Location = new System.Drawing.Point(6, 21);
            this.labChildName.Name = "labChildName";
            this.labChildName.Size = new System.Drawing.Size(56, 13);
            this.labChildName.TabIndex = 0;
            this.labChildName.Text = "Fullt navn:";
            // 
            // txtChildName
            // 
            this.txtChildName.Location = new System.Drawing.Point(134, 21);
            this.txtChildName.Name = "txtChildName";
            this.txtChildName.Size = new System.Drawing.Size(150, 20);
            this.txtChildName.TabIndex = 1;
            // 
            // txtChildDate
            // 
            this.txtChildDate.Location = new System.Drawing.Point(134, 48);
            this.txtChildDate.Name = "txtChildDate";
            this.txtChildDate.Size = new System.Drawing.Size(150, 20);
            this.txtChildDate.TabIndex = 2;
            // 
            // txtChildAllergy
            // 
            this.txtChildAllergy.Location = new System.Drawing.Point(134, 74);
            this.txtChildAllergy.Name = "txtChildAllergy";
            this.txtChildAllergy.Size = new System.Drawing.Size(150, 20);
            this.txtChildAllergy.TabIndex = 3;
            // 
            // labChildDate
            // 
            this.labChildDate.AutoSize = true;
            this.labChildDate.Location = new System.Drawing.Point(7, 47);
            this.labChildDate.Name = "labChildDate";
            this.labChildDate.Size = new System.Drawing.Size(121, 13);
            this.labChildDate.TabIndex = 4;
            this.labChildDate.Text = "Fødselsdato(ddmmyyyy):";
            // 
            // labAllergy
            // 
            this.labAllergy.AutoSize = true;
            this.labAllergy.Location = new System.Drawing.Point(7, 74);
            this.labAllergy.Name = "labAllergy";
            this.labAllergy.Size = new System.Drawing.Size(38, 13);
            this.labAllergy.TabIndex = 5;
            this.labAllergy.Text = "Allergi:";
            // 
            // groupParent1
            // 
            this.groupParent1.Controls.Add(this.labParent1Mail);
            this.groupParent1.Controls.Add(this.labParent1Tlf);
            this.groupParent1.Controls.Add(this.labParent1Zip);
            this.groupParent1.Controls.Add(this.labParent1Address);
            this.groupParent1.Controls.Add(this.txtParent1City);
            this.groupParent1.Controls.Add(this.txtParent1Mail);
            this.groupParent1.Controls.Add(this.txtParent1Tlf);
            this.groupParent1.Controls.Add(this.txtParent1Zip);
            this.groupParent1.Controls.Add(this.txtParent1Address);
            this.groupParent1.Controls.Add(this.txtParent1Name);
            this.groupParent1.Controls.Add(this.labParent1Name);
            this.groupParent1.Location = new System.Drawing.Point(7, 125);
            this.groupParent1.Name = "groupParent1";
            this.groupParent1.Size = new System.Drawing.Size(330, 166);
            this.groupParent1.TabIndex = 1;
            this.groupParent1.TabStop = false;
            this.groupParent1.Text = "1. foresatt";
            // 
            // labParent1Name
            // 
            this.labParent1Name.AutoSize = true;
            this.labParent1Name.Location = new System.Drawing.Point(7, 20);
            this.labParent1Name.Name = "labParent1Name";
            this.labParent1Name.Size = new System.Drawing.Size(56, 13);
            this.labParent1Name.TabIndex = 0;
            this.labParent1Name.Text = "Fullt navn:";
            // 
            // txtParent1Name
            // 
            this.txtParent1Name.Location = new System.Drawing.Point(134, 20);
            this.txtParent1Name.Name = "txtParent1Name";
            this.txtParent1Name.Size = new System.Drawing.Size(150, 20);
            this.txtParent1Name.TabIndex = 1;
            // 
            // txtParent1Address
            // 
            this.txtParent1Address.Location = new System.Drawing.Point(134, 47);
            this.txtParent1Address.Name = "txtParent1Address";
            this.txtParent1Address.Size = new System.Drawing.Size(150, 20);
            this.txtParent1Address.TabIndex = 2;
            // 
            // txtParent1Zip
            // 
            this.txtParent1Zip.Location = new System.Drawing.Point(134, 74);
            this.txtParent1Zip.Name = "txtParent1Zip";
            this.txtParent1Zip.Size = new System.Drawing.Size(40, 20);
            this.txtParent1Zip.TabIndex = 3;
            // 
            // txtParent1Tlf
            // 
            this.txtParent1Tlf.Location = new System.Drawing.Point(134, 101);
            this.txtParent1Tlf.Name = "txtParent1Tlf";
            this.txtParent1Tlf.Size = new System.Drawing.Size(150, 20);
            this.txtParent1Tlf.TabIndex = 4;
            // 
            // txtParent1Mail
            // 
            this.txtParent1Mail.Location = new System.Drawing.Point(134, 128);
            this.txtParent1Mail.Name = "txtParent1Mail";
            this.txtParent1Mail.Size = new System.Drawing.Size(150, 20);
            this.txtParent1Mail.TabIndex = 5;
            // 
            // txtParent1City
            // 
            this.txtParent1City.Location = new System.Drawing.Point(181, 74);
            this.txtParent1City.Name = "txtParent1City";
            this.txtParent1City.Size = new System.Drawing.Size(103, 20);
            this.txtParent1City.TabIndex = 6;
            // 
            // labParent1Address
            // 
            this.labParent1Address.AutoSize = true;
            this.labParent1Address.Location = new System.Drawing.Point(7, 47);
            this.labParent1Address.Name = "labParent1Address";
            this.labParent1Address.Size = new System.Drawing.Size(48, 13);
            this.labParent1Address.TabIndex = 7;
            this.labParent1Address.Text = "Adresse:";
            // 
            // labParent1Zip
            // 
            this.labParent1Zip.AutoSize = true;
            this.labParent1Zip.Location = new System.Drawing.Point(7, 74);
            this.labParent1Zip.Name = "labParent1Zip";
            this.labParent1Zip.Size = new System.Drawing.Size(67, 13);
            this.labParent1Zip.TabIndex = 8;
            this.labParent1Zip.Text = "Postnr/Sted:";
            // 
            // labParent1Tlf
            // 
            this.labParent1Tlf.AutoSize = true;
            this.labParent1Tlf.Location = new System.Drawing.Point(7, 101);
            this.labParent1Tlf.Name = "labParent1Tlf";
            this.labParent1Tlf.Size = new System.Drawing.Size(46, 13);
            this.labParent1Tlf.TabIndex = 9;
            this.labParent1Tlf.Text = "Telefon:";
            // 
            // labParent1Mail
            // 
            this.labParent1Mail.AutoSize = true;
            this.labParent1Mail.Location = new System.Drawing.Point(7, 128);
            this.labParent1Mail.Name = "labParent1Mail";
            this.labParent1Mail.Size = new System.Drawing.Size(40, 13);
            this.labParent1Mail.TabIndex = 10;
            this.labParent1Mail.Text = "E-post:";
            // 
            // groupParent2
            // 
            this.groupParent2.Controls.Add(this.labParent2Mail);
            this.groupParent2.Controls.Add(this.labParent2Tlf);
            this.groupParent2.Controls.Add(this.labParent2Zip);
            this.groupParent2.Controls.Add(this.labParent2Address);
            this.groupParent2.Controls.Add(this.txtParent2City);
            this.groupParent2.Controls.Add(this.txtParent2Mail);
            this.groupParent2.Controls.Add(this.txtParent2Tlf);
            this.groupParent2.Controls.Add(this.txtParent2Zip);
            this.groupParent2.Controls.Add(this.txtParent2Address);
            this.groupParent2.Controls.Add(this.txtParent2Name);
            this.groupParent2.Controls.Add(this.labParent2Name);
            this.groupParent2.Location = new System.Drawing.Point(7, 297);
            this.groupParent2.Name = "groupParent2";
            this.groupParent2.Size = new System.Drawing.Size(330, 166);
            this.groupParent2.TabIndex = 2;
            this.groupParent2.TabStop = false;
            this.groupParent2.Text = "2. foresatt";
            // 
            // labParent2Mail
            // 
            this.labParent2Mail.AutoSize = true;
            this.labParent2Mail.Location = new System.Drawing.Point(7, 128);
            this.labParent2Mail.Name = "labParent2Mail";
            this.labParent2Mail.Size = new System.Drawing.Size(40, 13);
            this.labParent2Mail.TabIndex = 10;
            this.labParent2Mail.Text = "E-post:";
            // 
            // labParent2Tlf
            // 
            this.labParent2Tlf.AutoSize = true;
            this.labParent2Tlf.Location = new System.Drawing.Point(7, 101);
            this.labParent2Tlf.Name = "labParent2Tlf";
            this.labParent2Tlf.Size = new System.Drawing.Size(46, 13);
            this.labParent2Tlf.TabIndex = 9;
            this.labParent2Tlf.Text = "Telefon:";
            // 
            // labParent2Zip
            // 
            this.labParent2Zip.AutoSize = true;
            this.labParent2Zip.Location = new System.Drawing.Point(7, 74);
            this.labParent2Zip.Name = "labParent2Zip";
            this.labParent2Zip.Size = new System.Drawing.Size(67, 13);
            this.labParent2Zip.TabIndex = 8;
            this.labParent2Zip.Text = "Postnr/Sted:";
            // 
            // labParent2Address
            // 
            this.labParent2Address.AutoSize = true;
            this.labParent2Address.Location = new System.Drawing.Point(7, 47);
            this.labParent2Address.Name = "labParent2Address";
            this.labParent2Address.Size = new System.Drawing.Size(48, 13);
            this.labParent2Address.TabIndex = 7;
            this.labParent2Address.Text = "Adresse:";
            // 
            // txtParent2City
            // 
            this.txtParent2City.Location = new System.Drawing.Point(181, 74);
            this.txtParent2City.Name = "txtParent2City";
            this.txtParent2City.Size = new System.Drawing.Size(103, 20);
            this.txtParent2City.TabIndex = 6;
            // 
            // txtParent2Mail
            // 
            this.txtParent2Mail.Location = new System.Drawing.Point(134, 128);
            this.txtParent2Mail.Name = "txtParent2Mail";
            this.txtParent2Mail.Size = new System.Drawing.Size(150, 20);
            this.txtParent2Mail.TabIndex = 5;
            // 
            // txtParent2Tlf
            // 
            this.txtParent2Tlf.Location = new System.Drawing.Point(134, 101);
            this.txtParent2Tlf.Name = "txtParent2Tlf";
            this.txtParent2Tlf.Size = new System.Drawing.Size(150, 20);
            this.txtParent2Tlf.TabIndex = 4;
            // 
            // txtParent2Zip
            // 
            this.txtParent2Zip.Location = new System.Drawing.Point(134, 74);
            this.txtParent2Zip.Name = "txtParent2Zip";
            this.txtParent2Zip.Size = new System.Drawing.Size(40, 20);
            this.txtParent2Zip.TabIndex = 3;
            // 
            // txtParent2Address
            // 
            this.txtParent2Address.Location = new System.Drawing.Point(134, 47);
            this.txtParent2Address.Name = "txtParent2Address";
            this.txtParent2Address.Size = new System.Drawing.Size(150, 20);
            this.txtParent2Address.TabIndex = 2;
            // 
            // txtParent2Name
            // 
            this.txtParent2Name.Location = new System.Drawing.Point(134, 20);
            this.txtParent2Name.Name = "txtParent2Name";
            this.txtParent2Name.Size = new System.Drawing.Size(150, 20);
            this.txtParent2Name.TabIndex = 1;
            // 
            // labParent2Name
            // 
            this.labParent2Name.AutoSize = true;
            this.labParent2Name.Location = new System.Drawing.Point(7, 20);
            this.labParent2Name.Name = "labParent2Name";
            this.labParent2Name.Size = new System.Drawing.Size(56, 13);
            this.labParent2Name.TabIndex = 0;
            this.labParent2Name.Text = "Fullt navn:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(746, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(784, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // filToolStripMenuItem
            // 
            this.filToolStripMenuItem.Name = "filToolStripMenuItem";
            this.filToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.filToolStripMenuItem.Text = "File";
            this.filToolStripMenuItem.Click += new System.EventHandler(this.filToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // mainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.menuStrip2);
            this.Name = "mainFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medlemsregistrering Barnekirka";
            this.tabMain.ResumeLayout(false);
            this.tabReg.ResumeLayout(false);
            this.tabReg.PerformLayout();
            this.groupChild.ResumeLayout(false);
            this.groupChild.PerformLayout();
            this.groupParent1.ResumeLayout(false);
            this.groupParent1.PerformLayout();
            this.groupParent2.ResumeLayout(false);
            this.groupParent2.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabReg;
        private System.Windows.Forms.GroupBox groupParent1;
        private System.Windows.Forms.Label labParent1Mail;
        private System.Windows.Forms.Label labParent1Tlf;
        private System.Windows.Forms.Label labParent1Zip;
        private System.Windows.Forms.Label labParent1Address;
        private System.Windows.Forms.TextBox txtParent1City;
        private System.Windows.Forms.TextBox txtParent1Mail;
        private System.Windows.Forms.TextBox txtParent1Tlf;
        private System.Windows.Forms.TextBox txtParent1Zip;
        private System.Windows.Forms.TextBox txtParent1Address;
        private System.Windows.Forms.TextBox txtParent1Name;
        private System.Windows.Forms.Label labParent1Name;
        private System.Windows.Forms.GroupBox groupChild;
        private System.Windows.Forms.Label labAllergy;
        private System.Windows.Forms.Label labChildDate;
        private System.Windows.Forms.TextBox txtChildAllergy;
        private System.Windows.Forms.TextBox txtChildDate;
        private System.Windows.Forms.TextBox txtChildName;
        private System.Windows.Forms.Label labChildName;
        private System.Windows.Forms.TabPage tabSok;
        private System.Windows.Forms.GroupBox groupParent2;
        private System.Windows.Forms.Label labParent2Mail;
        private System.Windows.Forms.Label labParent2Tlf;
        private System.Windows.Forms.Label labParent2Zip;
        private System.Windows.Forms.Label labParent2Address;
        private System.Windows.Forms.TextBox txtParent2City;
        private System.Windows.Forms.TextBox txtParent2Mail;
        private System.Windows.Forms.TextBox txtParent2Tlf;
        private System.Windows.Forms.TextBox txtParent2Zip;
        private System.Windows.Forms.TextBox txtParent2Address;
        private System.Windows.Forms.TextBox txtParent2Name;
        private System.Windows.Forms.Label labParent2Name;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem filToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
    }
}

