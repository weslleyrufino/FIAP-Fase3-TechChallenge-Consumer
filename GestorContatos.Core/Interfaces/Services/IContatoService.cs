﻿using GestorContatos.Core.Entities;

namespace GestorContatos.Core.Interfaces.Services;
public interface IContatoService
{
    IEnumerable<Contato> GetContatos();
    IEnumerable<Contato> GetContatosPorDDD(int ddd);
    void PostInserirContato(Contato contato);
    void PutAlterarContato(Contato contato);
    void DeleteContato(int id);
}
