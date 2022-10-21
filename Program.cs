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
----------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Candidate // Defining Candidate Class.
    {
        public string name; // Attribute
        public int age;  // Attribute
        public double cgpa;  // Attribute
        public string city;  // Attribute
        public int docnumber;  // Attribute
        public List<Document> list2;  // Attribute
         


    }
    class Document // Defining Document Class.
    {
        public string docName;  // Attribute
        public string docPath;  // Attribute
    }
    

    
    class Program // Main Class
    {
        static void Main(string[] args)
        {
            List<Candidate> list = new List<Candidate>(); // Using Data Structure. Customerized Data Structure.
            Dictionary<string, int> DD = new Dictionary<string, int>(); // Creating Dictionary.

                  //------------------------------------------ TASK 1 --------------------------------------------//

            Console.WriteLine("Time Complexity of Task 1 is O(n**2)");
            Console.WriteLine();
            Console.WriteLine("                                       --> Welocme to Registration Form <--                      ");
            Console.WriteLine("                                   Fill up this form with Correct Inforamtion.                   ");
            Console.WriteLine("                                  ---------------------------------------------                  ");
            for (int z = 0; z < 3; z++) // Task 1. Taking 15 values from User.
            {
                List<Document> totalDoc = new List<Document>(); // Customized Data Structure. 
                
                Console.Write("Enter your Name: ");
                string n = Console.ReadLine();
                Console.Write("Enter your age: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter your CGPA: ");
                double c = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter your City: ");
                string ct = Console.ReadLine();
                Console.Write("How many Documents You want to add: ");
                int numberDocument = Convert.ToInt32(Console.ReadLine()); // Total Number of Documents User want to add. 
                for (int i = 0; i < numberDocument; i++)
                {
                    Console.Write("Enter your Document Name: ");
                    string dName = Console.ReadLine();
                    Console.Write("Enter your Document Path: ");
                    string dP = Console.ReadLine();
                    Document D = new Document(); // Creating Document Class.
                    D.docName = dName; // Assignment
                    D.docPath = dP; // Assignment.
                    totalDoc.Add(D);


                }
                Candidate C = new Candidate(); // Creating Candidate class Object. 
                C.name = n; // Assignment
                C.age = a;  // Assignment
                C.cgpa = c;  // Assignment
                C.city = ct;  // Assignment
                C.docnumber = numberDocument;  // Assignment
                C.list2 = totalDoc;  // Assignment
                list.Add(C);
                Console.WriteLine(); // 



            }
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < list.Count; i++) // For loop to display Candidate basic info and Number of Documents  
            {
                Console.WriteLine("name of Candidate: " + list[i].name);
                Console.WriteLine("Number Of Documents Given by Candidate is: " + list[i].docnumber);


                for (int j = 0; j < list[i].list2.Count; j++)
                {
                    Console.WriteLine("Document Name is: " + list[i].list2[j].docName); // Display Document name.
                    Console.WriteLine("Document Path is: " + list[i].list2[j].docPath); // Display Document Path.
                }
                Console.WriteLine("-----------------------------");


            }


            //Dictionary<string, double> cgpaNames = new Dictionary<string, double>();

            //------------------------------------------ TASK 2 --------------------------------------------//


            Console.WriteLine("Time Complexity of Task 2 is O(n)");
            Console.WriteLine();
            List<String> listt = new List<string>(); // Creating List of Candidates with 3 or more than 3 cgpa.
            for (int count = 0; count < list.Count; count++) // Task 2. 
            {
                if (list[count].cgpa >= 3)
                {
                    listt.Add(list[count].name);

                }

            }

            Console.WriteLine("Candidates With 3 or more than 3 CGPA:");

            for (int j = 0; j < listt.Count; j++)
            {

                Console.WriteLine("Candidate no. "+(j+1)+": "+listt[j]);
            }
            Console.WriteLine("-----------------------------");

            //------------------------------------------ TASK 3 --------------------------------------------//

            Console.WriteLine("Time Complexity of Task 3 is O(n)");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine();
            Console.WriteLine();
            List<string> listz = new List<string>(); // Definig list.
            Random rnd = new Random(); // Creating object of random class.
            for (int y =0; y<listt.Count; y++) // Task 3
            {
                
                int p1 = rnd.Next(1, 101);
                int p2 = rnd.Next(1, 101);
                int p = (p1 + p2) / 2;
                if (p >= 90)
                {
                    DD.Add(listt[y], p);     //  Adding in Dictionary.
                    listz.Add(listt[y]);     // Adding in the list.


                }


            }

            //------------------------------------------ TASK 4 --------------------------------------------//

            Console.WriteLine("Time Complexity of Task 4 is O(n)");
            Console.WriteLine();
            Console.WriteLine("Candidates with 90% or more than 90% marks: "); // task 4. 
            int nm = 1;
            foreach (var item2 in listz)
            {

                Console.WriteLine("Candidate "+nm+":"+item2);
                nm += 1;

            }
            Console.WriteLine("-----------------------------");

            //------------------------------------------ TASK 5 --------------------------------------------///// 

            Console.WriteLine("Time Complexity of Task 5 is O(n)");
            Console.WriteLine();
            Console.WriteLine("Candidates with City Lahore are: "); // Task 5.
            List<string> listzz = new List<string>(); // New List creation.
            for (int s = 0; s < list.Count; s++)
            {
                if (list[s].city == "lhr")
                {
                    listzz.Add(list[s].name); // Adding Names in list.


                }

            }
            int nn = 1;
            foreach (var item4 in listzz)
            {
                Console.WriteLine("Candidate " + nn + ":" + item4); // Printing names of candidates with city lahore.
                nn += 1;
            }
            Console.WriteLine("-----------------------------");
            Console.WriteLine();

            //------------------------------------------ TASK 6  --------------------------------------------//

            Console.WriteLine("Time Complexity of Task 6 is O(n)");
            Console.WriteLine();
            Console.WriteLine("Candidates on ascending order.");
            Console.WriteLine("Sorted List of Candidates is: "); // Task 6.
            var newDict = from set in DD orderby set.Value ascending select set; // On the ASCENDING BASIS.
            foreach(KeyValuePair<string, int> set in newDict){
               
                Console.WriteLine("{0}:{1}",set.Key, set.Value); // will Display in ascending Order.

            }


                Console.ReadLine();


        }
    }
}
-----
css
 *{
    margin:0;
    padding:0;
}
.wrapper{
    font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
    /*border:2px solid black;*/
    margin: 0px auto;
    max-width:1000px;
    height:550vh;
}
.wrapper header{
    display:flex;
    align-items:center;
    justify-content:space-between;
}
.wrapper header .logo a img{
    height:40px;
    border-radius:50%;
    margin-left: 20px;
    margin-top: 18px;
}
.wrapper header nav{
    margin-right:20px;
    
}
.wrapper header nav ul{
    display:flex;
}
.wrapper header nav ul li{
    list-style:none;
    margin-left:20px;
}
.wrapper header nav ul li a{
    text-decoration:none;
    color:black;
    
    font-size:20px;
}
.wrapper header nav ul li a:hover{
    color:lightblue;
}
.wrapper main .banner{
    margin-top:30px;
}
.wrapper main .banner img{
    max-width:1000px;

}
.wrapper main .info{
    margin-top:40px;
    text-align:center;
}
.wrapper main .info p{
    padding-left:120px;
    padding-right:120px;
}
.wrapper main .info a{
    color:white;
    text-decoration:none;
    background-color:blue;
    padding:10px 17px;
    border-radius:10px;
    
}
.wrapper main .person{
    display:flex;
    align-items:center;
    justify-content:center;
    margin-top:50px;
    text-align:center;
}

