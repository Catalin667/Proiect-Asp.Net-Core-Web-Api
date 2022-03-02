using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_Lacatus_Catalin.Repositories.ProfDisElevRepository;

namespace WebApplication_Lacatus_Catalin.Entitati.DTOs
{
    public class GetDisciplineWithProfesoriDTO
    {
        public string Nume_Profesor { get; set; }
        public string Prenume_Profesor { get; set; }
        public string Telefon { get; set; }
        public string Denumire_disciplina { get; set; }
        public int Nr_ore_sapt { get; set; }
        public int Nr_examene { get; set; }
        
        public GetDisciplineWithProfesoriDTO(objectProfesorDisciplinaElev profesorDisciplinaElev)
        {
            
            this.Denumire_disciplina = profesorDisciplinaElev.Denumire_disciplina;
            this.Nr_ore_sapt = (int)profesorDisciplinaElev.Nr_ore_sapt;
            this.Nr_examene = (int)profesorDisciplinaElev.Nr_examene;
            this.Nume_Profesor = profesorDisciplinaElev.Nume_Profesor;
            this.Prenume_Profesor = profesorDisciplinaElev.Prenume_Profesor;
            this.Telefon = profesorDisciplinaElev.Telefon;
        }
       
    }


}
