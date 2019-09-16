using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    public class Producto
    {
        #region Atributos - Constructor 
        
        private string codigoDeBarra;
        private string marca;
        private float precio;


        public Producto(string marca, string codigoDeBarra, float precio)
        {
            this.codigoDeBarra = codigoDeBarra;
            this.marca = marca;
            this.precio = precio;
        }
        #endregion

        #region Get
        public string GetMarca()
        {
            return this.marca;
        }
        public float GetPrecio()
        {
            return this.precio;
        }
        #endregion

        #region Sobrecarga de operadores
        public static string MostrarProducto(Producto p)
        {
            return "Codigo de barra: "+ p.codigoDeBarra +"\nMarca: "+ p.marca + "\nPrecio: "+p.precio;
        }

        public static explicit operator string (Producto p)
        {
            return p.codigoDeBarra;
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            if(p1 is null || p2 is null)
            {
                return false;
            }
            else
            {
                if (p1.codigoDeBarra == p2.codigoDeBarra && p1.marca == p2.marca)
                    return true;
            }
            return false;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }


        public static bool operator ==(Producto p, string marca)
        {
            if (p.marca == marca)
                return true;
            return false;
        }

        public static bool operator !=(Producto p, string marca)
        {
            return !(p == marca);
        }
        #endregion

    }
}
