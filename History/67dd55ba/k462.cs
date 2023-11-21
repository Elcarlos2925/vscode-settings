using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheDropCoffee.Clases;

namespace TheDropCoffee
{
    public partial class Menú : Form
    {
        //Productos
        double Americano = 70.00, Cappuccino = 85.00, White_Mocha = 65.00, Latte = 80.00, Chocolate = 60.00, Mocha = 65.00, Tea_Matcha = 80.00, Frappuccino = 85.00, Galleta = 20.00, Brownie = 35.00, Pastel = 50.00, Sandwich = 55.00;
        int opc, ctdAmericano, ctdCappuccino, ctdWhite_Mocha, ctdLatte, ctdChocolate, ctdMocha, ctdTea_Matcha, ctdFrappuccino, ctdGalleta, ctdBrownie, ctdPastel, ctdSandwich;
        double Cambio, Monto, SubTotal, IVA, Total, strame, strcapp, strWM, strLatte, strChoco, strMocha, strTeaMat, strFrapp, strGall, strBrow, strPas, strSand;
        string Descripción, NAme = "Amaericano", NomCapp = "Cappuccino", NomWM = "White Mocha", NomLatte = "Latte", NomChoco = "Chocolate", NomMocha = "Mocha", NomTea_Mat = "Tea Matcha", NomFrap = "Frappuccino", NomGall = "Galleta", NomBrow = "Brownie", NomPas = "Pastel", NomSand = "Sandwich", DAme, DCapp, DWM, DLatt, DChoco, DMoch, DTea_Mat, DFrap, DGall, DBrow, DPas, DSand;

        private void Logo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Drop Coffee® Versión 0.1.3\n\nCreado por:\nLozoya Avalos Carlos Abraham\nMendez Neri Omar Alexander", "The Drop Coffee®");
        }

        private void btnCancelarPedido_Click(object sender, EventArgs e)
        {
            Clases.Productos obj = new Clases.Productos();
            obj.ReiniciarVariables( Total,txtMostrarTotal, ctdAmericano, ctdCappuccino, ctdWhite_Mocha, ctdLatte, ctdChocolate, ctdMocha, ctdTea_Matcha, ctdFrappuccino, ctdGalleta, ctdBrownie, ctdPastel, ctdSandwich,
             DAme, DCapp, DWM, DLatt, DChoco, DMoch, DTea_Mat, DFrap, DGall, DBrow, DPas, DSand, Descripción, bttnMenosAmericano, bttnMenosCappuccino, bttnMenosWhiteMocha, bttnMenosTeaMatcha, bttnMenosGalleta, bttnMenosPastel, bttnMenosLatte, bttnMenosChocolate, bttnMenosMocha, bttnMenosFrapuccino, bttnMenosBrownie, bttnMenosSandwich);
            LabelsZero();
        }
        private void BtnCompletarPedido_Click(object sender, EventArgs e)
        {
            Clases.Productos objFinalizarPedido = new Clases.Productos();
            objFinalizarPedido.ImprimirTicket(dTPFecha, cmbPedido,Descripción, Total,Cambio,Monto,SubTotal,IVA);
            objFinalizarPedido.ReiniciarVariables(Total, txtMostrarTotal, ctdAmericano, ctdCappuccino, ctdWhite_Mocha, ctdLatte, ctdChocolate, ctdMocha, ctdTea_Matcha, ctdFrappuccino, ctdGalleta, ctdBrownie, ctdPastel, ctdSandwich,
             DAme, DCapp, DWM, DLatt, DChoco, DMoch, DTea_Mat, DFrap, DGall, DBrow, DPas, DSand, Descripción, bttnMenosAmericano, bttnMenosCappuccino, bttnMenosWhiteMocha, bttnMenosTeaMatcha, bttnMenosGalleta, bttnMenosPastel, bttnMenosLatte, bttnMenosChocolate, bttnMenosMocha, bttnMenosFrapuccino, bttnMenosBrownie, bttnMenosSandwich);
            LabelsZero();
        }

