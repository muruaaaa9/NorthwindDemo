using System;
using System.Collections.Generic;
using System.ServiceModel;
using NorthwindowDemo.DomainModel.Models;

namespace NorthwindDemo.Service.Datacontract
{
    [ServiceContract]
    public interface ICategory : IDisposable
    {
        [OperationContract]
        IEnumerable<Category> GetAllCategories();
    }

}
