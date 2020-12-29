using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewLevelsConsoleApp.Models
{
public class Requirement:Common
    {
        //public int Id { get; set; }
        //public int Year { get; set; }
        //public bool reference  { get; set; }
        public static void Show(List<Requirement> requirements)
        {
            foreach (var i in requirements)
            {

                Console.WriteLine($"Telebler: {i.Id}\n Ad:{i.Name}\n ");
            }
           
        }
    }
}
