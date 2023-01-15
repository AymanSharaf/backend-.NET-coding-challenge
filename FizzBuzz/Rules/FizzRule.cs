namespace FizzBuzz.Rules
{
    public class FizzRule : IEngineRule
    {
        public string ApplyRule(int input)
        {
            if (input % 3 == 0)
            {
                return "Fizz";
            }

            return string.Empty;
        }
    }
}
