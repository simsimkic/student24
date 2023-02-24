using Model.Room;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimsProject.Repository.RoomRepository
{
    public interface IHallRepository : GenericRepository.IGenericRepository<Hall>
    {
        List<Hall> GetAllHall();
    }
}
