public class Produto
{
    public Produto(int Id, string Descricao, string Categoria)
    {
        this.id = Id;
        this.descricao = Descricao;
    }
       private int Id { get; private set; }
       private string Descricao { get; private set; }
       private string Categoria {get : private set;} 

}
