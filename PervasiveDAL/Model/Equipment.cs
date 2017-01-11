using System.Collections.Generic;

namespace PervasiveDAL.Model
{
    public class Equipment
    {
        public Equipment(   int equipmentId, string customerId, string unitId, 
                            string year, string engineMake, string engineModel, 
                            string territory, string gensetSerialNumber, string gensetMakeModel, 
                            string kwVoltage, string locationCode, int unitHours,
                            string nextServiceDate, string notes, IList<Invoice> invoices)
        {
            EquipmentId = equipmentId;
            CustomerId = customerId;
            UnitId = unitId;
            Year = year;
            EngineMake = engineMake;
            EngineModel = engineModel;
            Territory = territory;
            GensetSerialNumber = gensetSerialNumber;
            GensetMakeModel = gensetMakeModel;
            KwVoltage = kwVoltage;
            LocationCode = locationCode;
            UnitHours = unitHours;
            NextServiceDate = nextServiceDate;
            Notes = notes;

            Invoices = invoices;
        }

        public int EquipmentId { get; set; }
        public string CustomerId { get; set; }
        public string UnitId { get; set; }
        public string Year { get; set; }
        public string EngineMake { get; set; }
        public string EngineModel { get; set; }
        public string Territory { get; set; }
        public string GensetSerialNumber { get; set; }
        public string GensetMakeModel { get; set; }
        public string KwVoltage { get; set; }
        public string LocationCode { get; set; }
        public int UnitHours { get; set; }
        public string NextServiceDate { get; set; }
        public string Notes { get; set; }


        public IList<Invoice> Invoices { get; set; } 

    }
}
