using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> list = new List<int>() { 2,4,6,47,251,8,7,15,54};
			List<int> result = GetEvenItems(list,x=>x%2==0);

			foreach (int item in result)
			{
				Console.WriteLine(item);
			}

		}
		public static List<int> GetEvenItems(List<int> list,Func<int,bool>func)
	    {
			List<int> result = new List<int>();
			for (int i = 0; i < list.Count;i++)
			{
				if (func(list[i]))
					result.Add(list[i]);
			}
			return result;
	    }
	}

}
