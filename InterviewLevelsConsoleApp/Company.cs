using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewLevelsConsoleApp
{
    public class Company : Common
    {
        public int HoldingId { get; set; }
        public  void Show(Company company)
        {
            Console.WriteLine($"Id :{company.Id}\n Ad:{company.Name}\n Holding:{company.HoldingId}\n");
        }
        public List<Vacation> CreateVacancy()
        {
            List<Vacation> vacations= new List<Vacation>
            {
             new Vacation { Id=1,Name = "IT None" ,RequirementId=new List<int>{1,2 },DepartmentId=4 },
             new Vacation { Id=2,Name = "Maliyye None"  ,RequirementId=new List<int>{1,2 },DepartmentId=2},
             new Vacation {Id=3,Name = "Marketing None" ,RequirementId=new List<int>{1,2},DepartmentId=3}
            };
            return vacations;
        }
        public int SelectVacation(int id)
        {
            Console.WriteLine($" {id}-li Vakansiya  seçildi");
            return id;
        }
        public void SelectCandidate(int id)
        {
            Console.WriteLine($"{id}-idli Namized seçildi");
        }
        public void InviteCandidateInterview(int id)
        {
            Console.WriteLine($"Eziz namized siz musahibeye devet olunursunuz,Ugurlar! \n ");
        }
        public static void Levelinterview(int level)
        {
            if (level == 1)
                Console.WriteLine($"Eziz namized siz ilkin merhelede HR-la musahibede olacaqsiniz \n ");
            if (level == 2)
                Console.WriteLine(
                    "Eziz namized siz departament mudiri musahibede  olacaqsiniz");
        }
        public static void InterviewType(string type)
        {
            if (type ==InterviewLevelEnum.ikiherheleli.ToString())
            {
                Console.WriteLine("Iki merheleli musahibe");
            }
            if (type == InterviewLevelEnum.birmerheleli.ToString())
            {
                Console.WriteLine("Bir merheleli musahibe");
            }
        }


    }
}
