using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperaturas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmbMedidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CmbMedidas.SelectedIndex)
            {
                case 0:
                    pnlDatos.Visible = true;
                    pnlKelvin.Visible = false;
                    pnlFahrenheit.Visible = false;
                    pnlCelsius.Visible = true;
                    break;
                case 1:
                    pnlDatos.Visible = true;
                    pnlKelvin.Visible = false;
                    pnlFahrenheit.Visible = true;
                    pnlCelsius.Visible = false;
                    break;
                case 2:
                    pnlDatos.Visible = true;
                    pnlKelvin.Visible = true;
                    pnlFahrenheit.Visible = false;
                    pnlCelsius.Visible = false;
                    break;
            }
        }
    }
}
