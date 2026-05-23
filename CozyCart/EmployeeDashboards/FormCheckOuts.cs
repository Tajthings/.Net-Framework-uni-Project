using CozyCart.CozyCartDb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CozyCart.EmployeeDashboards
{
    public partial class FormCheckOuts : Form
    {
        private Cart[] cart_products;
        private FormCart frm;
        private double subtotal;
        private double discount;
        private double total;
        private string eid, ename, erole, esalary;

        private double refundAmount;
        private Cozycartcon cns;
        private double val;

        internal Cozycartcon Cns
        {
            get { return this.cns; }
            set { this.cns = value; }
        }
        internal Cart[] CartProducts
        {
            get { return this.cart_products; }
            set { this.cart_products = value; }
        }

        public FormCart Frm
        {
            get { return this.frm; }
            set { this.frm = value; }
        }

        public double Subtotal
        {
            get { return this.subtotal; }
            set { this.subtotal = value; }
        }

        public double Discount
        {
            get { return this.discount; }
            set { this.discount = value; }
        }

        public double Total
        {
            get { return this.total; }
            set { this.total = value; }
        }

        public double RefundAmount
        {
            get { return this.refundAmount; }
            set { this.refundAmount = value; }
        }
        internal FormCheckOuts(FormCart frm, Cart[] cart_products, string eid, string ename, string erole, string esalary)
        {
            InitializeComponent();

            this.flyoutBull.BackColor = Color.Transparent;
            this.pnlBill.BackColor = Color.Transparent;
            //  this.flyoutOrderSummary.BackColor=Color.Transparent;
            this.panel1.BackColor = Color.Transparent;
            this.Frm = frm;
            this.CartProducts = cart_products;
            this.Cns = new Cozycartcon();
            // this.cart_products = cart_products;
            this.eid = eid;
            this.ename = ename;
            this.erole = erole;
            this.esalary = esalary;
            this.tbxPaidAmount.Text = "0";
            this.val = Convert.ToDouble(this.tbxPaidAmount.Text);


        }



        private void tbxPaidAmount_TextChanged(object sender, EventArgs e)
        {

        }




        private void btnPayables_Click_1(object sender, EventArgs e)
        {
            //int subtotal = 0;
            //foreach(Cart crt in cart_products)
            //{
            //    if (!string.IsNullOrEmpty(crt.P_id))
            //    {
            //        subtotal += Convert.ToInt32(crt.P_price);
            //    }
            //}
            // this.lblSubAmount.Text = subtotal.ToString()+"Taka";
            this.RefundAmount = (Convert.ToDouble(tbxPaidAmount.Text) - this.Subtotal);
            if (this.RefundAmount > 0)
            {
                this.lblrfnds.Text = this.RefundAmount.ToString() + " Taka";
            }
            else
            {
                this.lblrfnds.Text = "0 Taka";
            }
        }

        private void photoLoad()
        {
            DataSet ds = this.Cns.getValueDb("select * from EmployeeTable;");
            int i = 0;
            while (i < ds.Tables[0].Rows.Count)
            {
                if (ds.Tables[0].Rows[i][0].ToString() == this.eid)
                {

                    byte[] img = (byte[])ds.Tables[0].Rows[i][5];

                    MemoryStream ms = new MemoryStream(img);
                    this.pbxInfo.Image = Image.FromStream(ms);
                    break;
                }
                i++;
            }
        }

        private void FormCheckOuts_Load(object sender, EventArgs e)
        {
            this.photoLoad();
            this.lblName.Text = this.ename;
            this.lblId.Text = this.eid;

            this.subtotal = 0;
            // int i = 0;
            //DataSet ds = this.cns.getValueDb("select * from CCwarehouseTable;");

            //  this.discount = Convert.ToDouble(this.cart_products);

            foreach (Cart crt in this.CartProducts)
            {
                if (!string.IsNullOrEmpty(crt.P_id))
                {
                    this.discount += Convert.ToInt32(crt.P_discount);
                    this.subtotal += Convert.ToInt32(crt.P_price);
                }
            }
            this.Total = this.Subtotal;
            this.lblTotal.Text = this.Total.ToString() + " Taka";
            this.lblDiscount.Text = this.Discount.ToString() + "%";
            this.Subtotal = this.Subtotal - (this.Subtotal * (this.Discount / 100));
            this.lblSubAmount.Text = this.Subtotal.ToString() + " Taka";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Frm.Show();
            this.Hide();
        }

        private void tbxPaidAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please enter paid amount.");
            }
        }

        private bool CheckStock()
        {
            DataSet ds = this.Cns.getValueDb("select * from CCwarehouseTable");
            double oldStock = 0;

            foreach (Cart cart in this.CartProducts)
            {

                if (!string.IsNullOrEmpty(cart.P_id))
                {
                    int i = 0;
                    while (i < ds.Tables[0].Rows.Count)
                    {
                        if (ds.Tables[0].Rows[i][0].ToString() == cart.P_id)
                        {

                            oldStock = Convert.ToDouble(ds.Tables[0].Rows[i][5]);
                            if ((oldStock - Convert.ToDouble(cart.Amount)) < 0)
                            {
                                MessageBox.Show(cart.P_name + "- Id :" + cart.P_id + " is out of stock!,couldnt generate bill");
                                return false;
                            }


                        }
                        i++;

                    }
                }
            }
            return true;
        }



        private void btnBill_Click(object sender, EventArgs e)
        {
            //if (this.CheckStock())
            //{
            //    DataSet ds = this.Cns.getValueDb("select * from CCwarehouseTable");
            //    double oldStock = 0;
            //    double newStock = -1;
            //    foreach (Cart crt in this.CartProducts)
            //    {
            //        if (!string.IsNullOrEmpty(crt.P_id))
            //        {
            //            int i = 0;
            //            while (i < ds.Tables[0].Rows.Count)
            //            {
            //                if (ds.Tables[0].Rows[i][0].ToString() == crt.P_id)
            //                {

            //                    oldStock = Convert.ToDouble(ds.Tables[0].Rows[i][5]);


            //                    newStock = oldStock - Convert.ToDouble(crt.Amount);
            //                    this.Cns.executeQueryDb("update CCwarehouseTable set pStock=" + newStock + " where pid=" + crt.P_id + ";");



            //                }
            //                i++;

            //            }
            //        }
            //    }
            //    this.UpdatePSTable();

            // FormBill fbl = new FormBill(this, this.cart_products, this.subtotal, this.discount, this.refundAmount);
            //fbl.Show();

            if (!string.IsNullOrWhiteSpace(tbxPaidAmount.Text) && Convert.ToDouble(this.tbxPaidAmount.Text) > val && Convert.ToDouble(this.tbxPaidAmount.Text) >= this.subtotal)

            {
                if (this.CheckStock())
                {
                    DataSet ds = this.Cns.getValueDb("select * from CCwarehouseTable");
                    double oldStock = 0;
                    double newStock = -1;
                    foreach (Cart crt in this.CartProducts)
                    {
                        if (!string.IsNullOrEmpty(crt.P_id))
                        {
                            int i = 0;
                            while (i < ds.Tables[0].Rows.Count)
                            {
                                if (ds.Tables[0].Rows[i][0].ToString() == crt.P_id)
                                {

                                    oldStock = Convert.ToDouble(ds.Tables[0].Rows[i][5]);


                                    newStock = oldStock - Convert.ToDouble(crt.Amount);
                                    this.Cns.executeQueryDb("update CCwarehouseTable set pStock=" + newStock + " where pId='" + crt.P_id + "';");
                                    //   MessageBox.Show("Db updated succcesfully");
                                    
                                 



                                }
                                i++;

                            }
                        }
                    }
                    this.UpdatePSTable();
                    this.btnBill.Enabled= false;
                    MessageBox.Show("Bill will get generated now,Please select end session,to end the current session");
                    this.pnlBill.Visible = true;
                    this.flyoutBull.Visible = true;



                    this.LoadBill();

                    this.lblBillTotal.Text = this.Total.ToString() + " Taka";
                    this.lblBillDiscount.Text = this.Discount.ToString() + "%";
                    this.lblBillSubtotal.Text = this.Subtotal.ToString() + " Taka";
                    this.lblBillPaid.Text = this.tbxPaidAmount.Text + " Taka";
                    if (Convert.ToDouble(this.tbxPaidAmount.Text) > this.Subtotal)
                    {
                        this.lblBillRefund.Text = (Convert.ToDouble(this.tbxPaidAmount.Text) - this.Subtotal).ToString() + " Taka";

                    }
                    this.lblsug.Visible = true;
                    this.lblBye.Visible = true;


                }
                else
                {
                    MessageBox.Show("Please fill with new stock!");
                }

               

            }
            else
            {
                MessageBox.Show("Fill the Price amount properly");
            }

        }
    
               



        

        private void button1_Click(object sender, EventArgs e)
        {
          //  FormAllProducts fall = new FormAllProducts(this.eid,this.ename,this.erole,this.esalary);
            this.Hide();
          //  fall.Show();
            this.frm.Frm.Show();
        }

        private void pbxInfo_Click(object sender, EventArgs e)
        {
            FormCashierInfo fc = new FormCashierInfo(this.eid, this.ename, this.erole,this.esalary);
            this.Hide();
            fc.Show();
        }

        private void btnEndSession_Click(object sender, EventArgs e)
        {
            FormAllProducts frp = new FormAllProducts(this.eid, this.ename, this.erole, this.esalary);
            this.Hide();
            frp.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FormLogIn fl = new FormLogIn();
            this.Hide();
            fl.Show();

        }

        private void UpdatePSTable()
        {
            foreach(Cart crt in cart_products)
            {
               if(!string.IsNullOrEmpty(crt.P_id))
                {
                    string qry =
               "INSERT INTO ProductSalesTable (pid, pdName, pAmountSold) " +
               "VALUES ('" + crt.P_id + "', '" +
               crt.P_name + "', " +
               crt.P_price + ")";
                    this.Cns.executeQueryDb(qry);

                }
            }
        }

      

        private void LoadBill()
        {
            this.flyoutBull.Controls.Clear();

            foreach (Cart crt in this.CartProducts)
            {
                if (!string.IsNullOrEmpty(crt.P_id))
                {
                    Panel p = new Panel();


                    p.Width = flyoutBull.ClientSize.Width - 4;
                    p.Height = 30;


                    p.BackColor = Color.FromArgb(120, 255, 255, 255);
                    p.Margin = new Padding(2);


                    Label nameQty = new Label();
                    nameQty.Text = $"{crt.P_name} x{crt.Amount}";
                    nameQty.Dock = DockStyle.Fill;
                    nameQty.TextAlign = ContentAlignment.MiddleLeft;
                    nameQty.BackColor = Color.Transparent;
                    nameQty.AutoEllipsis = true; // handles long names


                    Label price = new Label();

                    int qty = Convert.ToInt32(crt.Amount);
                    int unit = Convert.ToInt32(crt.P_price);
                    //int total = qty * unit;

                    price.Text = unit + " tk";
                    price.Dock = DockStyle.Right;
                    price.Width = 70; 
                    price.TextAlign = ContentAlignment.MiddleRight;
                    price.BackColor = Color.Transparent;


                    p.Controls.Add(nameQty);
                    p.Controls.Add(price);


                    p.Paint += (s, e) =>
                    {
                        e.Graphics.DrawLine(Pens.LightGray, 0, p.Height - 1, p.Width, p.Height - 1);
                    };

                    this.flyoutBull.Controls.Add(p);
                }
            }
        }
       


        private void FormCheckOut_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }
    }
}
