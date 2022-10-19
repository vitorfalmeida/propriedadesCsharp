namespace propriedadesCsharp.Model
{
  public class Venda
    {
        public Venda(int id, String produto, double preco){
            Id = id;
            Produto = produto;
            Preco = preco;
        }
        public int Id { get; set; }
        public String Produto { get; set; }
        public double Preco { get; set; }
    }
}