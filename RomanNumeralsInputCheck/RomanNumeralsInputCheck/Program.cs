namespace MyProject;
class Program
{
    static void Main(string[] args)
    {
        List<char> romanNumerals = new List<char> { 'I', 'V', 'X', 'L', 'C', 'D', 'M' };
        Console.WriteLine("Write in Roman numerals the edition of the book:");
        string inputToCheck = Console.ReadLine();
        List<char> userInput = inputToCheck.ToCharArray().ToList();
        
        var allOfListInputIsInRomanNumeralsList = userInput.Intersect(romanNumerals).Count() == userInput.Count();
        Console.WriteLine(allOfListInputIsInRomanNumeralsList);
        
    }
}