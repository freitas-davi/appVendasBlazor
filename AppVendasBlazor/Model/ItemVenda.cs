using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppVendasBlazor.Model
{
    [Table("tbItemVenda")]
    public class ItemVenda
    {
        [Key]
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
        public int VendaId { get; set; }
        public Pedido Pedido { get; set; }
        public int QuantidadeProduto { get; set; }
        public double PrecoUnitario { get; set; }
    }
}
