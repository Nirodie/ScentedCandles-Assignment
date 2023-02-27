using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScentedCandlesApplicationAssignment1
{
    /// <summary>
    /// 1. Input
    ///  1.1 Get the scent of the candle with a String
    ///  1.2 Get the amount of hours it last with a Double
    ///  1.3 Get the amount of candles of said scent with Int
    ///  
    /// 2. Output
    ///  2.1 Display the scent of the candles
    ///  2.2 Display the the hours the candles last
    ///  2.3 Display hows many candles there are
    /// </summary>

    class Candles
    {
        private string scent; //creates the string "scent"
        private double time; //creates the double "time"
        private int amount; //creates the int "amount"
  
        public void Start()
        {
            Input(); //Inputs are saved here
            Output(); //Outputs are displayed here
        }
        #region Input
        public void Input() //Saves all input data inside of "Input"
        {
            ReadScent();
            ReadTime();
            ReadAmount();
        }
        #endregion
        #region ReadScent
        public void ReadScent()
        {
            Console.Write("What is the scent of your candle?:  "); 
            scent = Console.ReadLine(); //Saves the input inside of "scent"
        }
        #endregion
        #region ReadTime
        public void ReadTime()
        {
            Console.WriteLine(); //Blankspace for neatness
            Console.Write("How long can your " + scent + " candles burn for?(In hours): ");
            time = double.Parse(Console.ReadLine()); //Saves the input as a double inside of "time"
        }
        #endregion
        #region ReadAmount
        public void ReadAmount()
        {
            Console.WriteLine(); //Blankspace for neatness
            Console.Write("How many " + scent + " candles do you have?: ");
            amount = int.Parse(Console.ReadLine()); //Saves the input as an int inside of "amount"
        }
        #endregion
        #region Output
        public void Output()
        {
            Console.WriteLine(); //Blankspace
            Console.WriteLine("_____________________________________________________________________________________________________________________");//Cosmetic line
            Console.WriteLine(); //Blankspace
            string outputText = "Your " + scent + " candles lasts for " + time + " hours and you currently have " + amount + " of them."; //Creates a string called "outputText"
            Console.WriteLine(outputText); //Displays the string "outputText"
            Console.WriteLine("_____________________________________________________________________________________________________________________");//Cosmetic line
            Console.WriteLine(); //Blankspace
        }
        #endregion
    }
}
