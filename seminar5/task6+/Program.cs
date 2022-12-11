// Необходимо найти  5 целых чисел (положительных), которые будут удовлетворять такому условию
// x^5 + y^5 + z^5 + q^5 = w^5 Т.е. сумма 4 чисел в пятой степени = 5 числу в пятой степени

void PrintText(string text)
{
    Console.Write(text);
}

long Gcd(long x, long y)
{
    while (x > 0 & y > 0)
    {
        if (x > y) x %= y;
        else y %= x;
    }
    return x + y;
}

string FindNumbers(int n, string str)
{
    for (int a = 1; a <= n; a++)
    {
        for (int b = a + 1; b <= n; b++)
        {
            for (int c = b + 1; c <= n; c++)
            {
                int e = c + 1;
                for (int d = c + 1; d <= n; d++)
                {
                    long a5 = (long) a*a*a*a*a;
                    long b5 = (long) b*b*b*b*b;
                    long c5 = (long) c*c*c*c*c;
                    long d5 = (long) d*d*d*d*d;
                    long sum = a5 + b5 + c5 + d5;
                    long e5 = (long) e*e*e*e*e;

                    while (e < n && (long) e*e*e*e*e < sum) e++;
                    if (sum == (long) e*e*e*e*e){
                        if (Gcd(a, Gcd( Gcd(b, c), Gcd(d,e))) == 1){
                            str += ($"{a}^5 + {b}^5 + {c}^5 + {d}^5 = {e}^5\n");
                            str += ($"{a5} + {b5} + {c5} + {d5} = {e5}\n");
                            return str;
                        }
                    }
                }
            }
        }
    }
    return str;
}

string answer = "Числа удовлетворяющие условию задачи: \n";
answer = FindNumbers(200, answer);
PrintText(answer);
Console.ReadLine();
