﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loopchengfa
{
	class Program
	{
		static void Main(string[] args)
		{
			for (int i = 1; i <= 9; i++)  // external for loop
			{
				// for (int j = 1; j <= 9; j++)  // internal for loop
				for (int j = 1; j <= i; j++)   // optional internal for loop
				{

					Console.Write("{0}*{1}={2}\t",i,j,i*j);
				}

				Console.WriteLine();
			}



		}
	}
}
