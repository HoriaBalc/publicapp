using Application;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly AppDbContext _dataContext;   
        public ISportRepository SportRepository { get; private set; }
        public IRoleRepository RoleRepository { get; private set; }
        public IUserRepository UserRepository { get; private set; }
        public IActivityRepository ActivityRepository { get; private set; }
        public IDetailActivityRepository DetailActivityRepository { get; private set; }
        public IPaceActivityRepository PaceActivityRepository { get; private set; }




        public UnitOfWork(AppDbContext dataContext, ISportRepository sportRepository, IRoleRepository roleRepository, IActivityRepository activityRepository, IDetailActivityRepository detailActivityRepository, IPaceActivityRepository paceActivityRepository, IUserRepository userRepository )
        {
            _dataContext = dataContext;
            SportRepository = sportRepository;
            RoleRepository = roleRepository;
            ActivityRepository = activityRepository;
            DetailActivityRepository = detailActivityRepository;
            PaceActivityRepository = paceActivityRepository;
            UserRepository = userRepository;

        }


        public async Task Save()
        {
            await _dataContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            _dataContext.Dispose();
        }
    }
}
