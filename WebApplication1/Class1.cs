using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Class1
    {
        Double unti,tunder,sumft,allsum,newunti;
        const Double ft = 0.9255;
        const Double low = 1.8047;
        const Double medium = 2.7781;
        const Double higt = 2.9780;
        const Double month = 40.90;
        public Double untis(Double unti)
        {
            if (unti <= 150)
            {
                tunder = unti * low;
                sumft = unti * ft;
                allsum = tunder + sumft + month;
                allsum = allsum + (allsum * 7 / 100);
                
            }
            else if ((unti > 150) && (unti <= 400))
            {
                newunti = unti - 150;
                tunder = (150 * low) + (newunti * medium);
                sumft = unti * ft;
                allsum = tunder + sumft + month;
                allsum = allsum + (allsum * 7 / 100);
               
            }
            else
            {
                newunti = unti - 400;
                tunder = (150 * low) + (250 * medium) + (newunti * higt);
                sumft = unti * ft;
                allsum = tunder + sumft + month;
                allsum = allsum + (allsum * 7 / 100);
               
            }
            return allsum;
        } 
       
    }
}