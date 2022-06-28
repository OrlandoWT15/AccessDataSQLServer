using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Class_AccesoSQL;
using System.Data;
using System.Data.SqlClient;

namespace AccessData
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        private ClassAccesoSQL llaveSQL = null;
        private SqlConnection puerta = null;
         
        protected void Page_Load(object sender, EventArgs e)
        {
            using (puerta = new SqlConnection())
            {
                if (Session["conexion"] != null)
                {
                }
                else
                {
                    puerta.ConnectionString = @"Data Source=DESKTOP-93UDGQE\SQLEXPRESS2019; Initial Catalog=SeguimientoCovid; Integrated Security=true";
                    try
                    {
                        Session["conexion"] = puerta.ConnectionString;
                        ListBox1.Items.Clear();
                        ListBox1.Items.Add("Conexión establecida");
                    }
                    catch (Exception i)
                    {
                        ListBox1.Items.Add("Error fatal " + i.Message);
                    }
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string consultita = "";
            string mensaje = "";
            ListBox1.Items.Clear();
            consultita = "SELECT * FROM Profesor";
            //if (llaveSQL.MConsultasDataSet())
            {

            }
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // GridView1.DataSource = contenedor.Tables[ListBox1.SelectedIndex];
        }
    }
}