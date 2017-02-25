namespace FizzBuzz.Rule.Interface
{
    public interface IRule
    {
        string Text { get; }

        bool IsAccepted(int value);
    }
}