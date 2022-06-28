using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAcessLayer.Entities;

namespace _1_DAL_DataAcessLayer.IServices
{
    public interface IColorService
    {
        public List<Color> GetLstColors();
        public void GetLstColorsFormDb();
        public string Add(Color color);
        public string Update(Color color);
        public string Delete(int id);
    }
}
