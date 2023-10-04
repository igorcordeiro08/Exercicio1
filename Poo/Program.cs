
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Aluno Igor = new Aluno("Igor");
        Igor.setProva1(7.0);
        Igor.setProva2(8.0);
        Igor.setTrabalho(5.0);
        double mediaFinal = Math.Round(Igor.CalculaMediaFinal(), 2);
        Console.WriteLine($"Media final de {Igor.nome}:" + mediaFinal);
    }
}
internal class Aluno
{
    public string nome;
    private double prova1, prova2;
    private double notaTrabalho;

    public Aluno(string nome)
    {
        this.nome = nome;
    }

    public void setProva1(double nota)
    {
        this.prova1 = nota;

    }

    public void setProva2(double nota)
    {
        this.prova2 = nota;
    }

    public void setTrabalho(double trab)
    {
        this.notaTrabalho = trab;


    }
    public double CalculaMediaFinal()
    {
        double pesoProva = 2.5;
        double pesoTrabalho = 2;

        double mediaProvas = (prova1 + prova2);
        double mediaFinal = (mediaProvas * pesoProva + notaTrabalho * pesoTrabalho) / (pesoProva * 2 + pesoTrabalho);

        return mediaFinal;
    }
}