using FluentAssertions.Equivalency;

namespace Questao5.Domain.Entities
{
    public class ContaCorrente : Entity
    {
        public ContaCorrente(int id,
                             string nome,
                             string numero,
                             bool ativo) : base(id)
        {
            SetId(id);
            Nome = nome;
            Numero = numero;
            Ativo = ativo;
        }

        public string Nome { get; private set; }
        public string Numero { get; private set; }
        public bool Ativo { get; private set; }
        public List<Movimento> Movimentos { get; private set; }

        public void SetarId(int id)
        {
            SetId(id);
        }
    }

    public class Movimento : Entity
    {
        public Movimento(int id,
            string contaCorrenteID,
            string dataMovimento,
            string tipoMovimento,
            decimal valor) : base(id)
        {
            ContaCorrenteID = contaCorrenteID;
            DataMovimento = dataMovimento;
            TipoMovimento = tipoMovimento;
            Valor = valor;

        }
        public string ContaCorrenteID { get; private set; }
        public string DataMovimento { get; private set; }
        public string TipoMovimento { get; private set; }
        public decimal Valor { get; private set; }
    }
}
