using CozyCart.CozyCartDb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CozyCart.EmployeeDashboards
{
    public partial class FormCashierInfo : Form
    {
        private string eid;
        private string ename;
        private string erole;
        private string esalary;
        private Cozycartcon cn;

      //  private string Date;

        public string Eid
        {
            get { return this.eid; }
            set { this.eid = value; }
        }
        internal Cozycartcon Cn
        {
            get { return this.cn; }
            set { this.cn = value; }
        }

        public string Ename
        {
            get { return this. ename; }
            set { this.ename = value; }
        }

        public string Erole
        {
            get { return this.erole; }
            set { this.erole = value; }
        }
        public string Esalary
        {
            get { return this.esalary; }
            set { this.esalary = value; }
        }


        public FormCashierInfo(string eid, string name, string role,string salary)
        {
            InitializeComponent();
            this.Eid = eid;
            this.Ename = name;
            this.Erole = role;
            this.Esalary = salary;
            this.Cn = new Cozycartcon();
            this.pnlUpdate.BackColor = Color.Transparent;
            this.pnlMain.BackColor= Color.Transparent;
            this.pnlInfo.BackColor = Color.Transparent;
            this.pnlMenu.BackColor=Color.Transparent;
            this.txtId.Text = this.Eid;
          //  this.JDate = jDate;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void FormCashierInfo_Load(object sender, EventArgs e)
        {
            this.lblIdValue.Text = this.Eid;
            this.lblNameValue.Text = this.Ename;
            this.lblRoleValue.Text = this.Erole;
            this.lbliId.Text = this.Eid;
            this.lblName.Text = this.Ename;
            DataSet ds = this.Cn.getValueDb("select * from EmployeeTable;");
            int i = 0;
            while (i < ds.Tables[0].Rows.Count)
            {
                if (ds.Tables[0].Rows[i][0].ToString() == this.Eid)
                {
                    this.lblDateValue.Text = Convert.ToDateTime(ds.Tables[0].Rows[i][6]).ToString("dd-MM-yyyy");
                   // MessageBox.Show(this.lblDateValue.Text);
                    byte[] img = (byte[])ds.Tables[0].Rows[i][5];

                    MemoryStream ms = new MemoryStream(img);
                    this.pbxInfoPhoto.Image = Image.FromStream(ms);
                    this.pbxInfo.Image = Image.FromStream(ms);
                    break;
                }
                i++;
            }

        }

        private bool isvalid()
        {
            if(string.IsNullOrWhiteSpace(this.txtName.Text) || string.IsNullOrWhiteSpace(this.txtNewpass.Text) || string.IsNullOrWhiteSpace(this.txtOldpass.Text))
            {
                return false;
            }
            return true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (isvalid())
            {
                string oldpass = this.txtOldpass.Text;
                string newName = this.txtName.Text;
                string newpass = this.txtNewpass.Text;

                int i = 0;
                DataSet ds = this.Cn.getValueDb("select * from EmployeeTable;");
                while (i < ds.Tables[0].Rows.Count)
                {
                    if (ds.Tables[0].Rows[i][0].ToString() == this.Eid)
                    {
                        if (ds.Tables[0].Rows[i][1].ToString() == oldpass)
                        {
                            if (newpass.Length >= 8)
                            {
                                this.Cn.executeQueryDb("update EmployeeTable set ename='" + newName + "',epass='" + newpass + "' where eid='" + this.Eid + "'");
                                MessageBox.Show("Name and Password updated successfully!");
                                this.lblNameValue.Text = newName;
                                this.Ename=newName;
                                
                                break;
                            }
                            else
                            {
                                MessageBox.Show("The Password must atleast be 8 characters long");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Your old password is incorectly typed");
                        }
                    }

                    i++;
                }
            }
            else
            {
                MessageBox.Show("Some fields are empty,provide all information!");
            }
           
        }

        private void pbxInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Show();
        }

        private void lblUpdatePhoto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string imagePath = "";
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imagePath = ofd.FileName;

                this.pbxInfoPhoto.Image = Image.FromFile(imagePath);
                MemoryStream ms = new MemoryStream();
                pbxInfoPhoto.Image.Save(ms, pbxInfoPhoto.Image.RawFormat);
                
                byte[] imgBytes = ms.ToArray();
                string qry = "update EmployeeTable set ephoto=@photo where eid='" + this.Eid + "'";
                SqlParameter[] prm = new SqlParameter[] { new SqlParameter("@photo", imgBytes)};
                this.Cn.executeQueryDb(qry, prm);
                MessageBox.Show("Profile photo updated successfully!");
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FormAllProducts fall = new FormAllProducts(this.Eid, this.Ename, this.Erole, this.Esalary);
            this.Hide();
            fall.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FormLogIn fl = new FormLogIn();
            this.Hide();
            fl.Show();
        }
    }
}
