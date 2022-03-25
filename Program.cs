System.Console.WriteLine("ta che adadi az donbale fibonach ra mikhaid");
int number = Convert.ToInt32(Console.ReadLine());
int a = 1;
int b = 0;
for (int i = 0; i < number; i++)
{
    a = a + b;
    Console.Write(a);
    Console.Write(" ");
    b = a + b;
    Console.Write(b);
    Console.Write(" ");
}
            