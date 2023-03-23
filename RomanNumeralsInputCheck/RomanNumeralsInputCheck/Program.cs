namespace MyProject;
class Program
{
    static void Main(string[] args)
    {
        List<char> romanNumerals = new List<char> { 'I', 'V', 'X', 'L', 'C', 'D', 'M' };
        Console.WriteLine("Write in Roman numerals the edition of the book:");
        bool allOfUserInputIsInRomanNumerals;
        bool isValid;
        do
        {
            string inputToCheck = Console.ReadLine();
            if (string.IsNullOrEmpty(inputToCheck))
            {
                Console.WriteLine("Invalid data");
            }
            else
            {
                List<char> userInput = inputToCheck.ToCharArray().ToList();
                allOfUserInputIsInRomanNumerals = userInput.Intersect(romanNumerals).Count() == userInput.Count();
                Console.WriteLine(allOfUserInputIsInRomanNumerals);
                if(allOfUserInputIsInRomanNumerals = true)
                {
                    break;
                }
                else
            }
        } while (isValid = false);

    }
}