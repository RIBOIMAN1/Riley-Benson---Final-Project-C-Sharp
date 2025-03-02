using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Riley_Benson___Final_Project_C_
{
    /// <summary>
    /// Allows users to delete subscriptions from the list.
    /// </summary>
    public class Delete
    {
        /// <summary>
        /// Removes the selected subscription.
        /// </summary>
        /// <param name="subs">List of subscriptions</param>
        public void DeleteSub(List<SubManagement> subs)
        {
            // Checks for an empty subscriprtion list, and returns messages to the user if true.
            if (subs.Count == 0)
            {
                Console.WriteLine("\nNo subscriptions are available to delete.");
                Console.WriteLine("Returning to the main menu...");
                return;
            }
            Console.WriteLine("Getting ready to delete subscription...");
            // Shows list of subscriptions
            Console.WriteLine("\nBelow is your list of subscriptions:");
			for (int i = 0; i < subs.Count; i++)
			{
				Console.WriteLine($"{i + 1}. {subs[i].FetchSubName()}");
			}
            // Prompts the user to select the subscription they want to delete.
            Console.Write("\nSelect the subscription you want to delete from the list (1, 2, 3, etc.): ");
            int deleteChoice;
			// Validates deletion
			if (!int.TryParse(Console.ReadLine(), out deleteChoice) || deleteChoice < 1 || deleteChoice > subs.Count)
            {
				throw new ArgumentException($"Your choice is invalid, please choose a number between 1 and {subs.Count}.");
			}
			// Handles what subscription gets deleted.
			SubManagement deletableSub = subs[deleteChoice - 1];
			string subName = deletableSub.FetchSubName();
            // Confirms subscription deletion
            Console.WriteLine($"Are you sure '{subName}' is the subscription you want to delete from your list? (type 'yes' or 'no'): ");
			string confirmPrompt = Console.ReadLine().ToLower();
			if (confirmPrompt == "yes")
			{
				// Remove the subscription
				subs.RemoveAt(deleteChoice - 1);
				Console.WriteLine($"\nThe subscription you have chosen, '{subName}', has been successfully deleted!");
			}
            else
            {
                Console.WriteLine("\nDeletion interrupted prematurely.");
            }
			Console.WriteLine("Returning to the main menu...");
		}
    }
}