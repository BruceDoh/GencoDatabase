using System;
using System.Collections.Generic;
using PervasiveDAL.Model;

namespace PervasiveDAL.Repository
{
    public abstract class EquipmentRepository
    {
        public abstract Equipment SelectEquipmentById(int vehicleId);
        public abstract IList<Equipment> SelectEquipmentByCustomerId(string customerId);
    }
}