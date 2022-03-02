using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_Lacatus_Catalin.Entitati.DTOs
{
    public class ProfesorElevDisciplinaCreateDTO
    {
        public int ProfesorId { get; set; }
        public int DisciplinaId { get; set; }
        public int ElevId { get; set; }
        public int an_studiu { get; set; }
    }
}
