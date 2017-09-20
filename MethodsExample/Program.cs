using System;

namespace MethodsExample
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Enter a phrase");
			String phrase = Console.ReadLine();
			char[] chars = phrase.ToCharArray();

			bool isPalandrome = true; // this is a FLAG value.

			// Oh shit! What's going on here!?!?!
			for (int i = 0, j = chars.Length - 1; i < chars.Length / 2; i++, j--)
			{
				if (chars[i] != chars[j])
				{
					isPalandrome = false;
					Swap(ref chars[i], ref chars[j]);
				}
			}

			if (isPalandrome) Console.WriteLine("Dude, that's a palandrome.");
			else Console.WriteLine(new String(chars));

			Console.ReadKey();
		}

		/// <summary>
		/// Swap the values of a and b.
		/// </summary>
		/// <param name="a">a letter</param>
		/// <param name="b">another letter</param>
		public static void Swap(ref char a, ref char b)
		{
			char temp = a;
			a = b;
			b = temp;
		}
	}
}
