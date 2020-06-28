namespace Loja.Testes.ConsoleApp.Model
{
    public class Endereco
    {
        public string CEP { get; internal set; }
        public string Logradouro { get; internal set; }
        public string Numero { get; internal set; }
        public string Complemento { get; internal set; }
        public string Bairro { get; internal set; }
        public string Cidade { get; internal set; }
        public Cliente Cliente { get; internal set; }
    }
}