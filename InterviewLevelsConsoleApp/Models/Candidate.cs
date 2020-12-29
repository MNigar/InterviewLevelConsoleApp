using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewLevelsConsoleApp.Models
{
    public class Candidate : Common
    {   public string Surname { get; set; }
        public int VacationId { get; set; }
        public int requirementyear { get; set; }
        public bool referance { get; set; }
        public static void Show(List<Candidate> candidates)

        {
            foreach (var i in candidates)
            {

                Console.WriteLine($"Id :{i.Id}\n Ad,Soyad:{i.Name} {i.Surname}\n Ish staji:{i.requirementyear} il\n " +
                    $"Referans mektubu:{i.referance}");
            }

        }

    }
}
