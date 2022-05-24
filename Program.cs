// See https://aka.ms/new-console-template for more information

int[] original = new int[5];
int[] replica = new int[5];

Console.WriteLine("-----------------------------------");


for (int i = 0; i < original.Length; i++)
{
    Console.WriteLine($"What number would you like in array slot number {i + 1}?");
    original[i] = Convert.ToInt16(Console.ReadLine());
}

Console.WriteLine("\n\n-----------------------------------");
Console.WriteLine("Original Array-------Replica Array");

for (int i = 0; i < original.Length; i++)
{
    replica[i] = original[i];
    Console.WriteLine("\t" +original[i] + "\t\t" + replica[i]);
}

Console.WriteLine("-----------------------------------");
Console.ReadKey();
