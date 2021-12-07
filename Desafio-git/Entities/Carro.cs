using System;

namespace Desafio_git.Entities
{
    public class Carro
    {
        public int ID { get; set; }
        public string Marca { get; set; }
        public string Cor { get; set; }
        public DateTime Ano { get; set; }

        public override string ToString()
        {
            return $"Carro Id: { ID.ToString()} " +
                $"\n Marca: {Marca} " +
                $" \n Cor{Cor} \n" +
                $" Ano {Ano.ToString("yyyy")} " +
                $"\n";
        }
    }
}
