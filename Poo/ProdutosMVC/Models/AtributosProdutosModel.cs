namespace ProdutosMVC.Models
{
    public class AtributosProdutosModel : BaseModel
    {
        public double Preço { get; set; }
        public string Categoria { get; set; }
        public int QemEstoque { get; set; }
        public double Peso { get; set; }
    }
}