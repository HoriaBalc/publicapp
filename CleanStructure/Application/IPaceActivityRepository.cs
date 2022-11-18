using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Application
{
    public interface IPaceActivityRepository
    {
        PaceActivity GetPaceActivity(Guid id);
        void CreatePaceActivity(PaceActivity activity);
    }
}
