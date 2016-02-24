using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Moq;
using MyEcomStore.Domain.Abstract;
using MyEcomStore.Domain.Concrete;
using MyEcomStore.Domain.Entities;
using Ninject;

namespace MyEcomStore.WebUI.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;
        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        private void AddBindings()
        {
            //put bindings here

            //var mock = new Mock<IProductRepository>();
            //mock.Setup(m => m.Products).Returns(new List<Product> {
            //            new Product { Name = "Football", Price = 25 },
            //            new Product { Name = "Surf board", Price = 179 },
            //            new Product { Name = "Running shoes", Price = 95 }
            //            });
            //kernel.Bind<IProductRepository>().ToConstant(mock.Object);
            
            kernel.Bind<IProductRepository>().To<EFProductRepository>();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
    }
}