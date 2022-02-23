namespace Modules.OOP.Details
{

    public enum TypeEngine
    {
        Дизель,
        Газ,
        Электрический
    }
    public enum TypeTransmission
    {
        Заднеприводный,
        Переднеприводный,
        Полноприводный
    }
    public enum NameDetails
    {
        Двигатель,
        Шасси,
        Трансмиссия
    }
    public static class NameTransport
    {
        public const string Car = "ЛЕГКОВОЙ АВТОМОБИЛЬ";
        public const string Scooter = "СКУТЕР";
        public const string Bus = "АВТОБУС";
        public const string Truck = "ГРУЗОВИК";
    }
}
