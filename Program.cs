double cm;
double m;
double km;

Console.Clear();

Console.Write("Entre com a medida (em metros): ");
m = Convert.ToDouble (Console.ReadLine());

Console.WriteLine(@"
--- Equivalência ---");

cm = m / 100;

Console.WriteLine($"{cm} cm");

Console.WriteLine($"{m} m");

km = m / 1000;

Console.WriteLine($"{km} km");