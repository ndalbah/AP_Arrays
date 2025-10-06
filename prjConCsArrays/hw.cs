using System;
namespace prjConCsArrays
{
	public static class hw
	{
		public static void home()
		{
			Int16 add;
			Single vals;
			string yn;

			Console.Write("Enter number of vals");
			add = Convert.ToInt16(Console.ReadLine());
			Single sum = 0;

			for (Int16 i = 1; i < add; i++)
			{
				Console.Write("Enter value " + i);
				vals = Convert.ToSingle(Console.ReadLine());
				sum += vals;
			}
			Console.WriteLine(sum);

			
			
			

			

		}
	}
}

