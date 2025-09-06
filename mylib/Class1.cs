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

public static class q2
{
    public static void media_peso()
    {
        int r = 2;
        double[] peso = new double[r];
        int[] idade = new int[r];
        double[] sum_pesos = new double[4];
        int[] qtd_pessoas = new int[4];

        for(int i = 0; i<peso.Length; i++)
        {
            Console.WriteLine($"Digite a idade da pessoa {i+1}: ");
            idade[i] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Digite o peso da pessoa {i+1}: ");
            peso[i] = Convert.ToDouble(Console.ReadLine());

            if (idade[i]<=10 && idade[i]>0)
            {
                qtd_pessoas[0] += 1;
                sum_pesos[0] += peso[i];
            }
            else if (idade[i]<=20 && idade[i]>=11)
            {
                qtd_pessoas[1] += 1;
                sum_pesos[1] += peso[i];
            }
            else if (idade[i]<=30 && idade[i]>=21)
            {
                qtd_pessoas[2] += 1;
                sum_pesos[2] += peso[i];
            }
            else
            {
                qtd_pessoas[3] += 1;
                sum_pesos[3] += peso[i];
            }
        }
       
        for(int i=0;i<sum_pesos.Length; i++)
        {

            switch(i)
            {
                case 0:
                    Console.WriteLine($"Medias de peso das pessoas entre 0 e 10 anos: ");
                    break;
                case 1:
                    Console.WriteLine($"Medias de peso das pessoas entre 11 e 20 anos: ");
                    break;
                case 2:
                    Console.WriteLine($"Medias de peso das pessoas entre 21 e 30 anos: ");
                    break;
                case 3:
                    Console.WriteLine($"Medias de peso das pessoas com mais que 30 anos: ");
                    break; 
            }

            if(qtd_pessoas[i]>0)
            {
                Console.WriteLine(sum_pesos[i]/qtd_pessoas[i]);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
