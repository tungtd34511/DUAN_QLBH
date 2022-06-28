using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAcessLayer.Entities;

namespace _1_DAL_DataAcessLayer.IServices
{
    public interface IOrderService
    {
        public List<Order> GetLstOrders();
        public void GetLstOrdersFormDb();
        public string Add(Order order);
        public string Update(Order order);
        public string Delete(int id);
    }
}
