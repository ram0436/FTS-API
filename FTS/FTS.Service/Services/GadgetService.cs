using FTS.Model.Entities;
using FTS.Repository.IRepositories;
using FTS.Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTS.Service.Services
{
    public class GadgetService : IGadgetService
    {
        IGadgetRepository _gadgetRepository;
        public GadgetService(IGadgetRepository gadgetRepository)
        {
            _gadgetRepository = gadgetRepository;
        }
        public IEnumerable<Gadgets> GetAll()
        {
            return _gadgetRepository.GetAll();
        }
        public Gadgets GetById(long userId)
        {
            return _gadgetRepository.GetById(userId);
        }
        public void Insert(Gadgets user)
        {
            _gadgetRepository.Insert(user);
        }
        public void Update(Gadgets user)
        {
            _gadgetRepository.Update(user);
        }

        public void Delete(long id)
        {
            _gadgetRepository.Delete(id);
        }
    }
}
