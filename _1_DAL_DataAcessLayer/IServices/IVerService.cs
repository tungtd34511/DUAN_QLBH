using System.Collections.Generic;
using _1_DAL_DataAcessLayer.Entities;

namespace _1_DAL_DataAcessLayer.IServices
{
    public interface IVerService
    {
        public List<Ver> GetLstVers();
        public void GetLstVersFormDb();
        public string Add(Ver job);
        public string Update(Ver job);
        public string Delete(int id);
    }
}