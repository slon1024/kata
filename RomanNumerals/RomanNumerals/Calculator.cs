using RomanNumerals.Engine;

namespace RomanNumerals
{
    /// <summary>
    /// Calculator Roman numbers.
    /// </summary>
    public class Calculator : ICalculator
    {
        /// <summary>
        /// Engine that performs all actions.
        /// </summary>
        private readonly IEngine _engine = null;

        /// <summary>
        /// Constructor
        /// Required parameter is the engine
        /// </summary>
        /// <param name="engine">Engine</param>
        public Calculator(IEngine engine)
        {
            _engine = engine;
        }
        
        /// <summary>
        /// Method performs the addition of two Roman numbers.
        /// </summary>
        /// <param name="first">The first Roman numeral</param>
        /// <param name="second">The second Roman numeral</param>
        /// <returns>Roman number - which is the result of adding two numbers of Roman</returns>
        public string Add(string first, string second)
        {
            return _engine.Add(first, second);
        }
    }
}
