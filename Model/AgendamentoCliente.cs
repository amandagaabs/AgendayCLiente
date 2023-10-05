using System;

namespace Agendamentos.Models;
public class AgendamentoClientes
{
    // Propriedades
    public int UsuarioID { get; set; }
    public string Nome { get; set; }
    public string Genero { get; set; }
    public string CPF { get; set; }
    public string Contato { get; set; }
    public DateTime DataAgendamento { get; set; }
    public DateTime DataCriacao { get; set; }

    // Construtor
    public Usuario(int usuarioID, string nome, string genero, string cpf, string contato, DateTime dataAgendamento, DateTime dataCriacao)
    {
        UsuarioID = usuarioID;
        Nome = nome;
        Genero = genero;
        CPF = cpf;
        Contato = contato;
        DataAgendamento = dataAgendamento;
        DataCriacao = dataCriacao;
    }
}






