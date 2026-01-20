public class ResultadoValidacao
{
    public bool Sucesso {get;}
    public string? Erro {get;}

    private ResultadoValidacao(bool sucesso, string? erro)
    {
        Sucesso = sucesso;
        Erro = erro;
    }

    public static ResultadoValidacao Ok() => new(true, null);
    public static ResultadoValidacao Falha(string erro) => new(false, erro);
}