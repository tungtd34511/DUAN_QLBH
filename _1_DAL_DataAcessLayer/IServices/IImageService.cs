using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAcessLayer.Entities;

namespace _1_DAL_DataAcessLayer.IServices
{
    public interface IImageService
    {
        public List<Image> GetLstImages();
        public void GetLstImagesFormDb();
        public string Add(Image image);
        public string Update(Image image);
        public string Delete(int id);
    }
}
