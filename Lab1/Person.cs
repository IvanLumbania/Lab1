using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Person
    {
        public int id;
        public string FirstName;
        public string LastName;
        public string FavouriteColour;
        public int age;
        public bool isWorking;
        public static int personCount;

        public Person(int id, string FirstName, string LastName, string FavouriteColour, int age, bool isWorking)
        {
            this.id = id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.FavouriteColour = FavouriteColour;
            this.age = age;
            this.isWorking = isWorking;
            personCount++;
        }
        public void DisplayPersonInfo()
        {
            Console.WriteLine($"{this.id}: {this.FirstName} {this.LastName}'s favorite colour is {this.FavouriteColour}\n");
        }

        public void ChangeFavoriteColor()
        {
            this.FavouriteColour = "White";
        }

        public int  GetAgeinTenYears(int age)
        {
            return this.age + 10;
        }
        public string ToStringMethod()
        {
            return $"PersonId: {this.id}\n" +
                $"FirstName: {this.FirstName}\n" +
                $"LastName: {this.LastName}\n" +
                $"FavoriteColour: {this.FavouriteColour}\n" +
                $"Age: {this.age}\n" +
                $"IsWorking: {this.isWorking}\n";
        }

    }

}
