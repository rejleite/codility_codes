using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculateHour
{
    public class Time
    {
         public string CalculateMinTime(int A, int B, int C, int D, int E, int F)
         {
             /* Given 6 numbers, calculate the smaller time valid HH:MM:ss */

            var values = new List<string>();
            values.Add(A.ToString());
            values.Add(B.ToString());
            values.Add(C.ToString());
            values.Add(D.ToString());
            values.Add(E.ToString());
            values.Add(F.ToString());

            values.Sort();

            var time = "";             

            for (int i = 1; i < values.Count; i++)
            {
                if(Convert.ToInt32(values[0] + values[i]) <= 24)
                {
                    time = values[0] + values[i] + ":";
                    
                    var minSec = values.Where((e, ix)=>ix != 0 && ix != i).ToList(); 
                    if (Convert.ToInt32(minSec[2] + minSec[3]) > 60){
                        time += minSec[0]+minSec[2] + ":" + // minute
                                minSec[1]+minSec[3] ; // second
                    }
                    else{
                        time += minSec[0]+minSec[1] + ":" + // minute
                                minSec[2]+minSec[3] ; // second
                    }            
                
                    try
                    {
                        if (TimeSpan.Parse(time) == null)
                        {
                            time =  "NOT POSSIBLE";   
                        }   
                        else{
                            break;
                        }                     
                    }
                    catch (OverflowException)
                    {
                        time =  "NOT POSSIBLE"; 
                    }
                }
            }

             return time;
         }
    }
}
