using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

[Route("api/cliente")] // Rota base para o controlador
[ApiController]
public class ClienteController : ControllerBase
{
    private List<Cliente> clientes = new List<Cliente>();

    // GET: api/cliente
    [HttpGet]
    public ActionResult<IEnumerable<Usuario>> Get()
    {
        return usuarios;
    }

    // GET: api/cliente/{id}
    [HttpGet("{id}")]
    public ActionResult<Cliente> Get(int id)
    {
        var cliente = clientes.Find(u => u.ClienteID == id);
        if (cliente == null)
        {
            return NotFound(); // Retornar 404 se o cliente não for encontrado
        }
        return cliente;
    }

    // POST: api/clientes
    [HttpPost]
    public IActionResult Post([FromBody] Cliente cliente)
    {
        cliente.ClienteID = clientes.Count + 1;
        cliente.DataCriacao = DateTime.Now; // Definir a data de criação como a data atual
        clientes.Add(cliente);
        return CreatedAtAction("Get", new { id = cliente.ClienteID }, cliente);
    }

    // PUT: api/clientes/{id}
    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody] Cliente cliente)
    {
        var clienteExistente = clientes.Find(u => u.ClienteID == id);
        if (clienteExistente == null)
        {
            return NotFound(); // Retornar 404 se o cliente não for encontrado
        }

        clienteExistente.Nome = cliente.Nome;
        clienteExistente.Genero = cliente.Genero;
        clienteExistente.CPF = cliente.CPF;
        clienteExistente.Contato = cliente.Contato;
        clienteExistente.DataAgendamento = cliente.DataAgendamento;

        return NoContent(); // Retornar 204 No Content para sucesso na atualização
    }

    // DELETE: api/clientes/{id}
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var cliente = clientes.Find(u => u.ClienteID == id);
        if (cliente == null)
        {
            return NotFound(); // Retornar 404 se o cliente não for encontrado
        }

        clientes.Remove(cliente);
        return NoContent(); // Retornar 204 No Content para sucesso na exclusão
    }
}
