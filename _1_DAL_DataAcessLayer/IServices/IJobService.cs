using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAcessLayer.Entities;

namespace _1_DAL_DataAcessLayer.IServices
{
    public interface IJobService
    {
        public List<Job> GetLstJobs();
        public void GetLstJobsFormDb();
        public string Add(Job job);
        public string Update(Job job);
        public string Delete(int id);
    }
}
