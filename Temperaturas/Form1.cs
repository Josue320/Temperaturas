using Dominio.Entities;
using Infraestructure;
using Infraestructure.Interfaces;
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
        public BaseRepository obj;
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

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            switch (cmbCelsius.SelectedIndex)
            {
                case 0:
                    Temperatura p = new Temperatura
                    {
                        Celsius = nudDatos.Value
                    };
                    obj.Create(p);
                    break;
                case 1:
                    Temperatura r = new Temperatura
                    {
                        Celsius = nudDatos.Value
                    };
                    obj.Create(r);
                    break;
                default:
                    Ingresar();
                    return;
            }
            switch (cmbFahrenheit.SelectedIndex)
            {
                case 0:
                    Temperatura s = new Temperatura
                    {
                        Fahrenheit = nudDatos.Value
                    };
                    obj.Create(s);
                    break;
                case 1:
                    Temperatura t = new Temperatura
                    {
                        Fahrenheit = nudDatos.Value
                    };
                    obj.Create(t);
                    break;
                default:
                    Ingresar();
                    return;
            }
            switch (cmbKelvin.SelectedIndex)
            {
                case 0:
                    Temperatura u = new Temperatura
                    {
                        Kelvin = nudDatos.Value
                    };
                    obj.Create(u);
                    break;
                case 1:
                    Temperatura v = new Temperatura
                    {
                        Kelvin = nudDatos.Value
                    };
                    obj.Create(v);
                    break;
                default:
                    Ingresar();
                    return;
            }
            dgbHistorial.DataSource = obj.GetAll(a => a.GetType == obj.);
        }
        private void Ingresar()
        {
            MessageBox.Show("Debe seleccionar una opcion antes de continuar");
        }
    }
}
