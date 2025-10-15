using ProductClientHub.API.Infraestructure;

namespace ProductClientHub.API.UseCases.Clients.GetAll;

public class GetAllClientsUseCase
{
    public ResponseAllClientsJson Execute()
    {
        var dbContext = new ProductClientHubDbContext();

        var clients = dbContext.Clients.ToList();

        return new ResponseAllClientsJson
        {
            Clients = clients.Select(client => new Comunication.Responses.ResponseShortsClientJson
            {
                Id = client.Id,
                Name = client.Name,
            }).ToList(),
        };
    }
}