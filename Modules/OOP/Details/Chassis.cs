using System;

namespace Modules.OOP.Details
{
    public class Chassis : Detail
    {
        public int AmountWheels { get; set; }
        public string Number { get; set; }
        public double PermissionLoad { get; set; }

        public Chassis() { }

        public Chassis(int amountWheels, string number, double permissionLoad, NameDetails nameChassis) 
            : base(nameChassis) 
        {
            AmountWheels = amountWheels;
            Number = number;
            PermissionLoad = permissionLoad;
        }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine +
                "Количество колёс - " + AmountWheels + Environment.NewLine + 
                "Номер - " + Number + Environment.NewLine + 
                "Допустимая нагрузка - " + PermissionLoad + " тонны" + Environment.NewLine;
        }    
    }
}
