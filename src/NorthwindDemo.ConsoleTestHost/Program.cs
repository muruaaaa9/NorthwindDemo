using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Autofac.Core;
using Autofac.Integration.Wcf;
using NorthwindDemo.Data;
using NorthwindDemo.Data.Repository;
using NorthwindDemo.Data.UOW;
using NorthwindDemo.Service;
using NorthwindDemo.Service.Datacontract;
using NorthwindowDemo.DomainModel.Models;

namespace NorthwindDemo.ConsoleTestHost
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //var svcHost = new ServiceHost(typeof(MRM.Mobile.Service.DataService));

                //svcHost.Open();

                //Console.WriteLine("Simple Service is hosted");
                //Console.ReadKey();


                ContainerBuilder builder = new ContainerBuilder();
                builder.RegisterType<NorthwindContext>().As<INorthwindContext>();
                builder.Register(x => new UnitOfWork((NorthwindContext)x.Resolve<INorthwindContext>())).As<IUnitOfWork>();
                builder.Register(c => new CategoryRepository((UnitOfWork)c.Resolve<IUnitOfWork>())).As<IRepository<Category>>();
                builder.Register(c => new CategoryService(c.Resolve<IRepository<Category>>())).As<NorthwindDemo.Service.Datacontract.ICategory>();

                using (IContainer container = builder.Build())
                {
                    ServiceHost host = new ServiceHost(typeof(CategoryService));

                    IComponentRegistration registration;
                    if (!container.ComponentRegistry.TryGetRegistration(new TypedService(typeof(ICategory)), out registration))
                    {
                        Console.WriteLine("The service contract has not been registered in the container.");
                        Console.ReadLine();
                        Environment.Exit(-1);
                    }

                    host.Description.Behaviors.Add(new AutofacDependencyInjectionServiceBehavior(container, typeof(CategoryService), registration));
                    host.Open();

                    Console.WriteLine("The host has been opened.");
                    Console.ReadLine();

                    host.Close();
                    Environment.Exit(0);
                }

            }
            catch (System.Exception oEx)
            {
                Console.WriteLine("Exception: " + oEx.Message);
            }

        }
    }
}
