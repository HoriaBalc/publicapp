using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public interface IUnitOfWork : IDisposable
    {
        public ISportRepository SportRepository { get; }
        public IRoleRepository RoleRepository { get; }
        public IUserRepository UserRepository { get; }
        public IActivityRepository ActivityRepository { get; }
        public IDetailActivityRepository DetailActivityRepository { get; }
        public IPaceActivityRepository PaceActivityRepository { get; }

        Task Save();
        void SaveSync();
    }
}
