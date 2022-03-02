using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_Lacatus_Catalin.Entitati.DTOs
{
    public class ProfDisciplinaElevDTO
    {   
        public string Nume_Profesor { get; set; } 
        public string Prenume_Profesor { get; set; }
        public string Telefon { get; set; }
        public string Nume_Elev { get; set; } 
        public string Prenume_Elev { get; set; }
        public string Telefon_elev { get; set; }
        public string Denumire_disciplina { get; set; }
        public int Nr_ore_sapt { get; set; }
        public int Nr_examene { get; set; }
        public int an_studiu { get; set; }
        
        public ProfDisciplinaElevDTO(ProfesorDisciplinaElev profesorDisciplinaElev)
        {
            this.Nume_Profesor = profesorDisciplinaElev.Profesor.Nume;
            this.Prenume_Profesor = profesorDisciplinaElev.Profesor.Prenume;
            this.Telefon = profesorDisciplinaElev.Profesor.Telefon;
            this.Nume_Elev = profesorDisciplinaElev.Elev.Nume;
            this.Prenume_Elev = profesorDisciplinaElev.Elev.Prenume;
            this.Telefon_elev = profesorDisciplinaElev.Elev.Telefon;
            this.Denumire_disciplina = profesorDisciplinaElev.Disciplina.Denumire_disciplina;
            this.Nr_ore_sapt = (int)profesorDisciplinaElev.Disciplina.Nr_ore_sapt;
            this.Nr_examene = (int)profesorDisciplinaElev.Disciplina.Nr_examene;
            this.an_studiu = profesorDisciplinaElev.an_studiu;
        }
    }
}
