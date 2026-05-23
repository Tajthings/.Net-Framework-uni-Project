using CozyCart.CozyCartDb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CozyCart.EmployeeDashboards
{
    public partial class FormCart : Form
    {
        private Cart[] cart_products;
        private FormAllProducts frm;
        private int currentStock;
        private Cozycartcon cn;
        private string eid, ename, erole, esalary;

        internal Cart[] CartProducts
        {
            get { return this.cart_products; }
            set { this.cart_products = value; }
        }
        internal FormAllProducts Frm
        {
            get{return  this.frm; }
            set { this.frm = value; }
        }
        internal int CurrentStock
        {
            get { return this.currentStock; }
            set { this.currentStock = value; }
        }
        internal Cozycartcon Cn
        {
            get { return this.cn; }
            set { this.cn = value; }
        }
        internal FormCart(FormAllProducts frm,Cart[] cart_products, string eid, string ename, string erole, string esalary)
        {
            InitializeComponent();
            flyoutCart.BackColor = Color.Transparent;
            flyoutCart.Padding = new Padding(100, 10, 0, 0);
            this.CartProducts = cart_products;
            this.Frm = frm;
            cn= new Cozycartcon();
       

        }

        private void Plus_Click(object sender, EventArgs e)
        {
            this.flyoutCart.Controls.Clear();
            Button btn = (Button)sender;
            string id = btn.Tag.ToString();
            



            for (int i = 0; i < FormAllProducts.index; i++)
            {
                if (this.CartProducts[i].P_id == id)
                {
                    int qty = Convert.ToInt32(this.CartProducts[i].Amount);
                    double unitPrice = Convert.ToInt32(this.CartProducts[i].P_price)/qty;
                    qty++;
                   
                    double price=unitPrice*qty;

                    this.CartProducts[i].Amount = qty.ToString();
                    this.CartProducts[i].P_price = price.ToString();
                    this.RefreshCartUI();
                    
                    break;
                }
            }
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            this.flyoutCart.Controls.Clear();
            Button btn = (Button)sender;
            string id = btn.Tag.ToString();

            for (int i = 0; i < FormAllProducts.index; i++)
            {
                if (cart_products[i].P_id == id)
                {
                    int qty = Convert.ToInt32(cart_products[i].Amount);
                    int qty2 = qty;

                    if (qty > 1)
                    {
                        qty--;
                    }
                    int price = (Convert.ToInt32(cart_products[i].P_price)* qty)/qty2;
      
                    this.CartProducts[i].Amount = qty.ToString();
                    this.CartProducts[i].P_price = price.ToString();
                    this.flyoutCart.Visible= false;
                    this.RefreshCartUI();
                    this.flyoutCart.Visible = false;
                    this.flyoutCart.Visible = true;
                    break;
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            
            Button btn = (Button)sender;
            string id = btn.Tag.ToString();

            
            for (int i = 0; i < cart_products.Length; i++)
            {
                if (this.CartProducts[i].P_id == id)
                {
                    this.CartProducts[i].P_id = null;
                    break;
                }
            }
            this.flyoutCart.Controls.Clear();

          
            this.RefreshCartUI();
        }
        private void RefreshCartUI() {
            this.flyoutCart.Visible = false;
            this.LoadCartPanels(cart_products);
            for(int i = 0; i <= 5; i++)
            {
                this.flyoutCart.Visible = false;
            }
            this.flyoutCart.Visible = true;
        }




        private void LoadCartPanels(Cart[] cart_products) { 
        
           // flyoutCart.Controls.Clear();

            foreach (Cart crt in this.CartProducts)
            {
                if (!string.IsNullOrEmpty(crt.P_id))
                {
                   
                    Panel p = new Panel();
                    p.Width = 350;
                    p.Height = 120;
                    p.BorderStyle = BorderStyle.FixedSingle;
                    p.BackColor = Color.FromArgb(120, 255, 255, 255);
                    

                  
                    PictureBox pb = new PictureBox();
                    pb.Width = 80;
                    pb.Height = 80;
                    pb.Location = new Point(10, 15);
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;

                    if (crt.P_image != null)
                    {
                        MemoryStream ms = new MemoryStream(crt.P_image);
                        pb.Image = Image.FromStream(ms);
                    }

                  
                    Label name = new Label();
                    name.Text = crt.P_name;
                    name.Location = new Point(100, 10);
                    name.AutoSize = true;
                    name.BackColor = Color.Transparent;

                 
                    Label price = new Label();
                    price.Text = "Price: " + crt.P_price;
                    price.Location = new Point(100, 35);
                    price.AutoSize = true;
                    price.BackColor = Color.Transparent;

                    Label id = new Label();
                    id.Text = "Id: " + crt.P_id;
                    id.Location = new Point(100, 50);
                    id.AutoSize = true;
                    id.BackColor = Color.Transparent;

                   
                    Label amount = new Label();
                    amount.Text = crt.Amount + " " + crt.Unit;
                  //  amount.Location = new Point(220, 50);
                    amount.Width = 60;
                    amount.Height = 20;
                    amount.TextAlign = ContentAlignment.MiddleCenter;
                    amount.BackColor = Color.Transparent;

                 
                    Button minus = new Button();
                    minus.Text = "-";
                    minus.Width = 30;
                    minus.Height = 25;
                    minus.Location = new Point(180, 45);

                 
                    Button plus = new Button();
                    plus.Text = "+";
                    plus.Width = 30;
                    plus.Height = 25;
                    plus.Location = new Point(250, 45);

                    int y = 40;

                    minus.Location = new Point(165, y);
                    amount.Location = new Point(195, y);
                    plus.Location = new Point(260, y);
                    minus.Tag = crt.P_id;
                    plus.Tag = crt.P_id;
                    amount.Tag = crt.P_id;
                    minus.Click += Minus_Click;
                    plus.Click += Plus_Click;

                
                    Button delete = new Button();
                    delete.Text = "X";
                    delete.Width = 30;
                    delete.Height = 25;
                    delete.Location = new Point(310, 5);
                    delete.BackColor = Color.FromArgb(200, 255, 100, 100);
                    delete.Location = new Point(290, 5);
                    delete.Click += Delete_Click;
                    delete.Tag = crt.P_id;

               
                    p.Controls.Add(pb);
                    p.Controls.Add(name);
                    p.Controls.Add(id);
                    p.Controls.Add(price);
                    p.Controls.Add(amount);
                    p.Controls.Add(minus);
                    p.Controls.Add(plus);
                    p.Controls.Add(delete);

                    this.flyoutCart.Controls.Add(p);
                }
            }
        }


        private void photoLoad()
        {
            DataSet ds = this.Cn.getValueDb("select * from EmployeeTable;");
            int i = 0;
            while (i < ds.Tables[0].Rows.Count)
            {
                if (ds.Tables[0].Rows[i][0].ToString() == this.frm.Eid)
                {

                    byte[] img = (byte[])ds.Tables[0].Rows[i][5];

                    MemoryStream ms = new MemoryStream(img);
                    this.pbxInfo.Image = Image.FromStream(ms);
                    break;
                }
                i++;
            }
        }

        internal void FormCart_Load(object sender, EventArgs e)
        {
            this.photoLoad();
            this.LoadCartPanels(this.CartProducts);
            this.lblId.Text=this.frm.Eid;
            this.lblName.Text=this.frm.Ename;
            
        }

        private void pbxInfo_Click(object sender, EventArgs e)
        {
            FormCashierInfo frms = new FormCashierInfo(this.frm.Eid, this.frm.Ename, this.frm.Erole, this.frm.Esalary);
            this.Hide();
            frms.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FormLogIn fl = new FormLogIn();
            this.Hide();
            fl.Show();
        }

        private void btnEndSession_Click(object sender, EventArgs e)
        {
            FormAllProducts frp = new FormAllProducts(this.frm.Eid,this.frm.Ename,this.frm.Erole,this.frm.Esalary);
            this.Hide();
            frp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Frm.Show();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            bool itemexist = false;
           foreach (Cart item in this.cart_products)
            {
                if (item.P_id != null)
                {
                    itemexist = true;
                }
            }
            if (itemexist)
            {
                FormCheckOuts frmc = new FormCheckOuts(this, this.cart_products, this.frm.Eid, this.frm.Ename, this.frm.Erole, this.frm.Esalary);
                this.Hide();
                frmc.Show();
            }
            else
            {
                MessageBox.Show("There must be atleast one element in cart for the checkout!");

            }

         
        }

        private void FormCart_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }
    }
}
