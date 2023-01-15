namespace FizzBuzz.Rules
{
    public class BuzzRule : IEngineRule
    {
        public string ApplyRule(int input)
        {
            if (input % 5 == 0)
            {
                return "Buzz";
            }

            return string.Empty;

        }
    }
}
