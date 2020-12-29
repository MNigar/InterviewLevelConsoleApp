using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewLevelsConsoleApp
{
    public class Position : Common
    {
        public int CompanyId { get; set; }
        public int DepartmentId { get; set; }
        public bool HrEvaluateCandidate(int choice)
        {
            if (choice == 1)
            {
                Company.Levelinterview(2);
                return true;
            }
            else
            {
                Console.WriteLine("Teessuf ki , novbeti merheleye keche bilmediniz");
                return false;
            }
         }
        public void DepartmentEvaluateCandidate(int choice)
        {
            if (choice == 1)
                Console.WriteLine("İshe qebul olundunuz");
            else
                Console.WriteLine("Teessuf!Ugurlar!");
        }
    }
}
