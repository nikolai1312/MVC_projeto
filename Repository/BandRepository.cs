using MVC_projeto.Database;
using MVC_projeto.Interfaces;
using MVC_projeto.Models;

namespace MVC_projeto.Repository
{
    public class BandRepository : IBandRepository
    {
        private readonly BandDbcontext _dbcontext;
        public BandRepository(BandDbcontext bandContext) {
            _dbcontext = bandContext;
        }

        public BandModel Add(BandModel bandModel)
        {
            _dbcontext.Bands.Add(bandModel);
            _dbcontext.SaveChanges();
            return bandModel;
        }

        public bool Delete(int id)
        {
            BandModel bandDB = GetById(id);

            if (bandDB == null) throw new Exception("Erro de atualização da banda!");
        
            _dbcontext.Bands.Remove(bandDB);
            _dbcontext.SaveChanges();

            return true;
        }

        public List<BandModel> GetAll()
        {
            return _dbcontext.Bands.ToList();
        }

        public BandModel GetById(int id)
        {
            return _dbcontext.Bands.FirstOrDefault(x => x.Id.Equals(id));
        }

        public BandModel Update(BandModel model)
        {
            BandModel bandDB = GetById(model.Id);
            if (bandDB == null) throw new Exception("Erro de atualização da banda!");

            bandDB.BandName = model.BandName;
            bandDB.BandGenre = model.BandGenre;
            bandDB.BandYear = model.BandYear;

            _dbcontext.Bands.Update(bandDB);
            _dbcontext.SaveChanges();

            return bandDB;
        }
    }
}
