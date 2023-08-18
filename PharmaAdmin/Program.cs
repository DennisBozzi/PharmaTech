using PharmaAdmin.PharmaAdmin.Domain.Enum;
using PharmaAdmin.PharmaAdmin.Domain.Service;
using System;

namespace PharmaAdmin
{
    internal class Program
    {
        static void Main()
        {
            MedicamentoService medicamentoService = new MedicamentoService();

            Console.WriteLine("Seja bem vindo ao Pharma Tech");

            //Cadastro de medicamentos
            medicamentoService.CadastrarMedicamento("Dipirona", 14, TipoMedicamento.Similar);
            medicamentoService.CadastrarMedicamento("Dipirona", 25, TipoMedicamento.Generico); //ERRO - Medicamento com mesmo nome!
            medicamentoService.CadastrarMedicamento("Paracetamol", 19, TipoMedicamento.Original);
            medicamentoService.CadastrarMedicamento("Ibuprofeno", 38, TipoMedicamento.Original);
            medicamentoService.CadastrarMedicamento("Aspirina", 22, TipoMedicamento.Similar);
            medicamentoService.CadastrarMedicamento("Omeprazol", 8, TipoMedicamento.Generico);
            medicamentoService.CadastrarMedicamento("Cetirizina", 12, TipoMedicamento.Generico);
            medicamentoService.CadastrarMedicamento("Loratadina", 26, TipoMedicamento.Similar);
            medicamentoService.CadastrarMedicamento("Simeticona", 11, TipoMedicamento.Original);
            medicamentoService.CadastrarMedicamento("Ranitidina", 13, TipoMedicamento.Similar);
            medicamentoService.CadastrarMedicamento("Maxapran", 42, TipoMedicamento.Generico);

            medicamentoService.AlterarPreco(100, 62); //ERRO - Código não encontrado!
            medicamentoService.AlterarPreco(5, 6);

            medicamentoService.ImprimirMedicamento(3); //Imprimindo por código

            Console.WriteLine("\n" + medicamentoService.BuscarCodigoPorNome("Remédio")); //Retorna 0 - Nome não encontrado!
            Console.WriteLine("\n" + medicamentoService.BuscarCodigoPorNome("Cetirizina")); //Retorna 6

            medicamentoService.ImprimirMedicamentosPorTipo(TipoMedicamento.Similar); //Imprimindo por tipo

            Console.ReadKey();

        }
    }
}
