namespace PhoneBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Phone Book application!");
            Console.WriteLine();
            Console.WriteLine("Choose your action:");
            Console.WriteLine();
            Console.WriteLine("1.\t Show all contacts in the book;");
            Console.WriteLine("2.\t Add new contact;");
            Console.WriteLine("3.\t Remove contact;");
            Console.WriteLine("4.\t Find contact by number;");
            Console.WriteLine("5.\t Find contacts by Name;");
            Console.WriteLine("Press X to exit.");

            var userInput = Console.ReadLine();

            var phoneBook = new PhoneBook();

            while (true)
            {
                switch (userInput)
                {
                    case "1":
                        phoneBook.ShowAllContacts();
                        break;

                    case "2":
                        Console.WriteLine("Type in a number of a new contact:");
                        var number = Console.ReadLine();
                        Console.WriteLine("Type in the name of this contact:");
                        var name = Console.ReadLine();

                        if (number.Length < 9 || number.Length > 12)
                        {
                            Console.WriteLine("Incorrect number. The length must be between 9 and 12 digits.");
                        }
                        else if (name.Length < 1)
                        {
                            Console.WriteLine("Cannot store contacts with no name.");
                        }
                        else
                        {
                            var newContact = new Contact(name, number);
                            phoneBook.AddContact(newContact);
                        }
                        break;
                    case "3":
                        Console.WriteLine("Insert contact name to remove:");
                        var contactToRemove = Console.ReadLine();
                        phoneBook.RemoveContact(contactToRemove);
                        phoneBook.ShowAllContacts();
                        break;
                    case "4":
                        Console.WriteLine("Give me the magic numbers, and I shall give you the name:");
                        var searchedNumber = Console.ReadLine();
                        phoneBook.FindContactByNumber(searchedNumber);
                        break;
                    case "5":
                        Console.WriteLine("Whom do you seek?");
                        var searchedContact = Console.ReadLine();
                        phoneBook.FindContactsByName(searchedContact);

                        break;
                    case "x":
                        return;
                    default:
                        Console.WriteLine("Your illegal actions are depleting my mana.");
                        break;
                }
                Console.WriteLine("Choose your action:");
                userInput = Console.ReadLine();
            }

        }
    }
}