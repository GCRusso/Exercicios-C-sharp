Console.WriteLine($"Serie de Fibonacci");

int num1 = 0;
int num2 = 1;
int aux;

for (var i = 0; i < 500; i++)
{
    aux = num1;
    num1 = num2;
    num2 = num1 + aux;

    Console.WriteLine($"{num2}");

 if(num2 > 500)  {
    break;
    
 }
}