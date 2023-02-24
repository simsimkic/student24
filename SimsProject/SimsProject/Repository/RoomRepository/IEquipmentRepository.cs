using Model.Room;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimsProject.Repository.RoomRepository
{
    public interface IEquipmentRepository : GenericRepository.IGenericRepository<SuppliesOfEquipment>
    {
        SuppliesOfEquipment GetEquipment(int id);
    }
}