.wrapper main .person .same{
    height:300px;
    width:200px;
    border:2px solid black;
    margin-left:20px;
    box-shadow:0px 0px 20px grey;
    border-radius:10px;

}
.wrapper main .person .same:hover{
    background-color:grey;
}
.wrapper main .person .same img{
    margin: 10px 15px;


}
.wrapper main .projects{
    margin-top:60px;
    text-align:center;
}
.wrapper main .projects p{
    margin-top:10px;
}
.wrapper main .projects .pics{
    margin-top:30px;
    height:410px;
    /*border:2px solid black;*/
}
.wrapper main .projects .pics .sameas{
    width:240px;
    height:180px;
    /*border:2px solid green;*/
    float:left;
    margin:5px 0px 5px 5px;
}
.wrapper main .projects .pics .sameas img{
    max-width:240px;
}
.wrapper main .projects a{
    
    color:white;
    text-decoration:none;
    background-color:blue;
    padding:10px 17px;
    border-radius:10px;
    

}
.wrapper main .table{
    margin-top:30px;
    
}
.wrapper main .table p{
    margin-top:20px;
}
.wrapper main .table table{
    text-align:center;
    width:1000px;
    height:500px;
    /*border:2px solid red;*/
    border-collapse:collapse;
}
.wrapper main .table table td,th{
    border-bottom:2px solid grey;
}
.wrapper main .form {
    
    text-align:center;
    height:800px;
    max-width:380px;
    margin:30px auto;
    /*border:2px solid grey;*/
    
}
.wrapper main .form form{
    text-align:left;
}
.wrapper main .form form textarea{
    resize:none;
    height:100px;
    width: 385px;
    border-radius: 6px;
    margin-top:12px;
}
.wrapper main .form form label{
    font-weight:bold;
    
}
.wrapper main .form form .input{
    height:35px;
    width: 385px;
    border-radius: 6px;
    margin-top:12px;
}
.wrapper main .form form .about .input{
    height:120px;
    width: 385px;
    border-radius: 6px;

}
.wrapper main .form form select{
    height:40px;
    width: 390px;
    border-radius: 6px;

}
.wrapper main .form form .f{
    margin-top: 30px;
}
.wrapper main .form form .button button{
    height: 40px;
    margin-top:15px;
    width: 100px;
    background-color:green;
    color:white;
    border-radius:10px;
}
.wrapper footer{
    height:500px;
    width:1000px;
    /*border:2px solid red;*/
    display:flex;
    background-color:aliceblue;
}
.wrapper footer .firsthalf{
    width:50%;
    /*border: 2px solid green;*/
    text-align:center;
}
.wrapper footer .secondhalf{
    width:50%;
    /*border: 2px solid green;*/
}
.wrapper footer .firsthalf img{
    max-width:80%;
}
.wrapper footer .secondhalf form .f{
    margin-top: 30px;
    

}
.wrapper footer .secondhalf form label{
    font-weight:bold;
}
.wrapper footer .secondhalf form .f input {
    height:30px;
    width: 385px;
    border-radius: 6px;
    

}
.wrapper footer .secondhalf form .button button{
    
    height: 40px;
    margin-top:15px;
    width: 100px;
    background-color:blue;
    color:white;
    border-radius:10px;

}
.wrapper footer .secondhalf form .ff textarea{
    resize:none;
     height:100px;
    width: 385px;
    border-radius: 6px;
    box-shadow:0px 0px 10px grey;

}
---
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Assignment</title>
    <link rel="stylesheet" type="text/css" href="StyleSheet1.css" />

