namespace Lab1_Final
{

    class MainClass
    {

        public static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            //a.	Create four objects using the following data:
            Person ian = new Person { personId = 1, firstName = "Ian", lastName = "Brooks", favoriteColour = "Red", age = 30, isWorking = true };
            Person gina = new Person { personId = 2, firstName = "Gina", lastName = "James", favoriteColour = "Green", age = 18, isWorking = false };
            Person mike = new Person { personId = 3, firstName = "Mike", lastName = "Briscoe", favoriteColour = "Blue", age = 45, isWorking = true };
            Person mary = new Person { personId = 4, firstName = "Mary", lastName = "Beals", favoriteColour = "Yellow", age = 28, isWorking = true };

            //b.	Display Gina’s information as a sentence that shows her id, first name, last name and her favorite colour.
            gina.DisplayPersonInfo();

            //c.	Display all of Mike’s information as a list.
            Console.WriteLine(mike.ToString());

            //d.	Change Ian’s Favorite Colour to white, and then print his information as a sentence.
            ian.ChangefavoriteColour();

            //e.	Display Mary’s age after ten years.
            Console.WriteLine($"{mary.firstName} {mary.lastName}'s age in 10 years is: {mary.GetageInTenYears()}");

            //f.	Create two Relation Objects that show that Gina and Mary are sisters, and that Ian and Mike are brothers. Then, display both relationships.
            Relation ginaMaryRelation = new Relation { RelationshipType = "Sisterhood" };
            Relation ianMikeRelation = new Relation { RelationshipType = "Brotherhood" };

            ginaMaryRelation.ShowRelationship(gina, mary);
            ianMikeRelation.ShowRelationship(ian, mike);

            //g.	Add all the Person objects to a list, and then use the list to display the following:
            people.Add(ian);
            people.Add(gina);
            people.Add(mike);
            people.Add(mary);

            DisplayListInfo(people);
        
        }

        static void DisplayListInfo(List<Person> people)
        {
            //•	The average age of the people in the list
            double averageage = people.Average(persona => persona.age);
            Console.WriteLine($"Average age is: {averageage}");

            //•	The youngest person and the oldest person
            Person youngestPerson = people.OrderBy(persona => persona.age).First();
            Person oldestPerson = people.OrderByDescending(persona => persona.age).First();
            Console.WriteLine($"The youngest person is: {youngestPerson.firstName}");
            Console.WriteLine($"The oldest person is: {oldestPerson.firstName}");

            //•	The names of the people whose first names start with M
            foreach (var person in people.Where(p => p.firstName.StartsWith("M")))
            {
                Console.WriteLine(person.ToString());
            
            }

            //•	The person information of the person that likes the colour blue
            var bluePerson = people.Find(person => person.favoriteColour == ("Blue"));
            Console.WriteLine($"{bluePerson?.ToString()}");

        }

    }

}
