namespace OtherPerson
{
    internal class Program
    {
        /// <summary>
        /// Having written similar in C++ earlier this is to demonstrate how much easier it is in C#
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //I have created an external class named Person and an external class named Client.
            Person();
            Console.Write("Press any key to continue!");
            Console.ReadLine();
            Console.Clear();
            Client();
        }

        static void Person()
        {
            //First we'll implement the Person and display the details.
            Person person = new Person();
            Console.WriteLine("Please enter the person details:\n");
            Console.Write("First name: ");
            person.firstname = Console.ReadLine();
            Console.Write("Last name: ");
            person.lastname = Console.ReadLine();
            Console.Write("Age: ");
            person.Age = Console.ReadLine();

            //convert the inputs to local variables
            string name = person.firstname + " " + person.lastname;
            int age = int.Parse(person.Age);

            //and output to console
            Console.WriteLine("\nPerson details:");
            Console.WriteLine("\nName: " + name + "\n ");
            Console.WriteLine("Age: " + age);
        }

        static void Client()
        {
            //Now we'll implement the Client and display the details
            Client client = new Client();
            Console.WriteLine("please enter the client details:\n");
            Console.Write("First name: ");
            client.firstName = Console.ReadLine();
            Console.Write("Last name: ");
            client.lastName = Console.ReadLine();
            Console.Write("Mobile: ");
            client.mobile = Console.ReadLine();

            //convert the inputs to local variables
            string name = client.firstName + " " + client.lastName;
            long mob = long.Parse(client.mobile);

            //and output to the console
            Console.WriteLine("\nClient details:");
            Console.WriteLine("\nName: " + name + "\n");
            Console.WriteLine("mobile: 0" +  mob);
        }
    }
}