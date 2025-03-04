﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Riley_Benson___Final_Project_C_
{
	public class SubManagement
	{
		private string name;
		private double price;
		private int months;
		public SubManagement()
		{
			this.name = "";
			this.price = 0;
			this.months = 0;
		}
		// Constructor used to help list subscription details.
		public SubManagement(string name, double price, int months)
		{
			this.name = name;
			this.price = price;
			this.months = months;
		}
		/// <summary>
		/// Uses a subscription's name, price, and the duration of the subscription to describe it.
		/// </summary>
		/// <param name="name">Subscription's name</param>
		/// <param name="price">Subscription's price</param>
		/// <param name="months"><Subscription's duration</param>
		public void DescribeSub(string name, double price, int months)
		{
			this.name = name;
			this.price = price;
			this.months = months;
		}
		/// <summary>
		/// Does calculations for the total price of the subscription and outputs info about the name, price, and duration in months of the subscription.
		/// </summary>
		/// <returns>Comprehensive details of the subscription.</returns>
		public string FetchSubName()
		{
			// Total price
			double totalPrice = this.price * this.months;
			// Name, price, and duration in months output.
			return ($"Subscription's name: {name}, subscription's price: ${price}, subscription's duration: {months} months, accumulated subscription price: ${totalPrice}");
		}
		/// <summary>
		/// Makes the confirmation message for the deletion of a subscription only show the name rather than all of the details.
		/// </summary>
		/// <returns>The name of the subscription</returns>
		public string GetName()
		{
			return this.name;
		}
	}
}