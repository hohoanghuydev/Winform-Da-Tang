using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MonHocDAL
    {
        QLSINHVIEN_B7DataContext context = new QLSINHVIEN_B7DataContext();

        public MonHocDAL()
        {

        }

        public List<MonHoc> GetAll()
        {
            return context.MonHocs.Select(mh => mh).ToList<MonHoc>();
        }

        public bool Create(MonHoc monHoc)
        {
            try
            {
                context.MonHocs.InsertOnSubmit(monHoc);
                context.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
