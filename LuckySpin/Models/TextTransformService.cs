using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LuckySpin.Models
{
    public class TextTransformService
    {
      string numberToText(string text, int luck )
        {
            luck = (new Random()).Next(1, 9);
            switch (luck)
            {
                case  1:
                    return "one";
                    
                   
                case 2: 
                    return "two";
                   
                case 3:
                    return "three";
                    
                case 4:
                    return "four";
                    
                case 5:
                    return "five";
                    
                case 6:
                    return "six";
                   
                case 7:
                    return "seven";
                    
                case 8:
                    return "eight";
                case 9:
                    return "nine";
                default:
                    return "";
                    

      }     }  
    }
}
