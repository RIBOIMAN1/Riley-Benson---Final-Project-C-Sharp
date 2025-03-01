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
            /// Checks for an empty subscriprtion list, and returns messages to the user if true.
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
		}
    }
}