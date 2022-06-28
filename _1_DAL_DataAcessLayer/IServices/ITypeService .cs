using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAcessLayer.Entities;

namespace _1_DAL_DataAcessLayer.IServices
{
    public interface ITypeService
    {
        public List<Entities.Type> GetLstTypes();
        public void GetLstTypesFormDb();
        public string Add(Entities.Type type);
        public string Update(Entities.Type type);
        public string Delete(int id);
    }
}
