using System;

namespace CompatibilityExcercise.Standard
{
	public class StandardClassThing
	{
		public int Num1 { get; set; }
		public int Num2 { get; set; }

		public StandardClassThing(int num1, int num2)
		{
			this.Num1 = num1;
			this.Num2 = num2;
		}

		public int Calculate() => Num1 + Num2;
	}
}
