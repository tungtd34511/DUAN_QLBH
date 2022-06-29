using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAcessLayer.DatabaseContext;
using _1_DAL_DataAcessLayer.Entities;
using _1_DAL_DataAcessLayer.IServices;


namespace _1_DAL_DataAcessLayer.Services
{
    public class ImageService : IImageService
    {
        private Image _image;
        private List<Image> _lstImages;
        private QLBHContext _qlbhContext;
        public ImageService()
        {
            _image = new Image();
            _lstImages = new List<Image>();
            _qlbhContext = new QLBHContext();
            GetLstImagesFormDb();
        }

        public List<Image> GetLstImages()
        {
            return _lstImages;
        }
        public void GetLstImagesFormDb()
        {
            _lstImages = _qlbhContext.Images.ToList();
        }
        public string Add(Image image)
        {
            _qlbhContext.Images.Add(image);
            _qlbhContext.SaveChanges();
            GetLstImagesFormDb();
            return "Thêm thành công!";
        }
        public string Update(Image image)
        {
            _qlbhContext.Images.Update(image);
            _qlbhContext.SaveChanges();
            GetLstImagesFormDb();
            return "Sửa thành công!";
        }
        public string Delete(int id)
        {
            _qlbhContext.Images.Remove(_lstImages.FirstOrDefault(c=>c.Id==id));
            _qlbhContext.SaveChanges();
            GetLstImagesFormDb();
            return "Xóa thành công!";
        }
    }
}
