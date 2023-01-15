namespace FizzBuzz.Rules
{
    public class BarRule : IEngineRule
    {
        public string ApplyRule(int input)
        {
            if (input % 7 == 0)
            {
                return "Bar";
            }

            return string.Empty;
        }
    }
}
