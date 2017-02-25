using FizzBuzz.Rule.Interface;

namespace FizzBuzz.Rule
{
    public class BuzzRule : IRule
    {
        public string Text => "Buzz";

        public bool IsAccepted(int value)
        {
            return value % 5 == 0;
        }
    }
}