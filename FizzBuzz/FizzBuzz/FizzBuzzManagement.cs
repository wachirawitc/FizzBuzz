using FizzBuzz.Rule.Interface;
using System.Linq;

namespace FizzBuzz
{
    public class FizzBuzzManagement
    {
        private readonly IRuleCollection collection;

        public FizzBuzzManagement(IRuleCollection collection)
        {
            this.collection = collection;
        }

        public string GetText(int value)
        {
            var rule = collection.Rules.FirstOrDefault(x => x.IsAccepted(value));
            return rule?.Text ?? value.ToString();
        }
    }
}