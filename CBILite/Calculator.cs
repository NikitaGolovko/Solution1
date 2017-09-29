//using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBILite
{
	public class Calculator : Core.ICalc
	{
		public int Add(int number1, int number2)
		{
			//UnityContainer container = new UnityContainer();
			return (number1 + number2);
		}

		public int Substract(int number1, int number2)
		{
			return (number1 - number2);
		}
	}
}
