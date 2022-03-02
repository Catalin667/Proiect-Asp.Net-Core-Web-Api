using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_Lacatus_Catalin.Entitati.DTOs
{
    public class ProfesorDisciplinaElevDTO
    {
        public int ProfesorId { get; set; }

        public int DisciplinaId { get; set; }
  
        public int ElevId { get; set; }
 
        public int an_studiu { get; set; }

        public ProfesorDisciplinaElevDTO(ProfesorDisciplinaElev profesorDisciplinaElev)
        {
            this.ProfesorId = profesorDisciplinaElev.ProfesorId;
            this.DisciplinaId = profesorDisciplinaElev.DisciplinaId;
            this.ElevId = profesorDisciplinaElev.ElevId;
            this.an_studiu = profesorDisciplinaElev.an_studiu;
        }
    }
}
