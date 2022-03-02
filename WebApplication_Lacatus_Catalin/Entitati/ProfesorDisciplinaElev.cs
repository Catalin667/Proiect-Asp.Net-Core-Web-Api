using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_Lacatus_Catalin.Entitati
{
    public class ProfesorDisciplinaElev
    {
        public int an_studiu { get; set; }
        public int ProfesorId { get; set; }
        public Profesor Profesor { get; set; }
        public int DisciplinaId { get; set; }
        public Disciplina Disciplina { get; set; }
        public int ElevId { get; set; }
        public Elev Elev { get; set; }
    }
}
