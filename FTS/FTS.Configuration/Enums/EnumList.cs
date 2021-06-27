using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTS.Configuration.Enum
{
  public class EnumList
    {
        public enum FuelType
        {
           Diesel = 1,
           Electric = 2,
           LPG = 3,
           Petrol = 4,
           CNG_Hybrid = 5 
        }
        public enum TransmissionType
        {
            Automatic = 1,
            Manula = 2,
        }
        public enum HouseType
        {
            Apartment = 1,
            Builder_Floor = 2,
            Farm_Houses = 3,
            Houses_Vilas = 4
        }
        public enum FurnishingStatus
        {
            Furnished = 1,
            Semi_Furnished = 2,
            Un_Furnished = 3
        }
        public enum ConstructionStatus
        {
            New_Launch = 1,
            ReadyToMove = 2,
            Under_Construction =3
        }

      public enum ListedBy
        {
            Builder = 1,
            Dealer = 2,
            Owner=3
        }
        public enum FacingType
        {
            East=1,
            North=2,
            North_East=3,
            North_West=4,
            South=5,
            South_East=6,
            South_West=7,
            West=8
        }
        public enum LandType
        {
            For_Rent=1,
            For_Sale=2
        }
        public enum PGType
        {
            Guest_House=1,
            PG=2,
            Roomate=3
        }
        public enum GadgetType
        {
            Mobile=1,
            Tablet=2,
            Accessories=3
        }
        public enum SalaryPeriodType
        {
            Hourly=1,
            Monthly=2,
            Weekly=3,
            Early=4
        }
        public enum PositionType
        {
            Contract=1,
            Full_Time=2,
            Part_Time=3,
            Temporary=4
        }
        public enum VehicleType
        {
            MotorCycle=1,
            Scooter=2,
            Scooty=3,
            Car=4
        }
      public  enum ServiceType
        {
            For_Sale = 1,
            For_Rent = 2,
            For_Lease = 3
        }
        public enum CommercialServiceType
        {
            Computer = 1,
            Education = 2,
            Driver_Taxi = 3,
            Health_Beauty = 4,
            Others = 5
        }
        public enum ElectronicApplianceType
        {
            TV = 1,
            Audio_Vedio = 2,
            Kitchen = 3,
            Camera = 4,
            Games_Entertainment = 5,
            Refrigrator = 6,
            Computer_Accessories = 7,
            AC = 8,
            Washing_Machine = 9,
            Others = 10
        }
       public enum FurnitureType
        {
            Sofa_Dining = 1,
            Beds_Warddrobes = 2,
            Home_Decorator = 3,
            Kids_Furniture = 4,
            Others = 5
        }
        public enum FashionType
        {
            Men = 1,
            Women = 2,
            Kids = 3
        }
    }
}
