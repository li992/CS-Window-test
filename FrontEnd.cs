using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CS_Window_test
{
    public partial class FrontEnd : Form
    {
        public FrontEnd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userID = LoginID.Text;
            string userPWD = LoginPWD.Text;

            string connectionString = @"Data Source = Regwcorpdb02v; Initial Catalog = IDW; User ID = "+userID+";Password="+userPWD+";";

            /*
            SqlConnection conn = new SqlConnection("user id=" + userID + ";" +
                                        "password = " + userPWD + "; server = Regwcorpdb02v;" +
                                        "Trusted_connection=yes;" +
                                        "database=IDW;" +
                                        "connection timeout = 30");
            try{
                conn.Open();
            }
            catch(Exception excp){
                MessageBox.Show(excp.ToString(), "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
             */

            SqlConnection cnn = new SqlConnection(connectionString);

            try
            {
                cnn.ConnectionString = connectionString;
                cnn.Open();
                if (cnn.State.Equals("Open"))
                {
                    DataReturn.Text = "Connected";
                }

            }
            catch(Exception EX)
            {
                if(cnn !=null)
                    cnn.Dispose();
                MessageBox.Show(EX.ToString(), "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

    }

}
