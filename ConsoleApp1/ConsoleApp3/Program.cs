using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Data types in C#

            string name = "Niti Dwivedi";
            System.String topic = "CSharp";


            uint id = 110;

            decimal basicSalary = 34000.00m; // 16 bytes
            float hra = 2000.00f; // 4 bytes
            double netSalary = 36000.00; //8 bytes

            bool constraint = false;

            DateTime joiningDate = DateTime.Now;




            /*   Console.WriteLine("Your data is entered :");
               Console.WriteLine("Name : " + name);

               Console.WriteLine("Topic : " + topic);

               Console.WriteLine("Age : " + age);

               Console.WriteLine("constraint : " + constraint);

               Console.WriteLine("Joining Date : " + joiningDate);


             Console.WriteLine("Name : {0}, topic:{1}, age:{2}, basicSalary: {3}" ,name ,topic,age,basicSalary); */


            /* Console.WriteLine("Enter your details :");
             Console.WriteLine("Enter your name :");
             name =  Console.ReadLine();

             Console.WriteLine("Your Name is : " + name);

             Console.WriteLine("Enter your Age :");
             int age = Console.ReadLine();

 */



            /* byte a = 126;

             Console.WriteLine(a);

             a++;

             Console.WriteLine(a);

             a++;

             Console.WriteLine(a);*/


            double number1 = 3.14;
            int wholenumber = (int)number1; //Explicit casting


            int x = 5; // declaration as well as initializing
            int y; // declaration

            y = ++x;

            Console.WriteLine("Pre Increment");
            Console.WriteLine("The value of x :" + x);
            Console.WriteLine("The value of y :" + y);


            x = 5;


            y = x++;

            Console.WriteLine("Pre Increment");
            Console.WriteLine("The value of x :" + x);
            Console.WriteLine("The value of y :" + y);



            y = 10;
            y = 20;

            y = x++;

            y = ++x;





        }


    }
}

Day - 1 Notes

Applications :   Console , windows, MVC, ASP.Net , Web API

C#.net ---  it contains all the features of C++ , VB.Net , Java as well as some additional features. 

Simple
Secure
Robust
Portable
Platform independent 
Multithreaded ,
OOPS

Strong Type

Before dot net framework

COM Framework : Component Object Model, VB language 

Drawback was :
	1) It will not support all the features of OOPs
	2) Platform dependent  ---  can run on only windows OS

NET stands for Network Enabled Technology . --- .Net  --- The oo programming through which we can implement internet based applications

Cross-platform , free, opensource ( C# , VB.Net )

Editors: VS, VS code editor, OmniSharp, JetBrains Rider etc..Framework : is a collection of many small technologies integrated together to develop applications that can be executed anywhere.

What .Net Framework provides :

	1.BCL(Base Class Libraries)--  designed by Microsoft   
	2. CLR ( Common Language Runtime) - responsible for converting the MSIL ( Microsoft Intermediate Language 

SC --- > IL  ----> (JIT) CLR ----> ML

C#   VB ( Source Code)  == > Language Compiler  ---- > MSIL/IL/Managed Code --- > CLR ( JIT)  -----> Native Code   -----> Execute


What is JIT ? 

It is the component of CLR that is responsible for converting MSIL code into NATIVE Code . Native code is code that is directly 
Understandable by the OS

.Net Framework : available in three different flavours :

	1. .Net Framework-- - Windows

    2. .Net-- - > .Net Core-- Linux, macOS
	3. Xamarin/Mono  - Mobile OS




Installations :

First we need to install SDK -

	1. Create a dir and get inside that folder or dir
	2. Dotnet new console(it will create a project with the same name of your folder name)

    3.Dotnet build-- - > To create a dll file  ( IL)
	4. Dotnet run  --- To execute your dotnet project

Or 

	1. Dotnet new console - o < projectname >
    2.Cd < projectname >
    3.Dotnet build
	4. Dotnet run
	

IDE's

	1) Visual Studio 2022 ( Community Version)
	2) Visual Studio Code 
	Extensions to add 
		
		C#
		.Net install tool
		C#Dev Kit
		

Data Types in C#




Library  :

Is a set of predefined classes  -- >  some methods 


• Use PascalCase for class names and method names.
• Use camelCase for method parameters and local variables.
• Use PascalCase for constant names, both fields and local constants.

From <https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/identifier-names> 


Write a program to calculate an area of a rectangle.

























