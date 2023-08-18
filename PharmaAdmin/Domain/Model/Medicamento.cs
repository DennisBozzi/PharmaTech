using PharmaAdmin.PharmaAdmin.Domain.Enum;
using System;

namespace PharmaAdmin.PharmaAdmin.Domain.Model
{
    internal class Medicamento
    {
        public long Codigo;
        public string Nome;
        public double Preco;
        public TipoMedicamento Tipo;

        public Medicamento(long codigo, string nome, double preco, TipoMedicamento tipo)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
            Tipo = tipo;
        }

        //Método de impressão do medicamento
        public void Imprimir()
        {
            Console.WriteLine($"\nO medicamento {Nome} de código {Codigo} é do tipo {Tipo} e custa R${Preco}");
        }
    }
}
