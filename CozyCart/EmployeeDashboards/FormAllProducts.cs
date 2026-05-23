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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CozyCart.EmployeeDashboards {

    internal struct Cart
    {
        private string p_id;
        private string p_name;
        private string p_price;
        public byte[] image;
        private string amount;
        private string unit;
        private string discount;
       

        internal Cart(string p_id, string p_name, string p_price, byte[] image,string unit,string discount)
        {
            this.p_id=p_id;
            this.p_name=p_name;
            this.p_price=p_price;
            this.image=image;
            this.amount = "1";
            this.unit = unit;
            this.discount = discount;
            

        }
        
        public string P_id
        {
            get { return p_id; }
            set { p_id = value; }
        }

        public string P_name
        {
            get { return p_name; }
            set { p_name = value; }
        }

        public string P_price
        {
            get { return p_price; }
            set { p_price = value; }
        }

        public byte[] P_image
        {
            get { return image; }
            set { image = value; }
        }

        public string Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public string Unit
        {
            get { return this.unit; }
            set { unit = value; }
        }
        internal string P_discount
        {
            get { return this.discount; }
            set { unit = value; }
        }

    }

    public partial class FormAllProducts : Form
    {
        private Cozycartcon cn;
        private Cart [] cart_products;
        private string eid, ename, erole, esalary;
        public FormAllProducts(string eid,string ename,string erole,string esalary)
        {
          
            InitializeComponent();
         
            flyoutPcategories.BackColor = Color.Transparent;
            flyoutPNameList.BackColor = Color.Transparent;
            this.pnlAllP.BackColor = Color.Transparent;
            this.btnAllProd.BackColor = Color.Transparent;
            pnlInfo.BackColor = Color.Transparent;
            pnlMenu.BackColor = Color.Transparent;
            this.Cn = new Cozycartcon();
            this.CartProducts = new Cart[100];
            this.Eid= eid;
            this.Ename = ename;
            this.Erole = erole;
            this.Esalary = esalary;
            this.lblName.Text = this.Ename;
            this.lblId.Text= this.Eid;
           
        }
        internal Cozycartcon Cn
        {
            get { return this.cn; }
            set { this.cn = value; }
        }

        internal Cart[] CartProducts
        {
            get { return this.cart_products; }
            set { this.cart_products = value; }
        }

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

        private void ButtonCategories_Click(object sender, EventArgs e)
        {
            flyoutPNameList.Controls.Clear();
            Button btn = (Button)sender;
           // MessageBox.Show(btn.Text);
            DataSet ds = this.Cn.getValueDb("select * from CCwarehouseTable where pCategory='"+btn.Text+"'");
            productList(ds);

        }
        private void Panel_Click(object sender, EventArgs e)
        {
            Panel p = (Panel)sender;
            MessageBox.Show(p.Tag.ToString());
        }
        private void Picture_Click(object sender, EventArgs e)
        {
            //PictureBox pb = (PictureBox)sender;
            //Panel p = pb.Parent as Panel;
            //MessageBox.Show(p.Tag.ToString());
        }
        private void LabelDetails_Click(object sender, EventArgs e)
        {

           // Label lbl = ( Label)sender;
           //// MessageBox.Show(lbl.Text);
           // Panel p = (Panel)lbl.Parent;
           // MessageBox.Show(p.Tag.ToString());
        }
        internal static int index = 0;
        private void BtnAddToCart_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            string productId = btn.Tag.ToString();

          

            DataSet ds = this.Cn.getValueDb("select * from CCwarehouseTable");

            int i = 0;
            while (i < ds.Tables[0].Rows.Count)
            {
                if (ds.Tables[0].Rows[i][0].ToString() == productId)
                {
                    string name = ds.Tables[0].Rows[i][2].ToString();
                    string price = ds.Tables[0].Rows[i][4].ToString();
                    byte[] img = (byte[])ds.Tables[0].Rows[i][3];
                    string unit = ds.Tables[0].Rows[i][7].ToString();
                    string discount = "0";
                    if (ds.Tables[0].Rows[i][6].ToString() != null)
                    {
                      discount = ds.Tables[0].Rows[i][6].ToString();
                    }
                   


                    bool alreadyExists = false;

                    for (int j = 0; j < index; j++)
                    {
                        if (this.CartProducts[j].P_id == productId)
                        {
                            alreadyExists = true;
                            break;
                        }
                    }

                    if (alreadyExists)
                    {
                        MessageBox.Show("Item already in cart");
                    }
                    else
                    {
                        if (index < this.CartProducts.Length)
                        {
                            this.CartProducts[index] = new Cart(productId, name, price, img, unit,discount);
                            MessageBox.Show("Added to cart. ID: " + productId);
                            index++;
                        }
                        else
                        {
                            MessageBox.Show("Cart is full");
                        }
                    }
                }

                i++;
            }
        }

        private void btnAllProd_Click(object sender, EventArgs e)
        {
            this.flyoutPNameList.Controls.Clear();
            DataSet ds = this.Cn.getValueDb("select * from CCwarehouseTable");
            productList(ds);

        }

        private void pbxInfo_Click(object sender, EventArgs e)
        {
            FormCashierInfo frm = new FormCashierInfo(this.Eid,this.Ename,this.Erole,this.Esalary);
            this.Hide();
            frm.Show();
        }

        private void frmLogOut_Click(object sender, EventArgs e)
        {
            FormLogIn fl = new FormLogIn();
            this.Hide();
            fl.Show();
        }

        private void tbxPnameSearch_TextChanged(object sender, EventArgs e)
        {
           
            this.flyoutPNameList.Controls.Clear();
            DataSet ds = this.Cn.getValueDb("select * from CCwarehouseTable where pName like '"+this.tbxPnameSearch.Text+"%'");
            productList(ds);
        }

        private void txtPidSearch_TextChanged(object sender, EventArgs e)
        {
            this.flyoutPNameList.Controls.Clear();
            DataSet ds = this.Cn.getValueDb("select * from CCwarehouseTable where pId like '" + this.txtPidSearch.Text + "%'");
            productList(ds);
        }

        private void productList(DataSet ds)
        {
            int i = 0;
            while (i < ds.Tables[0].Rows.Count)
            {
                if (Convert.ToInt32(ds.Tables[0].Rows[i][5]) > 0)
                {


                    Panel card = new Panel();
                    card.Width = 180;
                    card.Height = 260;
                    card.BorderStyle = BorderStyle.FixedSingle;
                    card.Click += Panel_Click;
                    card.Tag = ds.Tables[0].Rows[i][0];

                    PictureBox pb = new PictureBox();
                    pb.Width = 160;
                    pb.Height = 120;
                    pb.Location = new Point(10, 10);
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;

                    byte[] imgBytes = (byte[])ds.Tables[0].Rows[i][3];
                    MemoryStream ms = new MemoryStream(imgBytes);
                    pb.Image = Image.FromStream(ms);
                    pb.Click += Picture_Click;

                    Label lblPDetails = new Label();
                    lblPDetails.Width = 160;
                    lblPDetails.Height = 60;
                    lblPDetails.Location = new Point(10, 140);
                    lblPDetails.TextAlign = ContentAlignment.MiddleCenter;

                    string name = ds.Tables[0].Rows[i][2].ToString();
                    string price = ds.Tables[0].Rows[i][4].ToString();
                    string amount = ds.Tables[0].Rows[i][7].ToString();
                    string stock = ds.Tables[0].Rows[i][5].ToString();

                    lblPDetails.Text = name + "\nPrice: " + price + " taka\n1 " + amount + "\nStock:" + stock;
                    lblPDetails.Click += LabelDetails_Click;


                    Button btnAddToCart = new Button();
                    btnAddToCart.Text = "Add to Cart";
                    btnAddToCart.Width = 160;
                    btnAddToCart.Height = 30;
                    btnAddToCart.Location = new Point(10, 205);

                  
                    btnAddToCart.Tag = ds.Tables[0].Rows[i][0];

                    btnAddToCart.Click += BtnAddToCart_Click;

                
                    card.Controls.Add(pb);
                    card.Controls.Add(lblPDetails);
                    card.Controls.Add(btnAddToCart);

                    flyoutPNameList.Controls.Add(card);
                    
                }
                i++;
            }
           
        }

        private void btnEndSession_Click(object sender, EventArgs e)
        {
            FormAllProducts fall = new FormAllProducts(this.Eid,this.Ename,this.Erole,this.Esalary);
            this.Hide();
            fall.Show();
        }

        private void photoLoad()
        {
            DataSet ds = this.Cn.getValueDb("select * from EmployeeTable;");
            int i = 0;
            while (i < ds.Tables[0].Rows.Count)
            {
                if (ds.Tables[0].Rows[i][0].ToString() == this.Eid)
                {

                    byte[] img = (byte[])ds.Tables[0].Rows[i][5];

                    MemoryStream ms = new MemoryStream(img);
                    this.pbxInfo.Image = Image.FromStream(ms);
                    break;
                }
                i++;
            }
        }
        private void FormAllProducts_Load(object sender, EventArgs e)
        {
            this.photoLoad();
            DataSet ds = this.Cn.getValueDb("select distinct pCategory from CCwarehouseTable");
           // MessageBox.Show((ds.Tables[0].Rows.Count).ToString());
            int i = 0;
            while (i < ds.Tables[0].Rows.Count)
            {
               



                Button btnCategories = new Button();

                btnCategories.Text = ds.Tables[0].Rows[i][0].ToString();
                btnCategories.Width = 200;
                btnCategories.Height = 40;

                btnCategories.Click += ButtonCategories_Click;

                flyoutPcategories.Controls.Add(btnCategories);
               


                i++;
            }
            ds = this.Cn.getValueDb("select * from CCwarehouseTable");
            productList(ds);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCart crt = new FormCart(this, cart_products,this.eid,this.ename, this.erole,this. esalary);
            this.Hide();
            crt.Show();
        }
    }
}
