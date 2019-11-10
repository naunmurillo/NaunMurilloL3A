using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gasolinera2.Clases
{
    class Gasolina
    {
        private string tipo;

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        private double cantidad;

        public double Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        private double precio;

        public double Precio
        {
            get {
                if (Tipo == "Extra")
                {
                    return 1.50;
                }
                if (Tipo == "Super")
                {
                    return 2.00;
                } return precio;
            }

        }
        private double subtotal;

        public double Subtotal
        {
            get {
                subtotal = Cantidad * Precio;
                return subtotal; }

        }


        private double iva;

        public double Iva
        {
            get {
                iva = (Subtotal * 12) / 100;
                return iva; }

        }
        private double total;

        public  double Total
        {
            get {
                total = Subtotal + Iva;
                return total; }
         
        }


    }
}
