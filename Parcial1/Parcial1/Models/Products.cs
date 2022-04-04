using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial1.Models
{
    public class Products
    {

        public string Tipo { get; set; }
        public string Nombre { get; set; }
        public int Unidades { get; set; }
        public string Descripcion { get; set; }
        public int Precio { get; set; }

        public Products(int _tipo, string _nombre, int _unidades, int _precio, string _descripcion)
        {
            Nombre = _nombre;
            Tipo = HallarTipo(_tipo);
            Unidades = _unidades;
            Descripcion = _descripcion;
            Precio = _precio;

        }

        public static string HallarTipo(int __tipo)
        {
            string tipo_material;
            if (__tipo == 0)
            {
                tipo_material = "Nuevo";
            }
            else
            {
                tipo_material = "Reacondicionado";
            }
            return tipo_material;
        }
    }
}
