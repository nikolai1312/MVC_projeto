using MVC_projeto.Models;

namespace MVC_projeto.Interfaces
{
    public interface IBandRepository
    {
        List<BandModel> GetAll();
        BandModel Add(BandModel bandModel);

        BandModel GetById(int id);

        BandModel Update(BandModel model);

        bool Delete(int id);
    }
}
