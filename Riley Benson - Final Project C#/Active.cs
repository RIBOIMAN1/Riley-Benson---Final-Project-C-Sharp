using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Riley_Benson___Final_Project_C_
{
	/// <summary>
	/// Abstract class that covers all active subscriptions, which contains properties and methods for subscriptions.
	/// </summary>
	public abstract class Active
    {
		private string _name;
		private double _price;
		private int _months;
		public double Price
		{
			get => _price;
			set
			{
				if (value <= 0)
					throw new ArgumentException("The age cannot be less than 0, try again.");
				_price = value;
			}
		}
		/// <summary>
		/// Obtains subscription name.
		/// </summary>
		/// <exception cref="ArgumentException">Exception for null or white space text.</exception>
		public string Name
		{
			get => _name;
			set
			{
				if (string.IsNullOrWhiteSpace(value))
					throw new ArgumentException("Empty and null inputs are invalid, try again.");
				_name = value;
			}
		}
	}
}