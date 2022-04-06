using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Parcial1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Factura : ContentPage
    {
        public Factura()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
        private void PagarCuenta(object sender, EventArgs e)
        {

            double _total_cuenta; // valor de la cuenta
            double _integrantes; //  # de integrantes 
            double _porcentaje; // porcentaje propina
            double _vr_propina; // valor propina
            double _total_pagar; // valor total a pagar
            double _total_integrantes; // valor aporte por integrantes

            _total_cuenta = double.Parse(total_cuenta.Text);
            _integrantes = double.Parse(integrantes.Text);
            _porcentaje = double.Parse(porc_pro.Text);

            _vr_propina = _total_cuenta * (_porcentaje / 100);
            _total_pagar = _vr_propina + _total_cuenta;
            _total_integrantes = _total_pagar / _integrantes;

            total_cuentap.Text = _total_cuenta.ToString("0.##");
            valor_propina.Text = _vr_propina.ToString("0.##");
            valor_totalp.Text = _total_pagar.ToString("0.##");
            valor_ppp.Text = _total_integrantes.ToString("0.##");

        }

        private void Limpiar(object sender, EventArgs e)
        {
            total_cuenta.Text = "";
            integrantes.Text = "";
            porc_pro.Text = "";

            total_cuentap.Text = "";
            valor_propina.Text = "";
            valor_totalp.Text = "";
            valor_ppp.Text = "";
        }
    }
}