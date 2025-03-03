using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Riley_Benson___Final_Project_C_
{
	/// <summary>
	/// Gives the user the ability to add subscriptions to the service.
	/// </summary>
	public class Add
    {
		/// <summary>
		/// Adds an inputted subscription to the list of already existing subscriptions.
		/// </summary>
		/// <param name="subs">List of subscriptions</param>
		public void AddSubscription(List<SubManagement> subs)
        {
			SubManagement newSub = new SubManagement();
            Console.WriteLine("\nAdding new subscription...");
			// Obtains the name of the subscription.
			Console.Write("Enter the name of your subscription: ");
			string name = Console.ReadLine();
			if (string.IsNullOrWhiteSpace(name))
				throw new ArgumentException("Empty and null inputs are invalid, try again.");
			// Obtains the price of the subscription.
			Console.Write("Enter the per-month price of your subscription: $");
			double price;
			if (!double.TryParse(Console.ReadLine(), out price) || price <= 0)
				throw new ArgumentException("The price cannot be less than or equal to 0, try again.");
			// Obtains the amount of months that the subscription will last.
			Console.Write("Enter the amount of months your subscription will last: ");
			int months;
			if (!int.TryParse(Console.ReadLine(), out months) || months <= 0)
				throw new ArgumentException("The amount of months your subscription will last cannot be less than or equal to 0, try again.");
			// Adds the inputted subscription into the list of subscriptions and displays the details of the subscription(s).
			subs.Add(newSub);
			newSub.DescribeSub(name, price, months);
			Console.WriteLine($"The subscription '{name}' has been added to the list successfully!");
			Console.WriteLine("Returning to the main menu...");
		}
	}
}