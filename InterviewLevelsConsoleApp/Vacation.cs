using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewLevelsConsoleApp
{
    public class Vacation : Common
    {
        public int DepartmentId { get; set; }
        public List<int> RequirementId { get; set; }
        
        public static void Show(List<Vacation> vacations)
        {

            foreach (var i in vacations)
            {

                Console.WriteLine($"Id :{i.Id}\n Ad:{i.Name}\n Shobe:{i.DepartmentId}\n");
                foreach (var r in i.RequirementId)
                {
                    Console.WriteLine($"Tələb :{r}\n");
                }
               
            }


        }
    }


}
