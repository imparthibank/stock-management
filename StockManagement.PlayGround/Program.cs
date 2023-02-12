// See https://aka.ms/new-console-template for more information

Stack<double> stack=new();
stack.Push(9.2);
stack.Push(7.2);
stack.Push(10.2);
stack.Count();
Console.WriteLine($"Sum:{stack.Sum()}");
Console.WriteLine($"Count:{stack.Count()}");
Console.ReadLine();