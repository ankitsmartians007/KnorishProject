using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IBoatService
    {
        string AddBoat(Boat model);
        string RentBoat(Boat model);
        List<Boat> ListBoat();
    }
}
