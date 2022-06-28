using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Class_AccesoSQL
{
    public  class Class_NASQL
    {
        private SqlConnection puerta { get; set; }

        public void ConnectionString(string llave)
        {
            puerta.ConnectionString = llave;
        }

        public Boolean MultiplesDataSet()
        {
            SqlCommand consul = null;
            SqlDataAdapter trailer = null;
            Boolean salida = false;
        }

        //public Boolean MultiplesConsultasDataSet(string querySql, SqlConnection conAbierta, ref string mensaje, ref DataSet dataset1, string nomConsulta)
        //{
        //    SqlCommand carrito = null;
        //    SqlDataAdapter trailer = null;
        //    Boolean salida = false;

        //    if (conAbierta == null)
        //    {
        //        mensaje = "No hay conexion a la BD";
        //        salida = false;
        //    }
        //    else
        //    {
        //        carrito = new SqlCommand();
        //        carrito.CommandText = querySql;
        //        carrito.Connection = conAbierta;

        //        trailer = new SqlDataAdapter();
        //        trailer.SelectCommand = carrito;

        //        try
        //        {
        //            trailer.Fill(dataset1, nomConsulta);
        //            mensaje = "Consulta correcta en el DataSet";
        //            salida = true;
        //        }
        //        catch (Exception a)
        //        {
        //            mensaje = "Error: " + a.Message;
        //        }
        //        conAbierta.Close();
        //        conAbierta.Dispose();
        //    }
        //    return salida;
        //}
    }
}
