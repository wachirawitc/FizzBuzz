using FizzBuzz.Rule.Interface;
using System.Collections.Generic;

namespace FizzBuzz.Rule.Collections
{
    public class DefaultRuleCollection : IRuleCollection
    {
        public DefaultRuleCollection()
        {
            Rules = new List<IRule> {
                new FizzBuzzRule(),
                new BuzzRule(),
                new FizzRule()
            };
        }

        public List<IRule> Rules { get; }
    }
}