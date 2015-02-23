string inputText = Console.ReadLine();
double year = double.Parse(inputText);
double a = year % 19;
double b = Math.Floor(year / 100);
double c = year % 100;
double d = Math.Floor(b / 4);
double e = b % 4;
double f = Math.Floor((b + 8) / 25);
double g = Math.Floor((b - f + 1) / 3);
double h = (19 * a + b - d - g + 15) % 30;
double i = Math.Floor(c / 4);
double k = c % 4;
double L = (32 + 2 * e + 2 * i - h - k) % 7;
double m = Math.Floor((a + 11 * h + 22 * L) / 451);
double month = Math.Floor((h + L - 7 * m + 114) / 31);
double day = ((h + L - 7 * m + 114) % 31) + 1;
DateTime easterDate = new DateTime(
    (int) year, 
    (int) month, 
    (int) day);
Console.WriteLine(easterDate.ToLongDateString());