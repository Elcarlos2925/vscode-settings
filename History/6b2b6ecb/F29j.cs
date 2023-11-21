using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic;

namespace TheDropCoffee
{
    public partial class btnInfoAmericano : Form
    {
        public btnInfoAmericano()
        {
            InitializeComponent();
        }

        double Americano, Cappuccino, White_Mocha, Latte, Chocolate, Mocha, Tea_Matcha, Frappuccino, Galleta, Brownie, Pastel, Sandwich, Total, Cambio, Cantidad;
        double  CndAmericano, CndCappuccino, CndWhite_Mocha, CndLatte, CndChocolate, CndMocha, CndTea_Matcha, CndFrappuccino, CndGalleta, CndBrownie, CndPastel, CndSandwich, CndTotal;
        string strAmericano, strCappuccino, strWhite_Mocha, strLatte, strChocolate, strMocha, strTea_Matcha, strFrappuccino, strGalleta, strBrownie, strPastel, strSandwich, Productos, Pedido;
        private void lblTotal_Click(object sender, EventArgs e)
        {
            //Label Total 
        }
        private void btnInfoAmericano_Load(object sender, EventArgs e)
        {
            /*MessageBox.Show("Start");*/
            //MessageBox.Show("Grita abrete sesamo y pulsa aceptar.");
        }
        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            //Txt Total 
        }


        //========================Labels Vacios=========================
        private void lblPedido_Click(object sender, EventArgs e)
        {
            //lbl pedido
        }
        public void lblPrecioAmericano_Click(object sender, EventArgs e)
        {
            //lbl Precio Cafe Americano
        }
        public void lblPrecioCappucino_Click(object sender, EventArgs e)
        {
            //lbl Precio Cappucciono
        }
        public void lblPrecioWhiteMocha_Click(object sender, EventArgs e)
        {
            //lbl Precio White Mocha
        }
        public void lblPrecioTeaMatcha_Click(object sender, EventArgs e)
        {
            //lbl Precio Tea Matcha
        }
        public void lblPrecioGalleta_Click(object sender, EventArgs e)
        {
            //lbl Precio Galleta
        }
        public void lblPrecioPastel_Click(object sender, EventArgs e)
        {
            //lbl Precio Pastel
        }
        public void lblPrecioLatte_Click(object sender, EventArgs e)
        {
            //lbl Precio Latte
        }
        public void lblPrecioChocolate_Click(object sender, EventArgs e)
        {
            //lbl Precio Chocolate
        }
        public void lblPrecioMocha_Click(object sender, EventArgs e)
        {
            //lbl Precio Mocha
        }
        public void lblPrecioFrappucciono_Click(object sender, EventArgs e)
        {
            //lbl Precio Frappucciono
        }
        public void lblPrecioSandwich_Click(object sender, EventArgs e)
        {
            //lbl Precio Sandwich
        }
        public void lblPrecioBrownie_Click(object sender, EventArgs e)
        {
            //lbl Precio Brownie
        }
        //========================Labels Vacios=========================




