using Model.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimsProject.Repository.UserRepository
{
    public interface INotificationRepository : GenericRepository.IGenericRepository<Notification>
    {
        Boolean GetNotification(int notifyId);
    }
}
