using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_LACOA.Models
{
    public class PlazoFijo
    {
        public int id { get; set; }
        public Usuario titular { get; set; }
        public int idUsuario { get; set; }
        public float monto { get; set; }
        public DateTime fechaIni { get; set; }
        public DateTime FechaFin { get; set; }
        public float tasa { get; set; }
        public int cbu { get; set; }
        public Boolean pagado { get; set; }
        public PlazoFijo() {  }

        public PlazoFijo(Usuario Titular, int cbu , float Monto,DateTime FechaIni, DateTime FechaFin, float Tasa, bool Pagado)
        {   
            this.titular = Titular;
            this.monto = Monto;
            this.fechaIni = FechaIni;
            this.FechaFin = FechaFin;
            this.tasa = Tasa;
            this.pagado = Pagado;
            this.cbu = cbu;
            this.idUsuario = Titular.id;
        } 

        public string[] toArray()
        {
            return new string[] { monto.ToString(), fechaIni.ToString(), fechaIni.ToString(), tasa.ToString() };
        }
    }
}
