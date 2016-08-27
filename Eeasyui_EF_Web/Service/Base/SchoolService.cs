using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyDBContext;
using Entity;


namespace Service
{
    public class SchoolService
    {
        public List<school> GetList()
        {
            EFContext db = new EFContext();
            return db.Set<school>().ToList();
        }
    }
}
