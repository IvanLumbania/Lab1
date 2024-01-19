using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Relation
    {
        public string RelationshipType;


        public Relation(string RelationshipType)
        {
            this.RelationshipType = RelationshipType;
        }
        public void showRelationshipTypes(Person person1, Person person2)
        {
            if (this.RelationshipType == "Sister")
            {
                Console.WriteLine($"{person1.FirstName} and {person2.FirstName} are Sisterhood");

            }
            else if (this.RelationshipType == "Brother")
            {
                Console.WriteLine($"{person1.FirstName} and {person2.FirstName} are Brotherhood");
            }
            else if (this.RelationshipType == "Mother")
            {
                Console.WriteLine($"{person1.FirstName} and {person2.FirstName} are Motherhood");

            }
            else if (this.RelationshipType == "Father")
            {
                Console.WriteLine($"{person1.FirstName} and {person2.FirstName} are Fatherhood");

            }
            else
            {
                Console.WriteLine("Not a relationship type");
            }
        }
    }
}