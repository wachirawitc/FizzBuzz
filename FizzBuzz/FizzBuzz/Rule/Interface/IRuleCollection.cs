using System.Collections.Generic;

namespace FizzBuzz.Rule.Interface
{
    public interface IRuleCollection
    {
        List<IRule> Rules { get; }
    }
}