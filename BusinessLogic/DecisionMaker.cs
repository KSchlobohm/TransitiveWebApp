using Logging;
using System;

namespace BusinessLogic
{
    public class DecisionMaker
    {
        private readonly Random _random = new Random();

        /// <summary>
        /// Picks a number between 0 and 100
        /// </summary>
        /// <returns>true if the number was picked</returns>
        public bool PickANumber()
        {
            var number = _random.Next(0, 100);

            MyLogger.LogAMessage($"The secret number is: {number}");

            return true;
        }
    }
}
