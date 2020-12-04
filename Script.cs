using System;
using System.Security.Principal;

public class Conta
{
    public string nome;
    public int saldo = 0;

    public Conta(string name, int deposito)
    {
        nome = name;
        saldo += deposito;
    }

    ~Conta()
    {
        Console.WriteLine("A conta de {0} foi destruida", nome);
    }

    public void Depositar(int valor)
    {
        Console.Clear();
        saldo += valor;
        Console.WriteLine("DEPOSITADO COM SUCESSO");
    }

    public void Sacar(int valor)
    {
        if(saldo >= valor)
        {
            Console.Clear();
            saldo -= valor;
            Console.WriteLine("SACADO COM SUCESSO");
        }
        else
        {
            Console.Clear();
            Console.WriteLine("DINHEIRO INSUFICIENTE");
        }
    }
}
class Aula29
{
    static void Main()
    {
        Console.Write("Seu nome: ");
        string nome = Console.ReadLine();
        Console.Write("Depósito Inicial (sem centavos): R$");
        int depositoInic = int.Parse(Console.ReadLine());
        Conta n1 = new Conta(nome, depositoInic);

        bool loop = true;
        while (loop == true)
        {
            Console.WriteLine("{0} tem {1:c}", n1.nome, n1.saldo);
            Console.WriteLine("digite [1] para depositar, [2] para sacar, [3] para finalizar conta");
            switch(Console.ReadLine())
            {
                case "1":
                    Console.Write("Digite o valor (sem centavos): R$");
                    n1.Depositar(int.Parse(Console.ReadLine()));
                    break;
                case "2":
                    Console.Write("Digite o valor (sem centavos): R$");
                    n1.Sacar(int.Parse(Console.ReadLine()));
                    break;
                case "3":
                    loop = false;
                    break;
            }


        }
        
    }
}
