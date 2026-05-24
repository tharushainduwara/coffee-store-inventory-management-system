namespace Billing_System_Project.UI
{
    partial class frmPurchaseAndSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPurchaseAndSales));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.purSalLblHeader = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deaCustPanel = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelBillDate = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxContact = new System.Windows.Forms.TextBox();
            this.labelContact = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.labelDeaCust = new System.Windows.Forms.Label();
            this.proDetaPanel = new System.Windows.Forms.Panel();
            this.addBTN = new System.Windows.Forms.Button();
            this.qtyTxt2 = new System.Windows.Forms.TextBox();
            this.qtyLbl2 = new System.Windows.Forms.Label();
            this.rateTxt2 = new System.Windows.Forms.TextBox();
            this.rateLbl2 = new System.Windows.Forms.Label();
            this.inventoryTxt = new System.Windows.Forms.TextBox();
            this.inventoryLbl = new System.Windows.Forms.Label();
            this.nameTxt2 = new System.Windows.Forms.TextBox();
            this.nameLbl2 = new System.Windows.Forms.Label();
            this.searchTxt2 = new System.Windows.Forms.TextBox();
            this.searchLbl2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.addedProPanel = new System.Windows.Forms.Panel();
            this.dgvAddedProducts = new System.Windows.Forms.DataGridView();
            this.addedProLbl = new System.Windows.Forms.Label();
            this.calcuDetaPanel = new System.Windows.Forms.Panel();
            this.saveBtn = new System.Windows.Forms.Button();
            this.paidAmountTxt = new System.Windows.Forms.TextBox();
            this.paidAmountLbl = new System.Windows.Forms.Label();
            this.returnAmountTxt = new System.Windows.Forms.TextBox();
            this.reAmountLbl = new System.Windows.Forms.Label();
            this.vatTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grandTotalTxt = new System.Windows.Forms.TextBox();
            this.grandTotalLbl = new System.Windows.Forms.Label();
            this.discountTxt = new System.Windows.Forms.TextBox();
            this.discountLbl = new System.Windows.Forms.Label();
            this.subTotalTxt = new System.Windows.Forms.TextBox();
            this.subTotalLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.deaCustPanel.SuspendLayout();
            this.proDetaPanel.SuspendLayout();
            this.addedProPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddedProducts)).BeginInit();
            this.calcuDetaPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1285, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // purSalLblHeader
            // 
            this.purSalLblHeader.AutoSize = true;
            this.purSalLblHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purSalLblHeader.ForeColor = System.Drawing.Color.White;
            this.purSalLblHeader.Location = new System.Drawing.Point(606, 9);
            this.purSalLblHeader.Name = "purSalLblHeader";
            this.purSalLblHeader.Size = new System.Drawing.Size(212, 28);
            this.purSalLblHeader.TabIndex = 0;
            this.purSalLblHeader.Text = "PURCHASE and SALES";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.purSalLblHeader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1320, 42);
            this.panel1.TabIndex = 4;
            // 
            // deaCustPanel
            // 
            this.deaCustPanel.BackColor = System.Drawing.Color.DarkCyan;
            this.deaCustPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deaCustPanel.Controls.Add(this.dateTimePicker1);
            this.deaCustPanel.Controls.Add(this.labelBillDate);
            this.deaCustPanel.Controls.Add(this.textBoxAddress);
            this.deaCustPanel.Controls.Add(this.labelAddress);
            this.deaCustPanel.Controls.Add(this.textBoxContact);
            this.deaCustPanel.Controls.Add(this.labelContact);
            this.deaCustPanel.Controls.Add(this.textBoxEmail);
            this.deaCustPanel.Controls.Add(this.labelEmail);
            this.deaCustPanel.Controls.Add(this.textBoxName);
            this.deaCustPanel.Controls.Add(this.labelName);
            this.deaCustPanel.Controls.Add(this.textBoxSearch);
            this.deaCustPanel.Controls.Add(this.labelSearch);
            this.deaCustPanel.Controls.Add(this.labelDeaCust);
            this.deaCustPanel.Location = new System.Drawing.Point(12, 48);
            this.deaCustPanel.Name = "deaCustPanel";
            this.deaCustPanel.Size = new System.Drawing.Size(1296, 118);
            this.deaCustPanel.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1022, 34);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(247, 22);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // labelBillDate
            // 
            this.labelBillDate.AutoSize = true;
            this.labelBillDate.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBillDate.ForeColor = System.Drawing.Color.White;
            this.labelBillDate.Location = new System.Drawing.Point(952, 37);
            this.labelBillDate.Name = "labelBillDate";
            this.labelBillDate.Size = new System.Drawing.Size(55, 17);
            this.labelBillDate.TabIndex = 13;
            this.labelBillDate.Text = "Bill Date";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddress.Location = new System.Drawing.Point(708, 34);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(213, 66);
            this.textBoxAddress.TabIndex = 12;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.ForeColor = System.Drawing.Color.White;
            this.labelAddress.Location = new System.Drawing.Point(641, 36);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(56, 17);
            this.labelAddress.TabIndex = 11;
            this.labelAddress.Text = "Address";
            // 
            // textBoxContact
            // 
            this.textBoxContact.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContact.Location = new System.Drawing.Point(388, 74);
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.Size = new System.Drawing.Size(213, 25);
            this.textBoxContact.TabIndex = 10;
            // 
            // labelContact
            // 
            this.labelContact.AutoSize = true;
            this.labelContact.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContact.ForeColor = System.Drawing.Color.White;
            this.labelContact.Location = new System.Drawing.Point(322, 76);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(52, 17);
            this.labelContact.TabIndex = 9;
            this.labelContact.Text = "Contact";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(388, 35);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(213, 25);
            this.textBoxEmail.TabIndex = 8;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.Color.White;
            this.labelEmail.Location = new System.Drawing.Point(322, 37);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(39, 17);
            this.labelEmail.TabIndex = 7;
            this.labelEmail.Text = "Email";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(71, 75);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(213, 25);
            this.textBoxName.TabIndex = 6;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(12, 77);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(43, 17);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Name";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(71, 36);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(213, 25);
            this.textBoxSearch.TabIndex = 2;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.ForeColor = System.Drawing.Color.White;
            this.labelSearch.Location = new System.Drawing.Point(12, 38);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(47, 17);
            this.labelSearch.TabIndex = 1;
            this.labelSearch.Text = "Search";
            // 
            // labelDeaCust
            // 
            this.labelDeaCust.AutoSize = true;
            this.labelDeaCust.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeaCust.ForeColor = System.Drawing.Color.White;
            this.labelDeaCust.Location = new System.Drawing.Point(12, 8);
            this.labelDeaCust.Name = "labelDeaCust";
            this.labelDeaCust.Size = new System.Drawing.Size(185, 17);
            this.labelDeaCust.TabIndex = 0;
            this.labelDeaCust.Text = "Dealer and Customer Details";
            // 
            // proDetaPanel
            // 
            this.proDetaPanel.BackColor = System.Drawing.Color.DarkCyan;
            this.proDetaPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.proDetaPanel.Controls.Add(this.addBTN);
            this.proDetaPanel.Controls.Add(this.qtyTxt2);
            this.proDetaPanel.Controls.Add(this.qtyLbl2);
            this.proDetaPanel.Controls.Add(this.rateTxt2);
            this.proDetaPanel.Controls.Add(this.rateLbl2);
            this.proDetaPanel.Controls.Add(this.inventoryTxt);
            this.proDetaPanel.Controls.Add(this.inventoryLbl);
            this.proDetaPanel.Controls.Add(this.nameTxt2);
            this.proDetaPanel.Controls.Add(this.nameLbl2);
            this.proDetaPanel.Controls.Add(this.searchTxt2);
            this.proDetaPanel.Controls.Add(this.searchLbl2);
            this.proDetaPanel.Controls.Add(this.label7);
            this.proDetaPanel.Location = new System.Drawing.Point(12, 186);
            this.proDetaPanel.Name = "proDetaPanel";
            this.proDetaPanel.Size = new System.Drawing.Size(1296, 118);
            this.proDetaPanel.TabIndex = 15;
            // 
            // addBTN
            // 
            this.addBTN.BackColor = System.Drawing.Color.MediumBlue;
            this.addBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addBTN.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBTN.ForeColor = System.Drawing.Color.White;
            this.addBTN.Location = new System.Drawing.Point(1147, 27);
            this.addBTN.Name = "addBTN";
            this.addBTN.Size = new System.Drawing.Size(122, 38);
            this.addBTN.TabIndex = 54;
            this.addBTN.Text = "Add";
            this.addBTN.UseVisualStyleBackColor = false;
            this.addBTN.Click += new System.EventHandler(this.addBTN_Click);
            // 
            // qtyTxt2
            // 
            this.qtyTxt2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyTxt2.Location = new System.Drawing.Point(974, 32);
            this.qtyTxt2.Name = "qtyTxt2";
            this.qtyTxt2.Size = new System.Drawing.Size(125, 25);
            this.qtyTxt2.TabIndex = 12;
            // 
            // qtyLbl2
            // 
            this.qtyLbl2.AutoSize = true;
            this.qtyLbl2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyLbl2.ForeColor = System.Drawing.Color.White;
            this.qtyLbl2.Location = new System.Drawing.Point(932, 36);
            this.qtyLbl2.Name = "qtyLbl2";
            this.qtyLbl2.Size = new System.Drawing.Size(31, 17);
            this.qtyLbl2.TabIndex = 11;
            this.qtyLbl2.Text = "Qty.";
            // 
            // rateTxt2
            // 
            this.rateTxt2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rateTxt2.Location = new System.Drawing.Point(801, 33);
            this.rateTxt2.Name = "rateTxt2";
            this.rateTxt2.Size = new System.Drawing.Size(121, 25);
            this.rateTxt2.TabIndex = 10;
            // 
            // rateLbl2
            // 
            this.rateLbl2.AutoSize = true;
            this.rateLbl2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rateLbl2.ForeColor = System.Drawing.Color.White;
            this.rateLbl2.Location = new System.Drawing.Point(757, 35);
            this.rateLbl2.Name = "rateLbl2";
            this.rateLbl2.Size = new System.Drawing.Size(34, 17);
            this.rateLbl2.TabIndex = 9;
            this.rateLbl2.Text = "Rate";
            // 
            // inventoryTxt
            // 
            this.inventoryTxt.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryTxt.Location = new System.Drawing.Point(562, 33);
            this.inventoryTxt.Name = "inventoryTxt";
            this.inventoryTxt.Size = new System.Drawing.Size(183, 25);
            this.inventoryTxt.TabIndex = 8;
            // 
            // inventoryLbl
            // 
            this.inventoryLbl.AutoSize = true;
            this.inventoryLbl.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryLbl.ForeColor = System.Drawing.Color.White;
            this.inventoryLbl.Location = new System.Drawing.Point(487, 37);
            this.inventoryLbl.Name = "inventoryLbl";
            this.inventoryLbl.Size = new System.Drawing.Size(61, 17);
            this.inventoryLbl.TabIndex = 7;
            this.inventoryLbl.Text = "Inventory";
            // 
            // nameTxt2
            // 
            this.nameTxt2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxt2.Location = new System.Drawing.Point(300, 34);
            this.nameTxt2.Name = "nameTxt2";
            this.nameTxt2.Size = new System.Drawing.Size(177, 25);
            this.nameTxt2.TabIndex = 6;
            // 
            // nameLbl2
            // 
            this.nameLbl2.AutoSize = true;
            this.nameLbl2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl2.ForeColor = System.Drawing.Color.White;
            this.nameLbl2.Location = new System.Drawing.Point(245, 36);
            this.nameLbl2.Name = "nameLbl2";
            this.nameLbl2.Size = new System.Drawing.Size(43, 17);
            this.nameLbl2.TabIndex = 5;
            this.nameLbl2.Text = "Name";
            // 
            // searchTxt2
            // 
            this.searchTxt2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTxt2.Location = new System.Drawing.Point(68, 36);
            this.searchTxt2.Name = "searchTxt2";
            this.searchTxt2.Size = new System.Drawing.Size(170, 25);
            this.searchTxt2.TabIndex = 2;
            this.searchTxt2.TextChanged += new System.EventHandler(this.searchTxt2_TextChanged);
            // 
            // searchLbl2
            // 
            this.searchLbl2.AutoSize = true;
            this.searchLbl2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLbl2.ForeColor = System.Drawing.Color.White;
            this.searchLbl2.Location = new System.Drawing.Point(12, 38);
            this.searchLbl2.Name = "searchLbl2";
            this.searchLbl2.Size = new System.Drawing.Size(47, 17);
            this.searchLbl2.TabIndex = 1;
            this.searchLbl2.Text = "Search";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Product Details";
            // 
            // addedProPanel
            // 
            this.addedProPanel.BackColor = System.Drawing.Color.DarkCyan;
            this.addedProPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addedProPanel.Controls.Add(this.dgvAddedProducts);
            this.addedProPanel.Controls.Add(this.addedProLbl);
            this.addedProPanel.Location = new System.Drawing.Point(12, 324);
            this.addedProPanel.Name = "addedProPanel";
            this.addedProPanel.Size = new System.Drawing.Size(652, 395);
            this.addedProPanel.TabIndex = 55;
            // 
            // dgvAddedProducts
            // 
            this.dgvAddedProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddedProducts.Location = new System.Drawing.Point(15, 40);
            this.dgvAddedProducts.Name = "dgvAddedProducts";
            this.dgvAddedProducts.RowHeadersWidth = 51;
            this.dgvAddedProducts.RowTemplate.Height = 24;
            this.dgvAddedProducts.Size = new System.Drawing.Size(617, 337);
            this.dgvAddedProducts.TabIndex = 51;
            // 
            // addedProLbl
            // 
            this.addedProLbl.AutoSize = true;
            this.addedProLbl.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addedProLbl.ForeColor = System.Drawing.Color.White;
            this.addedProLbl.Location = new System.Drawing.Point(12, 8);
            this.addedProLbl.Name = "addedProLbl";
            this.addedProLbl.Size = new System.Drawing.Size(106, 17);
            this.addedProLbl.TabIndex = 0;
            this.addedProLbl.Text = "Added Products";
            // 
            // calcuDetaPanel
            // 
            this.calcuDetaPanel.BackColor = System.Drawing.Color.DarkCyan;
            this.calcuDetaPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calcuDetaPanel.Controls.Add(this.saveBtn);
            this.calcuDetaPanel.Controls.Add(this.paidAmountTxt);
            this.calcuDetaPanel.Controls.Add(this.paidAmountLbl);
            this.calcuDetaPanel.Controls.Add(this.returnAmountTxt);
            this.calcuDetaPanel.Controls.Add(this.reAmountLbl);
            this.calcuDetaPanel.Controls.Add(this.vatTxt);
            this.calcuDetaPanel.Controls.Add(this.label4);
            this.calcuDetaPanel.Controls.Add(this.grandTotalTxt);
            this.calcuDetaPanel.Controls.Add(this.grandTotalLbl);
            this.calcuDetaPanel.Controls.Add(this.discountTxt);
            this.calcuDetaPanel.Controls.Add(this.discountLbl);
            this.calcuDetaPanel.Controls.Add(this.subTotalTxt);
            this.calcuDetaPanel.Controls.Add(this.subTotalLbl);
            this.calcuDetaPanel.Controls.Add(this.label1);
            this.calcuDetaPanel.Location = new System.Drawing.Point(681, 324);
            this.calcuDetaPanel.Name = "calcuDetaPanel";
            this.calcuDetaPanel.Size = new System.Drawing.Size(627, 395);
            this.calcuDetaPanel.TabIndex = 56;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.MediumBlue;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(248, 339);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(153, 38);
            this.saveBtn.TabIndex = 55;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // paidAmountTxt
            // 
            this.paidAmountTxt.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paidAmountTxt.Location = new System.Drawing.Point(135, 230);
            this.paidAmountTxt.Name = "paidAmountTxt";
            this.paidAmountTxt.Size = new System.Drawing.Size(415, 25);
            this.paidAmountTxt.TabIndex = 26;
            this.paidAmountTxt.TextChanged += new System.EventHandler(this.paidAmountTxt_TextChanged);
            // 
            // paidAmountLbl
            // 
            this.paidAmountLbl.AutoSize = true;
            this.paidAmountLbl.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paidAmountLbl.ForeColor = System.Drawing.Color.White;
            this.paidAmountLbl.Location = new System.Drawing.Point(11, 233);
            this.paidAmountLbl.Name = "paidAmountLbl";
            this.paidAmountLbl.Size = new System.Drawing.Size(82, 17);
            this.paidAmountLbl.TabIndex = 25;
            this.paidAmountLbl.Text = "Paid Amount";
            // 
            // returnAmountTxt
            // 
            this.returnAmountTxt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnAmountTxt.Location = new System.Drawing.Point(135, 278);
            this.returnAmountTxt.Multiline = true;
            this.returnAmountTxt.Name = "returnAmountTxt";
            this.returnAmountTxt.ReadOnly = true;
            this.returnAmountTxt.Size = new System.Drawing.Size(415, 39);
            this.returnAmountTxt.TabIndex = 24;
            // 
            // reAmountLbl
            // 
            this.reAmountLbl.AutoSize = true;
            this.reAmountLbl.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reAmountLbl.ForeColor = System.Drawing.Color.White;
            this.reAmountLbl.Location = new System.Drawing.Point(11, 281);
            this.reAmountLbl.Name = "reAmountLbl";
            this.reAmountLbl.Size = new System.Drawing.Size(95, 17);
            this.reAmountLbl.TabIndex = 23;
            this.reAmountLbl.Text = "Return Amount";
            // 
            // vatTxt
            // 
            this.vatTxt.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vatTxt.Location = new System.Drawing.Point(135, 134);
            this.vatTxt.Name = "vatTxt";
            this.vatTxt.Size = new System.Drawing.Size(415, 25);
            this.vatTxt.TabIndex = 22;
            this.vatTxt.TextChanged += new System.EventHandler(this.vatTxt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "VAT (%)";
            // 
            // grandTotalTxt
            // 
            this.grandTotalTxt.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grandTotalTxt.Location = new System.Drawing.Point(135, 182);
            this.grandTotalTxt.Name = "grandTotalTxt";
            this.grandTotalTxt.ReadOnly = true;
            this.grandTotalTxt.Size = new System.Drawing.Size(415, 25);
            this.grandTotalTxt.TabIndex = 20;
            // 
            // grandTotalLbl
            // 
            this.grandTotalLbl.AutoSize = true;
            this.grandTotalLbl.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grandTotalLbl.ForeColor = System.Drawing.Color.White;
            this.grandTotalLbl.Location = new System.Drawing.Point(11, 185);
            this.grandTotalLbl.Name = "grandTotalLbl";
            this.grandTotalLbl.Size = new System.Drawing.Size(76, 17);
            this.grandTotalLbl.TabIndex = 19;
            this.grandTotalLbl.Text = "Grand Total";
            // 
            // discountTxt
            // 
            this.discountTxt.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountTxt.Location = new System.Drawing.Point(135, 86);
            this.discountTxt.Name = "discountTxt";
            this.discountTxt.Size = new System.Drawing.Size(415, 25);
            this.discountTxt.TabIndex = 18;
            this.discountTxt.TextChanged += new System.EventHandler(this.discountTxt_TextChanged);
            // 
            // discountLbl
            // 
            this.discountLbl.AutoSize = true;
            this.discountLbl.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountLbl.ForeColor = System.Drawing.Color.White;
            this.discountLbl.Location = new System.Drawing.Point(11, 89);
            this.discountLbl.Name = "discountLbl";
            this.discountLbl.Size = new System.Drawing.Size(81, 17);
            this.discountLbl.TabIndex = 17;
            this.discountLbl.Text = "Discount (%)";
            // 
            // subTotalTxt
            // 
            this.subTotalTxt.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalTxt.Location = new System.Drawing.Point(135, 40);
            this.subTotalTxt.Name = "subTotalTxt";
            this.subTotalTxt.ReadOnly = true;
            this.subTotalTxt.Size = new System.Drawing.Size(415, 25);
            this.subTotalTxt.TabIndex = 16;
            this.subTotalTxt.Text = "0";
            // 
            // subTotalLbl
            // 
            this.subTotalLbl.AutoSize = true;
            this.subTotalLbl.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalLbl.ForeColor = System.Drawing.Color.White;
            this.subTotalLbl.Location = new System.Drawing.Point(11, 43);
            this.subTotalLbl.Name = "subTotalLbl";
            this.subTotalLbl.Size = new System.Drawing.Size(62, 17);
            this.subTotalLbl.TabIndex = 15;
            this.subTotalLbl.Text = "Sub Total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculation Details";
            // 
            // frmPurchaseAndSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1320, 750);
            this.Controls.Add(this.calcuDetaPanel);
            this.Controls.Add(this.addedProPanel);
            this.Controls.Add(this.proDetaPanel);
            this.Controls.Add(this.deaCustPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPurchaseAndSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase And Sales";
            this.Load += new System.EventHandler(this.frmPurchaseAndSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.deaCustPanel.ResumeLayout(false);
            this.deaCustPanel.PerformLayout();
            this.proDetaPanel.ResumeLayout(false);
            this.proDetaPanel.PerformLayout();
            this.addedProPanel.ResumeLayout(false);
            this.addedProPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddedProducts)).EndInit();
            this.calcuDetaPanel.ResumeLayout(false);
            this.calcuDetaPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label purSalLblHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel deaCustPanel;
        private System.Windows.Forms.Label labelDeaCust;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelBillDate;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxContact;
        private System.Windows.Forms.Label labelContact;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Panel proDetaPanel;
        private System.Windows.Forms.TextBox inventoryTxt;
        private System.Windows.Forms.Label inventoryLbl;
        private System.Windows.Forms.TextBox nameTxt2;
        private System.Windows.Forms.Label nameLbl2;
        private System.Windows.Forms.TextBox searchTxt2;
        private System.Windows.Forms.Label searchLbl2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox qtyTxt2;
        private System.Windows.Forms.Label qtyLbl2;
        private System.Windows.Forms.TextBox rateTxt2;
        private System.Windows.Forms.Label rateLbl2;
        private System.Windows.Forms.Button addBTN;
        private System.Windows.Forms.Panel addedProPanel;
        private System.Windows.Forms.Label addedProLbl;
        private System.Windows.Forms.DataGridView dgvAddedProducts;
        private System.Windows.Forms.Panel calcuDetaPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox paidAmountTxt;
        private System.Windows.Forms.Label paidAmountLbl;
        private System.Windows.Forms.TextBox returnAmountTxt;
        private System.Windows.Forms.Label reAmountLbl;
        private System.Windows.Forms.TextBox vatTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox grandTotalTxt;
        private System.Windows.Forms.Label grandTotalLbl;
        private System.Windows.Forms.TextBox discountTxt;
        private System.Windows.Forms.Label discountLbl;
        private System.Windows.Forms.TextBox subTotalTxt;
        private System.Windows.Forms.Label subTotalLbl;
        private System.Windows.Forms.Button saveBtn;
    }
}