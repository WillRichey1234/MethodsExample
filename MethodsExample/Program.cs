using System;

namespace MethodsExample
{
	class MainClass
	{
		/// <summary>
		/// Simple program that reverses the characters in a string using an abstracted Swap method.
		/// </summary>
		/// <param name="args">The command-line arguments.</param>
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
					// if the two characters are not the same, then this is NOT a palandrome
					// and so, I need to swap the characters.
					isPalandrome = false;

					// do the swap!
					// The 'ref' keyword means pass-by-reference.
					// This means that changes in the child scope
					// are kept in the main scope.
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
