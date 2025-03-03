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
			Add newSub = new Add();
			Edit editSubs = new Edit();
			Delete deleteSubs = new Delete();
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
					// Choice #1 in the menu.
					if (choice == 1)
					{
						addSubs.AddSubscription(subs);
					}
					// Choice #2 in the menu.
					else if (choice == 2)
					{
						if (subs.Count == 0)
						{
							Console.WriteLine("\nThere are no currently active subscriptions to display.");
						}
						else
						{
							Console.WriteLine("\nBelow are your active subscriptions:");
							for (int i = 0; i < subs.Count; i++)
							{
								Console.WriteLine($"{i + 1}. {subs[i].FetchSubName()}");
							}
						}
					}
					// Choice #3 in the menu.
					else if (choice == 3)
					{
						editSubs.EditSubscription(subs);
					}
					// Choice #4 in the menu.
					else if (choice == 4)
					{
						deleteSubs.DeleteSub(subs);
					}
					// Choice #5 in the menu.
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
				catch (Exception)
				{
					Console.WriteLine($"Your input is not a proper integer; use integers in this menu, and make sure to input a number between 1 and 5.");
				}
			}
		}
	}
}