namespace RestApiModeloDDD.Domain.Entitys
{
    public class Produto : Base
    {
        public string Name { get; set; }
        public decimal Preco { get; set; }
        public bool IsDisponivel { get; set; }
    }
}
