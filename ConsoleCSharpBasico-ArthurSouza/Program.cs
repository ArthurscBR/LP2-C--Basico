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

    public static void Operadores()
    {
        int a = 2, b = 3;
        Console.WriteLine("Operadores relacionais");
        Console.WriteLine($"a==b: {a==b}");
        Console.WriteLine($"a>b: {a>b}");
        Console.WriteLine($"a<b: {a<b}");
        Console.WriteLine($"a>=b: {a>=b}");
        Console.WriteLine($"a<=b: {a<=b}");
        Console.WriteLine($"a!=b: {a!=b}");
        Console.WriteLine("Operadores logicos");
        Console.WriteLine($"AND &&: {a>3 && b>3}");
        Console.WriteLine($"OR ||: {a>3 || b==3}");
        Console.WriteLine($"XOR ^: {a<3 ^ b==3}");
        Console.WriteLine($"NOT !: {!(a>b)}");
    }

    public static void concat_string()
    {
        string a = "Hello";
        string b = "World";
        string c = a+" "+b;
        string d = c + ", My first string!";
        Console.WriteLine(d);
    }

    public static void arrays()
    {
        /*
        Questão do chat:

            Crie um programa em C# que:

            Leia 5 números inteiros digitados pelo usuário e armazene em um array.

            Mostre todos os números digitados.

            Mostre o maior número, o menor número e a média dos valores.
        */
        int[] vetor = new int[5];
        for(int i=0;i<vetor.Length;i++)
        {
            vetor[i] = Convert.ToInt32(Console.ReadLine());
        }

        int sum = 0, maior = vetor[0], menor = vetor[0];


        Console.WriteLine($"Numeros digitados: ");
        for(int i=0;i<vetor.Length;i++)
        {
            Console.Write($"{vetor[i]} ");
            if(maior<vetor[i])
                maior = vetor[i];
            if(menor>vetor[i])
                menor = vetor[i];
            sum += vetor[i];
        }

        Console.WriteLine($" ");
        Console.WriteLine($"Maior numero: {maior}");
        Console.WriteLine($"Menor numero: {menor}");
        Console.WriteLine($"Media : {sum/vetor.Length}");

    }

    public static void condicionais()
    {
        /* Questão do chat:
            * Exercício: Classificação de Notas
            *
            * Escreva um programa que leia uma nota (valor decimal entre 0.0 e 10.0)
            * e imprima a classificação do aluno de acordo com a seguinte tabela:
            *
            * Nota entre 9.0 e 10.0      → "Excelente"
            * Nota entre 7.0 e 8.9       → "Bom"
            * Nota entre 5.0 e 6.9       → "Regular"
            * Nota entre 0.0 e 4.9       → "Insuficiente"
            * Nota fora desse intervalo → "Nota inválida"
            *
            * Requisitos:
            * - Usar estruturas condicionais (if, else if, else)
            * - Validar se a nota está dentro do intervalo de 0.0 a 10.0
            * - Exibir a classificação correta de acordo com a nota
        */
        
        double nota = Convert.ToDouble(Console.ReadLine());

        if(nota<0.0 || nota>10.0)
        {
            Console.WriteLine("Nota invalida");
        }else{
            if(nota<=4.9 && nota>=0.0)
            {
                Console.WriteLine("Insuficiente");
            }
            else if(nota<=6.9)
            {
                Console.WriteLine("Regular");
            }
            else if(nota<=8.9)
            {
                Console.WriteLine("Bom");
            }
            else if(nota<=10.0)
            {
                Console.WriteLine("Excelente");
            }
        }
    }

    public static void interpolacao()
    {
        string a = "Hello";
        string b = " World";
        Console.WriteLine($"{a}{b}");
    }


    static void Main(string[] args){
        // Tipos();
        // Const_var();
        // nulo();
        // criando_obj();
        // Convertendo();
        // Operadores();
        // concat_string();
        // arrays();
        // condicionais();
        /* Comentarios: '//' o '/*' */

        var op = Console.ReadLine();

        switch (op)
        {
            case "1":
                Tipos();
                break;
            case "2":
                Const_var();
                break;
            case "3":
                nulo();
                break;
            case "4":
                criando_obj();
                break;
            case "5":
                Convertendo();
                break;
            case "6":
                Operadores();
                break;
            case "7":
                concat_string();
                break;
            case "8":
                arrays();
                break;
            case "9":
                condicionais();
                break;
            case "10":
                interpolacao();
                break;
            default:
                Console.WriteLine("Arthur Souza de Carvalho");
                break;
        }

    }
}
