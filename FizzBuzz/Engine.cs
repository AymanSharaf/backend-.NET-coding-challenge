using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    public class Engine
    {
        private List<IEngineRule> _engineRules;

        public Engine(List<IEngineRule> engineRules)
        {
            _engineRules = engineRules;
        }

        public void Run(int limit)
        {
            for (int i = 1; i <= limit; i++)
            {
                var output = string.Empty;

                foreach (var rule in _engineRules)
                {
                    output += rule.ApplyRule(i);
                }

                if (string.IsNullOrEmpty(output))
                {
                    output = i.ToString();
                }

                Console.WriteLine("{0}: {1}", i, output);
            }
        }
    }
}