</head>
<body>
    <div class="wrapper">
        <header>
            <div class="logo">
                <a href="#"><img src="qq.jpg" alt="logo" /></a> 
                

            </div>
            <nav>
                <ul>
                    <li> <a href="#">Home</a> </li>
                    <li> <a href="#">My Work</a> </li>
                    <li> <a href="#">About Me</a> </li>
                    <li> <a href="#">Contact Us</a> </li>
                </ul>
            </nav>
        </header>
        <main>
            <div class="banner">
                <img src="banner.png" />
            </div>
            <div class="info">
                <h2>Heading Text</h2>
                <p>My name is Syed Faraz Abbas. I am making assignment on HTML CSS.My name is Syed Faraz Abbas. I am making assignment on HTML CSS.My name is Syed Faraz Abbas. I am making assignment on HTML CSS.My name is Syed Faraz Abbas. I am making assignment on HTML CSS. My name is Syed Faraz Abbas. I am making assignment on HTML CSS. </p>
                <br />
                <a href="#">Explore</a>
            </div>
            <div class="person">
                <div class="same">
                    <div class="personLogo">
                        <img  src="person.png"/>
                        <h3>Faraz</h3>
                        <label> <span style="font-weight:bold;">Investment:</span> $100</label><br />
                        <label><span style="font-weight:bold;">Projects:</span> 20 global</label><br />
                        <label><span style="font-weight:bold;">Status:</span> Available</label>

                    </div>
                </div>
                <div class="same">
                    <div class="personLogo">
                        <img src="person.png" />
                        <h3>Abbas</h3>
                        <label><span style="font-weight:bold;">Investment:</span> $100</label> <br />
                        <label><span style="font-weight:bold;">Projects:</span> 20 global</label><br />
                        <label><span style="font-weight:bold;">Status:</span> Available</label>  
                        
                    </div>
                </div>
                <div class="same">
                    <div class="personLogo">
                        <img src="person.png" />
                        <h3>Iqbal</h3> 
                        <label><span style="font-weight:bold;">Investment:</span> $100</label><br />
                        <label><span style="font-weight:bold;">Projects:</span> 20 global</label><br />
                        <label><span style="font-weight:bold;">Status:</span> Available</label>


                    </div>
                </div>
                <div class="same">
                    <div class="personLogo">
                        <img src="person.png" />
                        <h3>Zaidi</h3>
                        <label><span style="font-weight:bold;">Investment:</span> $100</label><br />
                        <label><span style="font-weight:bold;">Projects:</span>20 global</label><br />
                        <label><span style="font-weight:bold;">Status:</span> Available</label>

                    </div>
                </div>

            </div>
            <div class="projects">
                <h2>Global Projects</h2>
                <p>My name is Syed Faraz Abbas. I am making assignment on HTML CSS.My name is Syed Faraz Abbas</p>
                <div class="pics">
                    <div class="sameas"><img src="qq.jpg"/></div>
                    <div class="sameas"><img src="qq.jpg" /></div>
                    <div class="sameas"><img src="qq.jpg" /></div>
                    <div class="sameas"><img src="qq.jpg" /></div>
                    <div class="sameas"><img src="qq.jpg" /></div>
                    <div class="sameas"><img src="qq.jpg" /></div>
                    <div class="sameas"><img src="qq.jpg" /></div>
                    <div class="sameas"><img src="qq.jpg" /></div>

                </div>

                <a href="#">See All Projects</a>

            </div>
            <div class="table">
                <h2>List of Contractors</h2>
                <p>My name is Syed Faraz Abbas. I am making assignment on HTML CSS.My name is Syed Faraz Abbas</p>
                <table>
                    <tr>
                        <th>ID</th>
                        <th>Name</th>
                        <th>Description</th>
                        <th>Status</th>
                        <th>Start Date</th>
                        <th>End Date</th>
                       
                    </tr>
                   
                    <tr>
                        <td>#001</td>
                        <td>Ahmed Rauf</td>
                        <td>My name is Ahmed.</td>
                        <td>Active</td>
                        <td>/06/2022/td>
                        <td>6/09/2022</td>

                    </tr>
                    <tr>
                        <td>#001</td>
                        <td>Ahmed Rauf</td>
                        <td>My name is Ahmed.</td>
                        <td>Active</td>
                        <td>06/2022/td>
                        <td>6/09/2022</td>

                    </tr>
                    <tr>
                        <td>#001</td>
                        <td>Ahmed Rauf</td>
                        <td>My name is Ahmed.</td>
                        <td>Active</td>
                        <td>06/2022/td>
                        <td>6/09/2022</td>

                    </tr>
                    <tr>
                        <td>#001</td>
                        <td>Ahmed Rauf</td>
                        <td>My name is Ahmed.</td>
                        <td>Active</td>
                        <td><206/2022/td>
                        <td>6/09/2022</td>

                    </tr>
                </table>

            </div>
            <div class="form">
                <h2>Fill your Interest</h2><br />
                <p>My name is Syed Faraz Abbas. Doing My Assignment.</p><br />
                <form>
                    <div class="f">
                        <label>Name</label><br />
                        <input class="input" type="text" />

                    </div>
                    <div class="f">
                        <label>Email</label><br />
                        <input class="input" type="text" />

                    </div>
                    <div class="f">
                        <label>DOB</label><br />
                        <input class="input" type="date" />

                    </div>
                    <div class="f">
                        <label >Select Your Interest</label><br />
                        <select >
                            <option value="volvo">Tourism</option>
                            <option value="saab">Cars</option>
                            <option value="opel">Bikes</option>
                            <option value="audi">Audi</option>
                        </select>

                    </div>
                    <br />
                    
                    <div class="ff">
                        
                        <input type="radio" name="name"/> <label>Individual</label>
                        <input type="radio" name="name" /> <label>Organization</label>

                    </div><br />
                    <div class="about">
                        <label>About you</label><br />
                        <textarea>

                        </textarea>

                    </div>
                    <div class="button">
                        <button>Send Details</button>

                    </div>
                       
                    
                </form>
            </div>
            
        </main>
        <footer>
            <div class="firsthalf">
                <h2>Contact Us</h2>
                <p>My Name is Syed Faraz Abbas. Contact Me.</p><br /><
                <img  src="map.png"/>
                
            </div>
            <div class="secondhalf">
                <form>
                    <div class="f">
                        <label>Name</label><br />
                        <input class="input" type="text" />

                    </div>
                    <div class="f">
                        <label>Email</label><br />
                        <input class="input" type="text" />

                    </div>
                    <div class="ff">
                        <label>Message</label><br />
                        <textarea>

                        </textarea>

                    </div><br />
                    <input class="check" type="checkbox"/> <label>Send me NewsLetter </label>
                    <div class="button"><br />
                        <button>Send Details</button>

                    </div>

                </form>

            </div>
        </footer>
    </div>


</body>
</html>




            


        
    

