using Data.Database;
using Model.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        public StudentRepository(LMSEntities context) : base(context)
        {

        }

        public DbSet<Student> Students { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }


}
