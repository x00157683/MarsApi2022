using System;
using System.Linq;
using System.Collections.Generic;

namespace EAD_Ca3.Data
{
    public class TempUser  //not in storage
    {
		public List<Photo> myFavs; 
		public List<Photo> ?SortedList;  

		public string name { get; init; } = "toasty";


		public TempUser()
		{


			this.myFavs = new List<Photo>();  //new empty list
		}

		public void SortFavs()
		{

			if(myFavs != null)   //check
            {

				SortedList = myFavs.OrderBy(p => p.earth_date).ToList();  //creates new list to store ordered favs
				foreach (var item in SortedList)
				{
					Console.WriteLine(item);   //prints to console
				}

			}
            else
            {
				Console.WriteLine("No list available");
            }
			

		}


		public void ViewFavorites()
		{
			foreach (var item in myFavs)
			{
				Console.WriteLine(item);
			}
		}


	}
}
