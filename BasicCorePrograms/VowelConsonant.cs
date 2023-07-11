using System;
namespace BasicCorePrograms
{
	public class VowelConsonant
	{
		public bool IsVowel(string a)
		{
			char[] vowels= { 'a', 'e' , 'i' , 'o' , 'u'} ;
			for(int i =0; i <5; i++)
			{
				if (a[0] == vowels[i])
				{
					return true;
				}

			}

			return false;

		}
	}
}

