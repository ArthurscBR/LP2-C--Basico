namespace mylib;

public class Pessoa
{
    public string nome;
    public int idade;

    public Pessoa(string nome, int idade)
    {
        this.nome = nome;
        this.idade = idade;
    }

    public void Hello()
    {
        Console.WriteLine($"Olá, {nome}!");
    }

}
