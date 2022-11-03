// See https://aka.ms/new-console-template for more information







namespace Edka.Sa05;

internal class Disciplina
{
      
    public string? Nome { get; set; }

    public DateTime DataInicial { get; set; }


    public DateTime DataFinal { get; set; }

    public override string ToString()=> $"{Nome,-10}-----{DataInicial}----{DataFinal}";




}