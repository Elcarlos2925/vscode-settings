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
        public void CalcularTotal(double Precio, 
        double cantidad, 
        string descripción,
        string nombre, 
        label lblPrecio,
        label lblCantidad,
        TextBox txtTotal, 
        double Total, 
        string Total_Productos, 
        label pedido)
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
        public void Limpiar(double Americano,
            double Cappuccino ,
            double White_Mocha,
            double Latte,
            double Chocolate,
            double Mocha,
            double Tea_Matcha ,
            double Frappuccino,
            double Galleta,
            double Brownie,
            double Pastel,
            double Sandwich,
            double Total,
            double txtTotal,
            string strAmericano,
            string strBrownie,
            string strCappuccino,
            string strChocolate,
            string strFrappuccino,
            string strGalleta,
            string strLatte,
            string strMocha,
            string strPastel,
            string strSandwich,
            string strTea_Matcha,
            string strWhite_Mocha,
            string productos,
            double CndAmericano,
            double CndCappuccino ,
            double CndWhite_Mocha ,
            double CndLatte ,
            double CndChocolate ,
            double CndMocha ,
            double CndTea_Matcha ,
            double CndFrappuccino,
            double CndGalleta ,
            double CndBrownie ,
            double CndPastel ,
            double CndSandwich,
            label lblCantidadAmericano,
            label lblCantidadCapuccino,
            label lblCantidadWhiteMocha,
            label lblCantidadLatte,
            label lblCantidadChocolate,
            label lblCantidadMocha,
            label lblCantidadTeaMatcha,
            label lblCantidadFrapuccino,
            label lblCantidadGalleta,
            label lblCantidadBrownie,
            label lblCantidadPastel,
            label lblCantidadSandwich,
            label lblPedido
             )
        {
            Americano = 0;
            Cappuccino = 0;
            White_Mocha = 0;
            Latte = 0;
            Chocolate = 0;
            Mocha = 0;
            Tea_Matcha = 0;
            Frappuccino = 0;
            Galleta = 0;
            Brownie = 0;
            Pastel = 0;
            Sandwich = 0;
            Total = 0;
            txtTotal.Clear();

            strAmericano = "";
            strBrownie = "";
            strCappuccino = "";
            strChocolate = "";
            strFrappuccino = "";
            strGalleta = "";
            strLatte = "";
            strMocha = "";
            strPastel = "";
            strSandwich = "";
            strTea_Matcha = "";
            strWhite_Mocha = "";
            productos = "";

            CndAmericano = 0;
            CndCappuccino = 0;
            CndWhite_Mocha = 0;
            CndLatte = 0;
            CndChocolate = 0;
            CndMocha = 0;
            CndTea_Matcha = 0;
            CndFrappuccino = 0;
            CndGalleta = 0;
            CndBrownie = 0;
            CndPastel = 0;
            CndSandwich = 0;

            lblCantidadAmericano.Text = "0";
            lblCantidadCapuccino.Text = "0";
            lblCantidadWhiteMocha.Text = "0";
            lblCantidadLatte.Text = "0";
            lblCantidadChocolate.Text = "0";
            lblCantidadMocha.Text = "0";
            lblCantidadTeaMatcha.Text = "0";
            lblCantidadFrapuccino.Text = "0";
            lblCantidadGalleta.Text = "0";
            lblCantidadBrownie.Text = "0";
            lblCantidadPastel.Text = "0";
            lblCantidadSandwich.Text = "0";
            lblPedido.Text = "";
        }
    }
}
