using Model.Room;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimsProject.Repository.RoomRepository
{
    public interface IRenvationRepository : GenericRepository.IGenericRepository<Renovation>
    {
        Renovation GetByRoom(Room room);
    }
}
