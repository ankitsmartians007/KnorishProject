using Models.Models;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class BoatRepo : IBoatRepo
    {
        KnorishDbContext db = new KnorishDbContext();

        public string AddBoat(Boat model)
        {
            try
            {
                string Message = string.Empty;
                var data = db.Boats.FirstOrDefault(x => x.BoatName == model.BoatName);
                if (data == null)
                {
                    Boat b = new Boat();
                    b.BoatName = model.BoatName;
                    b.HourlyRate = model.HourlyRate;
                    db.Boats.Add(b);
                    db.SaveChanges();
                    Message = "Boat registered successfully having BoatId " + b.BoatId;
                }
                else
                {
                    Message = "Boat Name already Exist";
                }
                return Message;
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
                string Message = string.Empty;
                var data = db.Boats.FirstOrDefault(x => x.BoatId == model.BoatId);
                if (data == null)
                {
                    Message = "Boat not found.";
                }
                if (data != null)
                {
                    if (!string.IsNullOrEmpty(data.CustomerName))
                    {
                        Message = "Boat is already rented to someone else. please find another boat.";
                    }
                    else
                    {
                        data.CustomerName = model.CustomerName;
                        db.SaveChanges();
                        Message = "Boat rented successfully.";
                    }
                }
                return Message;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Boat> ListBoat()
        {
            return db.Boats.ToList();
        }
    }
}
