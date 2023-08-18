using PharmaAdmin.PharmaAdmin.Domain.Enum;
using PharmaAdmin.PharmaAdmin.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PharmaAdmin.PharmaAdmin.Domain.Service
{
    internal class MedicamentoService
    {
        public List<Medicamento> listaMedicamento;

        public MedicamentoService()
        {
            listaMedicamento = new List<Medicamento>();
        }

        //Cadastrar novo medicamento
        public long CadastrarMedicamento(string nome, double preco, TipoMedicamento tipo)
        {
            long codigo = listaMedicamento.Count() + 1; //Atribuindo código sozinho

            var medicamento = listaMedicamento.FirstOrDefault(med => med.Nome == nome);


            if (medicamento == null) //Conferência de nome
            {
                Medicamento novoMedicamento = new Medicamento(codigo, nome, preco, tipo);

                listaMedicamento.Add(novoMedicamento);

                return codigo;
            }
            else
            {
                Console.WriteLine("\nMedicamento não cadastrado. Nome já existe!");
                return 0;
            }

        }

        //Alterar preço através do código
        public void AlterarPreco(long codigo, double preco)
        {
            //Utilizando o Recurso de consulta LINQ
            var medicamento = listaMedicamento.FirstOrDefault(med => med.Codigo == codigo);

            if (medicamento != null)
            {
                medicamento.Preco = preco;
                Console.WriteLine($"\nMedicamento de nome {medicamento.Nome} e código {medicamento.Codigo} - Preço alterado para R${medicamento.Preco}");
            }
            else
            {
                Console.WriteLine($"\nMedicamento de código {codigo} não encontrado. Preço não alterado!");
            }

        }

        //Imprimir medicamento através do código
        public void ImprimirMedicamento(long codigo)
        {
            //Utilizando o Recurso de consulta LINQ
            var medicamento = listaMedicamento.FirstOrDefault(med => med.Codigo == codigo);

            if (medicamento != null)
            {
                medicamento.Imprimir();
            }
            else
            {
                Console.WriteLine($"\nMedicamento de código {codigo} não encontrado. Não foi possível imprimir!");
            }
        }

        //Retorna código através do nome
        public long BuscarCodigoPorNome(string nome)
        {
            //Utilizando o Recurso de consulta LINQ
            var medicamento = listaMedicamento.FirstOrDefault(med => med.Nome == nome);

            if (medicamento != null)
            {
                return medicamento.Codigo;
            }

            return 0;
        }

        //Imprime todos os medicamentos de um tipo
        public void ImprimirMedicamentosPorTipo(TipoMedicamento tipo)
        {
            //Utilizando o Recurso de consulta LINQ
            var medicamento = listaMedicamento.Where(med => med.Tipo == tipo);

            //Converte para List e depois usa o ForEach
            medicamento.ToList().ForEach(med => med.Imprimir());
        }
    }
}
