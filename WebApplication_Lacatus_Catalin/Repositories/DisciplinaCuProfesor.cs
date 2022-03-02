using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_Lacatus_Catalin.Repositories
{
    public class DisciplinaCuProfesor
    {
        public string Denumire_disciplina { get; set; }
        public int Nr_ore_sapt { get; set; }
        public int Nr_examene { get; set; }
        public string Nume_Profesor { get; set; }
        public string Prenume_Profesor { get; set; }
        public string Telefon { get; set; }
    }
}
