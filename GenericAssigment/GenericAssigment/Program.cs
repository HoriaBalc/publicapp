using GenericAssigment;

GenericArray<string> genericArray = new GenericArray<string>();
genericArray.Set(0, "dada");
Console.WriteLine(genericArray.Get(0));
genericArray.Set(1, "nunu");
Console.WriteLine(genericArray.Get(1));
genericArray.Swap(0, 1);
Console.WriteLine(genericArray.Get(0));
Console.WriteLine(genericArray.Get(1));
genericArray.Swap("dada", "nunu");
Console.WriteLine(genericArray.Get(0));
Console.WriteLine(genericArray.Get(1));



