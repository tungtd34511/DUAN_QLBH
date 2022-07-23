using System.Collections.Generic;
using _1_DAL_DataAcessLayer.Entities;

namespace _2_BUS_BusinessLayer.Models
{
    public class SanPham
    {
        private Product _product;
        private ProductDetail _productDetail;
        private List<Ver> _vers;
        private List<Color> _colors;
        private List<Size> _sizes;
        private List<Image> _images;
        private Origin _origin;
        private ThuongHieu _thuongHieu;
        private Catergory _catergory;
        private Price _price;
        private Sale _sale;

        public SanPham()
        {

        }
        public SanPham(Product product, ProductDetail productDetail, List<Ver> vers, List<Color> colors, List<Size> sizes, List<Image> images, Origin origin, ThuongHieu thuongHieu, Catergory catergory, Price price, Sale sale)
        {
            _product = product;
            _productDetail = productDetail;
            _vers = vers;
            _colors = colors;
            _sizes = sizes;
            _images = images;
            _origin = origin;
            _thuongHieu = thuongHieu;
            _catergory = catergory;
            _price = price;
            _sale = sale;
        }

        public Product Product
        {
            get => _product;
            set => _product = value;
        }

        public ProductDetail ProductDetail
        {
            get => _productDetail;
            set => _productDetail = value;
        }

        public List<Ver> Vers
        {
            get => _vers;
            set => _vers = value;
        }

        public List<Color> Colors
        {
            get => _colors;
            set => _colors = value;
        }

        public List<Size> Sizes
        {
            get => _sizes;
            set => _sizes = value;
        }

        public List<Image> Images
        {
            get => _images;
            set => _images = value;
        }

        public Origin Origin
        {
            get => _origin;
            set => _origin = value;
        }

        public ThuongHieu ThuongHieu
        {
            get => _thuongHieu;
            set => _thuongHieu = value;
        }

        public Catergory Catergory
        {
            get => _catergory;
            set => _catergory = value;
        }

        public Price Price
        {
            get => _price;
            set => _price = value;
        }
        public Sale Sale
        {
            get => _sale;
            set => _sale = value;
        }
    }
}