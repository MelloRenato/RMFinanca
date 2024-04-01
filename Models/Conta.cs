namespace RMFinanca.Models
{
    public class Conta
    {
        public int Id { get; set; }
        public string Banco { get; set; }
        public string Agencia { get; set; }
        public string ContaCorrente { get; set; }
        public IList<LancFinanca> LancFinanca { get; set; }
    }
}
