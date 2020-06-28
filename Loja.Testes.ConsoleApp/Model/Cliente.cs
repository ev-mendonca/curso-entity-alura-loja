namespace Loja.Testes.ConsoleApp.Model
{
    public class Cliente
    {
        public int Id { get; internal set; }
        public string Nome { get; internal set; }
        public string Email { get; internal set; }
        public Endereco EnderecoDeEntrega { get; internal set; }
    }
}
