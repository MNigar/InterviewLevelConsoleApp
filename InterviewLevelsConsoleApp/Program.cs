using InterviewLevelsConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewLevelsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Holding holding = new Holding()
            {
                Id = 1,
                Name = "Pasha Holding"
            };
            Company company = new Company()
            {
                Id = 1,
                Name = "Pasha Sigorta",
                HoldingId=holding.Id
                
            };
            company.Show(company);
            List<Department> departments = new List<Department>() { 
            new Department{Id=1,Name="Insan Resurslari"},
            new Department{Id=2,Name="Maliyye"},
            new Department{Id=3,Name="Marketing"},
            new Department{Id=4,Name="Informasiya Texnologiyalari"},
            };

            List<Position> position = new List<Position>()
            {
               new Position{Id=1,Name="HR",DepartmentId=1,CompanyId=1},
               new Position{Id=2,Name="Departament mudiri",DepartmentId=2,CompanyId=1},
               new Position{Id=3,Name="Departament mudiri",DepartmentId=3,CompanyId=1},
               new Position{Id=4,Name="Departament mudiri",DepartmentId=4,CompanyId=1},
            };
            List<Requirement> requirements = new List<Requirement>
            {
             new Requirement { Id=1,Name = RequirementEnum.Ishstaji.ToString() },
             new Requirement { Id=2,Name =RequirementEnum.Referans.ToString() },

            };
            

            var vacancylist = company.CreateVacancy();
            Vacation.Show(vacancylist);
            Requirement.Show(requirements);
            List<Candidate> candidates = new List<Candidate>()
            {
                new Candidate{Id=1,Name="Nigar",Surname="Mammadova",VacationId=1,requirementyear=1,referance=true},
                new Candidate{Id=2,Name="Nergiz",Surname="Shabanova",VacationId=2,requirementyear=4,referance=false},
                new Candidate{Id=3,Name="Narmin",Surname="Aliyeva",VacationId=3,requirementyear=5,referance=true},
                new Candidate{Id=4,Name="Nariman",Surname="Shahsuvarov",VacationId=1,requirementyear=7,referance=true}
            };
            List<InterviewType> interviewTypes = new List<InterviewType>()
            {
                new InterviewType{Id=1,Name=InterviewLevelEnum.ikiherheleli.ToString()},
                new InterviewType{Id=2,Name=InterviewLevelEnum.birmerheleli.ToString()}

            };
            for (; ; )
            {
                Console.WriteLine("Vakasiyanin Idsini  seçib namizedlerin siyahısına bax\n Id:");
                int Id = Convert.ToInt32(Console.ReadLine());
                var selectedVacancy=company.SelectVacation(Id);

                Console.WriteLine("Namizedler");
                var candidateForVacation = candidates.Where(c => c.VacationId == Id).ToList();
                Candidate.Show(candidateForVacation);
                
                Console.WriteLine("Musahibeye cagirilacaq namized ish staji ve referansina gore sechilir:");
                var selectedCandidate= candidateForVacation.Where(c=>c.referance==true).OrderBy(c => c.requirementyear).LastOrDefault();
                company.SelectCandidate(selectedCandidate.Id);
                company.InviteCandidateInterview(selectedCandidate.Id);
                //Indiki halda musahibe
                Company.InterviewType(InterviewLevelEnum.ikiherheleli.ToString());
                Company.Levelinterview(1);

                Console.WriteLine("HR qiymetlendirir");
                var hr = position.Where(p => p.Name == "HR").FirstOrDefault();
                Console.WriteLine("Novbeti merheleye kechsinmi- He-1,Yox-2");
                int choice = Convert.ToInt32(Console.ReadLine());               
                bool result= hr.HrEvaluateCandidate(choice);
                var sVacancy = vacancylist.Where(v => v.Id == selectedVacancy).FirstOrDefault();
                var positionDepartament = position.Where(p => p.DepartmentId == sVacancy.DepartmentId).FirstOrDefault();
                if (!result)
                {
                    Console.WriteLine("Teessuf");
                }
                
                else
                {
                    Console.WriteLine("Departamnet mudiri qiymetlendirir");
                    Console.WriteLine("Ishe qebul uchun- He-1,Yox-2");
                    var choiceDepartment = Convert.ToInt32(Console.ReadLine());
                    positionDepartament.DepartmentEvaluateCandidate(choiceDepartment);
                }
                //After 2 month
                Console.WriteLine("2 ay sonraki musahibelerin gedishati");
                Company.InterviewType(InterviewLevelEnum.birmerheleli.ToString());
                Company.Levelinterview(2);

                Console.WriteLine("Ishe qebul uchun- He-1,Yox-2");

                int dChoice = Convert.ToInt32(Console.ReadLine());
                positionDepartament.DepartmentEvaluateCandidate(dChoice);
                
            }
        }
    }
}
