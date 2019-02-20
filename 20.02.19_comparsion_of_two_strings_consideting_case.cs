using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

    public static class Program 
    {
        public static void Main(string[] args) 
        {
           Console.WriteLine("Please enter the first line:");
           string ln1 = Console.ReadLine();
           Console.WriteLine("Please enter the second line:\n");
           string ln2 = Console.ReadLine();
           
           YesOrNo:
           Console.WriteLine("If you want a case-sensitive comparsion, please enter \"y\". \nIf else, please enter \"n\" \n");
           string yn = Console.ReadLine();
           if (yn == "y" || yn == "n") {} 
           else {Console.WriteLine("Please enter only eather \"y\" or \"n\"! Now please lets try to deside again:"); goto YesOrNo;}
           
           
           
           if(CompareStr(ln1, ln2, yn)) {Console.WriteLine("identical");}
           else {Console.WriteLine("Not identical");}
        }
        
            static bool CompareStr(string ln1, string ln2, string yn) 
            {
                bool rez =true;
                if (yn == "y") {rez = ln1.Equals(ln2);}
                else {rez = ln1.Equals(ln2, StringComparison.OrdinalIgnoreCase);}
                return rez;
            }
            
            
        
    }
}