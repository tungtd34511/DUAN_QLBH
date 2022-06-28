using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAcessLayer.Entities;

namespace _1_DAL_DataAcessLayer.IServices
{
    public interface IOrderDetailService
    {
        public List<OrderDetail> GetLstOrderDetails();
        public void GetLstOrderDetailsFormDb();
        public string Add(OrderDetail orderDetail);
        public string Update(OrderDetail orderDetail);
        public string Delete(int id);
    }
}
