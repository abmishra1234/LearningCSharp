// See https://aka.ms/new-console-template for more information

using CSharp_Algorithm;


Console.WriteLine("Hello, World!");
StringAlgo sa = new StringAlgo();

//Console.WriteLine(sa.IsUpperCase("ABCDghIJ"));
//Console.WriteLine(sa.IsUpperCase("ABCDIJ"));

//Console.WriteLine(sa.IsLowerCase("abcdefAghij"));
//Console.WriteLine(sa.IsLowerCase("abcdefaghij"));

//Console.WriteLine(sa.IsPasswordComplex("abcd"));
//Console.WriteLine(sa.IsPasswordComplex("Abcd"));
//Console.WriteLine(sa.IsPasswordComplex("AbcdF"));
//Console.WriteLine(sa.IsPasswordComplex("Abcd0"));

Console.WriteLine(sa.NormalizeString("           Hello There, beautiful lady          "));
Console.WriteLine(sa.Reverse("Abinash"));
Console.WriteLine(sa.Reverse2("Abinash"));
