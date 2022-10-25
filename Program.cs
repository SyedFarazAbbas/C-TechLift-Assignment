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
-----------------
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
</head>
<body>
    <input onkeyup="myCalculate()" type="text" id="fname" placeholder="" />
    <p id="p1"></p>
    <p id="p2"></p>
    <p id="p3"></p>
    <p id="p4"></p>
    <script>
        function myCalculate() {
            var x = document.getElementById("fname").value;
            if (x <= 600000) {
                document.getElementById("p1").innerHTML = x/12;
                document.getElementById("p2").innerHTML = 0;
                document.getElementById("p3").innerHTML = x;
                document.getElementById("p4").innerHTML = 0;

            }
            else if (1200000 > x > 600000) {
                var xx = x - 600000;
                var tax = xx * 2.5;
                var yearly = x - tax;
                document.getElementById("p1").innerHTML =  tax/12;
                document.getElementById("p2").innerHTML = (yearly/12)- tax/12;
                document.getElementById("p3").innerHTML = tax;
                document.getElementById("p4").innerHTML = yearly;


            }

        }
    </script>

</body>
</html>
------------------
*{
    margin:0;
    padding:0;
}
.m{
    background-color:aqua;
    height:150px;
    width:40%;
     border:2px solid purple;

}
.m input{
    margin-top:10px;
    margin-left:30px;
    height:27px;
    width:90%;
    border:2px solid white;
   

}
.m #b1{
    background-color:blue;
    color:white;
    height:30px;
    width:70px;
    border-radius:3px;
    border:2px solid blue;
        margin-top:10px;
         margin-left:30px;
}
.m #b2{
    background-color:red;
    color:white;
    height:30px;
    width:70px;
        border-radius:3px;
    border:2px solid red;
        margin-top:10px;
         margin-left:10px;
}
----
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
    <link href="StyleSheet1.css" rel="stylesheet" />
    <style>
        .cont {
            position: relative;
            margin: 5vh;
        }

        .cont2 {
            position: absolute;
            top: 0;
            text-align: center;
            padding-top: 17vh;
        }

            .cont2 p {
                padding: 0px 200px;
            }

        .cont img {
            width: 100%;
        }

        .l {
            padding: 0px 200px;
        }

        button {
            margin-left: 97vh;
            height: 40px;
            width: 130px;
            background-color: green;
            color: white;
            border: 2px solid white;
            border-radius: 5px;
        }

            button:hover {
                background-color: black;
                color: lightgreen;
            }

            button:active {
                background-color: green;
                color: white;
            }

        .main {
            /*border: 2px solid black;*/
            margin: 150px 0px 550px 550px;
            margin-bottom: 3px;
        }

        .x {
            height: 20px;
            width: 300px;
        }
        /*.formAbout input{
                height:100px;
                width:300px;

            }*/
        .form {
            margin-top: 10px;
        }

        label {
            font-weight: bold;
        }

        .b {
            margin-left: 83vh;
            height: 40px;
            width: 100px;
            background-color: green;
            color: white;
            border: 2px solid white;
            border-radius: 5px;
        }

            .b:hover {
                background-color: black;
                color: lightgreen;
            }

            .b:active {
                background-color: green;
                color: white;
            }

        .z {
            margin: 0;
            padding: 0;
        }

        select {
            height: 25px;
            width: 310px;
        }
    </style>

