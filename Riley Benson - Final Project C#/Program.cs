// Author: Riley Benson
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: To showcase what I have learned during my 8 weeks in this C# course by making a video game subscription service / manager.

namespace Riley_Benson___Final_Project_C_
{
    public class Program
    {
        static void Main(string[] args)
        {
			List<SubManagement> subs = new List<SubManagement>();
			Add addSubs = new Add();
            bool programActive = true;
            Console.WriteLine("Welcome to Pixel Hub!");
            Console.WriteLine("Your Premium Video Game Subscription Manager!");
            Console.WriteLine("\nChoose from one of the following options to get started on your journey to better spending habits:");
            while (programActive)
            {
                try
                {
					Console.WriteLine("\n1. Add a subscription");
					Console.WriteLine("2. View active subscriptions");
					Console.WriteLine("3. Edit subscription");
					Console.WriteLine("4. Delete subscription");
					Console.WriteLine("5. Exit");
					Console.Write("Enter your choice (1-5): ");
					int choice = int.Parse(Console.ReadLine());
					// Choice #1 in the list.
					if (choice == 1)
					{
						
					}
					// Choice #2 in the list.
					else if (choice == 2)
					{
						DescribeSub(subs);
					}
					// Choice #3 in the list.
					else if (choice == 3)
					{
						
					}
					// Choice #4 in the list.
					else if (choice == 4)
					{
						
					}
					// Choice #5 in the list.
					else if (choice == 5)
					{
						programActive = false;
						Console.WriteLine("Thank you for using Pixel Hub!");
						Console.WriteLine("Goodbye!");
					}
					else
					{
						Console.WriteLine("Your choice is invalid, please choose a number between 1 and 5.");
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine($"Error: {ex.Message}");
				}
			}
		}
	}
}