using System;

namespace AISCreditMeneger.Data.Models
{
    public class ClientProfile
    {
        public DateTime DateTime { get; } = DateTime.UtcNow;
        public FamilyStatus FamilyStatus { get; set; }
        public int CountChild { get; set; }
        public Work Work { get; set; }
        public Property Property { get; set; }
        public bool isVehicle { get; set; }
        public bool isAvailability_of_Credit { get; set; }

        public ClientProfile(DateTime dateTime, FamilyStatus familyStatus, int countChild, Work work, Property property, bool isVehicle, bool isAvailability_of_Credit)
        {
            DateTime = dateTime;
            FamilyStatus = familyStatus;
            CountChild = countChild;
            Work = work;
            Property = property;
            this.isVehicle = isVehicle;
            this.isAvailability_of_Credit = isAvailability_of_Credit;
        }
    }

    public enum Work
    {
        Work,
        Study,
        Pinsioner,
        WorkPinseoner,
        Unemployed
    }
    public enum Property
    {
        Home,
        Flat,
        Rent,
        Absent
    }
    public enum FamilyStatus
    {
        Single,
        Married,
        Divorce,
        Widower
    }
}
