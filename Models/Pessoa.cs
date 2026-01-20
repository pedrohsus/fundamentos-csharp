public class Pessoa
{
    public int Idade {get;}

    public Pessoa(int idade)
    {
        Idade = idade;
    }

    public ResultadoValidacao ValidarIdade()
    {
        if (Idade < 0 || Idade > 120)
            return ResultadoValidacao.Falha("Idade fora do intervalo permitido (0 à 120).");

        if (Idade < 18)
            return ResultadoValidacao.Falha("Pessoa menor de idade.");

        return ResultadoValidacao.Ok();
    }
}