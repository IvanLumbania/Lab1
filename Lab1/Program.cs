
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace Lab1;

class Program
{
    static void Main(string[] args)
    {
        List<object> personList = new List<object>();

        Person Gina = new Person(2,"Gina", "James", "Green", 18, false );
        Gina.DisplayPersonInfo();
        personList.Add(Gina);  

        Person Mike = new Person(3, "Mike","Briscoe","Blue",45, true);
        Console.WriteLine(Mike.ToStringMethod());
        personList.Add(Mike);

        Person Ian = new Person(1, "Ian", "Brooks", "Green", 30, true);
        Ian.ChangeFavoriteColor();
        Ian.DisplayPersonInfo();
        personList.Add(Ian);

        Person Mary = new Person(4,"Mary", "Beels", "Yellow", 28, true);
        Console.WriteLine($"{Mary.FirstName} {Mary.LastName} Age in 10 years is: {Mary.GetAgeinTenYears(Mary.age)}");
        personList.Add(Mary);

        Relation GinaAndMary = new Relation("Sister");
        GinaAndMary.showRelationshipTypes(Gina, Mary);

        Relation IanAndMike = new Relation("Brother");
        IanAndMike.showRelationshipTypes(Ian, Mike);

        double TotalAge = 0;
        double oldestAge = 0;
        string oldestPerson = "";
        double youngestAge = 0;
        string youngestPerson = "";

        foreach (Person person in personList)
        {
            TotalAge += person.age;
            if (person.age >= oldestAge) 
            { 
                oldestAge = person.age;
                oldestPerson = person.FirstName;
            }
   
            if (youngestAge == 0)
            {
                youngestAge = oldestAge;
            }

            if (person.age <= youngestAge)
            {
                youngestAge = person.age;
                youngestPerson = person.FirstName;
            }
        }

        Console.WriteLine($"The average age is: {TotalAge / Person.personCount}\n");
        Console.WriteLine($"The youngest person is: {youngestPerson}\n" +
            $"The oldest person is: {oldestPerson}\n");

        foreach (Person person in personList)
        {
            for (int i = 0; i < person.FirstName.Count(); i++)
            {
                if ('M' == person.FirstName[0])
                {
                    Console.WriteLine(person.ToStringMethod());
                    break;
                }

            }
        }
        
        foreach (Person person in personList)
        {
            for (int i = 0;i < person.FirstName.Count(); i++)
            {
                if (person.FavouriteColour == "Blue" && 'M' == person.FirstName[0])
                {
                    Console.WriteLine(person.ToStringMethod());
                    break;
                }
            }
        }   
    }
}