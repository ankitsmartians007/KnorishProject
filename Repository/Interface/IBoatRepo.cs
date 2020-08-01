using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IBoatRepo
    {
        string AddBoat(Boat model);
        string RentBoat(Boat model);
        List<Boat> ListBoat();
    }
}
