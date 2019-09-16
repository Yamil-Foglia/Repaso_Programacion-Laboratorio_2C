using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    public class Estante
    {
        #region Atributos - Contructor
        private Producto[] productos;
        private int ubicacionEstante;

        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }
        #endregion

        #region Get
        
        public Producto[] GetProductos()
        {
            return this.productos;
        }

        public static string MostrarEstantes(Estante e)
        {
            Producto[] productos = e.GetProductos();
            string datos = "Datos del estante introducido\n\n";
            
            for(int i=0; i<productos.Length; i++)
            {
               datos= datos + Producto.MostrarProducto(e.productos[i])+"\n\n";
            }

            return datos;
        }
        #endregion

        #region Sobrecarga de operadores
        /// <summary>
        ///  Retornará true, si es que el producto ya se encuentra en el estante, false, caso contrario
        /// </summary>
        /// <param name="e">Estante</param>
        /// <param name="p">Prodcuto</param>
        /// <returns></returns>
        public static bool operator ==(Estante e, Producto p)
        {
            for (int i = 0; i < e.productos.Length; i++)
            {
                if(e.productos[i] == p)
                {
                    return true;
                }
            }
            return false;
                
        }

        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }

        public static bool operator +(Estante e, Producto p)
        {
            for (int i = 0; i < e.productos.Length; i++)
            {
                if (e.productos[i] is null && e != p)
                {
                    e.productos[i] = p;
                    return true;
                }
            }
            return false;
        }

        public static Estante operator -(Estante e, Producto p)
        {
            for (int i = 0; i < e.productos.Length; i++)
            {
                if (e == p)
                {
                    e.productos[i] = null;
                    return e;
                }
            }
            return e;
        }
        #endregion
    }
}
