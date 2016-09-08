using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraAcuidadeVisual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {


            double distancia, tamanho, radianos, angulo;
            
            if (double.TryParse(txtDistancia.Text, out distancia) == false)
            {
                lblErroDistancia.Text = "Distância inválida";
                return;
            }
            if (double.TryParse(txtTamanho.Text, out tamanho) == false)
            {
                lblErroTamanho.Text = "Tamanho inválida";
                return;
            }

            //converter o tamanho para metros
            tamanho = tamanho / 1000;

            //descobrir angulo em radianos
            radianos = 2 * (Math.Tan((tamanho / 2) / distancia));


            //angulo em graus
            angulo = radianos * ( 180.0/Math.PI);


            //bagulho loko da net
            lblAngulo.Text = Angulo.GeoAngle.FromDouble(angulo).ToString();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
