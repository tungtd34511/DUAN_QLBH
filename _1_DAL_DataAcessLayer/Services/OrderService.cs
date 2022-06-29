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
    public class OrderService : IOrderService
    {
        private List<Order> _lstOrders;
        private QLBHContext _qlbhContext;
        public OrderService()
        {
            _lstOrders = new List<Order>();
            _qlbhContext = new QLBHContext();
            GetLstOrdersFormDb();
        }

        public List<Order> GetLstOrders()
        {
            return _lstOrders;
        }
        public void GetLstOrdersFormDb()
        {
            _lstOrders = _qlbhContext.Orders.ToList();
        }
        public string Add(Order order)
        {
            _qlbhContext.Orders.Add(order);
            _qlbhContext.SaveChanges();
            GetLstOrdersFormDb();
            return "Thêm thành công!";
        }
        public string Update(Order order)
        {
            _qlbhContext.Orders.Update(order);
            _qlbhContext.SaveChanges();
            GetLstOrdersFormDb();
            return "Sửa thành công!";
        }
        public string Delete(int id)
        {
            _qlbhContext.Orders.Remove(_lstOrders.FirstOrDefault(c=>c.Id == id));
            _qlbhContext.SaveChanges();
            GetLstOrdersFormDb();
            return "Xóa thành công!";
        }
    }
}
