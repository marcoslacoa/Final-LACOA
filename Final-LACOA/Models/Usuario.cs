    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Final_LACOA.Models; 

public class Usuario
{
    [Key]
    public int id { get; set; }
    public string nombre { get; set; }
    public string apellido { get; set; }
    public int dni { get; set; }
    public string mail { get; set; }
    public string contra { get; set; }
    public int intentosFallidos { get; set; }

    public bool bloqueado = false;

    public List<PlazoFijo> plazoFijo { get; set; } = new List<PlazoFijo>();
    public List<Pago> pagos { get; set; } = new List<Pago>();
    public List<TarjetaCredito> tarjetas { get; set; } = new List<TarjetaCredito>();
    //public List<CajaAhorro> cajasLista { get => listaCajas.ToList(); }
    public ICollection<CajaAhorro> listaCajas { get; } = new List<CajaAhorro>();
    public List<UsuarioCaja> UserCaja { get; set; }

    public bool esADM;

    public Usuario()
    {
        
    }
    public Usuario(string Nombre, string Apellido, int Dni, string Mail, string Contra, bool EsADM, int IntentosFallidos, bool Bloqueado, List<CajaAhorro> CajasList, List<PlazoFijo> PlazoFijo, List<Pago> Pagos, List<TarjetaCredito> Tarjetas)
        //,
        //List<CajaAhorro> CajasList, List<PlazoFijo> PlazoFijo, List<Pago> Pagos, List<TarjetaCredito> Tarjetas
    {
        nombre = Nombre;
        apellido = Apellido;
        dni = Dni;
        mail = Mail;
        contra = Contra;
        esADM = EsADM;
        this.intentosFallidos = IntentosFallidos;
        this.listaCajas = CajasList;
        this.plazoFijo = PlazoFijo;
        this.pagos = Pagos;
        this.tarjetas = Tarjetas;
        this.bloqueado = Bloqueado;
    }

    public Usuario(string Nombre, string Apellido, int Dni, string Mail, string Contra, bool Bloqueado, bool EsADM) : this(Nombre, Apellido)
    {
        dni = Dni;
        mail = Mail;
        contra = Contra;
        this.bloqueado = Bloqueado;
        this.esADM = EsADM;
        listaCajas = new List<CajaAhorro>(); // Estas van aca o van arriba en la definicion?
        plazoFijo = new List<PlazoFijo>();
        pagos = new List<Pago>();
        tarjetas = new List<TarjetaCredito>();
    }

    public Usuario(string Nombre, string Contra)
    {
        nombre = Nombre;
        contra = Contra;
        //
    }
    // agregar caja a lista de cajas

    
}
