using mylib;

class Program{
    public static void Tipos(){
        int a = 10;
        Console.WriteLine("Um inteiro: "+ a);
        float b = 20.0f;
        Console.WriteLine("Um float: "+ b);
        double c = 20.123456;
        Console.WriteLine("Um float: "+ c);
        char d = 'c';
        Console.WriteLine("Um char: "+ d);
        string e = "dotnet";
        Console.WriteLine("Uma Strirng: "+ e);
        bool f = true;
        Console.WriteLine("Um tipo boleano: "+ f);
        DateTime g = DateTime.Now;
        Console.WriteLine("Data atual: "+ g);
    }

    public static void Const_var()
    {
        const double pi = 3.14;
        Console.WriteLine("Uma constante: "+pi);
        var i = "Hello World";
        Console.WriteLine("Declaração com var: "+i);
    }

    public static void nulo()
    {
        Console.WriteLine("Pode receber null");
        string? str = null;

        if(str == null)
        {
            Console.WriteLine("Se printou é pq é nulo");
        }

    }

    static void Main(string[] args){
        Tipos();
        Console.WriteLine(" ");
        Const_var();
        nulo();

    }
}
