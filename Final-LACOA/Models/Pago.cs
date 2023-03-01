using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_LACOA.Models
{
    public class Pago
    {
        public int id { get; set; }
        public Usuario usuario { get; set; }
        public int idUsuario { get; set; }
        public float monto { get; set; }
        public Boolean pagado { get; set; }

        public string detalle { get; set; }

        public Pago() { }


        public Pago(Usuario Usuario, float Monto, bool Pagado, string detalle)
        {
            this.usuario = Usuario;
            this.monto = Monto;
            this.pagado = Pagado;
            this.detalle = detalle;
            this.idUsuario = Usuario.id;
        }
        public string[] toArray()
        {
            return new string[] { monto.ToString(), detalle.ToString() };
        }
    }
}
