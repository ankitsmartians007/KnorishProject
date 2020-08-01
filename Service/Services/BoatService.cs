using Models.Models;
using Repository.Interface;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Service.Services
{
    public class BoatService : IBoatService
    {
        IBoatRepo _IBoatRepo;
        public BoatService(IBoatRepo IBoatRepo)
        {
            _IBoatRepo = IBoatRepo;
        }

        public string AddBoat(Boat model)
        {
            try
            {
                return _IBoatRepo.AddBoat(model);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string RentBoat(Boat model)
        {
            try
            {
                return _IBoatRepo.RentBoat(model);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public List<Boat> ListBoat()
        {
            return _IBoatRepo.ListBoat();
        }
    }
}
