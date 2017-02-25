using FizzBuzz.Rule.Interface;

namespace FizzBuzz.Rule
{
    public class FizzBuzzRule : IRule
    {
        public string Text => "FizzBuzz";

        public bool IsAccepted(int value)
        {
            return value % 15 == 0;
        }
    }
}