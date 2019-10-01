using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public class Categoria
    {

        private readonly GranadoFluxoContext _dbContext;
        public Categoria(GranadoFluxoContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<DataAccess.Model.Categoria> GetAll()
        {
            List<DataAccess.Model.Categoria> listEntity;

            listEntity = _dbContext.Categoria.ToList();

            return listEntity;
        }

        public DataAccess.Model.Categoria GetById(int id)
        {
            DataAccess.Model.Categoria listEntity;

            listEntity = _dbContext.Categoria.Where(x => x.Id == id).FirstOrDefault();

            return listEntity;
        }

        public void Update(DataAccess.Model.Categoria model)
        {
            try
            {
                var categoria = _dbContext.Categoria.Where(x => x.Id == model.Id).FirstOrDefault();

                categoria.Nome = model.Nome;
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
