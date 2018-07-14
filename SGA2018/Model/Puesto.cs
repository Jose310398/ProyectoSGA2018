using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SGA2018.Model
{
    public class Puesto
    {
        [Key]
        public int PuestoId { get; set; }
        public string Descripcion { get; set; }
        public virtual ICollection<Profesor> Profesores { get; set; }

    }
}
