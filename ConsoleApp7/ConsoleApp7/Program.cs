using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace x
{
        class P
        {
            static void Main(string[] args)
            {
             string myString = "Arçelik Bir Dünya Devi";
             string finalstring="";
            for(int i=0; i <myString.Length;i++)
            {
                
                 if (!myString[i].Equals(" "))
                 {
                    finalstring += myString[i];
                    

                }
                 else
                 {
                    Console.Write(finalstring);
                    finalstring = " ";


                }
                 
             }
             
          
            Console.ReadLine();
        }
        }
    }


