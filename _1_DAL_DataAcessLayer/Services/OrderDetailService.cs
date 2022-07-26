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
    public class OrderDetailService : IOrderDetailService
    {
        private List<OrderDetail> _lstOrderDetails;
        private readonly QLBHContext _qlbhContext;
        public OrderDetailService()
        {
            _qlbhContext = new QLBHContext();
            GetLstOrderDetailsFormDb();
        }

        public List<OrderDetail> GetLstOrderDetails()
        {
            return _lstOrderDetails;
        }
        public void GetLstOrderDetailsFormDb()
        {
            _lstOrderDetails = new List<OrderDetail>();
            _lstOrderDetails = _qlbhContext.OrderDetails.ToList();
        }
        public string Add(OrderDetail orderDetail)
        {
            _qlbhContext.OrderDetails.Update(orderDetail);
            _qlbhContext.SaveChanges();
            GetLstOrderDetailsFormDb();
            return "Thêm thành công!";
        }
        public string Update(OrderDetail orderDetail)
        {
            _qlbhContext.OrderDetails.Update(orderDetail);
            _qlbhContext.SaveChanges();
            GetLstOrderDetailsFormDb();
            return "Sửa thành công!";
        }
        public string Delete(int id)
        {
            _qlbhContext.OrderDetails.Remove(_lstOrderDetails.FirstOrDefault(c=>c.Id == id));
            _qlbhContext.SaveChanges();
            GetLstOrderDetailsFormDb();
            return "Xóa thành công!";
        }
    }
}
