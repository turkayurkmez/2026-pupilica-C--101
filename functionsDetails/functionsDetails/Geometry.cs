using System;
using System.Collections.Generic;
using System.Text;

namespace functionsDetails
{
    internal class Geometry
    {

        public const string KARE = "KARE";
        public const string DAIRE = "DAİRE";
        public const string UCGEN = "ÜÇGEN";
        public const string DIKDORTGEN = "DİKDÖRTGEN";

        /// <summary>
        /// Bu fonksiyon, kare ya da daire iki boyutlu şekillerinin alanlarını hesaplamak için kullanılır.
        /// </summary>
        /// <param name="unit1">Daire için yarı çap kare için ise bir kenar uzunluğu</param>
        /// <param name="shape">KARE ya da DAİRE</param>
        /// <returns></returns>
       public double getArea(double unit1, string shape) //metod imzası: parametre sırası ve tipleridir
        {
            //shape değeri ya kare ya da daire olabilir.
            switch (shape)
            {
                case "KARE":
                    return Math.Pow(unit1, 2);                

                case "DAİRE":
                    return Math.PI * Math.Pow(unit1, 2);
                default:
                    return 0;
                  
            }

        }
        /// <summary>
        /// Bu fonksiyon üçgen veya dikdörtgenin alanını hesaplamak için kullanılır.
        /// </summary>
        /// <param name="unit1">Üçgen için alt taban, ya da dikdörtgen için en </param>
        /// <param name="unit2">yükseklik ya da boy</param>
        /// <param name="shape">ÜÇGEN ya da DİKDÖRTGEN</param>
        /// <returns></returns>
        public double getArea(double unit1, double unit2, string shape)
        {
            switch (shape)
            {
                case "ÜÇGEN":
                    return (unit1 * unit2) / 2;
                case "DİKDÖRTGEN":
                    return unit1 * unit2;                    
                default:
                    return 0;
            }
        }

       
    }
}
