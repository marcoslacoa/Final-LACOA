using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Message box


namespace Final_LACOA.Models
{
    public class Movimiento
    {
        public int id { get; set; }
        public CajaAhorro caja;
        public int idCaja { get; set; }
        public string detalle { get; set; }
        public float monto { get; set; }
        public DateTime fecha { get; set; }
        public Movimiento() { }
        public Movimiento(CajaAhorro Caja, string Detalle, float Monto, DateTime Fecha)
        {
            this.caja = Caja;
            this.detalle = Detalle;
            this.monto = Monto;
            this.fecha = Fecha;
            this.idCaja = Caja.id;
        }
        public void toStringMovimiento() {
            //MessageBox.Show("Detalle: " + detalle + " Monto: " + monto + " Fecha: " + fecha); // Forms
            Console.WriteLine("Detalle: " + detalle + " Monto: " + monto + " Fecha: " + fecha); // Console
        }
        public string[] toArray()
        {
            return new string[] { caja.cbu.ToString() , detalle.ToString(), monto.ToString(), fecha.ToString() };
        }
    }
}
