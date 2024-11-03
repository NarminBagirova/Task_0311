namespace Task_0311
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BackEndDeveloper bkDev= new BackEndDeveloper("Camal", "Isayev", 25);

            bkDev.SqlExperience= 5;

            FrontEndDeveloper frontEndDeveloper = new FrontEndDeveloper("Eli", "Huseynov", 22);
            frontEndDeveloper.ShowFullData();

            Human human1 = new Human();
            Console.WriteLine("Human's Data: ");
            Console.WriteLine("{0} {1} {2}", human1.Name, human1.Surname, human1.Age);
        }

        public class Human
        {
            public string Name = "Noname";
            public string Surname = "Nosurname";
            public byte Age =27;

            public Human() 
            {
                Console.WriteLine("Human is created");
            }  

            public Human(string name):this()
            {
                Name = name;
            }

            public Human(string name,string surname) : this(name)
            {
                Surname = surname;
            }

            public Human(string name, string surname, byte age) : this(name, surname)
            {
                Age = age;
            }


        }
    }
}