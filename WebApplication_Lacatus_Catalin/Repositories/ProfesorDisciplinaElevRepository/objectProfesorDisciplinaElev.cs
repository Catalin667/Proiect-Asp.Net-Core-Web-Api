using WebApplication_Lacatus_Catalin.Entitati.DTOs;

namespace WebApplication_Lacatus_Catalin.Repositories.ProfDisElevRepository
{
    public class objectProfesorDisciplinaElev
    {
        public string Denumire_disciplina { get; set; }
        public int Nr_ore_sapt { get; set; }
        public int Nr_examene { get; set; }
        public string Nume_Profesor { get; set; }
        public string Prenume_Profesor { get; set; }
        public string Telefon { get; set; }
    }
}