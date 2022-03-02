using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_Lacatus_Catalin.Entitati.DTOs
{
    public class DisciplinaDTO
    {
        public string Denumire_disciplina { get; set; }
        public int Nr_ore_sapt { get; set; }
        public int Nr_examene { get; set; }


        public DisciplinaDTO(Disciplina disciplina)
        {
            this.Denumire_disciplina = disciplina.Denumire_disciplina;
            this.Nr_ore_sapt = (int)disciplina.Nr_ore_sapt;
            this.Nr_examene = (int)disciplina.Nr_examene;

        }
    }
}
