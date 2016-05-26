using System;
using System.Collections.Generic;

namespace IMS
{
	class MainClass
	{
		 public static Manager manager = new Manager ();

		public static void Main (string[] args)
		{
			manager.add ("apple", "fruits", 5, 2.5);
			Console.WriteLine ("Welcome to IMS");


			while (Menu ()) {
				
			}




		}
		public static bool Menu()
		{
			Console.WriteLine("\n\nMenu Options\n" +
				"press 1: to add\n"+ 
				"press 2: to remove\n"+
				"press 3: to Update Price\n"+
				"press 4: to update quantity\n"+
				"press 5: to show all products\n"+
				"press any other digit to exit\n");
			
			int input = Convert.ToInt16(Console.ReadLine ());



			if (input == 1) {
				addProduct ();
			} else if (input == 2) {
				removeProduct ();
			} else if (input == 3) {
				UpdatePrice ();
			} else if (input == 4) {
				UpdateQuattity ();
			} else if(input == 5){
				manager.displayAll();
			} else if(input == 6){
				Console.WriteLine ("Name");
				string name = Console.ReadLine ();
				Console.WriteLine (manager.search(name));

			}else {
				return false;
			}


			return true;
		}
		public static void addProduct(){


			string name;
			string category;
			int quantity;
			int price;

			try {

				Console.WriteLine ("Please enter the following values to add in products");
				Console.WriteLine ("Name");
				name = Console.ReadLine ();
				Console.WriteLine ("Category");
				category = Console.ReadLine ();
				Console.WriteLine ("Quantity");
				quantity = Convert.ToInt16(Console.ReadLine ());
				Console.WriteLine ("Price");
				price = Convert.ToInt16(Console.ReadLine ());
				manager.add (name,category,quantity,price);

				
			} catch (Exception ex) {
				if (ex != null) {
					Console.WriteLine ("Invalid input\n You will be redirected to Main Menu");
					Menu ();
				}
			}


		}

		public static void removeProduct()
		{
			string name;
			Console.WriteLine ("Please enter the name of the product to be removed");
			Console.WriteLine ("Name");
			name = Console.ReadLine ();

			manager.removeProduct (name);
			Console.WriteLine ("Done");

		}
		public static void UpdatePrice(){

			string name;
			int price;

			try {

				Console.WriteLine ("Please enter the name of the product ");
				Console.WriteLine ("Name");
				name = Console.ReadLine ();

				Console.WriteLine ("Please enter the name of the product ");
				Console.WriteLine ("price");
				price = Convert.ToInt16(Console.ReadLine ());

				manager.updatePrice(name,price);
				
			} catch (Exception ex) {

				if (ex != null) {
					Console.WriteLine ("Invalid input\n You will be redirected to Main Menu");
					Menu ();
				}
				Console.WriteLine ("Price updated");


			}


		}

		public static void UpdateQuattity(){

			string name;
			int Quattity;

			try {

				Console.WriteLine ("Please enter the name of the product ");
				Console.WriteLine ("Name");
				name = Console.ReadLine ();

				Console.WriteLine ("Please enter the name of the Quattity ");
				Console.WriteLine ("Quattity");
				Quattity = Convert.ToInt16(Console.ReadLine ());

				manager.updateQuantity(name,Quattity);

			} catch (Exception ex) {

				if (ex != null) {
					Console.WriteLine ("Invalid input\n You will be redirected to Main Menu");
					Menu ();
				}
				Console.WriteLine ("Quantity updated");


			}


	}
	}}
