Console.Write("Введите цифру дня недели: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n % 7 == 6 || n % 7 == 0) Console.WriteLine("УРА! Выходной!");
else Console.WriteLine ("Рабочий...");

//int n = Convert.ToInt32(Console.ReadLine());
//if (n % 7 == 1) Console.WriteLine("Понедельник");
//if (n % 7 == 2) Console.WriteLine("Вторник");
//if (n % 7 == 3) Console.WriteLine("Среда");
//if (n % 7 == 4) Console.WriteLine("Четверг");
//if (n % 7 == 5) Console.WriteLine("Пятница");
//if (n % 7 == 6) Console.WriteLine("Суббота");
//if (n % 7 == 0) Console.WriteLine("Воскресенье");