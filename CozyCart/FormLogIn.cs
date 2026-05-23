using CozyCart.CozyCartDb;
using CozyCart.EmployeeDashboards;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CozyCart.AdminDashboards;

namespace CozyCart
{
    public partial class FormLogIn : Form
    {
        private string eid;
        private string ename;

        private string erole;
        private string esalary;
        private string edate;
        private Cozycartcon cns;

        public string Eid
        {
            get { return this.eid; }
            set { this.eid = value; }


        }

        public string Ename
        {
            get { return this.ename; }
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

        public string Edate
        {
            get { return this.edate; }
            set { this.edate = value; }
        }

        internal Cozycartcon Cns
        {
            get { return this.cns; }
            set { this.cns = value; }
        }
        public FormLogIn()
        {
            InitializeComponent();
            pnlLogIn.BackColor = Color.Transparent;
            pictureBox1.BackColor = Color.Transparent;
            txtPass.UseSystemPasswordChar = true;
            cns = new Cozycartcon();

        }

        private void cbsShowpass_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbsShowpass.Checked)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private bool isFilled()
        {
            if (string.IsNullOrWhiteSpace(txtUserid.Text) || string.IsNullOrWhiteSpace(txtPass.Text))
            {
                return false;
            }

            return true;
        }
        private void btnLogIN_Click(object sender, EventArgs e)
        {
            if (isFilled())
            {
                string id = txtUserid.Text;
                string pass = txtPass.Text;
                DataSet ds = this.Cns.getValueDb("select * from EmployeeTable;");
                int i = 0;
                bool found = false;
                while (i < ds.Tables[0].Rows.Count)
                {
                    if (id == (ds.Tables[0].Rows[i][0].ToString()) && pass == (ds.Tables[0].Rows[i][1].ToString()))
                    {
                        this.Eid = ds.Tables[0].Rows[i][0].ToString();
                        this.Ename = ds.Tables[0].Rows[i][2].ToString();
                        this.Erole = ds.Tables[0].Rows[i][3].ToString();
                        this.Esalary = ds.Tables[0].Rows[i][4].ToString();
                        //  this.edate= ds.Tables[0].Rows[i][6].ToString();
                        if (this.Erole == "Cashier")
                        {
                            FormAllProducts frm = new FormAllProducts(this.Eid, this.Ename, this.Erole, this.Esalary);
                            this.Hide();
                            frm.Show();
                            found = true;
                            MessageBox.Show("Cashier Log in sucessful!");
                            break;
                        }

                        else
                        {
                            FormHome frm = new FormHome(this.Eid, this.Ename, this.Erole);
                            this.Hide();
                            frm.Show();
                            found = true;
                            MessageBox.Show("Admin Log in sucessful!");
                            break;
                        }




                    }

                    i++;





                }
                if (!found)
                {
                    MessageBox.Show("User not found");
                    txtPass.Clear();
                    txtUserid.Clear();
                }

            }
            else
            {
                MessageBox.Show("Boxes cant be empty.");
            }
        }

    }
    

}
