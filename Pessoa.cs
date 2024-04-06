namespace PessoaOO.Pessoas
{
    public class Pessoa
    {
        // Propriedades privadas
        private string _nome;
        private int _idade;
        private string _endereco;
        
        // Getter e Setter das propriedades
        public string Nome
        {
            get{
                return _nome;
            }
            set{
                _nome = value;
            }
        }
        // public int Idade
        // {
        //     get{
        //         return Idade;
        //     }
        //     set{
        //         Idade = value;
        //     }
        // }
        public int Idade
        {
            get{
                return _idade;
            }
            set{
                _idade = value;
            }
        }
        public string Endereco
        {
            get{
                return _endereco;
            }
            set{
                _endereco = value;
            }
        }

        // Construtores
        public Pessoa(string nome, int idade, string endereco)
        {
            this._nome = nome;
            this._idade = idade;
            this._endereco = endereco;
        }

        // Métodos
        public void ImprimirInfo()
        {
            Console.WriteLine($"Nome: {Nome}, idade: {Idade}, endereço: {Endereco}");
        }
    }
}