
using System.Linq;
using NUnit.Framework;
using NorthwindDemo.Service.Datacontract;
using NorthwindDemo.Infrastructure;

namespace NorthwindDemo.Service.IntegrationTest
{
    [TestFixture]
    public class CategoryServiceTest
    {
        private ICategory _dataService;

        [SetUp]
        public void SetUp()
        {
            _dataService = DependencyResolver.Resolve<NorthwindDemo.Service.Datacontract.ICategory>();
        }

        [Test]
        public void ShouldGetAllCategories()
        {
            var allCategories = _dataService.GetAllCategories();
            Assert.That(allCategories.Count(), Is.GreaterThan(0));
        }
    }
}