        //========================Botones Información=========================
        public void button2_Click(object sender, EventArgs e)
        {
            //Botón Información Cafe Americnao 
            MessageBox.Show("Bedida caliente de 8oz\n\nEs un café que consiste en partes exactamente iguales de espresso y agua.", "Información Cafe Americano",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        public void btnInfoCappucino_Click(object sender, EventArgs e)
        {
            //Botón Información Cappucciono
            MessageBox.Show("Bebida caliente de 16oz\n\nContiene un shot de espresso con leche y mucha espuma", "Información Cappuccino", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void btnInfoWhiteMocha_Click(object sender, EventArgs e)
        {
            //Botón Información White Mocha
            MessageBox.Show("Bebida caliente de 16oz\n\nCafé Espresso con capas de mocha y mocha blanco combinadas en leche vaporizaday chispas sabor chocolate. No lleva crema batida. Sin endulzantes.", "Información White Mocha", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void btnInfoTeaMatcha_Click(object sender, EventArgs e)
        {
            //Botón Información Tea Matcha
            MessageBox.Show("Bebida fria de 16oz\n\n Contiene crema batida a base de leche entera", "Información Tea Matcha", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void btnInfoGalleta_Click(object sender, EventArgs e)
        {
            //Botón Información Galleta
            MessageBox.Show("Porción individual de 45 gr\n\nClasica galleta con chispas de chocolate", "Información Galleta", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void btbInfoPastel_Click(object sender, EventArgs e)
        {
            //Botón Información Pastel
            MessageBox.Show("Rebanada de pastel del día de 120g", "Información Pastel", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void btnInfoLatte_Click(object sender, EventArgs e)
        {
            //Botón Información Latte
            MessageBox.Show("Bebida caliente de 16oz\n\nContiene un shot de espresso con mucha leche y espuma ", "Información Latte", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void btnInfoChocolate_Click(object sender, EventArgs e)
        {
            //Botón Información Chocolate
            MessageBox.Show("Bedida caliente de 16oz\n\nContiene leche vaporizada combinada con salsa de chocolate y vainilla, cubierto con crema batida y espiral de salsa de chocolate", "Información Chocolate", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void btnInfoMocha_Click(object sender, EventArgs e)
        {
            //Botón Información Mocha
            MessageBox.Show("Bebida caliente de 16oz\n\nContiene un espresso con leche y salsa de chocolate", "Información Mocha", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void btnInfoFrappucciono_Click(object sender, EventArgs e)
        {
            //Botón información Frappucciono
            MessageBox.Show("Bebida fria de 16 oz\n\nContiene café con leche y hielo", "Información Frappucciono", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void btnInfoBrownie_Click(object sender, EventArgs e)
        {
            //Botón Información Brownie
            MessageBox.Show("Porción individual de 105gr\n\nClásico brownie sabor chocolate", "Información Brownie", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void btnInfoSandwich_Click(object sender, EventArgs e)
        {
            //Botón Información Sandwich
            MessageBox.Show("Sandwich de pierna\n\nContiene pan de 12 granos con queso crema, jamón de pierna, queso manchego, lechuga, tomate y alfalfa", "Información Sandwich", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //========================Botones Información=========================




        //========================Botones Productos=========================
        public void btnAmericano_Click(object sender, EventArgs e)
        {
            if (CndAmericano >= 0)
            {
                string Nom; Nom = "Americano";
                /*string label;
                //Botón Cafe Americano
                Americano = Convert.ToDouble(lblPrecioAmericano.Text);
                Americano = Americano * CndAmericano;
                strAmericano = (CndAmericano + " Americano          $ " + Americano + "\n");

                Productos = strAmericano + strBrownie + strCappuccino + strChocolate + strFrappuccino + strGalleta + strLatte + strMocha + strPastel + strSandwich + strTea_Matcha + strWhite_Mocha;
                Total = Americano + Cappuccino + White_Mocha + Latte + Chocolate + Mocha + Tea_Matcha + Frappuccino + Galleta + Brownie + Pastel + Sandwich;

                lblCantidadAmericano.Text = "";
                txtTotal.Clear();
                txtTotal.Text = ("$" + Total);
                label = Convert.ToString(CndAmericano);
                lblCantidadAmericano.Text = label;
                lblPedido.Text = (Productos);*/
                Clases.Productos objProducto = new Clases.Productos();
                objProducto.CalcularTotal(Americano, CndAmericano, strAmericano, Nom, lblPrecioAmericano, lblCantidadAmericano, txtTotal, Total,Productos,lblPedido);
            }
        }
        public void btnCappucino_Click(object sender, EventArgs e)
        {
            if (CndCappuccino >= 0)
            {
                string label;
                //Botón Cappucciono
                Cappuccino = Convert.ToDouble(lblPrecioCappucino.Text);
                Cappuccino = Cappuccino * CndCappuccino;
                strCappuccino = (CndCappuccino + " Cappuccino         $ " + Cappuccino + "\n");
                Productos = strAmericano + strBrownie + strCappuccino + strChocolate + strFrappuccino + strGalleta + strLatte + strMocha + strPastel + strSandwich + strTea_Matcha + strWhite_Mocha;

                Total = Americano + Cappuccino + White_Mocha + Latte + Chocolate + Mocha + Tea_Matcha + Frappuccino + Galleta + Brownie + Pastel + Sandwich;
                txtTotal.Clear();
                txtTotal.Text = ("$" + Total);
                lblCantidadCapuccino.Text = "";
                label = Convert.ToString(CndCappuccino);
                lblCantidadCapuccino.Text = label;
                lblPedido.Text = (Productos);
            }
        }
        public void btnWhiteMocha_Click(object sender, EventArgs e)
        {
            if (CndWhite_Mocha >= 0)
            {
                string label;
                //Botón White Mocha
                White_Mocha = Convert.ToDouble(lblPrecioWhiteMocha.Text);
                White_Mocha = White_Mocha * CndWhite_Mocha;
                strWhite_Mocha = (CndWhite_Mocha + " White Mocha       $ " + White_Mocha + "\n");
                Productos = strAmericano + strBrownie + strCappuccino + strChocolate + strFrappuccino + strGalleta + strLatte + strMocha + strPastel + strSandwich + strTea_Matcha + strWhite_Mocha;

                Total = Americano + Cappuccino + White_Mocha + Latte + Chocolate + Mocha + Tea_Matcha + Frappuccino + Galleta + Brownie + Pastel + Sandwich;
                txtTotal.Clear();
                txtTotal.Text = ("$" + Total);
                lblCantidadWhiteMocha.Text = "";
                label = Convert.ToString(CndWhite_Mocha);
                lblCantidadWhiteMocha.Text = label;
                lblPedido.Text = (Productos);
            }
        }
        public void btnTeaMatcha_Click(object sender, EventArgs e)
        {
            if (CndTea_Matcha >= 0)
            {
                string label;
                //Botón Tea Matcha
                Tea_Matcha = Convert.ToDouble(lblPrecioTeaMatcha.Text);
                Tea_Matcha = Tea_Matcha * CndTea_Matcha;
                strTea_Matcha = (CndTea_Matcha + " Tea Matcha          $ " + Tea_Matcha + "\n");
                Productos = strAmericano + strBrownie + strCappuccino + strChocolate + strFrappuccino + strGalleta + strLatte + strMocha + strPastel + strSandwich + strTea_Matcha + strWhite_Mocha;

                Total = Americano + Cappuccino + White_Mocha + Latte + Chocolate + Mocha + Tea_Matcha + Frappuccino + Galleta + Brownie + Pastel + Sandwich;
                txtTotal.Clear();
                txtTotal.Text = ("$" + Total);
                lblCantidadTeaMatcha.Text = "";
                label = Convert.ToString(CndTea_Matcha);
                lblCantidadTeaMatcha.Text = label;
                lblPedido.Text = (Productos);
            }
        }
        public void btnGalleta_Click(object sender, EventArgs e)
        {
            if (CndGalleta >= 0)
            {
                string label;
                //Botón Galleta
                Galleta = Convert.ToDouble(lblPrecioGalleta.Text);
                Galleta = Galleta * CndGalleta;
                strGalleta = (CndGalleta + " Galleta                  $ " + Galleta + "\n");
                Productos = strAmericano + strBrownie + strCappuccino + strChocolate + strFrappuccino + strGalleta + strLatte + strMocha + strPastel + strSandwich + strTea_Matcha + strWhite_Mocha;

                Total = Americano + Cappuccino + White_Mocha + Latte + Chocolate + Mocha + Tea_Matcha + Frappuccino + Galleta + Brownie + Pastel + Sandwich;
                txtTotal.Clear();
                txtTotal.Text = ("$" + Total);
                lblCantidadGalleta.Text = "";
                label = Convert.ToString(CndGalleta);
                lblCantidadGalleta.Text = label;
                lblPedido.Text = (Productos);
            }
        }
        public void btnPastel_Click(object sender, EventArgs e)
        {
            if (CndPastel >= 0)
            {
                string label;
                //Botón pastel
                Pastel = Convert.ToDouble(lblPrecioPastel.Text);
                Pastel = Pastel * CndPastel;
                strPastel = (CndPastel + " Pastel                   $ " + Pastel + "\n");
                Productos = strAmericano + strBrownie + strCappuccino + strChocolate + strFrappuccino + strGalleta + strLatte + strMocha + strPastel + strSandwich + strTea_Matcha + strWhite_Mocha;

                Total = Americano + Cappuccino + White_Mocha + Latte + Chocolate + Mocha + Tea_Matcha + Frappuccino + Galleta + Brownie + Pastel + Sandwich;
                txtTotal.Clear();
                txtTotal.Text = ("$" + Total);
                lblCantidadPastel.Text = "";
                label = Convert.ToString(CndPastel);
                lblCantidadPastel.Text = label;
                lblPedido.Text = (Productos);
            }
        }
        public void btnLatte_Click(object sender, EventArgs e)
        {
            if (CndLatte >= 0)
            {
                string label;
                //Botón Latte
                Latte = Convert.ToDouble(lblPrecioLatte.Text);
                Latte = Latte * CndLatte;
                strLatte = (CndLatte + " Latte                     $ " + Latte + "\n");
                Productos = strAmericano + strBrownie + strCappuccino + strChocolate + strFrappuccino + strGalleta + strLatte + strMocha + strPastel + strSandwich + strTea_Matcha + strWhite_Mocha;

                Total = Americano + Cappuccino + White_Mocha + Latte + Chocolate + Mocha + Tea_Matcha + Frappuccino + Galleta + Brownie + Pastel + Sandwich;
                txtTotal.Clear();
                txtTotal.Text = ("$" + Total);
                lblCantidadLatte.Text = "";
                label = Convert.ToString(CndLatte);
                lblCantidadLatte.Text = label;
                lblPedido.Text = (Productos);
            }
        }
        public void btnChocolate_Click(object sender, EventArgs e)
        {
            if (CndChocolate >= 0)
            {
                string label;
                //Botón Chocolate
                Chocolate = Convert.ToDouble(lblPrecioChocolate.Text);
                Chocolate = Chocolate * CndChocolate;
                strChocolate = (CndChocolate + " Chocolate            $ " + Chocolate + "\n");
                Productos = strAmericano + strBrownie + strCappuccino + strChocolate + strFrappuccino + strGalleta + strLatte + strMocha + strPastel + strSandwich + strTea_Matcha + strWhite_Mocha;

                Total = Americano + Cappuccino + White_Mocha + Latte + Chocolate + Mocha + Tea_Matcha + Frappuccino + Galleta + Brownie + Pastel + Sandwich;
                txtTotal.Clear();
                txtTotal.Text = ("$" + Total);
                lblCantidadChocolate.Text = "";
                label = Convert.ToString(CndChocolate);
                lblCantidadChocolate.Text = label;
                lblPedido.Text = (Productos);
            }
        }
        public void btnMocha_Click(object sender, EventArgs e)
        {
            if (CndMocha >= 0)
            {
                string label;
                //Botón Mocha
                Mocha = Convert.ToDouble(lblPrecioMocha.Text);
                Mocha = Mocha * CndMocha;
                strMocha = (CndMocha + " Mocha                  $ " + Mocha + "\n");
                Productos = strAmericano + strBrownie + strCappuccino + strChocolate + strFrappuccino + strGalleta + strLatte + strMocha + strPastel + strSandwich + strTea_Matcha + strWhite_Mocha;

                Total = Americano + Cappuccino + White_Mocha + Latte + Chocolate + Mocha + Tea_Matcha + Frappuccino + Galleta + Brownie + Pastel + Sandwich;
                txtTotal.Clear();
                txtTotal.Text = ("$" + Total);
                lblCantidadMocha.Text = "";
                label = Convert.ToString(CndMocha);
                lblCantidadMocha.Text = label;
                lblPedido.Text = (Productos);
            }
        }
        public void btnFrappucciono_Click(object sender, EventArgs e)
        {
            if (CndFrappuccino >= 0)
            {
                string label;
                //Botón Frappucciono
                Frappuccino = Convert.ToDouble(lblPrecioFrappucciono.Text);
                Frappuccino = Frappuccino * CndFrappuccino;
                strFrappuccino = (CndFrappuccino + " Frappuccino        $ " + Frappuccino + "\n");
                Productos = strAmericano + strBrownie + strCappuccino + strChocolate + strFrappuccino + strGalleta + strLatte + strMocha + strPastel + strSandwich + strTea_Matcha + strWhite_Mocha;

                Total = Americano + Cappuccino + White_Mocha + Latte + Chocolate + Mocha + Tea_Matcha + Frappuccino + Galleta + Brownie + Pastel + Sandwich;
                txtTotal.Clear();
                txtTotal.Text = ("$" + Total);
                lblCantidadFrapuccino.Text = "";
                label = Convert.ToString(CndFrappuccino);
                lblCantidadFrapuccino.Text = label;
                lblPedido.Text = (Productos);
            }
        }
        public void btnBrownie_Click(object sender, EventArgs e)
        {
            if (CndBrownie >= 0)
            {
                string label;
                //Botón Brownie
                Brownie = Convert.ToDouble(lblPrecioBrownie.Text);
                Brownie = Brownie * CndBrownie;
                strBrownie = (CndBrownie + " Brownie               $ " + Brownie + "\n");
                Productos = strAmericano + strBrownie + strCappuccino + strChocolate + strFrappuccino + strGalleta + strLatte + strMocha + strPastel + strSandwich + strTea_Matcha + strWhite_Mocha;

                Total = Americano + Cappuccino + White_Mocha + Latte + Chocolate + Mocha + Tea_Matcha + Frappuccino + Galleta + Brownie + Pastel + Sandwich;
                txtTotal.Clear();
                txtTotal.Text = ("$" + Total);
                lblCantidadBrownie.Text = "";
                label = Convert.ToString(CndBrownie);
                lblCantidadBrownie.Text = label;
                lblPedido.Text = (Productos);
            }
        }
        public void btnSandwich_Click(object sender, EventArgs e)
        {
            if (CndSandwich >= 0)
            {
                string label;
                //Botón Sandwich
                Sandwich = Convert.ToDouble(lblPrecioSandwich.Text);
                Sandwich = Sandwich * CndSandwich;
                strSandwich = (CndSandwich + " Sandwich             $ " + Sandwich + "\n");
                Productos = strAmericano + strBrownie + strCappuccino + strChocolate + strFrappuccino + strGalleta + strLatte + strMocha + strPastel + strSandwich + strTea_Matcha + strWhite_Mocha;

                Total = Americano + Cappuccino + White_Mocha + Latte + Chocolate + Mocha + Tea_Matcha + Frappuccino + Galleta + Brownie + Pastel + Sandwich;
                txtTotal.Clear();
                txtTotal.Text = ("$" + Total);
                lblCantidadSandwich.Text = "";
                label = Convert.ToString(CndSandwich);
                lblCantidadSandwich.Text = label;
                lblPedido.Text = (Productos);
            }
        }
        //========================Botones Productos=========================





        //========================Botones Menos=========================
        public void btnMenosAmericano_Click(object sender, EventArgs e)
        {
            CndAmericano = CndAmericano - 1;
            string label;
            lblCantidadAmericano.Text = "";
            label = Convert.ToString(CndAmericano);
            lblCantidadAmericano.Text = label;
            if (CndAmericano < 0)
            {
                MessageBox.Show("No es posible ingresar números negativos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnMenosCappuccino_Click(object sender, EventArgs e)
        {
            CndCappuccino = CndCappuccino - 1;
            string label;
            lblCantidadCapuccino.Text = "";
            label = Convert.ToString(CndCappuccino);
            lblCantidadCapuccino.Text = label;
            if (CndCappuccino < 0)
            {
                MessageBox.Show("No es posible ingresar números negativos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMenosWhiteMocha_Click(object sender, EventArgs e)
        {
            CndWhite_Mocha = CndWhite_Mocha - 1;
            string label;
            lblCantidadWhiteMocha.Text = "";
            label = Convert.ToString(CndWhite_Mocha);
            lblCantidadWhiteMocha.Text = label;
            if (CndWhite_Mocha < 0)
            {
                MessageBox.Show("No es posible ingresar números negativos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMenosTeaMatcha_Click(object sender, EventArgs e)
        {
            CndTea_Matcha = CndTea_Matcha - 1;
            string label;
            lblCantidadTeaMatcha.Text = "";
            label = Convert.ToString(CndTea_Matcha);
            lblCantidadTeaMatcha.Text = label;
            if (CndTea_Matcha < 0)
            {
                MessageBox.Show("No es posible ingresar números negativos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMenosGalleta_Click(object sender, EventArgs e)
        {
            CndGalleta = CndGalleta - 1;
            string label;
            lblCantidadGalleta.Text = "";
            label = Convert.ToString(CndGalleta);
            lblCantidadGalleta.Text = label;
            if (CndGalleta < 0)
            {
                MessageBox.Show("No es posible ingresar números negativos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMenosPastel_Click(object sender, EventArgs e)
        {
            CndPastel = CndPastel - 1;
            string label;
            lblCantidadPastel.Text = "";
            label = Convert.ToString(CndPastel);
            lblCantidadPastel.Text = label;
            if (CndPastel < 0)
            {
                MessageBox.Show("No es posible ingresar números negativos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMenosLatte_Click(object sender, EventArgs e)
        {
            CndLatte = CndLatte - 1;
            string label;
            lblCantidadLatte.Text = "";
            label = Convert.ToString(CndLatte);
            lblCantidadLatte.Text = label;
            if (CndLatte < 0)
            {
                MessageBox.Show("No es posible ingresar números negativos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMenosChocolate_Click(object sender, EventArgs e)
        {
            CndChocolate = CndChocolate - 1;
            string label;
            lblCantidadChocolate.Text = "";
            label = Convert.ToString(CndChocolate);
            lblCantidadChocolate.Text = label;
            if(CndChocolate < 0)
            {
                MessageBox.Show("No es posible ingresar números negativos","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnMenosMocha_Click(object sender, EventArgs e)
        {
            CndMocha = CndMocha - 1;
            string label;
            lblCantidadMocha.Text = "";
            label = Convert.ToString(CndMocha);
            lblCantidadMocha.Text = label;
            if (CndMocha < 0)
            {
                MessageBox.Show("No es posible ingresar números negativos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMenosFrapuccino_Click(object sender, EventArgs e)
        {
            CndFrappuccino = CndFrappuccino - 1;
            string label;
            lblCantidadFrapuccino.Text = "";
            label = Convert.ToString(CndFrappuccino);
            lblCantidadFrapuccino.Text = label;
            if (CndFrappuccino < 0)
            {
                MessageBox.Show("No es posible ingresar números negativos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMenosBrownie_Click(object sender, EventArgs e)
        {
            CndBrownie = CndBrownie - 1;
            string label;
            lblCantidadBrownie.Text = "";
            label = Convert.ToString(CndBrownie);
            lblCantidadBrownie.Text = label;
            if (CndBrownie < 0)
            {
                MessageBox.Show("No es posible ingresar números negativos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMenosSandwich_Click(object sender, EventArgs e)
        {
            CndSandwich = CndSandwich - 1;
            string label;
            lblCantidadSandwich.Text = "";
            label = Convert.ToString(CndSandwich);
            lblCantidadSandwich.Text = label;
            if (CndSandwich < 0)
            {
                MessageBox.Show("No es posible ingresar números negativos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //========================Botones Menos=========================







        //========================Botones Mas=========================
        public void btnMasAmericano_Click(object sender, EventArgs e)
        {
            CndAmericano = CndAmericano +  1;
            string label;
            lblCantidadAmericano.Text = "";
            label = Convert.ToString(CndAmericano);
            lblCantidadAmericano.Text = label;
        }

        public void btnMasCapuccino_Click(object sender, EventArgs e)
        {
            CndCappuccino = CndCappuccino + 1;
            string label;
            lblCantidadCapuccino.Text = "";
            label = Convert.ToString(CndCappuccino);
            lblCantidadCapuccino.Text = label;
        }

        public void btnMasWhiteMocha_Click(object sender, EventArgs e)
        {
            CndWhite_Mocha = CndWhite_Mocha + 1;
            string label;
            lblCantidadWhiteMocha.Text = "";
            label = Convert.ToString(CndWhite_Mocha);
            lblCantidadWhiteMocha.Text = label;
        }

        public void btnMasTeaMatcha_Click(object sender, EventArgs e)
        {
            CndTea_Matcha=CndTea_Matcha+1;
            string label;
            lblCantidadTeaMatcha.Text = "";
            label = Convert.ToString(CndTea_Matcha);
            lblCantidadTeaMatcha.Text = label;
        }

        public void btnMasGallleta_Click(object sender, EventArgs e)
        {
            CndGalleta = CndGalleta + 1;
            string label;
            lblCantidadGalleta.Text = "";
            label = Convert.ToString(CndGalleta);
            lblCantidadGalleta.Text = label;
        }

        public void btnMasPastel_Click(object sender, EventArgs e)
        {
            CndPastel = CndPastel + 1;
            string label;
            lblCantidadPastel.Text = "";
            label = Convert.ToString(CndPastel);
            lblCantidadPastel.Text = label;
        }

        public void btnMasLatte_Click(object sender, EventArgs e)
        {
            CndLatte = CndLatte + 1;
            string label;
            lblCantidadLatte.Text = "";
            label = Convert.ToString(CndLatte);
            lblCantidadLatte.Text = label;
        }

        public void btnMasChocolate_Click(object sender, EventArgs e)
        {
            CndChocolate = CndChocolate + 1;
            string label;
            lblCantidadChocolate.Text = "";
            label = Convert.ToString(CndChocolate);
            lblCantidadChocolate.Text = label;
        }

        public void btnMasMocha_Click(object sender, EventArgs e)
        {
            CndMocha = CndMocha + 1;
            string label;
            lblCantidadMocha.Text = "";
            label = Convert.ToString(CndMocha);
            lblCantidadMocha.Text = label;
        }

        public void btnMasFrapuccino_Click(object sender, EventArgs e)
        {
            CndFrappuccino = CndFrappuccino + 1;
            string label;
            lblCantidadFrapuccino.Text = "";
            label = Convert.ToString(CndFrappuccino);
            lblCantidadFrapuccino.Text = label;
        }

        public void btnMasBrownie_Click(object sender, EventArgs e)
        {
            CndBrownie = CndBrownie + 1;
            string label;
            lblCantidadBrownie.Text = "";
            label = Convert.ToString(CndBrownie);
            lblCantidadBrownie.Text = label;
        }

        public void btnMasSandwich_Click(object sender, EventArgs e)
        {
            CndSandwich = CndSandwich + 1;
            string label;
            lblCantidadSandwich.Text = "";
            label = Convert.ToString(CndSandwich);
            lblCantidadSandwich.Text = label;
        }
        //========================Botones Mas=========================






        //========================Labels Cantidad=========================
        private void lblCantidadAmericano_Click(object sender, EventArgs e)
        {

        }

        private void lblCantidadCapuccino_Click(object sender, EventArgs e)
        {

        }

        private void lblCantidadWhiteMocha_Click(object sender, EventArgs e)
        {

        }

        private void lblCantidadTeaMatcha_Click(object sender, EventArgs e)
        {

        }

        private void lblCantidadGalleta_Click(object sender, EventArgs e)
        {

        }

        private void lblCantidadPastel_Click(object sender, EventArgs e)
        {

        }

        private void lblCantidadLatte_Click(object sender, EventArgs e)
        {

        }

        private void lblCantidadChocolate_Click(object sender, EventArgs e)
        {

        }

        private void lblCantidadMocha_Click(object sender, EventArgs e)
        {

        }

        private void lblCantidadFrapuccino_Click(object sender, EventArgs e)
        {

        }

        private void lblCantidadBrownie_Click(object sender, EventArgs e)
        {

        }

        private void lblCantidadSandwich_Click(object sender, EventArgs e)
        {

        }
        //========================Labels Cantidad=========================



        public void btnImprimirTicket_Click(object sender, EventArgs e)
        {
            //Botón imprimir Ticket
            Cantidad = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el monto que efectuo el cliente: ", "CAMBIO"));
            Cambio = Cantidad - Total;

            StreamWriter Venta = new StreamWriter(@"C:\Users\Telnor\Desktop\Programación II\Archivo.txt", true); //@"E:\Programación II\Archivo.txt
            try
            {
                Venta.WriteLine("=====" + dateTimePicker1.Text + "=====");
                Venta.WriteLine("PRODUCTOS\n" + Productos);
                Venta.WriteLine("Total IVA incluido  $\t" + Total);
                Venta.WriteLine("Efectivo            $\t" + Cantidad);
                Venta.WriteLine("Cambio              $\t" + Cambio);
            }
            catch
            {
                MessageBox.Show("Lo sentimos, su registro no logro ser guardado exitosamente.","Error al guardar registro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            Venta.Close();

            MessageBox.Show(("=====" + dateTimePicker1.Text + "=====\n\n" + 
            ("PRODUCTOS\n\n" + Productos) +
            "\nTotal IVA incluido     $"+Total+
            "\nEFECTIVO               $"+ Cantidad +
            "\nCAMBIO                 $"+ Cambio), "Ticket");
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
            Productos = "";

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
        public void btnNuevoPedido_Click(object sender, EventArgs e)
        {
            Clases.Productos objLimpiar = new Clases.Productos();
                objLimpiar.Limpiar(Americano,Cappuccino ,White_Mocha,Latte, Chocolate,Mocha,Tea_Matcha , Frappuccino, Galleta, Brownie, Pastel,Sandwich, Total, txtTotal,strAmericano,strBrownie, strCappuccino,strChocolate, strFrappuccino, strGalleta,strLatte,strMocha, strPastel,strSandwich, strTea_Matcha,strWhite_Mocha, Productos, CndAmericano,CndCappuccino ,CndWhite_Mocha ,CndLatte ,CndChocolate ,CndMocha ,CndTea_Matcha ,CndFrappuccino, CndGalleta , CndBrownie , CndPastel ,CndSandwich, lblCantidadAmericano, lblCantidadCapuccino, lblCantidadWhiteMocha,lblCantidadLatte,lblCantidadChocolate, lblCantidadMocha,lblCantidadTeaMatcha,lblCantidadFrapuccino,lblCantidadGalleta,lblCantidadBrownie,lblCantidadPastel,lblCantidadSandwich,lblPedido);
        }

        public void btnCancelar_Click(object sender, EventArgs e)
        {
            //Botón Cancelar
            Application.Exit();
        }
    }
}