﻿using System.Text;

namespace NackademinUppgift05
{
	public partial class Animal
	{
		public override string ToString()
		{
			return $"{Name} ({Species.Label}), from {Origin}";
		}
	}
}