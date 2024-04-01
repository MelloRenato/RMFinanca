
namespace RMFinanca.Models
{
    public class LancFinanca
    {
        public int Id { get; set; }
        public string? PagarReceber { get; set; }
        public DateTime DtEmissao { get; set; }
        public DateTime DtPagto { get; set; }
        public DateTime DtVencimento { get; set; }
        public Double Valor { get; set; }
        public Double Juros { get; set; }
        public double VlPagto { get; set; }
        public string? Observacao { get; set; }
        public  Conta? Conta { get; set; }
        public Cliente? Cliente { get; set; }
    }

}
