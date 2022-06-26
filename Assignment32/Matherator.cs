using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment2
{
    /// <summary>
    /// Provides a variety of numeric methods
    /// </summary>
    public class Matherator
    {
        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        public Matherator()
        {
        }

        #endregion

        #region Methods

        /// <summary>
        /// Prints the numbers from 1 to 10
        /// </summary>
        public void PrintOneToTen()
        {
            var result = "";
            for (var i = 1; i <= 10; i++)
            {
                result += i + " ";
            }
            Console.WriteLine(result.Trim());
        }

        /// <summary>
        /// Prints the numbers from m to n
        /// </summary>
        /// <param name="m">m</param>
        /// <param name="n">n</param>
        public void PrintMToN(int m, int n)
        {
            if (m > n)
            {
                Console.WriteLine("m must be less than or equal to n.");
                return;
            }
            var result = "";
            for (var i = m; i <= n; i++)
            {
                result += i + " ";
            }
            Console.WriteLine(result.Trim());
        }

        /// <summary>
        /// Returns the tenth even number, with 2 as the first even number
        /// </summary>
        /// <returns>tenth even number</returns>
        public int GetTenthEvenNumber()
        {
            // delete code below; only included so we could compile
            return 2 + 9 * 2;
        }

        /// <summary>
        /// Returns the nth even number, with 2 as the first even number
        /// </summary>
        /// <param name="n">n</param>
        /// <returns>nth even number</returns>
        public int GetNthEvenNumber(int n)
        {
            // delete code below; only included so we could compile
            if (n < 1)
                return -1;
            return 2 + (n - 1) * 2;
        }

        #endregion
    }
}