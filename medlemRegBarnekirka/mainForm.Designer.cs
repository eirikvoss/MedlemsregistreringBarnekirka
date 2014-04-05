namespace medlemRegBarnekirka
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabReg = new System.Windows.Forms.TabPage();
            this.groupRegistrer = new System.Windows.Forms.GroupBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.chckPrint = new System.Windows.Forms.CheckBox();
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
            this.groupParent1 = new System.Windows.Forms.GroupBox();
            this.labParent1Mail = new System.Windows.Forms.Label();
            this.labParent1Tlf = new System.Windows.Forms.Label();
            this.labParent1Zip = new System.Windows.Forms.Label();
            this.labParent1Address = new System.Windows.Forms.Label();
            this.txtParent1City = new System.Windows.Forms.TextBox();
            this.txtParent1Mail = new System.Windows.Forms.TextBox();
            this.txtParent1Tlf = new System.Windows.Forms.TextBox();
            this.txtParent1Zip = new System.Windows.Forms.TextBox();
            this.txtParent1Address = new System.Windows.Forms.TextBox();
            this.txtParent1Name = new System.Windows.Forms.TextBox();
            this.labParent1Name = new System.Windows.Forms.Label();
            this.groupChild = new System.Windows.Forms.GroupBox();
            this.labAllergy = new System.Windows.Forms.Label();
            this.labChildDate = new System.Windows.Forms.Label();
            this.txtChildAllergy = new System.Windows.Forms.TextBox();
            this.txtChildDate = new System.Windows.Forms.TextBox();
            this.txtChildName = new System.Windows.Forms.TextBox();
            this.labChildName = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tabSok = new System.Windows.Forms.TabPage();
            this.dataSearch = new System.Windows.Forms.DataGridView();
            this.childName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.childDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parent1Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parent1Tlf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parent2Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parent2Tlf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemView = new System.Windows.Forms.ToolStripMenuItem();
            this.radioAlreadyMember = new System.Windows.Forms.RadioButton();
            this.radioWantMember = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuItemFileRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemViewRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemViewSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemHelpFaq = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMain.SuspendLayout();
            this.tabReg.SuspendLayout();
            this.groupRegistrer.SuspendLayout();
            this.groupParent2.SuspendLayout();
            this.groupParent1.SuspendLayout();
            this.groupChild.SuspendLayout();
            this.tabSok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSearch)).BeginInit();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabReg);
            this.tabMain.Controls.Add(this.tabSok);
            this.tabMain.Location = new System.Drawing.Point(12, 27);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(667, 522);
            this.tabMain.TabIndex = 0;
            // 
            // tabReg
            // 
            this.tabReg.Controls.Add(this.pictureBox1);
            this.tabReg.Controls.Add(this.groupRegistrer);
            this.tabReg.Controls.Add(this.groupParent2);
            this.tabReg.Controls.Add(this.groupParent1);
            this.tabReg.Controls.Add(this.groupChild);
            this.tabReg.Controls.Add(this.menuStrip1);
            this.tabReg.Location = new System.Drawing.Point(4, 22);
            this.tabReg.Name = "tabReg";
            this.tabReg.Padding = new System.Windows.Forms.Padding(3);
            this.tabReg.Size = new System.Drawing.Size(659, 496);
            this.tabReg.TabIndex = 0;
            this.tabReg.Text = "Registrering";
            this.tabReg.UseVisualStyleBackColor = true;
            // 
            // groupRegistrer
            // 
            this.groupRegistrer.Controls.Add(this.radioWantMember);
            this.groupRegistrer.Controls.Add(this.radioAlreadyMember);
            this.groupRegistrer.Controls.Add(this.btnRegister);
            this.groupRegistrer.Controls.Add(this.chckPrint);
            this.groupRegistrer.Location = new System.Drawing.Point(352, 7);
            this.groupRegistrer.Name = "groupRegistrer";
            this.groupRegistrer.Size = new System.Drawing.Size(239, 178);
            this.groupRegistrer.TabIndex = 4;
            this.groupRegistrer.TabStop = false;
            this.groupRegistrer.Text = "Registrer";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(32, 118);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(140, 40);
            this.btnRegister.TabIndex = 3;
            this.btnRegister.Text = "Registrer";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // chckPrint
            // 
            this.chckPrint.AutoSize = true;
            this.chckPrint.Location = new System.Drawing.Point(7, 76);
            this.chckPrint.Name = "chckPrint";
            this.chckPrint.Size = new System.Drawing.Size(103, 17);
            this.chckPrint.TabIndex = 2;
            this.chckPrint.Text = "Print navnelapp.";
            this.chckPrint.UseVisualStyleBackColor = true;
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
            this.txtParent2City.Location = new System.Drawing.Point(221, 73);
            this.txtParent2City.Name = "txtParent2City";
            this.txtParent2City.Size = new System.Drawing.Size(103, 20);
            this.txtParent2City.TabIndex = 6;
            // 
            // txtParent2Mail
            // 
            this.txtParent2Mail.Location = new System.Drawing.Point(174, 125);
            this.txtParent2Mail.Name = "txtParent2Mail";
            this.txtParent2Mail.Size = new System.Drawing.Size(150, 20);
            this.txtParent2Mail.TabIndex = 5;
            // 
            // txtParent2Tlf
            // 
            this.txtParent2Tlf.Location = new System.Drawing.Point(174, 99);
            this.txtParent2Tlf.Name = "txtParent2Tlf";
            this.txtParent2Tlf.Size = new System.Drawing.Size(150, 20);
            this.txtParent2Tlf.TabIndex = 4;
            // 
            // txtParent2Zip
            // 
            this.txtParent2Zip.Location = new System.Drawing.Point(175, 73);
            this.txtParent2Zip.Name = "txtParent2Zip";
            this.txtParent2Zip.Size = new System.Drawing.Size(40, 20);
            this.txtParent2Zip.TabIndex = 3;
            // 
            // txtParent2Address
            // 
            this.txtParent2Address.Location = new System.Drawing.Point(174, 47);
            this.txtParent2Address.Name = "txtParent2Address";
            this.txtParent2Address.Size = new System.Drawing.Size(150, 20);
            this.txtParent2Address.TabIndex = 2;
            // 
            // txtParent2Name
            // 
            this.txtParent2Name.Location = new System.Drawing.Point(174, 21);
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
            // groupParent1
            // 
            this.groupParent1.Controls.Add(this.label4);
            this.groupParent1.Controls.Add(this.label3);
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
            // labParent1Mail
            // 
            this.labParent1Mail.AutoSize = true;
            this.labParent1Mail.Location = new System.Drawing.Point(7, 128);
            this.labParent1Mail.Name = "labParent1Mail";
            this.labParent1Mail.Size = new System.Drawing.Size(40, 13);
            this.labParent1Mail.TabIndex = 10;
            this.labParent1Mail.Text = "E-post:";
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
            // labParent1Zip
            // 
            this.labParent1Zip.AutoSize = true;
            this.labParent1Zip.Location = new System.Drawing.Point(7, 74);
            this.labParent1Zip.Name = "labParent1Zip";
            this.labParent1Zip.Size = new System.Drawing.Size(67, 13);
            this.labParent1Zip.TabIndex = 8;
            this.labParent1Zip.Text = "Postnr/Sted:";
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
            // txtParent1City
            // 
            this.txtParent1City.Location = new System.Drawing.Point(221, 72);
            this.txtParent1City.Name = "txtParent1City";
            this.txtParent1City.Size = new System.Drawing.Size(103, 20);
            this.txtParent1City.TabIndex = 6;
            // 
            // txtParent1Mail
            // 
            this.txtParent1Mail.Location = new System.Drawing.Point(174, 124);
            this.txtParent1Mail.Name = "txtParent1Mail";
            this.txtParent1Mail.Size = new System.Drawing.Size(150, 20);
            this.txtParent1Mail.TabIndex = 5;
            // 
            // txtParent1Tlf
            // 
            this.txtParent1Tlf.Location = new System.Drawing.Point(174, 98);
            this.txtParent1Tlf.Name = "txtParent1Tlf";
            this.txtParent1Tlf.Size = new System.Drawing.Size(150, 20);
            this.txtParent1Tlf.TabIndex = 4;
            // 
            // txtParent1Zip
            // 
            this.txtParent1Zip.Location = new System.Drawing.Point(175, 72);
            this.txtParent1Zip.Name = "txtParent1Zip";
            this.txtParent1Zip.Size = new System.Drawing.Size(40, 20);
            this.txtParent1Zip.TabIndex = 3;
            // 
            // txtParent1Address
            // 
            this.txtParent1Address.Location = new System.Drawing.Point(174, 46);
            this.txtParent1Address.Name = "txtParent1Address";
            this.txtParent1Address.Size = new System.Drawing.Size(150, 20);
            this.txtParent1Address.TabIndex = 2;
            // 
            // txtParent1Name
            // 
            this.txtParent1Name.Location = new System.Drawing.Point(174, 20);
            this.txtParent1Name.Name = "txtParent1Name";
            this.txtParent1Name.Size = new System.Drawing.Size(150, 20);
            this.txtParent1Name.TabIndex = 1;
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
            // groupChild
            // 
            this.groupChild.Controls.Add(this.label2);
            this.groupChild.Controls.Add(this.label1);
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
            // labAllergy
            // 
            this.labAllergy.AutoSize = true;
            this.labAllergy.Location = new System.Drawing.Point(7, 74);
            this.labAllergy.Name = "labAllergy";
            this.labAllergy.Size = new System.Drawing.Size(38, 13);
            this.labAllergy.TabIndex = 5;
            this.labAllergy.Text = "Allergi:";
            // 
            // labChildDate
            // 
            this.labChildDate.AutoSize = true;
            this.labChildDate.Location = new System.Drawing.Point(7, 47);
            this.labChildDate.Name = "labChildDate";
            this.labChildDate.Size = new System.Drawing.Size(127, 13);
            this.labChildDate.TabIndex = 4;
            this.labChildDate.Text = "Fødselsdato(dd.mm.yyyy):";
            // 
            // txtChildAllergy
            // 
            this.txtChildAllergy.Location = new System.Drawing.Point(174, 73);
            this.txtChildAllergy.Name = "txtChildAllergy";
            this.txtChildAllergy.Size = new System.Drawing.Size(150, 20);
            this.txtChildAllergy.TabIndex = 3;
            // 
            // txtChildDate
            // 
            this.txtChildDate.Location = new System.Drawing.Point(174, 47);
            this.txtChildDate.Name = "txtChildDate";
            this.txtChildDate.Size = new System.Drawing.Size(150, 20);
            this.txtChildDate.TabIndex = 2;
            // 
            // txtChildName
            // 
            this.txtChildName.Location = new System.Drawing.Point(174, 21);
            this.txtChildName.Name = "txtChildName";
            this.txtChildName.Size = new System.Drawing.Size(150, 20);
            this.txtChildName.TabIndex = 1;
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
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(653, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tabSok
            // 
            this.tabSok.Controls.Add(this.dataSearch);
            this.tabSok.Controls.Add(this.btnSearch);
            this.tabSok.Controls.Add(this.txtSearch);
            this.tabSok.Location = new System.Drawing.Point(4, 22);
            this.tabSok.Name = "tabSok";
            this.tabSok.Padding = new System.Windows.Forms.Padding(3);
            this.tabSok.Size = new System.Drawing.Size(659, 496);
            this.tabSok.TabIndex = 1;
            this.tabSok.Text = "Søk";
            this.tabSok.UseVisualStyleBackColor = true;
            // 
            // dataSearch
            // 
            this.dataSearch.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.childName,
            this.childDate,
            this.parent1Name,
            this.parent1Tlf,
            this.parent2Name,
            this.parent2Tlf});
            this.dataSearch.Location = new System.Drawing.Point(6, 35);
            this.dataSearch.Name = "dataSearch";
            this.dataSearch.Size = new System.Drawing.Size(647, 455);
            this.dataSearch.TabIndex = 2;
            // 
            // childName
            // 
            this.childName.HeaderText = "Barnets navn";
            this.childName.Name = "childName";
            // 
            // childDate
            // 
            this.childDate.HeaderText = "Fødselsdato";
            this.childDate.Name = "childDate";
            // 
            // parent1Name
            // 
            this.parent1Name.HeaderText = "Foresatt 1";
            this.parent1Name.Name = "parent1Name";
            // 
            // parent1Tlf
            // 
            this.parent1Tlf.HeaderText = "Telefon 1";
            this.parent1Tlf.Name = "parent1Tlf";
            // 
            // parent2Name
            // 
            this.parent2Name.HeaderText = "Foresatt 2";
            this.parent2Name.Name = "parent2Name";
            // 
            // parent2Tlf
            // 
            this.parent2Tlf.HeaderText = "Telefon 2";
            this.parent2Tlf.Name = "parent2Tlf";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(212, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Søk";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(6, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 20);
            this.txtSearch.TabIndex = 0;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemFile,
            this.menuItemView,
            this.menuItemHelp});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(691, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuItemFile
            // 
            this.menuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemFileRegister,
            this.menuItemFileExit});
            this.menuItemFile.Name = "menuItemFile";
            this.menuItemFile.Size = new System.Drawing.Size(31, 20);
            this.menuItemFile.Text = "Fil";
            this.menuItemFile.Click += new System.EventHandler(this.filToolStripMenuItem_Click);
            // 
            // menuItemView
            // 
            this.menuItemView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemViewRegister,
            this.menuItemViewSearch});
            this.menuItemView.Name = "menuItemView";
            this.menuItemView.Size = new System.Drawing.Size(50, 20);
            this.menuItemView.Text = "Vindu";
            // 
            // radioAlreadyMember
            // 
            this.radioAlreadyMember.AutoSize = true;
            this.radioAlreadyMember.Location = new System.Drawing.Point(7, 28);
            this.radioAlreadyMember.Name = "radioAlreadyMember";
            this.radioAlreadyMember.Size = new System.Drawing.Size(161, 17);
            this.radioAlreadyMember.TabIndex = 4;
            this.radioAlreadyMember.Text = "Allerede medlem i Barnekirka";
            this.radioAlreadyMember.UseVisualStyleBackColor = true;
            // 
            // radioWantMember
            // 
            this.radioWantMember.AutoSize = true;
            this.radioWantMember.Checked = true;
            this.radioWantMember.Location = new System.Drawing.Point(7, 52);
            this.radioWantMember.Name = "radioWantMember";
            this.radioWantMember.Size = new System.Drawing.Size(179, 17);
            this.radioWantMember.TabIndex = 5;
            this.radioWantMember.TabStop = true;
            this.radioWantMember.Text = "Ønsker å bli medlem i Barnekirka";
            this.radioWantMember.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "*";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(359, 203);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 239);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // menuItemFileRegister
            // 
            this.menuItemFileRegister.Name = "menuItemFileRegister";
            this.menuItemFileRegister.Size = new System.Drawing.Size(159, 22);
            this.menuItemFileRegister.Text = "Registrer person";
            // 
            // menuItemFileExit
            // 
            this.menuItemFileExit.Name = "menuItemFileExit";
            this.menuItemFileExit.Size = new System.Drawing.Size(159, 22);
            this.menuItemFileExit.Text = "Avslutt";
            // 
            // menuItemViewRegister
            // 
            this.menuItemViewRegister.Name = "menuItemViewRegister";
            this.menuItemViewRegister.Size = new System.Drawing.Size(152, 22);
            this.menuItemViewRegister.Text = "Registrering";
            // 
            // menuItemViewSearch
            // 
            this.menuItemViewSearch.Name = "menuItemViewSearch";
            this.menuItemViewSearch.Size = new System.Drawing.Size(152, 22);
            this.menuItemViewSearch.Text = "Søk";
            // 
            // menuItemHelp
            // 
            this.menuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemHelpFaq,
            this.menuItemHelpAbout});
            this.menuItemHelp.Name = "menuItemHelp";
            this.menuItemHelp.Size = new System.Drawing.Size(47, 20);
            this.menuItemHelp.Text = "Hjelp";
            // 
            // menuItemHelpFaq
            // 
            this.menuItemHelpFaq.Name = "menuItemHelpFaq";
            this.menuItemHelpFaq.Size = new System.Drawing.Size(164, 22);
            this.menuItemHelpFaq.Text = "FAQ";
            // 
            // menuItemHelpAbout
            // 
            this.menuItemHelpAbout.Name = "menuItemHelpAbout";
            this.menuItemHelpAbout.Size = new System.Drawing.Size(164, 22);
            this.menuItemHelpAbout.Text = "Om programmet";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 562);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 600);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medlemsregistrering Barnekirka";
            this.tabMain.ResumeLayout(false);
            this.tabReg.ResumeLayout(false);
            this.tabReg.PerformLayout();
            this.groupRegistrer.ResumeLayout(false);
            this.groupRegistrer.PerformLayout();
            this.groupParent2.ResumeLayout(false);
            this.groupParent2.PerformLayout();
            this.groupParent1.ResumeLayout(false);
            this.groupParent1.PerformLayout();
            this.groupChild.ResumeLayout(false);
            this.groupChild.PerformLayout();
            this.tabSok.ResumeLayout(false);
            this.tabSok.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSearch)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.TextBox txtParent2Mail;
        private System.Windows.Forms.TextBox txtParent2Tlf;
        private System.Windows.Forms.TextBox txtParent2City;
        private System.Windows.Forms.TextBox txtParent2Zip;
        private System.Windows.Forms.TextBox txtParent2Address;
        private System.Windows.Forms.TextBox txtParent2Name;
        private System.Windows.Forms.Label labParent2Name;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem menuItemFile;
        private System.Windows.Forms.ToolStripMenuItem menuItemView;
        private System.Windows.Forms.GroupBox groupRegistrer;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.CheckBox chckPrint;
        private System.Windows.Forms.DataGridView dataSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn childName;
        private System.Windows.Forms.DataGridViewTextBoxColumn childDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn parent1Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn parent1Tlf;
        private System.Windows.Forms.DataGridViewTextBoxColumn parent2Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn parent2Tlf;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton radioWantMember;
        private System.Windows.Forms.RadioButton radioAlreadyMember;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem menuItemFileRegister;
        private System.Windows.Forms.ToolStripMenuItem menuItemFileExit;
        private System.Windows.Forms.ToolStripMenuItem menuItemViewRegister;
        private System.Windows.Forms.ToolStripMenuItem menuItemViewSearch;
        private System.Windows.Forms.ToolStripMenuItem menuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem menuItemHelpFaq;
        private System.Windows.Forms.ToolStripMenuItem menuItemHelpAbout;
    }
}

