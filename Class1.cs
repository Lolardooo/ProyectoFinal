using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Primeros_Pasos
{
    public class Usuario
    {
        public int id;
        public string nombre;
        public string apellido;
        public string nombreUsuario;
        public string contraseña;
        public string mail;
    }

    public class Producto
    {
        public int id;
        public string descripcion;
        public double costo;
        public double precioVenta;
        public int stock;
        public int idUsuario;
    }

    public class ProductoVendido
    {
        public int id;
        public int idProducto;
        public int stock;
        public int idVenta;
    }

    public class Venta
    {
        public int id;
        public string comentarios;
        public string idUsuario;
    }
}
