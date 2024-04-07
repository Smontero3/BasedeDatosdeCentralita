
using System;

public class Centralitas
{
    private int numeroLlamadas;
    private decimal costeLlamadas;

    public Centralitas()
    {
    }

    public Centralitas(int numeroLlamadas, decimal costeLlamadas)
    {
        this.numeroLlamadas = numeroLlamadas;
        this.costeLlamadas = costeLlamadas;
    }

    public int GetNumeroLlamadas()
    {
        return numeroLlamadas;
    }

    public decimal GetCosteLlamadas()
    {
        return costeLlamadas;
    }

    public void ImprimirCosteTotalLlamadas()
    {
        Console.WriteLine("El coste total de las llamadas es: RD$" + GetCosteLlamadas());
    }

    public void NumeroTotalLlamada()
    {
        Console.WriteLine("El numero total de llamadas ha sido: " + GetNumeroLlamadas());
    }

    public void RegistrarLlamadas(Llamada param)
    {
        numeroLlamadas += 1;
        costeLlamadas += param.CalcularPrecio();
    }
}

public abstract class Llamada
{
    private string numQueLlama;
    private string numDestino;
    private int segundosLlamada = 0;



    public Llamada(string numQueLlama, string numDestino, int segundosLlamada)
    {
        this.numQueLlama = numQueLlama;
        this.numDestino = numDestino;
        this.segundosLlamada = segundosLlamada;
    }

    public abstract decimal CalcularPrecio();
    public abstract void ImprimirCosteLlamada();

    public void SetNumQueLlama(string numQueLlama)
    {
        this.numQueLlama = numQueLlama;
    }

    public void SetNumDestino(string numDestino)
    {
        this.numDestino = numDestino;
    }

    public void SetSegundosLlamada(int segundosLlamada)
    {
        this.segundosLlamada = segundosLlamada;
    }

    public string GetNumQueLlama()
    {
        return numQueLlama;
    }

    public string GetNumDestino()
    {
        return numDestino;
    }

    public int GetSegundosLlamada()
    {
        return segundosLlamada;
    }

    public void ImprimirNumOrigen()
    {
        Console.WriteLine("El numero que llama es: " + GetNumQueLlama());
    }

    public void ImprimirNumDestino()
    {
        Console.WriteLine("El numero al que se llama es: " + GetNumDestino());
    }

    public void ImprimirDuracionSegundos()
    {
        Console.WriteLine("La duracion en segundos de la llamada ha sido: " + GetSegundosLlamada());
    }
}

public class LlamadaLocal : Llamada
{
    private decimal costeLocal = 0.15m;



    public LlamadaLocal(string numQueLlama, string numDestino, int segundosLlamada) : base(numQueLlama, numDestino, segundosLlamada)
    {
    }

    public override decimal CalcularPrecio()
    {
        return (costeLocal * base.GetSegundosLlamada());
    }

    public override void ImprimirCosteLlamada()
    {
        Console.WriteLine("El coste total de la llamada local es: RD$" + (costeLocal * base.GetSegundosLlamada()));
    }
}

public class LlamadaProvincial : Llamada
{
    private decimal costeProvincial1 = 0.20m;
    private decimal costeProvincial2 = 0.25m;
    private decimal costeProvincial3 = 0.30m;
    private int llamada = 0;

    public LlamadaProvincial(string numQueLlama, string numDestino, int segundosLlamada, int llamada) : base(numQueLlama, numDestino, segundosLlamada)
    {
        this.llamada = llamada;
    }

    public override decimal CalcularPrecio()
    {
        if (llamada == 1)
        {
            return (base.GetSegundosLlamada() * costeProvincial1);
        }
        else if (llamada == 2)
        {
            return (base.GetSegundosLlamada() * costeProvincial2);
        }
        else
        {
            return (base.GetSegundosLlamada() * costeProvincial3);
        }
    }

    public override void ImprimirCosteLlamada()
    {
        if (llamada == 1)
        {
            Console.WriteLine("El precio de la llamada #1 es: RD$" + base.GetSegundosLlamada() * costeProvincial1);
        }
        else if (llamada == 2)
        {
            Console.WriteLine("El precio de la llamada #2 es: RD$" + base.GetSegundosLlamada() * costeProvincial2);
        }
        else
        {
            Console.WriteLine("El precio de la llamada #3 es: RD$" + base.GetSegundosLlamada() * costeProvincial3);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Centralitas c = new Centralitas();
        Llamada l1 = new LlamadaLocal("809-995-0417", "829-123-4567", 43);
        Llamada l2 = new LlamadaLocal("809-999-9999", "829-987-6543", 93);
        Llamada p1 = new LlamadaProvincial("809-888-8888", "829-111-1111", 32, 1);
        Llamada p2 = new LlamadaProvincial("809-777-7777", "829-222-2222", 54, 3);

        c.RegistrarLlamadas(l1);
        c.RegistrarLlamadas(l2);
        c.RegistrarLlamadas(p1);
        c.RegistrarLlamadas(p2);
        l1.ImprimirNumOrigen();
        l1.ImprimirNumDestino();
        l1.ImprimirDuracionSegundos();
        l1.ImprimirCosteLlamada();
        l2.ImprimirNumOrigen();
        l2.ImprimirNumDestino();
        l2.ImprimirDuracionSegundos();
        l2.ImprimirCosteLlamada();
        p1.ImprimirNumOrigen();
        p1.ImprimirNumDestino();
        p1.ImprimirDuracionSegundos();
        p1.ImprimirCosteLlamada();
        p2.ImprimirNumOrigen();
        p2.ImprimirNumDestino();
        p2.ImprimirDuracionSegundos();
        p2.ImprimirCosteLlamada();
       

 c.NumeroTotalLlamada();
        c.ImprimirCosteTotalLlamadas();
    }
}


