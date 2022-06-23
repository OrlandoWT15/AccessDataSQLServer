using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace AccessData
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private SqlConnection puerta = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            using (puerta = new SqlConnection())
            {
                if (Session["conexion"]!=null)
                {
                }
                else
                {
                    puerta.ConnectionString = @"Data Source=DESKTOP-93UDGQE\SQLEXPRESS2019; Initial Catalog=SeguimientoCovid; Integrated Security=true";
                    try
                    {
                        Session["conexion"] = puerta.ConnectionString;
                        TextBox1.Text = "Conexión establecida";
                    }
                    catch (Exception i)
                    {
                        TextBox1.Text = "Error fatal " + i.Message;
                    }
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection puertaPequenia = null;
            using (puertaPequenia = new SqlConnection())
                try
                {
                    puerta.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["conkcinco"].ConnectionString;
                    puerta.Open();
                    SqlCommand comand = new SqlCommand();

                    comand.CommandText = "INSERT INTO EstadoCivil Values ('soltero','bien amarrado')";
                    comand.Connection = puerta;
                    comand.ExecuteNonQuery();

                    comand.CommandText = "INSERT INTO Profesor Values (1,'Orlando Ivan Basulto Benitez','1','1','Masculino','1','gouiterra@gmail.com','2228971336',1)";
                    comand.Connection = puerta;
                    comand.ExecuteNonQuery();


                    TextBox1.Text = "Se agrego correctamente";
                    puerta.Close();
                }
                catch (Exception i)
                {
                    TextBox1.Text = ("Errro al agregar " + i.Message);
                }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlCommand comand = null;
            SqlDataAdapter cajaG = null;
            DataSet cajaS = null;

            using (puerta=new SqlConnection())
            {
                puerta.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["conkcinco"].ConnectionString;
                try
                {
                    puerta.Open();
                    comand = new SqlCommand();
                    comand.CommandText = "select * from profesor";
                    comand.Connection = puerta;
                    cajaG = new SqlDataAdapter();
                    cajaS = new DataSet();
                    cajaG.SelectCommand = comand;
                    cajaG.Fill(cajaS);

                    
                    if (cajaS!=null)
                    {
                        GridView1.DataSource = cajaS.Tables[0];
                        GridView1.DataBind();
                        TextBox1.Text = "Consulta Correcta";
                    }
                    puerta.Close();
                }
                catch (Exception i)
                {
                    TextBox1.Text = "Excepcion :"+i;
                }
            }
        }

        private void antiguomostrar()
        {
            //SqlConnection puertaPequenia = null;
            //SqlCommand comand = null;
            //SqlDataReader cajaGrande = null;
            //SqlDataAdapter trailer = null;
            //DataSet cajachica = null;
            //using (puerta = new SqlConnection())
            //{
            //    puerta.ConnectionString = @"Data Source=DESKTOP-93UDGQE\SQLEXPRESS2019; Initial Catalog=SeguimientoCovid; Integrated Security=true";
            //    try
            //    {
            //        puerta.Open();
            //        comand = new SqlCommand();
            //        comand.CommandText = "select * from profesor";
            //        comand.Connection = puertaPequenia;
            //        trailer = new SqlDataAdapter();
            //        cajachica = new DataSet();
            //        trailer.SelectCommand = comand;
            //        trailer.Fill(cajachica);
            //        //cajaGrande=comand.ExecuteReader();
            //        TextBox1.Text = "Consulta correcta";
            //        //if (cajaGrande.HasRows)
            //        //{
            //        //    GridView1.DataSource = cajaGrande.Read();
            //        //    GridView1.DataBind();
            //        //}
            //        if (cajachica!=null)
            //        {
            //            GridView1.DataSource = cajachica.Tables[0];
            //            GridView1.DataBind();
            //        }
            //        puerta.Close();
            //    }
            //    catch (Exception i)
            //    {
            //        TextBox1.Text = ("Errro al agregar " + i.Message);
            //    }
            //}
        }
    }
}