        public Menú()
        {
            MessageBox.Show("Grita abrete sesamo y pulsa aceptar para iniciar");
            InitializeComponent();
        }
        //*********************Botonoes menos*************************
        private void bttnMenosAmericano_Click(object sender, EventArgs e)
        {
            Clases.Productos obj = new Clases.Productos();
            ctdAmericano = obj.MenosCount(ctdAmericano, bttnMenosAmericano);
            lablCantidadAmericano.Text = Convert.ToString(ctdAmericano);
            strame = obj.TotalProducto(Americano, ctdAmericano);
            DAme = obj.ProductoDescripción(NAme, Americano, ctdAmericano);
            Descripción = DAme + DBrow + DCapp + DChoco + DFrap + DLatt + DMoch + DPas + DSand + DTea_Mat + DWM + DGall; RTxtTicket.Text = Descripción;
            Total = strame + strBrow + strcapp + strChoco + strFrapp + strGall + strLatte + strMocha + strPas + strSand + strTeaMat + strWM; txtMostrarTotal.Text = Convert.ToString("$" + Total);//Todos son iguales
        }
        private void bttnMenosCappuccino_Click(object sender, EventArgs e)
        {
            Clases.Productos obj = new Clases.Productos();
            ctdCappuccino = obj.MenosCount(ctdCappuccino, bttnMenosCappuccino);
            strcapp = obj.TotalProducto(Cappuccino, ctdCappuccino);
            lablCantidadCapuccino.Text = Convert.ToString(ctdCappuccino);
            DCapp = obj.ProductoDescripción(NomCapp, Cappuccino, ctdCappuccino);
            Total = strame + strBrow + strcapp + strChoco + strFrapp + strGall + strLatte + strMocha + strPas + strSand + strTeaMat + strWM; txtMostrarTotal.Text = Convert.ToString("$" + Total);//Todos son iguales
            Descripción = DAme + DBrow + DCapp + DChoco + DFrap + DLatt + DMoch + DPas + DSand + DTea_Mat + DWM + DGall; RTxtTicket.Text = Descripción;
        }
        private void bttnMenosWhiteMocha_Click(object sender, EventArgs e)
        {
            Clases.Productos obj = new Clases.Productos();
            ctdWhite_Mocha = obj.MenosCount(ctdWhite_Mocha, bttnMenosWhiteMocha);
            lablCantidadWhiteMocha.Text = Convert.ToString(ctdWhite_Mocha);
            strWM = obj.TotalProducto(White_Mocha, ctdWhite_Mocha);
            DWM = obj.ProductoDescripción(NomWM, White_Mocha, ctdWhite_Mocha);
            Total = strame + strBrow + strcapp + strChoco + strFrapp + strGall + strLatte + strMocha + strPas + strSand + strTeaMat + strWM; txtMostrarTotal.Text = Convert.ToString("$" + Total);//Todos son iguales
            Descripción = DAme + DBrow + DCapp + DChoco + DFrap + DLatt + DMoch + DPas + DSand + DTea_Mat + DWM + DGall; RTxtTicket.Text = Descripción;
        }
        private void bttnMenosTeaMatcha_Click(object sender, EventArgs e)
        {
            Clases.Productos obj = new Clases.Productos();
            ctdTea_Matcha = obj.MenosCount(ctdTea_Matcha, bttnMenosTeaMatcha);
            lablCantidadTeaMatcha.Text = Convert.ToString(ctdTea_Matcha);
            strTeaMat = obj.TotalProducto(Tea_Matcha, ctdTea_Matcha);
            DTea_Mat = obj.ProductoDescripción(NomTea_Mat, Tea_Matcha, ctdTea_Matcha);
            Total = strame + strBrow + strcapp + strChoco + strFrapp + strGall + strLatte + strMocha + strPas + strSand + strTeaMat + strWM; txtMostrarTotal.Text = Convert.ToString("$" + Total);//Todos son iguales
            Descripción = DAme + DBrow + DCapp + DChoco + DFrap + DLatt + DMoch + DPas + DSand + DTea_Mat + DWM + DGall; RTxtTicket.Text = Descripción;

        }
        private void bttnMenosGalleta_Click(object sender, EventArgs e)
        {
            Clases.Productos obj = new Clases.Productos();
            ctdGalleta = obj.MenosCount(ctdGalleta, bttnMenosGalleta);
            lablCantidadGalleta.Text = Convert.ToString(ctdGalleta);
            strGall = obj.TotalProducto(Galleta, ctdGalleta);
            DGall = obj.ProductoDescripción(NomGall, Galleta, ctdGalleta);
            Total = strame + strBrow + strcapp + strChoco + strFrapp + strGall + strLatte + strMocha + strPas + strSand + strTeaMat + strWM; txtMostrarTotal.Text = Convert.ToString("$" + Total);//Todos son iguales
            Descripción = DAme + DBrow + DCapp + DChoco + DFrap + DLatt + DMoch + DPas + DSand + DTea_Mat + DWM + DGall; RTxtTicket.Text = Descripción;

        }
        private void bttnMenosPastel_Click(object sender, EventArgs e)
        {
            Clases.Productos obj = new Clases.Productos();
            ctdPastel = obj.MenosCount(ctdPastel, bttnMenosPastel);
            lablCantidadPastel.Text = Convert.ToString(ctdPastel);
            strPas = obj.TotalProducto(Pastel, ctdPastel);
            DPas = obj.ProductoDescripción(NomPas, Pastel, ctdPastel);
            Total = strame + strBrow + strcapp + strChoco + strFrapp + strGall + strLatte + strMocha + strPas + strSand + strTeaMat + strWM; txtMostrarTotal.Text = Convert.ToString("$" + Total);//Todos son iguales
            Descripción = DAme + DBrow + DCapp + DChoco + DFrap + DLatt + DMoch + DPas + DSand + DTea_Mat + DWM + DGall; RTxtTicket.Text = Descripción;
        }
        private void bttnMenosLatte_Click(object sender, EventArgs e)
        {
            Clases.Productos obj = new Clases.Productos();
            ctdLatte = obj.MenosCount(ctdLatte, bttnMenosLatte);
            lablCantidadLatte.Text = Convert.ToString(ctdLatte);
            strLatte = obj.TotalProducto(Latte, ctdLatte);
            DLatt = obj.ProductoDescripción(NomLatte, Latte, ctdLatte);
            Total = strame + strBrow + strcapp + strChoco + strFrapp + strGall + strLatte + strMocha + strPas + strSand + strTeaMat + strWM; txtMostrarTotal.Text = Convert.ToString("$" + Total);//Todos son iguales
            Descripción = DAme + DBrow + DCapp + DChoco + DFrap + DLatt + DMoch + DPas + DSand + DTea_Mat + DWM + DGall; RTxtTicket.Text = Descripción;

        }
        private void bttnMenosChocolate_Click(object sender, EventArgs e)
        {
            Clases.Productos obj = new Clases.Productos();
            ctdChocolate = obj.MenosCount(ctdChocolate, bttnMenosChocolate);
            lablCantidadChocolate.Text = Convert.ToString(ctdChocolate);
            strChoco = obj.TotalProducto(Chocolate, ctdChocolate);
            DChoco = obj.ProductoDescripción(NomChoco, Chocolate, ctdChocolate);
            Total = strame + strBrow + strcapp + strChoco + strFrapp + strGall + strLatte + strMocha + strPas + strSand + strTeaMat + strWM; txtMostrarTotal.Text = Convert.ToString("$" + Total);//Todos son iguales
            Descripción = DAme + DBrow + DCapp + DChoco + DFrap + DLatt + DMoch + DPas + DSand + DTea_Mat + DWM + DGall; RTxtTicket.Text = Descripción;
        }
        private void bttnMenosMocha_Click(object sender, EventArgs e)
        {
            Clases.Productos obj = new Clases.Productos();
            ctdMocha = obj.MenosCount(ctdMocha, bttnMenosMocha);
            lablCantidadMocha.Text = Convert.ToString(ctdMocha);
            strMocha = obj.TotalProducto(Mocha, ctdMocha);
            DMoch = obj.ProductoDescripción(NomMocha, Mocha, ctdMocha);
            Total = strame + strBrow + strcapp + strChoco + strFrapp + strGall + strLatte + strMocha + strPas + strSand + strTeaMat + strWM; txtMostrarTotal.Text = Convert.ToString("$" + Total);//Todos son iguales
            Descripción = DAme + DBrow + DCapp + DChoco + DFrap + DLatt + DMoch + DPas + DSand + DTea_Mat + DWM + DGall; RTxtTicket.Text = Descripción;
        }
        private void bttnMenosFrapuccino_Click(object sender, EventArgs e)
        {
            Clases.Productos obj = new Clases.Productos();
            ctdFrappuccino = obj.MenosCount(ctdFrappuccino, bttnMenosFrapuccino);
            lablCantidadFrapuccino.Text = Convert.ToString(ctdFrappuccino);
            strFrapp = obj.TotalProducto(Frappuccino, ctdFrappuccino);
            DFrap = obj.ProductoDescripción(NomFrap, Frappuccino, ctdFrappuccino);
            Total = strame + strBrow + strcapp + strChoco + strFrapp + strGall + strLatte + strMocha + strPas + strSand + strTeaMat + strWM; txtMostrarTotal.Text = Convert.ToString("$" + Total);//Todos son iguales
            Descripción = DAme + DBrow + DCapp + DChoco + DFrap + DLatt + DMoch + DPas + DSand + DTea_Mat + DWM + DGall; RTxtTicket.Text = Descripción;
        }
        private void bttnMenosBrownie_Click(object sender, EventArgs e)
        {
            Clases.Productos obj = new Clases.Productos();
            ctdBrownie = obj.MenosCount(ctdBrownie, bttnMenosBrownie);
            lablCantidadBrownie.Text = Convert.ToString(ctdBrownie);
            strBrow = obj.TotalProducto(Brownie, ctdBrownie);
            DBrow = obj.ProductoDescripción(DBrow, Brownie, ctdBrownie);
            Total = strame + strBrow + strcapp + strChoco + strFrapp + strGall + strLatte + strMocha + strPas + strSand + strTeaMat + strWM; txtMostrarTotal.Text = Convert.ToString("$" + Total);//Todos son iguales
            Descripción = DAme + DBrow + DCapp + DChoco + DFrap + DLatt + DMoch + DPas + DSand + DTea_Mat + DWM + DGall; RTxtTicket.Text = Descripción;
        }
        private void bttnMenosSandwich_Click(object sender, EventArgs e)
        {
            Clases.Productos obj = new Clases.Productos();
            ctdSandwich = obj.MenosCount(ctdSandwich, bttnMenosSandwich);
            labelCantidadSandwich.Text = Convert.ToString(ctdSandwich);
            strSand = obj.TotalProducto(Sandwich, ctdSandwich);
            DSand = obj.ProductoDescripción(NomSand, Sandwich, ctdSandwich);
            Total = strame + strBrow + strcapp + strChoco + strFrapp + strGall + strLatte + strMocha + strPas + strSand + strTeaMat + strWM; txtMostrarTotal.Text = Convert.ToString("$" + Total);//Todos son iguales
            Descripción = DAme + DBrow + DCapp + DChoco + DFrap + DLatt + DMoch + DPas + DSand + DTea_Mat + DWM + DGall; RTxtTicket.Text = Descripción;
        }
        //**********************Botones menos*************************


