using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewLevelsConsoleApp.Models
{
    public class Common
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public  void Show (Common common)
        {
            Console.WriteLine($"Id :{common.Id}\n Ad:{common.Name}\n");

        }
    }
}
