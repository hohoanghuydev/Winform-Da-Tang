using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class MonHocBLL
    {
        MonHocDAL monHocDAL = new MonHocDAL();
        public MonHocBLL()
        {
            
        }

        public List<MonHoc> GetAll()
        {
            return monHocDAL.GetAll();
        }

        public bool Create(MonHoc monHoc)
        {
            return monHocDAL.Create(monHoc);
        }
    }
}
