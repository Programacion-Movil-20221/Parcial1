using Parcial1.Models;
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
    public partial class ProductosList : ContentPage
    {
        public List<Products> ListaProductos { get; set; }

        public ProductosList()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            ListaProductos = new List<Products>
            {
                new Products(0, "Computador", 50, 2000, "Nuevo prod 2.0"),
                new Products(1, "Libreta", 27, 2000, "Nuevo prod 3.0"),
                new Products(0, "Portatil", 75, 2000, "Nuevo prod 2.0.1"),
                new Products(1, "Sueter", 16, 2000, "Nuevo prod 2.0.2"),
                new Products(1, "Sudadera", 30, 2000, "Nuevo prod 4.5")
            };

            ListadoProductos.ItemsSource = ListaProductos;
        }

        private int HallarItemIndex(String nombre)
        {
            int index = 0;
            for (int i = 0; i < ListaProductos.Count; i++)
            {
                if (nombre == ListaProductos[i].Nombre)
                {
                    index = i;
                }
            }
            return index;
        }

        private void ListadoProductos_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (Products)e.SelectedItem;
            int j = HallarItemIndex(item.Nombre);
            var i = ListaProductos[j];


            string nombre = i.Nombre.ToString();
            int precio = int.Parse(i.Precio.ToString("0.##"));
            int cantidad = int.Parse(i.Unidades.ToString("0.##"));
            string tipo = i.Tipo.ToString();
            string descripcion = i.Descripcion.ToString();

            Navigation.PushAsync(new MostrarProductos(nombre, precio, cantidad, tipo, descripcion));
        }

        private void MainSearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            var keyword = "";
            if (MainSearchBar.Text.Length == 1)
            {
                keyword = MainSearchBar.Text.ToUpperInvariant();
            }
            keyword = MainSearchBar.Text;
            ListadoProductos.ItemsSource = ListaProductos.Where(name => name.Nombre.Contains(keyword));

        }

        private void Btn_AgregarProducto(object sender, EventArgs e)
        {
            stackVisible.IsVisible = true;
        }

        private void Img_btn_Cancel(object sender, EventArgs e)
        {
            entry_name.Text = "";
            entry_precio.Text = "";
            entry_units.Text = "";
            picker.SelectedIndex = -1;
            editor_des.Text = "";

            stackVisible.IsVisible = false;
        }

        private void Img_btn_Save(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(entry_name.Text) && !string.IsNullOrWhiteSpace(entry_precio.Text) && !string.IsNullOrWhiteSpace(entry_units.Text) && picker.SelectedIndex != -1 && !string.IsNullOrWhiteSpace(editor_des.Text))
            {
                ListaProductos.Add(new Products(picker.SelectedIndex, entry_name.Text, int.Parse(entry_units.Text), int.Parse(entry_precio.Text), editor_des.Text));
                ListadoProductos.ItemsSource = ListaProductos;
                entry_name.Text = "";
                entry_precio.Text = "";
                entry_units.Text = "";
                picker.SelectedIndex = -1;
                editor_des.Text = "";

            }
            else
                DisplayAlert("Error", "Debe llenar todos los campos", "OK");
            stackVisible.IsVisible = false;
        }

        private void Button_Clicked(object sender,  EventArgs e)
        {
            /*
            var item = (Products)e.SelectedItem;
            int j = HallarItemIndex(item.Nombre);
            var i = ListaProductos[j];

            string nombre = i.Nombre.ToString();
            int precio = int.Parse(i.Precio.ToString("0.##"));
            int cantidad = int.Parse(i.Unidades.ToString("0.##"));
            string descripcion = i.Descripcion.ToString();

            Navigation.PushAsync(new MostrarProductos(nombre, precio, cantidad, descripcion));*/
        }
    }
}       