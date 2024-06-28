using AutoMotoApp;

var stack = new BasicStack();
stack.Push(4.5);
stack.Push(45);
stack.Push(245);

double sum = 0.0;

while (stack.Count > 0)
{
    double item = stack.Pop();
    Console.WriteLine($"Item: {item}");
    sum += item;
}
Console.WriteLine($"Sum: {sum}");
