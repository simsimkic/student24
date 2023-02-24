using Model.Room;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimsProject.Repository.RoomRepository
{
    public interface IBedroomRepository : GenericRepository.IGenericRepository<Bedroom>
    {
        Bedroom GetBedroomByNumber(int roomNumber);
    }
}
