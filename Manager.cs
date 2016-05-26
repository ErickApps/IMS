using System;
using System.Collections.Generic;


namespace IMS
{
	

	public class Manager 
	{
		Dictionary<string, Product> products = new Dictionary<string, Product> ();

		
		public  void add(string _name,string _category,double _quantity,double _price)
		{
			this.products.Add (_name,new Product {name = _name, category = _category,quantity = _quantity, price = _price });
			if (this.products.ContainsKey(_name)) {
				Console.WriteLine("added succesfully");
			}

		}

		public void updateQuantity(string _key, double _number)
		{
			this.products [_key].quantity = _number;
		}

		public void updatePrice(string _key, double _number)
		{
			this.products [_key].price = _number;
		}

		public  void removeProduct(string key)
		{
			this.products.Remove (key);

		}

		public  string search(string key){

			try {
				return "Name:" + this.products [key].name + "Category: " + this.products [key].category + 
					" Quantity: " + this.products [key].quantity + " Price: " + this.products [key].price;
				
			} catch (Exception ex) {
				return ex.Message;
			}

		}

		public void displayAll()
		{



			foreach (var item in products.Keys) 
			{


				Console.Write ("\n"+"Name: " + this.products [item].name + "\nCategory: " + this.products [item].category + 
					"\nQuantity: " + this.products [item].quantity + "\nPrice: " + this.products [item].price);

			}

		}


	}
}

