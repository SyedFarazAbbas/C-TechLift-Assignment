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
---------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Candidate
    {
        public string name;
        public int age;
        public double cgpa;
        public string city;
        public List<Document> list2;



    }
    class Document
    {
        public string docName;
        public string docPath;
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Candidate> list = new List<Candidate>();
            for (int z = 0; z < 2; z++)
            {
                List<Document> totalDoc = new List<Document>();
                Console.Write("Enter your Name: ");
                string n = Console.ReadLine();
                Console.Write("Enter your age: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter your CGPA: ");
                double c = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter your City: ");
                string ct = Console.ReadLine();
                Console.Write("How many Documents You want to add: ");
                int numberDocument = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < numberDocument; i++)
                {
                    Console.Write("Enter your Document Name: ");
                    string dName = Console.ReadLine();
                    Console.Write("Enter your Document Path: ");
                    string dP = Console.ReadLine();
                    Document D = new Document();
                    D.docName = dName;
                    D.docPath = dP;
                    totalDoc.Add(D);


                }
                Candidate C = new Candidate();
                C.name = n;
                C.age = a;
                C.cgpa = c;
                C.city = ct;
                C.list2 = totalDoc;
                list.Add(C);
                


            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("name: " + list[i].name);


                for (int j = 0; j < list[i].list2.Count; j++)
                {
                    Console.WriteLine(list[i].list2[j].docName);
                    Console.WriteLine(list[i].list2[j].docPath);
                }


            }
                
            
            //Dictionary<string, double> cgpaNames = new Dictionary<string, double>();
            List<String> listt = new List<string>();
            for ( int count = 0; count < list.Count; count++ )
            {
                if (list[count].cgpa >=3){
                    listt.Add(list[count].name);

                }
                
            }
            
            Console.WriteLine("Candidates With 3 or more than 3 CGPA:");
            
            for (int j = 0; j < listt.Count; j++)
            {

              Console.WriteLine(listt[j]);
            }
       
            Console.ReadLine();


        }
    }
}
---------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Candidate
    {
        public string name;
        public int age;
        public double cgpa;
        public string city;
        public List<Document> list2;



    }
    class Document
    {
        public string docName;
        public string docPath;
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Candidate> list = new List<Candidate>();
            for (int z = 0; z < 2; z++)
            {
                List<Document> totalDoc = new List<Document>();
                Console.Write("Enter your Name: ");
                string n = Console.ReadLine();
                Console.Write("Enter your age: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter your CGPA: ");
                double c = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter your City: ");
                string ct = Console.ReadLine();
                Console.Write("How many Documents You want to add: ");
                int numberDocument = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < numberDocument; i++)
                {
                    Console.Write("Enter your Document Name: ");
                    string dName = Console.ReadLine();
                    Console.Write("Enter your Document Path: ");
                    string dP = Console.ReadLine();
                    Document D = new Document();
                    D.docName = dName;
                    D.docPath = dP;
                    totalDoc.Add(D);


                }
                Candidate C = new Candidate();
                C.name = n;
                C.age = a;
                C.cgpa = c;
                C.city = ct;
                C.list2 = totalDoc;
                list.Add(C);
                


            }
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("name of Candidate: " + list[i].name);


                for (int j = 0; j < list[i].list2.Count; j++)
                {
                    Console.WriteLine("Document Name is: "+list[i].list2[j].docName);
                    Console.WriteLine("Document Path is: "+list[i].list2[j].docPath);
                }
                Console.WriteLine("-----------------------------");


            }
                
            
            //Dictionary<string, double> cgpaNames = new Dictionary<string, double>();
            List<String> listt = new List<string>();
            for ( int count = 0; count < list.Count; count++ )
            {
                if (list[count].cgpa >=3){
                    listt.Add(list[count].name);

                }
                
            }
            
            Console.WriteLine("Candidates With 3 or more than 3 CGPA:");
            
            for (int j = 0; j < listt.Count; j++)
            {

              Console.WriteLine(listt[j]);
            }
            Console.WriteLine("-----------------------------");
            List<string> listz = new List<string>();
            foreach (var item in listt)
            {
                Random rnd = new Random();
                int p1  = rnd.Next(90, 101);
                int p2  = rnd.Next(90, 101);
                int p = (p1+ p2)/2;
                if (p>=90){
                    listz.Add(item);

                }


            }
            Console.WriteLine("Candidates with 90: ");
            foreach (var item2 in listz)
            {
                Console.WriteLine(item2);
                
            }
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Candidates with Lahore: ");
            List<string> listzz = new List<string>();
            for (int s = 0; s < list.Count; s++)
            {
                if(list[s].city=="lhr"){
                    listzz.Add(list[s].name);


                }
                
            }
            foreach (var item4 in listzz)
            {
                Console.WriteLine(item4);
                
            }
            Console.WriteLine("-----------------------------");
       
            Console.ReadLine();


        }
    }
}


            


        
    

