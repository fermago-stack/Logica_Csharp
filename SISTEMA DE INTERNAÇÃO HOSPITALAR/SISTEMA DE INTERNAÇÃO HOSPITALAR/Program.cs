using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SISTEMA_DE_INTERNAÇÃO_HOSPITALAR
{
    internal class Program


    {

        public static class variaveis
        {

            public static string none, nome, crm, especialidade, tipoSanguineo, Alergias, ContatoEmergencia, NumeroQuarto, tipo, DiagnosticoEntrada, Status, motAlta, orialta, docalta, conttracasa;
            public static string diapri, sicliatu, res, situ, indi, cont, indifin;


            public static int id, cpf, telefone, PacienteId, MedicoResponsavelId, LeitoId, nupro, aptoleito, unidade;

            public static DateTime dataNascimento;
            static void Main(string[] args)
            {
                int opcao = -1;

                while (opcao != 0)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(" ════════════════════════════════════════════════════════════════════════════════ ");
                    Console.WriteLine(" ════════════════════════════════════════════════════════════════════════════════ ");
                    Console.WriteLine(@" ══════════════════════════

░██████╗██╗░██████╗████████╗███████╗███╗░░░███╗░█████╗░  ██████╗░███████╗
██╔════╝██║██╔════╝╚══██╔══╝██╔════╝████╗░████║██╔══██╗  ██╔══██╗██╔════╝
╚█████╗░██║╚█████╗░░░░██║░░░█████╗░░██╔████╔██║███████║  ██║░░██║█████╗░░
░╚═══██╗██║░╚═══██╗░░░██║░░░██╔══╝░░██║╚██╔╝██║██╔══██║  ██║░░██║██╔══╝░░
██████╔╝██║██████╔╝░░░██║░░░███████╗██║░╚═╝░██║██║░░██║  ██████╔╝███████╗
╚═════╝░╚═╝╚═════╝░░░░╚═╝░░░╚══════╝╚═╝░░░░░╚═╝╚═╝░░╚═╝  ╚═════╝░╚══════╝

██╗███╗░░██╗████████╗███████╗██████╗░███╗░░██╗░█████╗░░█████╗░░█████╗░░█████╗░
██║████╗░██║╚══██╔══╝██╔════╝██╔══██╗████╗░██║██╔══██╗██╔══██╗██╔══██╗██╔══██╗
██║██╔██╗██║░░░██║░░░█████╗░░██████╔╝██╔██╗██║███████║██║░░╚═╝███████║██║░░██║
██║██║╚████║░░░██║░░░██╔══╝░░██╔══██╗██║╚████║██╔══██║██║░░██╗██╔══██║██║░░██║
██║██║░╚███║░░░██║░░░███████╗██║░░██║██║░╚███║██║░░██║╚█████╔╝██║░░██║╚█████╔╝
╚═╝╚═╝░░╚══╝░░░╚═╝░░░╚══════╝╚═╝░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝░╚════╝░╚═╝░░╚═╝░╚════╝░

██╗░░██╗░█████╗░░██████╗██████╗░██╗████████╗░█████╗░██╗░░░░░░█████╗░██████╗░
██║░░██║██╔══██╗██╔════╝██╔══██╗██║╚══██╔══╝██╔══██╗██║░░░░░██╔══██╗██╔══██╗
███████║██║░░██║╚█████╗░██████╔╝██║░░░██║░░░███████║██║░░░░░███████║██████╔╝
██╔══██║██║░░██║░╚═══██╗██╔═══╝░██║░░░██║░░░██╔══██║██║░░░░░██╔══██║██╔══██╗
██║░░██║╚█████╔╝██████╔╝██║░░░░░██║░░░██║░░░██║░░██║███████╗██║░░██║██║░░██║
╚═╝░░╚═╝░╚════╝░╚═════╝░╚═╝░░░░░╚═╝░░░╚═╝░░░╚═╝░░╚═╝╚══════╝╚═╝░░╚═╝╚═╝░░╚═╝  ────────────── ");
                    Console.WriteLine(" ══╗  ╔═  ╔═  ╔═  ╔═  ╔═  ╔═  ╔═  ╔═  ╔═  ╔═  ╔═  ╔═  ╔═  ╔═  ╔═  ╔═  ╔═  ");
                    Console.WriteLine(" ══╝  ╚═  ╚═  ╚═  ╚═  ╚═  ╚═  ╚═  ╚═  ╚═  ╚═  ╚═  ╚═  ╚═  ╚═  ╚═  ╚═  ╚─  ");

                    Console.WriteLine(" 1 - CadastrarPaciente)");
                    Console.WriteLine(" 2 - Cadastrar Medico");
                    Console.WriteLine(" 3 - Cadastrar Leito");
                    Console.WriteLine(" 4 - Registrar Internação (Admissão)");
                    Console.WriteLine(" 5 - Dar Alta Hospitalar");
                    Console.WriteLine(" 6 - Listar Pacientes Internados");
                    Console.WriteLine(" 7 - Exibir Relatório Geral do Hospital");
                    Console.WriteLine(" 0 - Sair");

                    Console.WriteLine(" ════════════════════════════════════════════════════════════════════════════════ ");

                    Console.Write("Digite a opção desejada:    ");
                    opcao = int.Parse(Console.ReadLine());

                    switch (opcao)
                    {

                        case 1:
                            Console.WriteLine("Cadastrar Paciente");
                            CadastrarPaciente();
                            break;

                        case 2:
                            Console.WriteLine("Cadastrar Médico ");
                            CadastrarMedico();
                            break;

                        case 3:
                            Console.WriteLine("Cadastrar Leito");
                            CadastrarLeito();
                            break;

                        case 4:
                            Console.WriteLine(" Registrar Internação (Admissão) ");
                            RegistrarInternacao();
                            break;

                        case 5:
                            Console.WriteLine(" Dar Alta Hospitalar ");
                            DarAltaHospitalar();
                            break;

                        case 6:
                            Console.WriteLine("Listar Pacientes Internados ");
                            ListarPacientesInternados();
                            break;

                        case 7:
                            Console.WriteLine(" Exibir Relatório Geral do Hospital ");
                            ExibirRelatorioGeralHospital();
                            break;

                        case 0:
                            Console.WriteLine("Saindo do sistema...");
                            break;
                    }
                    Console.Clear();
                }


            }

            static void CadastrarPaciente()
            {

                DateTime dataNascimento;

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(@"       
█▀▀ ▄▀█ █▀▄ ▄▀█ █▀ ▀█▀ █▀█ ▄▀█ █▀█     █▀█ ▄▀█ █▀▀ █ █▀▀ █▄░█ ▀█▀ █▀▀
█▄▄ █▀█ █▄▀ █▀█ ▄█ ░█░ █▀▄ █▀█ █▀▄     █▀▀ █▀█ █▄▄ █ ██▄ █░▀█ ░█░ ██▄");


                Console.WriteLine("\n Digite o Identificador Unico do paciente:");
                id = int.Parse(Console.ReadLine());

                Console.WriteLine("\n Digite o nome do paciente:");
                nome = Console.ReadLine();

                Console.WriteLine("\n Digite o registrodo paciente:");
                cpf = int.Parse(Console.ReadLine());

                Console.WriteLine("\n Digite a data de nascimento do paciente:");
                DateTime.TryParse(Console.ReadLine(), out dataNascimento);

                Console.WriteLine("\n Digite o tipo sanguíneo do paciente (A+, A-, B+, B-, AB+, AB-, O+, O-):");
                tipoSanguineo = Console.ReadLine();

                Console.WriteLine("\n Digite as Descrição de alergias medicamentosas/alimentares do paciente:");
                Alergias = Console.ReadLine();

                Console.WriteLine("\n Nome e telefone de um familiar/responsável");
                ContatoEmergencia = Console.ReadLine();


                // Aqui você pode adicionar o código para salvar os dados do paciente em um banco de dados ou lista
                Console.WriteLine("Paciente " + nome +  " cadastrado com sucesso!");

                Thread.Sleep(2000);

            }

            static void CadastrarMedico()
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(@"       
█▀▀ ▄▀█ █▀▄ ▄▀█ ▀█▀ █▀█ ▄▀█ █▀█   █▀▄▀█ █▀▀ █▀▄ █ █▀▀ █▀█
█▄▄ █▀█ █▄▀ █▀█ ░█░ █▀▄ █▀█ █▀▄   █░▀░█ ██▄ █▄▀ █ █▄▄ █▄█
                ");

                Console.WriteLine("\n Digite o Identificador Unico do médico:");
                id = int.Parse(Console.ReadLine());

                Console.WriteLine("\n Digite o nome do Profissional:");
                nome = Console.ReadLine();

                Console.WriteLine("\n Digite o CRM do médico:");
                crm = Console.ReadLine();

                Console.WriteLine("\n Digite a Especializãção do médico (Ex: Cardiologia, UTI, Cirurgia Geral):");
                especialidade = Console.ReadLine();

                Console.WriteLine("\n Digite o Telefone de contato rápido");
                telefone = int.Parse(Console.ReadLine());

                Console.WriteLine("Médico  " + nome + " cadastrado com sucesso!");

                Thread.Sleep(2000);

            }

            static void CadastrarLeito()
            {

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(@" 
█▀▀ ▄▀█ █▀▄ ▄▀█ █▀ ▀█▀ █▀█ ▄▀█ █▀█     █░░ █▀▀ █ ▀█▀ █▀█
█▄▄ █▀█ █▄▀ █▀█ ▄█ ░█░ █▀▄ █▀█ █▀▄     █▄▄ ██▄ █ ░█░ █▄█ ");

                Console.WriteLine("\n Digite Número ou identificador do leito:");
                id = int.Parse(Console.ReadLine());

                Console.WriteLine("\n Número ou código do quarto/ala:");
                NumeroQuarto = Console.ReadLine();

                Console.WriteLine("\n Enfermaria, Apartamento, UTIo:");
                tipo = Console.ReadLine();

                Console.WriteLine("\n O leito está ocupado? (true/false):");
                bool ocupado = bool.Parse(Console.ReadLine());


                Console.WriteLine("Leito " + NumeroQuarto + " cadastrado com sucesso!");

                Thread.Sleep(2000);
            }

            static void RegistrarInternacao()
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(@" 
█▀█ █▀▀ █▀▀ █ █▀ ▀█▀ █▀█ ▄▀█ █▀█   █ █▄░█ ▀█▀ █▀▀ █▀█ █▄░█ ▄▀█ █▀▀ ▄▀█ █▀█
█▀▄ ██▄ █▄█ █ ▄█ ░█░ █▀▄ █▀█ █▀▄   █ █░▀█ ░█░ ██▄ █▀▄ █░▀█ █▀█ █▄▄ █▀█ █▄█

▄▀ ▄▀█ █▀▄ █▀▄▀█ █ █▀ █▀ ▄▀█ █▀█ ▀▄
▀▄ █▀█ █▄▀ █░▀░█ █ ▄█ ▄█ █▀█ █▄█ ▄▀ ");


                Console.WriteLine("\nCódigo do registro de internação:");
                id = int.Parse(Console.ReadLine());

                Console.WriteLine("\nCódigo do paciente:");
                PacienteId = int.Parse(Console.ReadLine());

                Console.WriteLine("\nCódigo do médico responsável:");
                MedicoResponsavelId = int.Parse(Console.ReadLine());

                Console.WriteLine("\n Código do leito alocado");
                LeitoId = int.Parse(Console.ReadLine());

                Console.WriteLine("\nDigite a data de admissão:");
                DateTime dataAdmissao = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("\n Data de alta (dd/MM/yyyy) (deixe em branco se ainda não houver alta):");
                DateTime dataAlta = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("\n Motivo/quadro na admissão");
                DiagnosticoEntrada = Console.ReadLine();

                Console.WriteLine("\n Status do paciente:");
                Status = Console.ReadLine();

                Console.WriteLine("Registro de internaçãor " + PacienteId + "    cadastrado com sucesso!");

                Thread.Sleep(2000);

            }



            static void DarAltaHospitalar()
            {

                DateTime dataalta;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(@" 
█▀▄ ▄▀█ █▀█   ▄▀█ █░░ ▀█▀ ▄▀█   █░█ █▀█ █▀ █▀█ █ ▀█▀ ▄▀█ █░░ ▄▀█ █▀█
█▄▀ █▀█ █▀▄   █▀█ █▄▄ ░█░ █▀█   █▀█ █▄█ ▄█ █▀▀ █ ░█░ █▀█ █▄▄ █▀█ █▀▄");

                Console.WriteLine("\nDigite o código do registro de internação para dar alta:");
                int Id = int.Parse(Console.ReadLine());

                Console.WriteLine("\nDigite a data de alta (dd/MM/yyyy):");
                DateTime.TryParse(Console.ReadLine(), out dataalta);

                Console.WriteLine("\n Digite o Conceito de Alta Hospitalar:");
                motAlta = Console.ReadLine();

                Console.WriteLine("\n Orientações ao Paciente e Família:");
                orialta = Console.ReadLine();

                Console.WriteLine("\n Documentação da Alta:");
                docalta = Console.ReadLine();

                Console.WriteLine("\n Continuidade do Tratamento Pós-Alta:");
                conttracasa = Console.ReadLine();

                Console.WriteLine($" Alta {dataalta} cadastrado com sucesso!");

                Thread.Sleep(2000);

            }


            static void ListarPacientesInternados()
            {
                DateTime datainpac;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(@" 
█░░ █ █▀ ▀█▀ ▄▀█   █▀▄ █▀█ █▀   █▀█ ▄▀█ █▀▀ █ █▀▀ █▄░█ ▀█▀ █▀▀ █▀   █ █▄░█ ▀█▀ █▀▀ █▀█ █▄░█ ▄▀█ █▀▄ █▀█ █▀
█▄▄ █ ▄█ ░█░ █▀█   █▄▀ █▄█ ▄█   █▀▀ █▀█ █▄▄ █ ██▄ █░▀█ ░█░ ██▄ ▄█   █ █░▀█ ░█░ ██▄ █▀▄ █░▀█ █▀█ █▄▀ █▄█ ▄█");

                Console.WriteLine("\nNome do Paciente:");
                nome = Console.ReadLine();

                Console.WriteLine("\n Numero do Prontuario:");
                nupro = int.Parse(Console.ReadLine());

                Console.WriteLine("\n Numero do Apartamento/Leito:");
                aptoleito = int.Parse(Console.ReadLine());

                Console.WriteLine("\n Setor ou Unidade de Internação:");
                unidade = int.Parse(Console.ReadLine());

                Console.WriteLine("\nDigite Data de Internação (dd/MM/yyyy):");
                DateTime.TryParse(Console.ReadLine(), out datainpac);

                Console.WriteLine("\n Diagnóstico Principal:");
                diapri = Console.ReadLine();

                Console.WriteLine("\n Situação Clínica Atual:");
                sicliatu = Console.ReadLine();



                Console.WriteLine($" Lista Internados {nupro} cadastrado com sucesso!");

                Thread.Sleep(2000);


                // Aqui você pode adicionar o código para registrar a internação no banco de dados ou lista

            }

            static void ExibirRelatorioGeralHospital()
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(@" 

█▀▀ ▀▄▀ █ █▄▄ █ █▀█   █▀█ █▀▀ █░░ ▄▀█ ▀█▀ █▀█ █▀█ █ █▀█   █▀▄ █▀█   █░█ █▀█ █▀ █▀█ █ ▀█▀ ▄▀█ █░░
██▄ █░█ █ █▄█ █ █▀▄   █▀▄ ██▄ █▄▄ █▀█ ░█░ █▄█ █▀▄ █ █▄█   █▄▀ █▄█   █▀█ █▄█ ▄█ █▀▀ █ ░█░ █▀█ █▄▄");


                Console.WriteLine("\n  Resumo Geral de Atendimentos");
                res = Console.ReadLine();

                Console.WriteLine("\n  Situação dos Pacientes Internados");
                situ = Console.ReadLine();

                Console.WriteLine("\n  Indicadores Assistenciais");
                indi = Console.ReadLine();

                Console.WriteLine("\n  Controle de Recursos Hospitalares");
                cont = Console.ReadLine();

                Console.WriteLine("\n  Indicadores Financeiros e Operacionais");
                indifin = Console.ReadLine();

                Console.WriteLine($" Relatório Geral do Hospital {res} cadastrado com sucesso!");

                Thread.Sleep(2000);


            }

            static void funcaotodoscadrastros(string value)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(@"  
▀█▀ █▀█ █▀▄ █▀█ █▀   █▀▀ ▄▀█ █▀▄ ▄▀█ █▀ ▀█▀ █▀█ █▀█ █▀
░█░ █▄█ █▄▀ █▄█ ▄█   █▄▄ █▀█ █▄▀ █▀█ ▄█ ░█░ █▀▄ █▄█ ▄█");
    
                Console.WriteLine("\n" + variaveis.id);
                Console.WriteLine("\n" + variaveis.nome);
                Console.WriteLine("\n" + variaveis.crm);    
                Console.WriteLine("\n" + variaveis.especialidade);
                Console.WriteLine("\n" + variaveis.tipoSanguineo);
                Console.WriteLine("\n" + variaveis.Alergias);
                Console.WriteLine("\n" + variaveis.ContatoEmergencia);
                Console.WriteLine("\n" + variaveis.NumeroQuarto);
                Console.WriteLine("\n" + variaveis.tipo);
                Console.WriteLine("\n" + variaveis.DiagnosticoEntrada);
                Console.WriteLine("\n" + variaveis.Status);
                Console.WriteLine("\n" + variaveis.motAlta);
                Console.WriteLine("\n" + variaveis.orialta);
                Console.WriteLine("\n" + variaveis.docalta);
                Console.WriteLine("\n" + variaveis.conttracasa);
                Console.WriteLine("\n" + variaveis.diapri);
                Console.WriteLine("\n" + variaveis.sicliatu);
                Console.WriteLine("\n" + variaveis.res);
                Console.WriteLine("\n" + variaveis.situ);
                Console.WriteLine("\n" + variaveis.indi);
                Console.WriteLine("\n" + variaveis.cont);
                Console.WriteLine("\n" + variaveis.indifin);
                


            }
        }

    }
}
    

