namespace CozyCart
{
    partial class FormLogIn
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
            this.pnlLogIn = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserid = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLogIN = new System.Windows.Forms.Button();
            this.cbsShowpass = new System.Windows.Forms.CheckBox();
            this.pnlLogIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogIn
            // 
            this.pnlLogIn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlLogIn.Controls.Add(this.cbsShowpass);
            this.pnlLogIn.Controls.Add(this.btnLogIN);
            this.pnlLogIn.Controls.Add(this.label3);
            this.pnlLogIn.Controls.Add(this.txtPass);
            this.pnlLogIn.Controls.Add(this.txtUserid);
            this.pnlLogIn.Controls.Add(this.label2);
            this.pnlLogIn.Controls.Add(this.label1);
            this.pnlLogIn.Location = new System.Drawing.Point(390, 174);
            this.pnlLogIn.Name = "pnlLogIn";
            this.pnlLogIn.Size = new System.Drawing.Size(541, 467);
            this.pnlLogIn.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CozyCart.Properties.Resources.Logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 76);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(156, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "CozyCart Log in";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Id";
            // 
            // txtUserid
            // 
            this.txtUserid.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserid.Location = new System.Drawing.Point(116, 182);
            this.txtUserid.Name = "txtUserid";
            this.txtUserid.Size = new System.Drawing.Size(346, 34);
            this.txtUserid.TabIndex = 2;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(116, 286);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(346, 34);
            this.txtPass.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(111, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // btnLogIN
            // 
            this.btnLogIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(183)))), ((int)(((byte)(160)))));
            this.btnLogIN.Font = new System.Drawing.Font("Stencil", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogIN.Location = new System.Drawing.Point(116, 382);
            this.btnLogIN.Name = "btnLogIN";
            this.btnLogIN.Size = new System.Drawing.Size(331, 40);
            this.btnLogIN.TabIndex = 6;
            this.btnLogIN.Text = "LOG IN";
            this.btnLogIN.UseVisualStyleBackColor = false;
            this.btnLogIN.Click += new System.EventHandler(this.btnLogIN_Click);
            // 
            // cbsShowpass
            // 
            this.cbsShowpass.AutoSize = true;
            this.cbsShowpass.Location = new System.Drawing.Point(207, 328);
            this.cbsShowpass.Name = "cbsShowpass";
            this.cbsShowpass.Size = new System.Drawing.Size(148, 24);
            this.cbsShowpass.TabIndex = 7;
            this.cbsShowpass.Text = "Show Password";
            this.cbsShowpass.UseVisualStyleBackColor = true;
            this.cbsShowpass.CheckedChanged += new System.EventHandler(this.cbsShowpass_CheckedChanged);
            // 
            // FormLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CozyCart.Properties.Resources.Background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1578, 844);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlLogIn);
            this.Name = "FormLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogIn";
            this.pnlLogIn.ResumeLayout(false);
            this.pnlLogIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogIn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUserid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLogIN;
        private System.Windows.Forms.CheckBox cbsShowpass;
    }
}