using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Final
{
    class Person
    {

        public int personId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string favoriteColour { get; set; }
        public int age { get; set; }
        public bool isWorking { get; set; }

        public string Name => $"{firstName} {lastName}";

        public void DisplayPersonInfo()
        {
            Console.WriteLine($"{personId}: {Name}'s favorite colour is {favoriteColour}");
        }

        public void ChangefavoriteColour()
        {
            favoriteColour = "White";
            Console.WriteLine($"{personId}: {Name}'s favorite colour is: {favoriteColour}");
        }

        public int GetageInTenYears()
        {
            return age + 10;
        
        }

        public override string ToString()
        {
            return $"PersonId: {personId}\n" +
                $"FirstName: {firstName}\n" +
                $"LastName: {lastName}\n" +
                $"FavoriteColour: {favoriteColour}\n" +
                $"Age: {age}\n" +
                $"IsWorking: {isWorking}";
        
        }
    }

}