</head>
<body>
    <!-- Question no. 1 -->
    <!-- <h1 > Syed Faraz Abbas</h1 > <p id="hide" > My name is Syed Faraz Abbas.</p > <button onclick="myFunction()" > Click me!</button > <script > function myFunction() {
        document .getElementById('hide').style.display = 'none';
    }

    </script >-->
    <!-- Question no. 2 -->
    <!-- <h1 > Changing of Picture.</h1 > <img id="img" src="icon.png" / > <button onclick="myPic()" > Click me</button > <script > function myPic() {
        document .getElementById("img").src = "map.png";
    }

    </script >-->
    <!-- Question no.3 -->
    <!-- <h1 > Changing Text</h1 > <p id="pp" > Syed Faraz Abbas</p > <button onclick="myP()" > Change text</button > <script > function myP() {
        document .getElementById("pp").innerHTML = "Ibtisam";
    }

    </script >-->
    <!-- Question no.4 -->
    <!-- <h1 > Alert</h1 > <p > Program to show alert </p > <button onclick="aalert()" > Click me!!</button > <script > function aalert() {
        alert("Error!!!!");
    }

    </script >-->
    <!-- Question No.5 -->
    <!-- <h1 > Changing text on button</h1 > <p id="text" > Syed Faraz Abbas</p > <button onclick="change()" > click me!!</button > <script > function change() {
        if (document.getElementById("text").innerHTML == "Syed Faraz Abbas");

    {
        document .getElementById("text").innerHTML = "Syed Dabeer Hussain Shah";
    }

    else {
        document .getElementById("text").innerHTML = "Syed Faraz Abbas";
    }

    }

    </script >-->
    <!-- Question No.7 -->
    <!-- <div class="m" > <input id="i" value="0" / > <button id="b1" onclick="first()" > Add</button > <button id="b2" onclick="second()" > Subtract</button > </div > <script > var num = 0; function first() {
        var num1 = document.getElementById("i") num = num + 1;
        num1 .value = num;
    }

    function second() {
        var num1 = document.getElementById("i");
        num = num - 1;
        num1 .value = num;
    }

    </script >-->
    <!-- Question no.8 -->
    <!-- <div class="a" > <label > First Name</label > <input id="fName" placeholder="First Name"/ > <br / > <label > Second Name</label > <input id="lName" placeholder="Second Name" / > <br / > <label > Name Format</label > <select id="s1" > <option value="1" > first name, last name</option > <option value="2" > last name, first name</option > </select > <br / > <button onclick="myName()" > Formated Name</button > <p > formated name <strong id="s" > </strong > </p > </div > <script > function myName() {
        var firstName = document.getElementById("fName").value;
        var lastName = document.getElementById("lName").value;
        if (document.getElementById("s1").value == "fName");

    {
        var Name = firstName + " " + lastName;
    }

    else {
        var Name = lastName + " " + firstName;
    }

    document.getElementById("s").innerHTML = Name;
    }

    </script >-->
    <!-- Question no.12 -->
    <!-- <label > User Name</label > <input id="naam" / > <label > Password</label > <input id="p" / > <button onclick="chec()" > Login</button > <script > function chec() {
        var count = 0;
        var n = document.getElementById("naam").value;
        var pp = document.getElementById("p").value;
        const a = [ "faraz", 123, "abbas", 321, "ibi", 456 ];
        for (var i = 0; i < a.length; i++);

    {
        if (a[i] == n);

    {
        if (a[i+1] == pp);

    {
        window .open("https://www.w3schools.com");
        break;
    }

    }

    count + = 1; if (count == 3) {
        alert("Errors");
    }

    }
    }


    </script >-->
    <!-- Question no. 9 -->
    <!-- <label > Text</label > <textarea id="text" > </textarea > <button onclick="counnter()" > Counter</button > <p id="cc" > </p > <script > function counnter() {
        var t = document.getElementById("text").value;
        var c = 0;
        for (var i = 0; i < t.length; i++);

    {
        if (t[i] != " ");

    {
        c += 1;
    }

    }
    document.getElementById("cc").innerHTML = c;
    }

    </script >-->
    <div class="main">
        <div class="formBasic">
            <h1 style="font-family:calibri">Fill your interests</h1><br />
            <p>This is a form you want to fill up if you want to be registered.</p><br />
            <small id="s1"></small>
        </div>
        <div class="form">
            <label>Name</label><br />
            <input id="xx" class="x" type="text" value="Write your Name" />
            <small id="s2"></small>
        </div>
        <div class="form">
            <label>Email</label><br />
            <input id="x2" class="x" type="text" value="Write your Email" />
            <small id="s3"></small>
        </div>
        <div class="form">
            <label>DOB</label><br />
            <input id="x3" class="x" type="date" value="Write your DOB" />
        </div>
        <div class="form">
            <label>Select your Interest</label><br />
            <!--<input class="x" type="text" value="Select" />-->
            <select id="cars">
                <option value="1">Engineering</option>
                <option value="2">Medical</option>

            </select>
        </div>
        <br />
        <div style="" class="z">

            <input style="" type="radio" name="w"> Individual
            <input type="radio" name="w"> Oganization

        </div><br />


        <label>About you</label><br />
        <textarea style="width:310px;max-width:310px;resize:none; height:170px;"></textarea>



    </div>
    <button onclick="checc()" class="b">Send Details</button>
    <script>
        function chec() {
            var n = document.getElementById("xx").value;

            var e = document.getElementById("x2").value;
            if (n == "") {
                document.getElementById("s1").innerHTML = "Name cannot be empyited";

            }
        }

    </script>
