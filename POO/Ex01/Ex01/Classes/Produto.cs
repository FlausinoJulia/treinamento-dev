namespace Ex01.Classes
{
    public class Produto
    {
        private string _Nome;
        private decimal _Preco;
        private int _Quantidade;

        public Produto(string nome, decimal preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
            
        }

        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }

        public decimal Preco
        {
            get { return _Preco; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("O preço não pode ser negativo.");
                }

                _Preco = value;
            }
        } 

        public int Quantidade
        {
            get { return _Quantidade; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("A quantidade não pode ser negativa.");
                }

                _Quantidade = value;
            }
        }

        public decimal Peso { get; set; }

        public decimal CalcularValorTotalEstoque()
        {
            return _Preco * _Quantidade;
        }

        public void AdicionarQuantidadeEstoque(int quantidade)
        {
            if (quantidade <= 0)
                throw new Exception("A quantidade a ser adicionada dever ser maior que 0.");
        
            _Quantidade += quantidade;
        }

        public void RemoverQuantidadeEstoque(int quantidade)
        {
            if (quantidade <= 0)
                throw new Exception("A quantidade a ser removida dever ser maior que 0.");

            if (quantidade > _Quantidade)
                throw new Exception("Não há estoque suficiente para remover a quantidade solicitada");

            _Quantidade -= quantidade;
        }
    }
}
