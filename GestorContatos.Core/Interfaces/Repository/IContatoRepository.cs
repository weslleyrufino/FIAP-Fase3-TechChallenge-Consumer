﻿using GestorContatos.Core.Entities;

namespace GestorContatos.Core.Interfaces.Repository;
public interface IContatoRepository : IRepository<Contato>
{
    IEnumerable<Contato> GetContatosPorDDD(int ddd);

    IEnumerable<Contato> GetTodosContatosMesclandoComDDD();

}
