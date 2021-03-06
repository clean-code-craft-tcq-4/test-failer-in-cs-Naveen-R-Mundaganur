using System;
using System.Diagnostics;

namespace TshirtSpace 
{
    class Tshirt 
    {
        static string Size(int cms) 
        {           
                if(cms>0)
                {
                    if(cms < 38) 
                    {
                        return "S";
                    } 
                    else if(cms > 38 && cms < 42) 
                    {
                        return "M";
                    } 
                    else 
                    {
                        return "L";
                    }
                }
                else
                {
                    return "Invalid Choice";
                }            
        }
        static void Main(string[] args) 
        {
            Debug.Assert(Size(38) == "S");
            Debug.Assert(Size(42) == "M");            
            Debug.Assert(Size(43) == "L");
            Debug.Assert(Size(0)=="Invalid Choice");      
            Console.WriteLine( "All is well (maybe!)");
        }
    }
}
