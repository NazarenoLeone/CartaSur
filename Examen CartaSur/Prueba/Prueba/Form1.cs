using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba
{
    public partial class Form1 : Form
    {
        static string conexionString = "Server=localhost;Database=ventas;Trusted_Connection=True;"; // REVISAR
        SqlConnection conexion = new SqlConnection(conexionString);
        bool flag = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_conectarse_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                MessageBox.Show("La conexion a la DB: " + conexion.Database + " Ha sido exitosa.");
                flag = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la conexion a la DB.");
            }
        }

        private void Btn_desconectarse_Click(object sender, EventArgs e)
        {
            if(flag)
            {
                conexion.Close();
                MessageBox.Show("Se ha desconectado correctamente.");
                flag = false;
            }
            else
            {
                MessageBox.Show("La DB no se ha conectado. Intente nuevamente");
            }
        }
        private void Btn_FMV_Click(object sender, EventArgs e)
        {
            try
            {
                if(flag)
                {
                    string query = "SELECT TOP 1 Fecha_venta, SUM(Cantidad) FROM ventas WHERE Cantidad = (SELECT MAX(B.Cantidad) FROM ventas B WHERE B.ID_VENTA = ventas.ID_VENTA) GROUP BY Fecha_venta;";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    SqlDataAdapter data = new SqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    data.Fill(tabla);

                    dgv_consulta.DataSource = tabla;
                }
                else
                {
                    MessageBox.Show("La DB no se ha conectado. Intente nuevamente");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hubo un error");
            }
        }

        private void Btn_FMI_Click(object sender, EventArgs e)
        {
            try
            {
                if (flag)
                {
                    string query = "SELECT TOP 1 Fecha_venta, SUM(Importe_total) FROM ventas WHERE Importe_total = (SELECT MAX(B.Importe_total) FROM ventas B WHERE B.ID_VENTA = ventas.ID_VENTA) GROUP BY Fecha_venta;";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    SqlDataAdapter data = new SqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    data.Fill(tabla);

                    dgv_consulta.DataSource = tabla;
                }
                else
                {
                    MessageBox.Show("La DB no se ha conectado. Intente nuevamente");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error");
            }
        }
    }
}
