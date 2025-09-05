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

    public static void criando_obj()
    {
        Pessoa p1 = new Pessoa("Arthur", 21);
        Console.WriteLine("Objeto da Classe Pessoa criado.");
        p1.nome = "Arthur Souza";
        p1.Hello();
    }

    public static void Convertendo()
    {
        Console.WriteLine("digite um numero");
        var num = Console.ReadLine();
        Console.WriteLine($"tipo do dado recebido: {num.GetType()}");
        var conv_num = Convert.ToInt32(num);
        Console.WriteLine($"Tipo do dado apos a conversao: {conv_num.GetType()}");
    }

    static void Main(string[] args){
        Tipos();
        Const_var();
        nulo();
        criando_obj();
        Convertendo();
    }
}
