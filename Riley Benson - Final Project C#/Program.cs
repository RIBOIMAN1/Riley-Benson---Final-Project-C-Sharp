namespace Riley_Benson___Final_Project_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
			bool programActive = true;
			Console.WriteLine("Welcome to Pixel Hub!");
            Console.WriteLine("Your Premium Video Game Suvbscription Manager!");
            Console.WriteLine("\nChoose from one of the following options to get started on your journey to better spending habits:");
            Console.WriteLine("\n1. Add a subscription");
            Console.WriteLine("2. View active subscriptions");
			Console.WriteLine("3. Edit subscription");
			Console.WriteLine("4. Delete subscription");
			Console.WriteLine("5. Exit");
            Console.Write("Enter your choice below (1-5): ");
			int choice = int.Parse(Console.ReadLine());
			if (choice == 1)
            {
                
            }
            else if (choice == 2)
            {
                
            }
            else if (choice == 3)
            {
                
            }
            else if (choice == 4)
            {
                
            }
            else if (choice == 5)
			{
				programActive = false;
				Console.WriteLine("Thank you for using Pixel Hub!");
			}
		}
    }
}