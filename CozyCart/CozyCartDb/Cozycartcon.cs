using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CozyCart.CozyCartDb
{
    internal class Cozycartcon
    {
        private SqlConnection sqlcon;
        private SqlCommand sqlcmd;
        private SqlDataAdapter sda;
        private DataSet ds;

        internal Cozycartcon()
        {
            this.Sqlcon= new SqlConnection("Data Source =.; Initial Catalog = COZYCARTDB; Integrated Security = True;");
            this.Sqlcon.Open();
        }

        //    internal string Strcon { get; set; }
        internal SqlConnection Sqlcon
        {
            get { return this.sqlcon; }
            set { this.sqlcon = value; }
        }

        internal SqlCommand Sqcmd
        {
            get { return this.sqlcmd; }
            set { this.sqlcmd = value; }
        }

        internal SqlDataAdapter Sda
        {
            get { return this.sda; }
            set { this.sda = value; }
        }
        internal DataSet Ds
        {
            get { return this.ds; }
            set { this.ds = value; }
        }
        internal DataSet getValueDb(string qry, SqlParameter[] parameters = null)
        {
            try
            {
                this.Sqcmd = new SqlCommand(qry, this.Sqlcon);




                this.Sda = new SqlDataAdapter(this.Sqcmd);

                this.Ds = new DataSet();
                this.Sda.Fill(this.Ds);

                return this.Ds;
            }
            catch (Exception ex) { 

                MessageBox.Show(ex.Message);
                return null;
            }
            
        }
        internal int executeQueryDb(string qry, SqlParameter[] parameters = null)
        {
            try
            {
                this.Sqcmd = new SqlCommand(qry, this.Sqlcon);

                if (parameters != null)
                {
                    this.Sqcmd.Parameters.AddRange(parameters);
                }

                int result = this.Sqcmd.ExecuteNonQuery();
                return result;
            }
            catch (Exception ex) {

                MessageBox.Show("Something went wrong in the server");
               return -1;
            
            }
            
        }

        internal DataTable GetValueDbTable(string qry, SqlParameter[] parameters = null)
        {
            try
            {



                this.Sqcmd = new SqlCommand(qry, this.Sqlcon);



                this.Sda = new SqlDataAdapter(this.Sqcmd);

                this.Ds = new DataSet();
                this.Sda.Fill(this.Ds);

                return this.Ds.Tables[0];
        }

            catch (Exception ex)
            {

                MessageBox.Show("Something went wrong in the server");
                return null;
            }


}


    }
}

