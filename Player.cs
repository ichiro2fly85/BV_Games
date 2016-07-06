using System;

namespace Business
{

	public class Player
	{
		//Variables

		private string pName;
		private string pLocation;
		public string[] pSpecialty = {"Automotive", "Technology", "Agriculture", "Mining", "Retail"};
		public int cSpecialty;
		private string companyName;
		private string secretaryName;

		//Player Object

		public Player(string name, string loc, int spec, string comp, string secret)
		{
			pName = name;
			pLocation = loc;
			companyName = comp;
			secretaryName = secret;
			cSpecialty = spec;


		}

		//Methods

		public string pSpecial(int n)
		{
			switch(n)
			{


			case 1:
				return pSpecialty [0];				

			case 2:
				return pSpecialty [1];

			case 3:
				return pSpecialty [2];

			case 4:
				return pSpecialty [3];

			case 5:
				return pSpecialty [4];

			default:
				return "Not Found";

			}
		}

		public string playerInfo()
		{

			string pselection = pSpecialty[cSpecialty];



			return "Name: " + pName + "\nLocation: " + pLocation + "\nSpecialty: " + pselection + "\nCompany Name: " + companyName + "\nSecretary Name: " + secretaryName;
		}




	}

	public class Program 
	{
		public static void Main(string[] args) 
		{

			//variables
			int specialty = 0;
			bool isSpecialty = true;


			Console.WriteLine("Welcome to Business Simulator 2016\n\n\n");

			Console.WriteLine("Please Enter Your Name: ");
			string na = Console.ReadLine();

			Console.WriteLine("Please Enter Your Location: ");
			string lo = Console.ReadLine();

			while(isSpecialty)
			{
				Console.WriteLine("Please Select Your Specialty: ");
				string sp = "";

				sp = Console.ReadLine();

				try
				{
					specialty = int.Parse(sp);

					if(specialty > 4 || specialty < 0)
					{
						Console.WriteLine("Please enter a number between 0 - 4 ");
					}
					else
					{
						isSpecialty = false;
					}
				}
				catch(FormatException e)
				{
					Console.WriteLine(" Ooops an error has occured. The string ' " + sp + " ' is not a valid integer.\n\n " + e + "\n\n");



				}
			}

			Console.WriteLine("Please Enter Your Company Name: ");
			string cn = Console.ReadLine();

			Console.WriteLine("Finally...Please Enter Your Secretary Name: ");
			string sn = Console.ReadLine();

			Player appbbjohn = new Player(na, lo, specialty, cn, sn);


			Console.WriteLine(appbbjohn.playerInfo());



		}
	}
}

