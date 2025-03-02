using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Riley_Benson___Final_Project_C_
{
    /// <summary>
    /// Lets the user edit a subscription of their choice from their list of subscriptions.
    /// </summary>
    public class Edit
    {
        /// <summary>
        /// Gives the user the choice to edit the name, price, and duration in months of the subscription they choose.
        /// </summary>
        /// <param name="subs">List of already existing subscriptions</param>
        public void EditSubscription(List<SubManagement> subs)
        {
            // Checks for an empty subscription list before proceeding with the rest of the program.
            if (subs.Count == 0)
            {
                Console.WriteLine("There are no subscriptions currently in your list, therefore none can be edited.");
				Console.WriteLine("Returning to the main menu...");
                return;
			}
            Console.WriteLine("\nGetting ready to edit subscription...");
            // List the different subscriptions the user of the program has to them.
            Console.WriteLine("\nBelow is your current list of subscriptions: ");
			for (int i = 0; i < subs.Count; i++)
			{
				Console.WriteLine($"{i + 1}. {subs[i].FetchSubName()}");
			}
            // Prompts the user to select one of their subscriptions to edit.
            Console.WriteLine("\nChoose from the list of subscriptions which one you want to edit (1, 2, 3, etc.): ");
            int editChoice;
			// Handles the input of the user in the program.
			if (!int.TryParse(Console.ReadLine(), out editChoice) || editChoice < 1 || editChoice > subs.Count)
			{
				throw new ArgumentException($"Your choice is invalid, please choose a number between 1 and {subs.Count}.");
			}
			// Uses the subscription that has been selected by the user.
			SubManagement chosenSub = subs[editChoice - 1];
			string currentSubName = chosenSub.FetchSubName();
			Console.WriteLine($"\nGetting ready to edit subscription: {currentSubName}");
			// Obtains the new name of the subscription you are editing.
			Console.Write("\nEnter the new name for this subscription: ");
			string newSubName = Console.ReadLine();
			if (string.IsNullOrWhiteSpace(newSubName))
				throw new ArgumentException("Empty and null inputs are invalid, try again.");
			// Obtains the new name of the subscription you are editing.
			Console.Write("Enter the new monthly price for your subscription: $");
			double newSubPrice;
			if (!double.TryParse(Console.ReadLine(), out newSubPrice) || newSubPrice <= 0)
				throw new ArgumentException("The price cannot be less than or equal to 0, try again.");
			// Obtains the new duration in months of the subscription you are editing.
			Console.WriteLine("Enter the amount of months your subscription will last: ");
			int newSubMonths;
			if (!int.TryParse(Console.ReadLine(), out newSubMonths) || newSubMonths <= 0)
				throw new ArgumentException("The amount of months your subscription will last cannot be less than or equal to 0, try again.");
			// Updates the subscription and its details.
			UpdateSubscription(subs, editChoice - 1, newSubName, newSubPrice, newSubMonths);
			Console.WriteLine($"\nThe subscription {editChoice} has been updated successfully!");
			Console.WriteLine("Returning to the main menu...");
		}
	}
}