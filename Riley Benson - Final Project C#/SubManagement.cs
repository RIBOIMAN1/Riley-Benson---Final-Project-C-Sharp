using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Riley_Benson___Final_Project_C_
{
    public class SubManagement
    {
		/// <summary>
		/// Uses a subscription's name, price, and the duration of the subscription to describe it.
		/// </summary>
		/// <param name="name">Subscription's name</param>
		/// <param name="price">Subscription's price</param>
		/// <param name="months"><Subscription's duration</param>
		public void DescribeSub(string name, double price, int months)
		{
			Console.WriteLine($"Subscription's name: {name}, subscription's price: {price}, subscription's duration: {months} months");
		}
	}
}