using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_LACOA.Models
{
    public class UsuarioCaja
    {
        //Acá podríamos agregar cualquier otra propiedad que necesitemos (por ejemplo el total de una compra no?) ;)
        public int idCaja { get; set; }
        public CajaAhorro caja { get; set; }
        public int num_usr { get; set; }
        public Usuario usuario { get; set; }
        public int cantidad { get; set; }
        public UsuarioCaja() { }
    }
}