-----------------
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Assignment No. 1</title>
    <style>
        .cont{
            position:relative;
            margin:5vh;
        }
        .cont2{
            position:absolute;
            top:0;
            text-align:center;
            padding-top:17vh;
            

        }
        .cont2 p{
           padding: 0px 200px;

        }
        .cont img{
            width:100%;
        }
        .l{
            padding: 0px 200px;

        }
        button{
            margin-left:97vh;
            height: 40px;
            width: 100px;
            background-color:green;
            color:white;
            border: 2px solid white;
            border-radius: 5px;
        }
        button:hover{
            background-color:black;
            color:lightgreen;
        }
        button:active{
            background-color:green;
            color:white;

        }
        .main{
            /*border: 2px solid black;*/
            margin: 150px 0px 550px 550px;
            margin-bottom: 3px;
        }
        .x {
            height:20px;
            width:300px;
        }
        /*.formAbout input{
            height:100px;
            width:300px;
            
        }*/
        .form{
            margin-top:10px;

        }
        label{
            font-weight:bold;
        }
        .b{
            margin-left:83vh;
            height: 40px;
            width: 100px;
            background-color:green;
            color:white;
            border: 2px solid white;
            border-radius: 5px;
        }
        .b:hover{
            background-color:black;
            color:lightgreen;
        }
        .b:active {
                background-color: green;
                color: white;
            }
        .z{
            margin:0;
            padding:0;
        }
        select{
           height:25px;
           width:310px;


        }
    </style>
</head>
<body>
    <div class="cont">
        <img src="q.jpg" />
        <div class="cont2">
            <h1 style="font-family:Calibri">My Country</h1> 
            <p style="font-family:Calibri">
                My name is Syed Faraz Abbas. This is my First Assignment on HTML CSS in CureMD. Ihope to learn more from here. Hopefully, When bootcamp will be completed, I shall be ful stack developer. This is just a design without any responsiveness included.
            </p>
        </div>
    </div>
    <h2 style="text-align:center;font-family:Calibri; margin-top:0">Heading text</h2>
    <p class="l" style="text-align:center;font-family:Calibri">HTML is Markup Language. It is used for Web Development purposes. It doesnot like any other programming language. CSS is cascading Style Sheet. It is used to fill beautify website with your custom design </p>
    <button>Explore</button>
    <div class="main">
        <div class="formBasic">
            <h1 style="font-family:calibri">Fill your interests</h1>
            <p>This is a form you want to fill up if you want to be registered.</p>
        </div>
        <div class="form">
            <label>Name</label><br />
            <input class="x"  type="text" value="Write your Name" />
        </div>
        <div class="form">
            <label>Email</label><br />
            <input class="x" type="text" value="Write your Email" />
        </div>
        <div class="form">
            <label>DOB</label><br />
            <input class="x" type="date" value="Write your DOB" />
        </div>
        <div class="form">
            <label>Select your Interest</label><br />
            <!--<input class="x" type="text" value="Select" />-->
            <select id="cars">
                <option value=""></option>
                <option value="volvo">Volvo</option>
                <option value="saab">Saab</option>
                <option value="opel">Opel</option>
                <option value="audi">Audi</option>
            </select>
        </div>
        <div style="" class="z">
       
            <input style="" type="radio" name="w"> Individual 
            <input type="radio" name="w"> Oganization

        </div>
        
        
            <label>About you</label><br />
            <textarea style="width:310px;max-width:310px;">
                
            </textarea>
    
        
        
    </div>
    <button class="b">Send Details</button>
    
    
    

</body>
</html>
----------------------------






            


        
    

