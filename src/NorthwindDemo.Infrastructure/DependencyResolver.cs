using System.ServiceModel;
using Autofac;
using NorthwindDemo.Service;


namespace NorthwindDemo.Infrastructure
{
    public class DependencyResolver
    {
        private static IContainer _container;
        private static DependencyMapper dependencyMapper = new DependencyMapper();

        static DependencyResolver()
        {
            var containerBuilder = new ContainerBuilder();
            containerBuilder = RegisterDependencies(containerBuilder);
            _container = containerBuilder.Build();
        }

        private static ContainerBuilder RegisterDependencies(ContainerBuilder containerBuilder)
        {
            containerBuilder = dependencyMapper.Register(containerBuilder);
            return containerBuilder;
        }

        public static T Resolve<T>()
        {
            var resolve = _container.Resolve<T>();
            return resolve;
        }
    }

    public class DependencyMapper
    {
        public ContainerBuilder Register(ContainerBuilder builder)
        {
            builder.Register(c => new ChannelFactory<NorthwindDemo.Service.Datacontract.ICategory>("DataServiceTcpEndpoint").CreateChannel()).As<NorthwindDemo.Service.Datacontract.ICategory>().InstancePerDependency();
           return builder;

        }
    }
}
