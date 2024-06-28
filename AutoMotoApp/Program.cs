using AutoMotoApp;

var stack = new BasicStack<double>();
stack.Push(4.5);
stack.Push(45);
stack.Push(245);

var stackString = new BasicStack<string>();
stackString.Push("Company");
stackString.Push("Company1");
stackString.Push("Company2");

double sum = 0.0;

while (stack.Count > 0)
{
    double item = stack.Pop();
    Console.WriteLine($"Item: {item}");
    sum += item;
}
Console.WriteLine($"Sum: {sum}");
