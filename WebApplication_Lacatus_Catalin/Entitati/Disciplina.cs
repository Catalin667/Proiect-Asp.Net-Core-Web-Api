using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_Lacatus_Catalin.Entitati
{
    public class Disciplina
    {
#nullable enable
        public int DisciplinaId { get; set; }
        public string? Denumire_disciplina { get; set; }
        public int? Nr_ore_sapt { get; set; }
        public int? Nr_examene { get; set; }
#nullable disable
        public ICollection<ProfesorDisciplinaElev> ProfesorDisciplinaElev { get; set; }
    }
}
