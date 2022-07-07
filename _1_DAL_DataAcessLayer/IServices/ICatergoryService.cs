using System.Collections.Generic;
using _1_DAL_DataAcessLayer.Entities;

namespace _1_DAL_DataAcessLayer.IServices
{
    public interface ICatergoryService
    {
        public List<Catergory> GetLstCatergorys();
        public void GetLstCatergorysFormDb();
        public string Add(Catergory catergory);
        public string Update(Catergory catergory);
        public string Delete(int id);
    }
}