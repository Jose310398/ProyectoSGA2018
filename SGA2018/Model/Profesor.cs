using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SGA2018.Model
{
   public class Profesor
    {
        [Key]
        public int ProfesorId { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int NumeroCursos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public virtual Puesto Puesto { get; set; }

    }
}
