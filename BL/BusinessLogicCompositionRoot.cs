using Autofac;
using BL.Managers;
using BL.Managers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BusinessLogicCompositionRoot
    {
        public static void RegisterTypes(ContainerBuilder builder)
        {
            //var currentAssembly = Assembly.GetExecutingAssembly();
            //builder.RegisterAssemblyTypes(currentAssembly)
            //    .Where(t => t.Name.EndsWith("Manager"))
            //    .AsImplementedInterfaces();
            builder.RegisterType<StudentManager>().As<IStudentManager>().InstancePerRequest();
            builder.RegisterType<UserManager>().As<IUserManager>().InstancePerRequest();
        }
    }


}
