// переменные
using System.Xml.Linq;

bool q = true;      // хранит значение true или false
byte w = 1;         // хранит целое число от 0 до 255 и занимает 1 байт
sbyte e = -101;     // хранит целое число от -128 до 127 и занимает 1 байт
short r = 1;        // хранит целое число от -32768 до 32767 и занимает 2 байта
ushort t = 1;       // хранит целое число от 0 до 65535 и занимает 2 байта
int y = 10;         // хранит целое число от -2147483648 до 2147483647 и занимает 4 байта
uint u = 10;        // хранит целое число от 0 до 4294967295 и занимает 4 байта
double i = 2.6;     // хранит число с плавающей точкой от ±5.0*10-324 до ±1.7*10308 и 8 байта
string o = "Hello"; // хранит набор символов Unicode
object p = 3.14;    // может хранить значение любого типа данных

// получение информации с консоли
string? a = Console.ReadLine();                 // получаем строку
int s = Convert.ToInt32(Console.ReadLine());    // получаем целое число
double d = Convert.ToDouble(Console.ReadLine()); // получаем число в плавующей запятой

// логические операции
int f = y + w;
int g = y - w;
int h = y * w;
int j = y / w;
double k = 10.0 / 4.0;
int l = ++j;    // +1
int x = --j;    // -1

// присвоение
int c, v, b;
c = v = b = 34;
c = v = b = 34 * 2 / 4;
w += 10;    // w = w + 10

// операции сравнения
int n = 10;
int m = 4;
bool qq = n == m; // false
bool ww = n != m; // true
bool ee = n < m; // false
bool tt = n != m;
bool rr = (5 > 6) | (4 < 6);

// IF // если одно условие можно убрать {}
int num1 = 8;
int num2 = 6;
if (num1 > num2 && num1 == 8)
{
    Console.WriteLine($"Число {num1} больше числа {num2}");
}
else
{
    Console.WriteLine($"Число {num1} меньше числа {num2}");
}

if (num1 > num2) Console.WriteLine($"Число {num1} больше числа {num2}"); // в одну строчку

// FOR // если нужно выйти, можем использовать break
for (int yy = 1; yy < 4; yy++) // выполнится 3 раза
{
    Console.WriteLine(yy);
}

// WHILE
int oo = 6;
while (oo > 0)
{
    Console.WriteLine(oo);
    oo--;
}

// вывод
Console.Write(o); // не добавляет переход на следующую строку
Console.WriteLine(a);
Console.WriteLine($"Имя: {o}  Возраст: {y}  Рост: {i}м"); // вывод нескольких значений
