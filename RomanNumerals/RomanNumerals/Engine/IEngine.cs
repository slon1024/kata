namespace RomanNumerals.Engine
{
    public interface IEngine
    {
        /// <summary>
        /// Method performs the addition of two Roman numbers.
        /// </summary>
        /// <param name="first">The first Roman numeral</param>
        /// <param name="second">The second Roman numeral</param>
        /// <returns>Roman number - which is the result of adding two numbers of Roman</returns>
        string Add(string first, string second);
    }
}
