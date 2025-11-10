using System;

namespace Weeek3
{
	public class Program
	{
		public static void Main()
		{
			Operators op = new Operators();
			op.Add(5,10);
			op.Sub(25,20);
			op.multi(5, 20);
			op.div(30, 5);
			op.OddEvenfinder(20);

		}
	}
}

