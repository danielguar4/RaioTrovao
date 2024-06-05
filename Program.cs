double Seg, kilometros = 0;

Console.WriteLine("Quantos segundos foi percorrido o tempo de trovão entre raio...: ");
Seg = Convert.ToDouble(Console.ReadLine());

void calculo(){
    kilometros = Seg * 340.29;
    kilometros = kilometros / 1000;
}

calculo();

Console.WriteLine($"A distancia percorrida foi...: {kilometros}");

