namespace CozyCart.EmployeeDashboards
{
    partial class FormCart
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
            this.flyoutCart = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnEndSession = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pbxInfo = new System.Windows.Forms.PictureBox();
            this.pnlMenu.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // flyoutCart
            // 
            this.flyoutCart.AutoScroll = true;
            this.flyoutCart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flyoutCart.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flyoutCart.Location = new System.Drawing.Point(273, 51);
            this.flyoutCart.Name = "flyoutCart";
            this.flyoutCart.Size = new System.Drawing.Size(764, 642);
            this.flyoutCart.TabIndex = 0;
            this.flyoutCart.WrapContents = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(579, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "All products";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(689, 6);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(98, 37);
            this.btnCheckOut.TabIndex = 2;
            this.btnCheckOut.Text = "Checkout";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMenu.Controls.Add(this.btnEndSession);
            this.pnlMenu.Controls.Add(this.btnLogOut);
            this.pnlMenu.Controls.Add(this.btnCheckOut);
            this.pnlMenu.Controls.Add(this.button1);
            this.pnlMenu.Location = new System.Drawing.Point(273, -4);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(996, 49);
            this.pnlMenu.TabIndex = 4;
            // 
            // btnEndSession
            // 
            this.btnEndSession.Location = new System.Drawing.Point(432, 3);
            this.btnEndSession.Name = "btnEndSession";
            this.btnEndSession.Size = new System.Drawing.Size(129, 39);
            this.btnEndSession.TabIndex = 14;
            this.btnEndSession.Text = "End Session";
            this.btnEndSession.UseVisualStyleBackColor = true;
            this.btnEndSession.Click += new System.EventHandler(this.btnEndSession_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(793, 6);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(86, 34);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // pnlInfo
            // 
            this.pnlInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlInfo.Controls.Add(this.lblId);
            this.pnlInfo.Controls.Add(this.lblName);
            this.pnlInfo.Controls.Add(this.pbxInfo);
            this.pnlInfo.Location = new System.Drawing.Point(0, 12);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(222, 130);
            this.pnlInfo.TabIndex = 6;
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
            this.pbxInfo.Image = global::CozyCart.Properties.Resources.profile;
            this.pbxInfo.Location = new System.Drawing.Point(76, 3);
            this.pbxInfo.Name = "pbxInfo";
            this.pbxInfo.Size = new System.Drawing.Size(70, 61);
            this.pbxInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxInfo.TabIndex = 0;
            this.pbxInfo.TabStop = false;
            this.pbxInfo.Click += new System.EventHandler(this.pbxInfo_Click);
            // 
            // FormCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CozyCart.Properties.Resources.Background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1578, 844);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.flyoutCart);
            this.Name = "FormCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cart View";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCart_FormClosing);
            this.Load += new System.EventHandler(this.FormCart_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flyoutCart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pbxInfo;
        private System.Windows.Forms.Button btnEndSession;
    }
}