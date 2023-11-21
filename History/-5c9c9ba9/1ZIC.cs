using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using Mysqlx.Cursor;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Clases
{
    internal class Productos
    {
        public void CalcularTotal(double Precio, double cantidad, string descripción,string nombre, label lblPrecio,label lblCantidad,TextBox txtTotal, double Total, string Total_Productos, label pedido)
        {
            string label;
            Precio = Convert.ToDouble(lblPrecio.Text);
            Precio = Precio * cantidad;
            descripción = (cantidad + nombre + "          $ " + Precio + "\n");
            Total=Total+Precio;
            Total_Productos = Total_Productos + descripción;
            lblCantidad.Text = "";
            txtTotal.Clear();
            txtTotal.Text = ("$" + Total);
            label = Convert.ToString(cantidad);
            lblCantidad.Text = label;
            pedido.Text = (Total_Productos);
        }
    }
}
