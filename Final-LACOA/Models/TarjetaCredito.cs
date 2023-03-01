using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_LACOA.Models
{
    public class TarjetaCredito
    {
        public int id { get; set; }
        public Usuario titular { get; set; }
        public int idUsuario { get; set; }
        public int numero { get; set; }
        public int codigoSeguridad { get; set; }
        public float limite { get; set; }
        public float consumos { get; set; }
        public TarjetaCredito() { }
        public TarjetaCredito(Usuario Titular, int Numero, int CodigoSeguridad, float Limite, float Consumos)
        {
            this.titular = Titular;
            this.numero = Numero;
            this.codigoSeguridad = CodigoSeguridad;
            this.limite = Limite;
            this.consumos = Consumos;
            this.idUsuario = Titular.id;
        }
        public string[] toArray()
        {
            return new string[] { numero.ToString(), codigoSeguridad.ToString(), limite.ToString(), consumos.ToString() };
        }
    }
}
