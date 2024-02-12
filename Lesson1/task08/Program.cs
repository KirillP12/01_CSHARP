// складываем первое и последние число трёх значного числа.

int a = 834;
int a1 = a / 100;
int a2 = a % 10;     // В данном случае процент отделяет передние числа от поcледнего
                        // таким образом сколько нулей в числе, которое стоит после % столько последних цифр мы получим от числа которое стоит перед % .
int sum = a1 + a2;
System.Console.WriteLine(sum);

System.Console.WriteLine(' ');

float c = 4933;
float chyslo = c % 100 ;
System.Console.WriteLine(chyslo);

int n = 12345;
int count = 0;
while (n > 0)
{
    count++;

    int remainder = n % 10;

    Console.WriteLine(remainder);

    n /=10;
}
System.Console.WriteLine(' ');

System.Console.WriteLine(count);
