using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
//create a class student accept the 3 subj marks & calculate total & percentage


namespace ConsoleApp2
{
    internal class Program
    {
        public class student
        {
            private string mar;
            private string hin;
            private string eng;
            private string total;
            

            public student()
            {
                mar = "20";
                hin = "30";
                eng = "50";

                total = mar + hin + eng;
            }
            
            public student(string mar, string hin, string eng, string total)
            {
                this.mar = mar;
                this.hin = hin;
                this.eng = eng;
                this.total = total;
                
            }

        
            

            public string Print()
            {
                return $"{mar}-> {hin} -> {eng}";
            }

            static void Main(string[] args)
            {
                student p1 = new student();
                Console.WriteLine(p1.Print());
                 
                    student p2 = new student("20", "30","50","total");
                
                Console.WriteLine(p2.Print());


            }
        }
    }
}
