using Tyuiu.MazurkevichVS.Sprint3.Task2.V6.Lib;
DataService ds = new DataService();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");

double value = 0.25;
int startvalue = 1;
int stopvalue = 10;
Console.WriteLine("Переменная X: " + value);
Console.WriteLine("Старт шага: " + startvalue);
Console.WriteLine("Конец шага: " + stopvalue);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Произведение ряда: " + ds.GetMultiplySeries(value, startvalue, stopvalue));
Console.ReadKey();
