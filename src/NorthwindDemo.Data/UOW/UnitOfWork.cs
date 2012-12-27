using System;
using NorthwindowDemo.DomainModel.Models;

namespace NorthwindDemo.Data.UOW
{
    public interface IUnitOfWork
    {
        int Save();
        INorthwindContext Context { get; }
    }

    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly INorthwindContext _context;

        public UnitOfWork()
        {
            _context = new NorthwindContext();
        }

        public UnitOfWork(NorthwindContext context)
        {
            _context = context;
        }

        public int Save()
        {
            return _context.SaveChanges();
        }

        public INorthwindContext Context
        {
            get { return _context; }
        }

        public void Dispose()
        {
            //_context.Dispose();
        }
    }
}
