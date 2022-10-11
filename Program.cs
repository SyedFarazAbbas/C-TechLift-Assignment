using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    public class Candidate
    {
        public string name;
        public double cgpa;
        int age;
        string city;
        int num;
        int num2;
        int number;
        public Candidate(string Name, double Cgpa, int Age, string City, int Num, int Num2)
        {
            name = Name;
            cgpa = Cgpa;
            age = Age;
            city = City;
            num = Num;
            num2 = Num2;
            number = num +num2;

        }
        public string getInfo()
        {
            
            return ("Name of Candidate is: "+name +". Cgpa is: "+ cgpa +". Age of Candidate is: " +age+" "+". Candidate resides in "+city+ "Score of Candidate "+number );

        }
        public string cgpaEligibleCandidates(List<Candidate> l){
            int count2 = 0;
            Dictionary<string, double> cgpaNames = new Dictionary<string, double>();
            List<String> list2 = new List<string>();
            for ( count2 = 0; count2 < 2; count2++ )
            {
                cgpaNames.Add(l[count2].name,l[count2].cgpa);
            }
            foreach (KeyValuePair<string, double> z in cgpaNames)
            {
                if (z.Value >= 3)
                {
                    list2.Add(z.Key);

                }

            }
            Console.WriteLine("Candidates With 3 or more than 3 CGPA:");
            
            for (int j = 0; j < list2.Count; j++)
            {

              Console.WriteLine( list2[j]);
            }
            return "";
        }
        public string CandidateWith90(List<Candidate> l){
            int count2 = 0;
            Dictionary<string, double> projectPassedNames = new Dictionary<string, double>();
            List<String> list2 = new List<string>();
            for ( count2 = 0; count2 < 2; count2++ )
            {
                projectPassedNames.Add(l[count2].name,l[count2].number);
            }
            foreach (KeyValuePair<string, double> z in projectPassedNames)
            {
                if (z.Value > 180)
                {
                    list2.Add(z.Key);

                }

            }
            Console.WriteLine("Candidates With more than 90% MARKS:");
            for (int j = 0; j < list2.Count; j++)
            {

              Console.WriteLine( list2[j]);
            }
            return "";


        }
        public string CandidateWithCity(List<Candidate> l){
            int count2 = 0;
            Dictionary<string, string> cityCandidate = new Dictionary<string, string>();
            List<String> list3 = new List<string>();
            for ( count2 = 0; count2 < 2; count2++ )
            {
                cityCandidate.Add(l[count2].name,l[count2].city);
            }
            foreach (KeyValuePair<string, string> z in cityCandidate)
            {
                if (z.Value == "rawalpindi")
                {
                    list3.Add(z.Key);

                }

            }
            Console.WriteLine("Candidates With City Name RAWALPINDI:");
            for (int j = 0; j < list3.Count; j++)
            {

              Console.WriteLine( list3[j]);
            }
            return "";


        }
    class Program
    {
        static public void Main(string[] args)
        {
            List<Candidate> list = new List<Candidate>();
            
            
            int count = 0;
             
            while (count<2)
            {
                Console.Write("Enter your Name: ");
                string n = Console.ReadLine();
                Console.Write("Enter your CGPA: ");
                double c = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter your Age: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter your City: ");
                string cc = Console.ReadLine();
                Random rnd = new Random();
                int nm = rnd.Next(1,100);
                Random rnd2 = new Random();
                int nm2 = rnd.Next(1,100);

                Candidate x = new Candidate(n, c, a, cc,nm,nm2);
                Console.WriteLine(x.getInfo());
                count += 1;
                list.Add(x);
                
                //

            }
            Candidate y = new Candidate("",0.0,0,"",0,0);
            Console.WriteLine(y.cgpaEligibleCandidates(list)); 
            //Candidate z = new Candidate("",0.0,0,"",0,0);
            Console.WriteLine(y.CandidateWith90(list)); 
            Console.WriteLine(y.CandidateWithCity(list));
            Console.ReadLine();
        }
    }
}
}


            


        
    

