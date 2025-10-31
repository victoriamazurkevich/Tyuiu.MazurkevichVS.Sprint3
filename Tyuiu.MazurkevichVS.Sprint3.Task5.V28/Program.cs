using Tyuiu.MazurkevichVS.Sprint3.Task5.V28.Lib;
DataService ds = new DataService();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");

int x = 2;
int startValue1 = 1;
int startValue2 = 1;
int stopValue2 = 12;
int stopValue1 = 3;
Console.WriteLine("Старт шага первой суммы: " + startValue1);
Console.WriteLine("Старт шага второй суммы: " + startValue2);
Console.WriteLine("Конец шага первой суммы: " + stopValue1);
Console.WriteLine("Конец шага второй суммы: " + stopValue2);


Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Сумма ряда: " + ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2));
Console.ReadKey();
