namespace RMFinanca.Models
{
    public class Cliente
    {
        //prop tab
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string DDD { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public  string Complemento { get; set; }
        public  string UF  { get; set; }
        public string CEP { get; set; }
        public IList<LancFinanca> LancFinanca { get; set; }
    }
}
