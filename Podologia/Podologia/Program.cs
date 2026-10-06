using System;
class Program
{
    public static int idAgendamento;
    public static int clienteIdAgendamento;
    public static int podologoIdAgendamento;
    public static int procedimentoIdAgendamento;
    public static DateTime dataHoraAgendamento;
    public static string statusAgendamento;
    public static void Main(string[] args)
    {
        int opcao;
        do
        {
            Console.Clear();
            Console.WriteLine("======================================");
            Console.WriteLine("       CLÍNICA DE PODOLOGIA");
            Console.WriteLine("======================================");
            Console.WriteLine("1 - Cliente");
            Console.WriteLine("2 - Podólogo");
            Console.WriteLine("3 - Procedimento");
            Console.WriteLine("4 - Agendamento");
            Console.WriteLine("5 - Listar Agendamento");
            Console.WriteLine("6 - Todos os Cadastros");
            Console.WriteLine("0 - Sair");
            Console.WriteLine();
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    FuncaoClientePodologia();
                    break;
                case 2:
                    FuncaoPodologo();
                    break;
                case 3:
                    FuncaoProcedimento();
                    break;
                case 4:
                    FuncaoAgendamento();
                    break;
                case 5:
                    FuncaoListarAgendamentos();
                    break;
                case 6:
                    FuncaoTodosCadastros();
                    break;
                case 0:
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    Console.ReadLine();
                    break;
            }
        } while (opcao != 0);
    }
    public static void FuncaoClientePodologia()
    {
        Console.Clear();
        int id;
        string nome;
        string cpf;
        string telefone;
        DateTime dataNascimento;
        bool possuiDiabetes;
        string observacoesAnamnese;
        Console.Write("id: ");
        id = int.Parse(Console.ReadLine());
        Console.Write("nome: ");
        nome = Console.ReadLine();
        Console.Write("cpf: ");
        cpf = Console.ReadLine();
        Console.Write("telefone: ");
        telefone = Console.ReadLine();
        Console.Write("data de nascimento: ");
        DateTime.TryParse(Console.ReadLine(), out dataNascimento);
        Console.Write("possui diabetes: ");
        bool.TryParse(Console.ReadLine(), out possuiDiabetes);
        Console.Write("observações da anamnese: ");
        observacoesAnamnese = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("id: " + id);
        Console.WriteLine("nome do paciente: " + nome);
        Console.WriteLine("cpf: " + cpf);
        Console.WriteLine("telefone: " + telefone);
        Console.WriteLine("data de nascimento: " + dataNascimento);
        Console.WriteLine("possui diabetes: " + possuiDiabetes);
        Console.WriteLine("observações: " + observacoesAnamnese);
        Console.WriteLine();
        Console.WriteLine("Pressione ENTER para voltar ao menu...");
        Console.ReadLine();
    }
    public static void FuncaoPodologo()
    {
        Console.Clear();
        int id;
        string nome;
        string registroProfissional;
        string especialidade;
        string telefone;
        Console.Write("id: ");
        id = int.Parse(Console.ReadLine());
        Console.Write("nome: ");
        nome = Console.ReadLine();
        Console.Write("registro profissional: ");
        registroProfissional = Console.ReadLine();
        Console.Write("especialidade: ");
        especialidade = Console.ReadLine();
        Console.Write("telefone: ");
        telefone = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("id: " + id);
        Console.WriteLine("nome do especialista: " + nome);
        Console.WriteLine("registro profissional: " + registroProfissional);
        Console.WriteLine("especialidade: " + especialidade);
        Console.WriteLine("telefone: " + telefone);
        Console.WriteLine();
        Console.WriteLine("Pressione ENTER para voltar ao menu...");
        Console.ReadLine();
    }
    public static void FuncaoProcedimento()
    {
        Console.Clear();
        int id;
        string nome;
        int duracaoMinutos;
        decimal valor;
        Console.Write("id: ");
        id = int.Parse(Console.ReadLine());
        Console.Write("nome: ");
        nome = Console.ReadLine();
        Console.Write("duração em minutos: ");
        duracaoMinutos = int.Parse(Console.ReadLine());
        Console.Write("valor: ");
        valor = decimal.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("id: " + id);
        Console.WriteLine("nome do procedimento: " + nome);
        Console.WriteLine("duração: " + duracaoMinutos + " minutos");
        Console.WriteLine("valor: R$ " + valor);
        Console.WriteLine();
        Console.WriteLine("Pressione ENTER para voltar ao menu...");
        Console.ReadLine();
    }
    public static void FuncaoAgendamento()
    {
        Console.Clear();
        Console.WriteLine("======================================");
        Console.WriteLine("            AGENDAMENTO");
        Console.WriteLine("======================================");
        Console.Write("id: ");
        idAgendamento = int.Parse(Console.ReadLine());
        Console.Write("cliente id: ");
        clienteIdAgendamento = int.Parse(Console.ReadLine());
        Console.Write("podologo id: ");
        podologoIdAgendamento = int.Parse(Console.ReadLine());
        Console.Write("procedimento id: ");
        procedimentoIdAgendamento = int.Parse(Console.ReadLine());
        Console.Write("data e hora: ");
        DateTime.TryParse(Console.ReadLine(), out dataHoraAgendamento);
        Console.Write("status: ");
        statusAgendamento = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("codigo do agendamento: " + idAgendamento);
        Console.WriteLine("codigo do paciente cadastrado: " + clienteIdAgendamento);
        Console.WriteLine("codigo do profissional responsável: " + podologoIdAgendamento);
        Console.WriteLine("codigo do procedimento a ser realizado: " + procedimentoIdAgendamento);
        Console.WriteLine("data e hora marcados: " + dataHoraAgendamento);
        Console.WriteLine("agendado: " + statusAgendamento);
        Console.WriteLine();
        Console.WriteLine("Agendamento cadastrado!");
        Console.WriteLine();
        Console.WriteLine("Pressione ENTER para voltar ao menu...");
        Console.ReadLine();
    }
    public static void FuncaoListarAgendamentos()
    {
        Console.Clear();
        Console.WriteLine("======================================");
        Console.WriteLine("       LISTAR AGENDAMENTO");
        Console.WriteLine("======================================");
        Console.WriteLine();
        Console.WriteLine("codigo do agendamento: " + idAgendamento);
        Console.WriteLine("codigo do paciente: " + clienteIdAgendamento);
        Console.WriteLine("codigo do profissional: " + podologoIdAgendamento);
        Console.WriteLine("codigo do procedimento: " + procedimentoIdAgendamento);
        Console.WriteLine("data e hora: " + dataHoraAgendamento);
        Console.WriteLine("status: " + statusAgendamento);
        Console.WriteLine();
        Console.WriteLine("Pressione ENTER para voltar ao menu...");
        Console.ReadLine();
    }
    public static void FuncaoTodosCadastros()
    {
        Console.Clear();
        Console.WriteLine("======================================");
        Console.WriteLine("        TODOS OS CADASTROS");
        Console.WriteLine("======================================");
        Console.WriteLine();
        Console.WriteLine("1 - Cliente");
        Console.WriteLine("2 - Podólogo");
        Console.WriteLine("3 - Procedimento");
        Console.WriteLine("4 - Agendamento");
        Console.WriteLine();
        Console.Write("Escolha uma opção: ");
        int opcao = int.Parse(Console.ReadLine());
        switch (opcao)
        {
            case 1:
                FuncaoClientePodologia();
                break;
            case 2:
                FuncaoPodologo();
                break;
            case 3:
                FuncaoProcedimento();
                break;
            case 4:
                FuncaoAgendamento();
                break;
            default:
                Console.WriteLine("Opção inválida!");
                Console.ReadLine();
                break;
        }
    }
}
