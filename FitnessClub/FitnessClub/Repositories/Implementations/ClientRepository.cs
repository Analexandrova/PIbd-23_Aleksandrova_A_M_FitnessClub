using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessClub.Entities;
using FitnessClub.Entities.Enum;

namespace FitnessClub.Repositories.Implementations;

internal class ClientRepository : IClientRepository
{
    public void CreateClient(Client client) { }
    public void DeleteClient(int id) { }
    public Client ReadClientById(int id) => Client.CreateEntity(0, string.Empty, string.Empty);
    public IEnumerable<Client> ReadClients() => new List<Client>();
    public void UpdateClient(Client client) { }
}