        //**********************Botones mas***********************
        private void bttnMasAmericano_Click(object sender, EventArgs e)
        {
            Clases.Productos obj = new Clases.Productos();
            ctdAmericano = obj.MasCount(ctdAmericano,bttnMenosAmericano);
            lablCantidadAmericano.Text = Convert.ToString(ctdAmericano);
            strame = obj.TotalProducto(Americano, ctdAmericano);
            DAme = obj.ProductoDescripción(NAme, Americano, ctdAmericano);
            Descripción = DAme + DBrow + DCapp + DChoco + DFrap + DLatt + DMoch + DPas + DSand + DTea_Mat + DWM + DGall; RTxtTicket.Text = Descripción;
            Total = strame + strBrow + strcapp + strChoco + strFrapp + strGall + strLatte + strMocha + strPas + strSand + strTeaMat + strWM; txtMostrarTotal.Text = Convert.ToString("$" + Total);//Todos son iguales
        }
        private void bttnMasCapuccino_Click(object sender, EventArgs e)
        {
            Clases.Productos obj = new Clases.Productos();
            ctdCappuccino = obj.MasCount(ctdCappuccino,bttnMenosCappuccino);
            lablCantidadCapuccino.Text = Convert.ToString(ctdCappuccino);
            strcapp = obj.TotalProducto(Cappuccino, ctdCappuccino);
            DCapp = obj.ProductoDescripción(NomCapp, Cappuccino, ctdCappuccino);
            Total = strame + strBrow + strcapp + strChoco + strFrapp + strGall + strLatte + strMocha + strPas + strSand + strTeaMat + strWM; txtMostrarTotal.Text = Convert.ToString("$" + Total);//Todos son iguales
            Descripción = DAme + DBrow + DCapp + DChoco + DFrap + DLatt + DMoch + DPas + DSand + DTea_Mat + DWM + DGall; RTxtTicket.Text = Descripción;
        }
        private void bttnMasWhiteMocha_Click(object sender, EventArgs e)
        {
            Clases.Productos obj = new Clases.Productos();
            ctdWhite_Mocha = obj.MasCount(ctdWhite_Mocha,bttnMenosWhiteMocha);
            strWM = obj.TotalProducto(White_Mocha, ctdWhite_Mocha);
            lablCantidadWhiteMocha.Text = Convert.ToString(ctdWhite_Mocha);
            DWM = obj.ProductoDescripción(NomWM, White_Mocha, ctdWhite_Mocha);
            Total = strame + strBrow + strcapp + strChoco + strFrapp + strGall + strLatte + strMocha + strPas + strSand + strTeaMat + strWM; txtMostrarTotal.Text = Convert.ToString("$" + Total);//Todos son iguales
            Descripción = DAme + DBrow + DCapp + DChoco + DFrap + DLatt + DMoch + DPas + DSand + DTea_Mat + DWM + DGall; RTxtTicket.Text = Descripción;

        }
        private void bttnMasTeaMatcha_Click(object sender, EventArgs e)
        {
            Clases.Productos obj = new Clases.Productos();
            ctdTea_Matcha = obj.MasCount(ctdTea_Matcha,bttnMenosTeaMatcha);
            lablCantidadTeaMatcha.Text = Convert.ToString(ctdTea_Matcha);
            strTeaMat = obj.TotalProducto(Tea_Matcha, ctdTea_Matcha);
            DTea_Mat = obj.ProductoDescripción(NomTea_Mat, Tea_Matcha, ctdTea_Matcha);
            Total = strame + strBrow + strcapp + strChoco + strFrapp + strGall + strLatte + strMocha + strPas + strSand + strTeaMat + strWM; txtMostrarTotal.Text = Convert.ToString("$" + Total);//Todos son iguales
            Descripción = DAme + DBrow + DCapp + DChoco + DFrap + DLatt + DMoch + DPas + DSand + DTea_Mat + DWM + DGall; RTxtTicket.Text = Descripción;
        }
        private void bttnMasGallleta_Click(object sender, EventArgs e)
        {
            Clases.Productos obj = new Clases.Productos();
            ctdGalleta = obj.MasCount(ctdGalleta,bttnMenosGalleta);
            lablCantidadGalleta.Text = Convert.ToString(ctdGalleta);
            strGall = obj.TotalProducto(Galleta, ctdGalleta);
            DGall = obj.ProductoDescripción(NomGall, Galleta, ctdGalleta);
            Total = strame + strBrow + strcapp + strChoco + strFrapp + strGall + strLatte + strMocha + strPas + strSand + strTeaMat + strWM; txtMostrarTotal.Text = Convert.ToString("$" + Total);//Todos son iguales
            Descripción = DAme + DBrow + DCapp + DChoco + DFrap + DLatt + DMoch + DPas + DSand + DTea_Mat + DWM + DGall; RTxtTicket.Text = Descripción;
        }
        private void bttnMasPastel_Click(object sender, EventArgs e)
        {
            Clases.Productos obj = new Clases.Productos();
            ctdPastel = obj.MasCount(ctdPastel,bttnMenosPastel);
            lablCantidadPastel.Text = Convert.ToString(ctdPastel);
            strPas = obj.TotalProducto(Pastel, ctdPastel);
            DPas = obj.ProductoDescripción(NomPas, Pastel, ctdPastel);
            Total = strame + strBrow + strcapp + strChoco + strFrapp + strGall + strLatte + strMocha + strPas + strSand + strTeaMat + strWM; txtMostrarTotal.Text = Convert.ToString("$" + Total);//Todos son iguales
            Descripción = DAme + DBrow + DCapp + DChoco + DFrap + DLatt + DMoch + DPas + DSand + DTea_Mat + DWM + DGall; RTxtTicket.Text = Descripción;
        }
        private void bttnMasLatte_Click(object sender, EventArgs e)
        {
            Clases.Productos obj = new Clases.Productos();
            ctdLatte = obj.MasCount(ctdLatte,bttnMenosLatte);
            lablCantidadLatte.Text = Convert.ToString(ctdLatte);
            strLatte = obj.TotalProducto(Latte, ctdLatte);
            DLatt = obj.ProductoDescripción(NomLatte, Latte, ctdLatte);
            Total = strame + strBrow + strcapp + strChoco + strFrapp + strGall + strLatte + strMocha + strPas + strSand + strTeaMat + strWM; txtMostrarTotal.Text = Convert.ToString("$" + Total);//Todos son iguales
            Descripción = DAme + DBrow + DCapp + DChoco + DFrap + DLatt + DMoch + DPas + DSand + DTea_Mat + DWM + DGall; RTxtTicket.Text = Descripción;
        }
        private void bttnMasChocolate_Click(object sender, EventArgs e)
        {
            Clases.Productos obj = new Clases.Productos();
            ctdChocolate = obj.MasCount(ctdChocolate,bttnMenosChocolate);
            lablCantidadChocolate.Text = Convert.ToString(ctdChocolate);
            strChoco = obj.TotalProducto(Chocolate, ctdChocolate);
            DChoco = obj.ProductoDescripción(NomChoco, Chocolate, ctdChocolate);
            Total = strame + strBrow + strcapp + strChoco + strFrapp + strGall + strLatte + strMocha + strPas + strSand + strTeaMat + strWM; txtMostrarTotal.Text = Convert.ToString("$" + Total);//Todos son iguales
            Descripción = DAme + DBrow + DCapp + DChoco + DFrap + DLatt + DMoch + DPas + DSand + DTea_Mat + DWM + DGall; RTxtTicket.Text = Descripción;
        }
        private void bttnMasMocha_Click(object sender, EventArgs e)
        {
            Clases.Productos obj = new Clases.Productos();
            ctdMocha = obj.MasCount(ctdMocha,bttnMenosMocha);
            lablCantidadMocha.Text = Convert.ToString(ctdMocha);
            strMocha = obj.TotalProducto(Mocha, ctdMocha);
            DMoch = obj.ProductoDescripción(NomMocha, Mocha, ctdMocha);
            Total = strame + strBrow + strcapp + strChoco + strFrapp + strGall + strLatte + strMocha + strPas + strSand + strTeaMat + strWM; txtMostrarTotal.Text = Convert.ToString("$" + Total);//Todos son iguales
            Descripción = DAme + DBrow + DCapp + DChoco + DFrap + DLatt + DMoch + DPas + DSand + DTea_Mat + DWM + DGall; RTxtTicket.Text = Descripción;
        }
        private void bttnMasFrapuccino_Click(object sender, EventArgs e)
        {
            Clases.Productos obj = new Clases.Productos();
            ctdFrappuccino = obj.MasCount(ctdFrappuccino,bttnMenosFrapuccino);
            lablCantidadFrapuccino.Text = Convert.ToString(ctdFrappuccino);
            strFrapp = obj.TotalProducto(Frappuccino, ctdFrappuccino);
            DFrap = obj.ProductoDescripción(NomFrap, Frappuccino, ctdFrappuccino);
            Total = strame + strBrow + strcapp + strChoco + strFrapp + strGall + strLatte + strMocha + strPas + strSand + strTeaMat + strWM; txtMostrarTotal.Text = Convert.ToString("$" + Total);//Todos son iguales
            Descripción = DAme + DBrow + DCapp + DChoco + DFrap + DLatt + DMoch + DPas + DSand + DTea_Mat + DWM + DGall; RTxtTicket.Text = Descripción;
        }
        private void bttnMasBrownie_Click(object sender, EventArgs e)
        {
            Clases.Productos obj = new Clases.Productos();
            ctdBrownie = obj.MasCount(ctdBrownie,bttnMenosBrownie);
            lablCantidadBrownie.Text = Convert.ToString(ctdBrownie);
            strBrow = obj.TotalProducto(Brownie, ctdBrownie);
            DBrow = obj.ProductoDescripción(NomBrow, Brownie, ctdBrownie);
            Total = strame + strBrow + strcapp + strChoco + strFrapp + strGall + strLatte + strMocha + strPas + strSand + strTeaMat + strWM; txtMostrarTotal.Text = Convert.ToString("$" + Total);//Todos son iguales
            Descripción = DAme + DBrow + DCapp + DChoco + DFrap + DLatt + DMoch + DPas + DSand + DTea_Mat + DWM + DGall; RTxtTicket.Text = Descripción;
        }
        private void bttnMasSandwich_Click(object sender, EventArgs e)
        {
            Clases.Productos obj = new Clases.Productos();
            ctdSandwich = obj.MasCount(ctdSandwich,bttnMenosSandwich);
            labelCantidadSandwich.Text = Convert.ToString(ctdSandwich);
            strSand = obj.TotalProducto(Sandwich, ctdSandwich);
            DSand = obj.ProductoDescripción(NomSand, Sandwich, ctdSandwich);
            Total = strame + strBrow + strcapp + strChoco + strFrapp + strGall + strLatte + strMocha + strPas + strSand + strTeaMat + strWM; txtMostrarTotal.Text = Convert.ToString("$" + Total);//Todos son iguales
            Descripción = DAme + DBrow + DCapp + DChoco + DFrap + DLatt + DMoch + DPas + DSand + DTea_Mat + DWM + DGall;RTxtTicket.Text = Descripción;
        }
        //*************************Botones mas**************************
        //*************************Botones Info*************************
        private void bttnInfoBrownie_Click(object sender, EventArgs e)
        {
            opc = 10;
            Clases.Productos obj = new Clases.Productos();
            obj.Info(opc);
        }
        private void bttnInfoFrappucciono_Click(object sender, EventArgs e)
        {
            opc = 9;
            Clases.Productos obj = new Clases.Productos();
            obj.Info(opc);
        }
        private void bttnInfoMocha_Click(object sender, EventArgs e)
        {
            opc = 8;
            Clases.Productos obj = new Clases.Productos();
            obj.Info(opc);
        }
        private void bttnInfoChocolate_Click(object sender, EventArgs e)
        {
            opc = 7;
            Clases.Productos obj = new Clases.Productos();
            obj.Info(opc);
        }
        private void bttnInfoLatte_Click(object sender, EventArgs e)
        {
            opc = 6;
            Clases.Productos obj = new Clases.Productos();
            obj.Info(opc);
        }
        private void bttnInfoSandwich_Click(object sender, EventArgs e)
        {
            opc = 11;
            Clases.Productos obj = new Clases.Productos();
            obj.Info(opc);
        }
        private void bttbInfoPastel_Click(object sender, EventArgs e)
        {
            opc = 5;
            Clases.Productos obj = new Clases.Productos();
            obj.Info(opc);
        }
        private void bttnInfoGalleta_Click(object sender, EventArgs e)
        {
            opc = 4;
            Clases.Productos obj = new Clases.Productos();
            obj.Info(opc);
        }
        private void bttnInfoTeaMatcha_Click(object sender, EventArgs e)
        {
            opc = 3;
            Clases.Productos obj = new Clases.Productos();
            obj.Info(opc);
        }
        private void bttnInfoWhiteMocha_Click(object sender, EventArgs e)
        {
            opc = 2;
            Clases.Productos obj = new Clases.Productos();
            obj.Info(opc);
        }
        private void bttnInfoCappucino_Click(object sender, EventArgs e)
        {
            opc = 1;
            Clases.Productos obj = new Clases.Productos();
            obj.Info(opc);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            opc = 0;
            Clases.Productos obj = new Clases.Productos();
            obj.Info(opc);
        }
        //************************Botones Info**************************
        private void cmbPedido_SelectedIndexChanged(object sender, EventArgs e){}
        public void LabelsZero()
        {
            lablCantidadAmericano.Text = "0";
            lablCantidadCapuccino.Text = "0";
            lablCantidadWhiteMocha.Text = "0";
            lablCantidadTeaMatcha.Text = "0";
            lablCantidadGalleta.Text = "0";
            lablCantidadPastel.Text = "0";
            lablCantidadLatte.Text = "0";
            lablCantidadChocolate.Text = "0";
            lablCantidadMocha.Text = "0";
            lablCantidadFrapuccino.Text = "0";
            lablCantidadBrownie.Text = "0";
            labelCantidadSandwich.Text = "0";
            RTxtTicket.Clear();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {   //Boton Salir
            Application.Exit();
        }
    }
}
