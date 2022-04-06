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
    public partial class MostrarProductos : ContentPage
    {
        public MostrarProductos(string nombre, int precio, int cantidad, string descripcion)
        {
            InitializeComponent();
            lbl_nombre.Text = nombre;
            lbl_precio.Text = precio.ToString();
            lbl_cantidad.Text = cantidad.ToString();
            lbl_descripcion.Text = descripcion;
        }
    }
}