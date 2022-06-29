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
    public class JobService : IJobService
    {
        private List<Job> _lstJobs;
        private QLBHContext _qlbhContext;
        public JobService()
        {
            _lstJobs = new List<Job>();
            _qlbhContext = new QLBHContext();
            GetLstJobsFormDb();
        }

        public List<Job> GetLstJobs()
        {
            return _lstJobs;
        }
        public void GetLstJobsFormDb()
        {
            _lstJobs = _qlbhContext.Jobs.ToList();
        }
        public string Add(Job job)
        {
            _qlbhContext.Jobs.Add(job);
            _qlbhContext.SaveChanges();
            GetLstJobsFormDb();
            return "Thêm thành công!";
        }
        public string Update(Job job)
        {
            _qlbhContext.Jobs.Update(job);
            _qlbhContext.SaveChanges();
            GetLstJobsFormDb();
            return "Sửa thành công!";
        }
        public string Delete(int id)
        {
            _qlbhContext.Jobs.Remove(_lstJobs.FirstOrDefault(c=>c.Id==id));
            _qlbhContext.SaveChanges();
            GetLstJobsFormDb();
            return "Xóa thành công!";
        }
    }
}
