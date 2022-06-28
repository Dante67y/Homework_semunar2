int n;
Console.Write("Введите число ");
n = Convert.ToInt32(Console.ReadLine());
if (n < 100) Console.WriteLine("Третьей цифры нет");
else {
    if (n > 99 && n < 1000) Console.WriteLine(n % 10);
    else {
        if (n > 999 && n < 10000) Console.WriteLine((n % 100) / 10);
        else {
            if (n > 9999 && n < 100000) Console.WriteLine((n % 1000) / 100);
            else {
                if (n > 99999 && n < 1000000) Console.WriteLine((n % 10000) / 1000);
                else {
                    if (n > 999999 && n < 10000000) Console.WriteLine((n % 100000) / 10000);
                    else {
                        if (n > 9999999 && n < 100000000) Console.WriteLine((n % 1000000) / 100000);
                        else {
                            if (n > 99999999 && n < 1000000000) Console.WriteLine((n % 10000000) / 1000000);
                        }
                    }
                }
            }
        }
    }
}
