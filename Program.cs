Console.Clear();

bool t, p, r, w;

Console.WriteLine("--- Simulado de Luz de Advertência ---\n");
Console.WriteLine("[A]tivado, [outro] Desativado");

Console.Write("Sensor de temperatura...: ");
string sensorT = Console.ReadLine()!.ToUpper();
t = (sensorT == "A");


Console.Write("Sensor de pressão.......: ");
string sensorP = Console.ReadLine()!.ToUpper();
p = (sensorP == "A");


Console.Write("Sensor de rotação.......: ");
string sensorR = Console.ReadLine()!.ToUpper();
r = (sensorR == "A");

w = t && (p || !r);

string resultado;

resultado = w ? "Ativada" : "Desativada";

Console.WriteLine($"\nA luz de advertência estará {resultado}");


