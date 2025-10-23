using Tyuiu.MazurkevichVS.Sprint3.Task1.V25.Lib;
DataService ds = new DataService();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");

int value = 5;
int startvalue = 1;
int stopvalue = 6;
Console.WriteLine("Переменная X: " + value);
Console.WriteLine("Старт шага: " + startvalue);
Console.WriteLine("Конец шага: " + stopvalue);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Произведение равно: " + ds.GetMultiplySeries(value, startvalue, stopvalue));
Console.ReadKey();
