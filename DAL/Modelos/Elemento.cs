using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Modelos
{
    /// <summary>
    /// Entidad de la tabla elemento
    /// </summary>
    public class Elemento
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long idElemento { get; set; } = 0;
        public string codigoElemento { get; set; } = "aaaaa";
        public string nombreElemento { get; set; } = "aaaaa";
        public string descripcionElemento { get; set; } = "aaaaa";
        public int cantidadElemento { get; set; } = 0;

        public ICollection<Reserva> Reservas { get; set; }


        #region Constructores
        public Elemento()
        {
        }

        public Elemento(long idElemento, string codigoElemento, string nombreElemento, string descripcionElemento, int cantidadElemento)
        {
            this.idElemento = idElemento;
            this.codigoElemento = codigoElemento;
            this.nombreElemento = nombreElemento;
            this.descripcionElemento = descripcionElemento;
            this.cantidadElemento = cantidadElemento;
        }
        public Elemento( string nombreElemento, string descripcionElemento, int cantidadElemento)
        {
            this.nombreElemento = nombreElemento;
            this.descripcionElemento = descripcionElemento;
            this.cantidadElemento = cantidadElemento;
        }
        public Elemento(long idElemento, int cantidadElemento)
        {
            this.idElemento = idElemento;
            this.cantidadElemento = cantidadElemento;
        }
        public Elemento(long idElemento)
        {
            this.idElemento = idElemento;
            
        }
        #endregion


    }
}
