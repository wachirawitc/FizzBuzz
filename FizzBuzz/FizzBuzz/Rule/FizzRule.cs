using FizzBuzz.Rule.Interface;

namespace FizzBuzz.Rule
{
    public class FizzRule : IRule
    {
        public string Text => "Fizz";

        public bool IsAccepted(int value)
        {
            return value % 3 == 0;
        }
    }
}