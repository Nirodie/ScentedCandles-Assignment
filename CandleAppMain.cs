using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScentedCandlesApplicationAssignment1
{
    class CandleAppMain
    {
        static void Main(string[] args)
        {
            #region Console window colours
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Clear(); //uses colour above as background
            Console.ForegroundColor = ConsoleColor.DarkBlue; //Colour of text
            Console.Title = "Scented candles";
            #endregion

            Candles candlesObj = new Candles(); //Creates the object Candles
            candlesObj.Start(); //Uses the object Candles

            Console.WriteLine("Press Enter to close!");
            Console.ReadLine(); //When Enter is pressed it closes the program
        }
    }
}
