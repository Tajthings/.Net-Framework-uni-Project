namespace CozyCart.EmployeeDashboards
{
    partial class FormAllProducts
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
            this.flyoutPcategories = new System.Windows.Forms.FlowLayoutPanel();
            this.flyoutPNameList = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnEndSession = new System.Windows.Forms.Button();
            this.pnlAllP = new System.Windows.Forms.Panel();
            this.btnAllProd = new System.Windows.Forms.Button();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pbxInfo = new System.Windows.Forms.PictureBox();
            this.tbxPnameSearch = new System.Windows.Forms.TextBox();
            this.txtPidSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlMenu.SuspendLayout();
            this.pnlAllP.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // flyoutPcategories
            // 
            this.flyoutPcategories.AutoScroll = true;
            this.flyoutPcategories.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flyoutPcategories.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flyoutPcategories.Location = new System.Drawing.Point(2, 190);
            this.flyoutPcategories.Name = "flyoutPcategories";
            this.flyoutPcategories.Size = new System.Drawing.Size(222, 492);
            this.flyoutPcategories.TabIndex = 0;
            this.flyoutPcategories.WrapContents = false;
            // 
            // flyoutPNameList
            // 
            this.flyoutPNameList.AutoScroll = true;
            this.flyoutPNameList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flyoutPNameList.Location = new System.Drawing.Point(257, 125);
            this.flyoutPNameList.Name = "flyoutPNameList";
            this.flyoutPNameList.Size = new System.Drawing.Size(859, 570);
            this.flyoutPNameList.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(559, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMenu.Controls.Add(this.btnLogOut);
            this.pnlMenu.Controls.Add(this.btnEndSession);
            this.pnlMenu.Controls.Add(this.button1);
            this.pnlMenu.Location = new System.Drawing.Point(292, -1);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1107, 49);
            this.pnlMenu.TabIndex = 3;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(659, 8);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(94, 34);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.frmLogOut_Click);
            // 
            // btnEndSession
            // 
            this.btnEndSession.Location = new System.Drawing.Point(431, 7);
            this.btnEndSession.Name = "btnEndSession";
            this.btnEndSession.Size = new System.Drawing.Size(122, 34);
            this.btnEndSession.TabIndex = 3;
            this.btnEndSession.Text = "End Session";
            this.btnEndSession.UseVisualStyleBackColor = true;
            this.btnEndSession.Click += new System.EventHandler(this.btnEndSession_Click);
            // 
            // pnlAllP
            // 
            this.pnlAllP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAllP.Controls.Add(this.btnAllProd);
            this.pnlAllP.Location = new System.Drawing.Point(2, 139);
            this.pnlAllP.Name = "pnlAllP";
            this.pnlAllP.Size = new System.Drawing.Size(222, 57);
            this.pnlAllP.TabIndex = 4;
            // 
            // btnAllProd
            // 
            this.btnAllProd.Location = new System.Drawing.Point(-2, -2);
            this.btnAllProd.Name = "btnAllProd";
            this.btnAllProd.Size = new System.Drawing.Size(222, 57);
            this.btnAllProd.TabIndex = 0;
            this.btnAllProd.Text = "All Categories";
            this.btnAllProd.UseVisualStyleBackColor = true;
            this.btnAllProd.Click += new System.EventHandler(this.btnAllProd_Click);
            // 
            // pnlInfo
            // 
            this.pnlInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlInfo.Controls.Add(this.lblId);
            this.pnlInfo.Controls.Add(this.lblName);
            this.pnlInfo.Controls.Add(this.pbxInfo);
            this.pnlInfo.Location = new System.Drawing.Point(2, 3);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(222, 130);
            this.pnlInfo.TabIndex = 5;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(81, 103);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(26, 20);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(81, 81);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // pbxInfo
            // 
            this.pbxInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxInfo.Location = new System.Drawing.Point(76, 3);
            this.pbxInfo.Name = "pbxInfo";
            this.pbxInfo.Size = new System.Drawing.Size(70, 61);
            this.pbxInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxInfo.TabIndex = 0;
            this.pbxInfo.TabStop = false;
            this.pbxInfo.Click += new System.EventHandler(this.pbxInfo_Click);
            // 
            // tbxPnameSearch
            // 
            this.tbxPnameSearch.Location = new System.Drawing.Point(479, 69);
            this.tbxPnameSearch.Name = "tbxPnameSearch";
            this.tbxPnameSearch.Size = new System.Drawing.Size(247, 26);
            this.tbxPnameSearch.TabIndex = 6;
            this.tbxPnameSearch.TextChanged += new System.EventHandler(this.tbxPnameSearch_TextChanged);
            // 
            // txtPidSearch
            // 
            this.txtPidSearch.Location = new System.Drawing.Point(966, 66);
            this.txtPidSearch.Name = "txtPidSearch";
            this.txtPidSearch.Size = new System.Drawing.Size(247, 26);
            this.txtPidSearch.TabIndex = 7;
            this.txtPidSearch.TextChanged += new System.EventHandler(this.txtPidSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Search by product name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(788, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Search by product ID";
            // 
            // FormAllProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CozyCart.Properties.Resources.Background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1578, 844);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPidSearch);
            this.Controls.Add(this.tbxPnameSearch);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.pnlAllP);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.flyoutPNameList);
            this.Controls.Add(this.flyoutPcategories);
            this.Name = "FormAllProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products View";
            this.Load += new System.EventHandler(this.FormAllProducts_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlAllP.ResumeLayout(false);
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flyoutPcategories;
        private System.Windows.Forms.FlowLayoutPanel flyoutPNameList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlAllP;
        private System.Windows.Forms.Button btnAllProd;
        private System.Windows.Forms.Button btnEndSession;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.PictureBox pbxInfo;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.TextBox tbxPnameSearch;
        private System.Windows.Forms.TextBox txtPidSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

