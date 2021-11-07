using System;
using System.Collections.Generic;
using RepetitionInheritance;
using RepetitionInheritance.Exercise1;
using RepetitionInheritance.Exercise2;

//int[] arrayBoy = new[] { 1, 2, 3, 4 };
//ArrayModifier arrModBoy = new IncrementModifier(arrayBoy);
//arrModBoy.Modify();

List<IComputation> computations = new();
computations.Add(new AdditionComputation());
computations.Add(new SubtractionComputation());
Console.WriteLine("Format ex: minus 6 5 5 or + 5 5 5...8");
while (true)
{
    string input = Console.ReadLine();
    string[] parts = input.Split(" ");
    foreach (var element in computations)
    {
        if (element.CanCompute(parts[0]))
        {
            Console.WriteLine(element.Compute(Array.ConvertAll(parts[1..parts.Length], int.Parse)));
        }

    }
}

