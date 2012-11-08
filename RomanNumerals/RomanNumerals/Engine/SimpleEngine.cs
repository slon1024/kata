using System.Collections.Generic;
using System.Linq;

namespace RomanNumerals.Engine
{
    public class SimpleEngine : IEngine
    {
        /// <summary>
        /// Dictionary that is used in temporary trasformat to Psedo in Roman numerals and vice versa
        /// </summary>
        private readonly Dictionary<int, string> _map =
            new Dictionary<int, string>
            {
                {4, "IV"},
                {5, "V"},
                {9, "IX"},
                {40, "XL"},
                {90, "XC"},
                {10, "X"},
                {50, "L"},
                {400, "CD"},
                {900, "CM"},
                {100, "C"},
                {500, "D"},
                {1000, "M"},
            };
        
        /// <summary>
        /// The list of keys, sorted in a certain order (descending). Used in the transformation of the pseudo Roman numbers in Roman numerals.
        /// </summary>
        /// <see cref="_map"/>
        /// <seealso cref="ToRomanNormal"/>
        private readonly List<int> _keysOrder;

        /// <summary>
        /// Constructor. 
        /// Initialization list _keysOrder.
        /// </summary>
        public SimpleEngine()
        {
            _keysOrder = _map.Keys.ToList();
            _keysOrder.Sort();
            _keysOrder.Reverse();
        }

        /// <summary>
        /// This method will be called at the calculator.
        /// Method performs the addition of two Roman numbers.
        /// </summary>
        /// <see cref="Calculator.Add"/>
        /// <param name="first">The first Roman numeral</param>
        /// <param name="second">The second Roman numeral</param>
        /// <returns>Roman number - which is the result of adding two numbers of Roman</returns>
        public string Add(string first, string second)
        {
            var romanOnes = ToRomanOnes(first) + ToRomanOnes(second);
            return ToRomanNormal(romanOnes);
        }

        /// <summary>
        /// This method repeat the character (first argument), the amount of time (second argument).
        /// </summary>
        /// <param name="value">A char that will be repeated</param>
        /// <param name="times">How many times will be repeated</param>
        /// <returns>A string which is the product of repetition char times</returns>
        public string Repeat(char value, int times)
        {
            return new string(value, times);
        }

        /// <summary>
        /// The method takes a Roman numeral and returns pseudo Roman numeral consisting of only ones. 
        /// </summary>
        /// <example>
        /// An example of how it works
        /// <code>
        /// ToRomanOnes("I") == "I";
        /// //but
        /// ToRomanOnes("IV") == "IIII";//(four ones)
        /// ToRomanOnes("X")  == "IIIIIIIIII";//(ten ones)
        /// </code>
        /// </example>
        /// <param name="roman">Roman numeral</param>
        /// <returns>Returns pseudo Roman numeral, it means that the number is only ones.</returns>
        public string ToRomanOnes(string roman)
        {
            return _map.Keys.Aggregate(roman, (current, key) => current.Replace(_map[key], Repeat('I', key)));
        }

        /// <summary>
        /// The method takes a pseudo Roman numeral (consisting of only ones) and return Roman numeral
        /// For
        /// </summary>
        /// <see cref="ToRomanOnes"/>
        /// <example>
        /// An example of how it works
        /// <code>
        /// ToRomanNormal("I") == "I";
        /// //but
        /// ToRomanNormal("IIII") == "IV";
        /// ToRomanNormal("IIIIIIIIII")  == "X";
        /// </code>
        /// </example>
        /// <param name="roman">Pseudo Roman numeral</param>
        /// <returns>Return Roman numeral from pseud Roman numeral</returns>
        public string ToRomanNormal(string roman)
        {
            return _keysOrder.Aggregate(roman, (current, key) => current.Replace(Repeat('I', key), _map[key]));
        }
    }
}