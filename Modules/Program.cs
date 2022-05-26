using Modules.OOP;
using Modules.OOP.Details;
using Modules.OOP.Exceptions;
using Modules.OOP.Transports;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Modules
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join("", Enumerable.Repeat("-", 70)));
            Console.Write(string.Join("", Enumerable.Repeat("-", 15)));
            Console.Write(" Module: Exceptions ");
            Console.WriteLine(string.Join("", Enumerable.Repeat("-", 15)));
            Console.WriteLine(string.Join("", Enumerable.Repeat("-", 70)));

            Console.OutputEncoding = Encoding.UTF8;

            var transports = GetTransport();

            try
            {
                Add(new Truck(4, NameTransport.Truck,
                    new Engine(280, 1.8, TypeEngine.Газ, "8845791G", NameDetails.Двигатель),
                    new Chassis(4, "15748624", 4.75, NameDetails.Шасси),
                    new Transmission(TypeTransmission.Полноприводный, 6, "Japan", NameDetails.Трансмиссия)));
            }
            catch (AddException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                var userTransportParameter = GetAutoByParameter("Power", "100");
                foreach (var item in userTransportParameter)
                {
                    Console.WriteLine(item);
                }
            }
            catch (GetAutoByParameterException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                UpdateAuto(5, new Truck(4, NameTransport.Truck,
                    new Engine(280, 1.8, TypeEngine.Газ, "8845791G", NameDetails.Двигатель),
                    new Chassis(4, "15748624", 4.75, NameDetails.Шасси),
                    new Transmission(TypeTransmission.Полноприводный, 6, "Japan", NameDetails.Трансмиссия)));
            }
            catch (UpdateAutoException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                RemoveAuto(5);
            }
            catch (RemoveAutoException ex)
            {
                Console.WriteLine(ex.Message);
            }

            XmlSerializer serializerforTransportParamVolume = new XmlSerializer(typeof(List<Transport>));
            using (FileStream fs = new FileStream(@"..\..\..\OOP\XMLDocuments\TheFirstCondition.xml", FileMode.OpenOrCreate))
            {
                var transportParamVolume = transports.Where(t => t.Engine.Volume > 1.5).ToList();

                serializerforTransportParamVolume.Serialize(fs, transportParamVolume);
            }

            XmlSerializer serializerforTruckAndBusParam = new XmlSerializer(typeof(List<Engine>));
            using (FileStream fs = new FileStream(@"..\..\..\OOP\XMLDocuments\TheSecondCondition.xml", FileMode.OpenOrCreate))
            {
                var truckAndBusParam = transports.Where(t => t.NameTransport == "АВТОБУС" || t.NameTransport == "ГРУЗОВИК").
                    Select(t => new Engine
                    {
                        Type = t.Engine.Type,
                        SerialNumber = t.Engine.SerialNumber,
                        Volume = t.Engine.Volume
                    }).ToList();

                fs.SetLength(0);

                serializerforTruckAndBusParam.Serialize(fs, truckAndBusParam);
            }

            XmlSerializer serializerforTransmissionParam = new XmlSerializer(typeof(List<GroupedTransport>));
            using (FileStream fs = new FileStream(@"..\..\..\OOP\XMLDocuments\TheThirdCondition.xml", FileMode.OpenOrCreate))
            {
                var transmissionParam = transports.GroupBy(t => t.Transmission.Type).
                    Select(t => new GroupedTransport
                    {
                        TransmissionKey = t.Key,
                        Transports = t.ToList()
                    }).
                    ToList();

                serializerforTransmissionParam.Serialize(fs, transmissionParam);
            }

            Console.Write("Data serialized!");
        }

        private static List<Transport> GetTransport()
        {
            try
            {
                var allTransports = new List<Transport> {
                new Car(96.7, NameTransport.Car,
                    new Engine(100, 1.4, TypeEngine.Дизель, "1234523RT", NameDetails.Двигатель),
                    new Chassis(4, "173678263", 2, NameDetails.Шасси),
                    new Transmission(TypeTransmission.Заднеприводный, 6, "Japan", NameDetails.Трансмиссия)),
                new Car(88.9, NameTransport.Car,
                    new Engine(88, 1.2, TypeEngine.Газ, "15953264IY", NameDetails.Двигатель),
                    new Chassis(4, "5556495875", 1.56, NameDetails.Шасси),
                    new Transmission(TypeTransmission.Полноприводный, 5, "USA", NameDetails.Трансмиссия)),
                new Car(92.1, NameTransport.Car,
                    new Engine(92, 1.6, TypeEngine.Электрический, "5469853LK", NameDetails.Двигатель),
                    new Chassis(4, "3325649", 1.7, NameDetails.Шасси),
                    new Transmission(TypeTransmission.Переднеприводный, 5, "Lithuania", NameDetails.Трансмиссия)),

                new Scooter(65, NameTransport.Scooter,
                    new Engine(25, 0.8, TypeEngine.Электрический, "1829304КВ", NameDetails.Двигатель),
                    new Chassis(2, "78263", 0.2, NameDetails.Шасси),
                    new Transmission(TypeTransmission.Переднеприводный, 2, "China", NameDetails.Трансмиссия)),
                new Scooter(73, NameTransport.Scooter,
                    new Engine(32, 1.0, TypeEngine.Электрический, "74159874PO", NameDetails.Двигатель),
                    new Chassis(2, "5487892", 0.25, NameDetails.Шасси),
                    new Transmission(TypeTransmission.Полноприводный,3, "South Korea", NameDetails.Трансмиссия)),
                new Scooter(55, NameTransport.Scooter,
                    new Engine(19, 0.6, TypeEngine.Электрический, "5478965KJ", NameDetails.Двигатель),
                    new Chassis(2, "3232316", 0.18, NameDetails.Шасси),
                    new Transmission(TypeTransmission.Заднеприводный, 2, "Poland", NameDetails.Трансмиссия)),

                new Bus(11, NameTransport.Bus,
                    new Engine(90, 1.2, TypeEngine.Дизель, "76459В", NameDetails.Двигатель),
                    new Chassis(4, "87543", 3, NameDetails.Шасси),
                    new Transmission(TypeTransmission.Переднеприводный, 5, "Uzbekistan", NameDetails.Трансмиссия)),
                new Bus(2, NameTransport.Bus,
                    new Engine(88, 1.0, TypeEngine.Дизель, "852469L", NameDetails.Двигатель),
                    new Chassis(4, "121452", 4, NameDetails.Шасси),
                    new Transmission(TypeTransmission.Полноприводный, 6, "Armenia", NameDetails.Трансмиссия)),
                new Bus(29, NameTransport.Bus,
                    new Engine(92, 1.2, TypeEngine.Дизель, "778795O", NameDetails.Двигатель),
                    new Chassis(4, "325649", 2.5, NameDetails.Шасси),
                    new Transmission(TypeTransmission.Переднеприводный, 4, "Ukraine", NameDetails.Трансмиссия)),

                new Truck(2, NameTransport.Truck,
                    new Engine(120, 1.4, TypeEngine.Газ, "234987", NameDetails.Двигатель),
                    new Chassis(4, "098789", 3.25, NameDetails.Шасси),
                    new Transmission(TypeTransmission.Полноприводный, 4, "Belarus", NameDetails.Трансмиссия)),
                new Truck(3, NameTransport.Truck,
                    new Engine(180, 1.6, TypeEngine.Газ, "2223569J", NameDetails.Двигатель),
                    new Chassis(4, "002154", 2.5, NameDetails.Шасси),
                    new Transmission(TypeTransmission.Заднеприводный, 5, "Russia", NameDetails.Трансмиссия)),
                new Truck(4, NameTransport.Truck,
                    new Engine(240, 1.8, TypeEngine.Газ, "8845791G", NameDetails.Двигатель),
                    new Chassis(4, "950236", 4.75, NameDetails.Шасси),
                    new Transmission(TypeTransmission.Полноприводный, 6, "Japan", NameDetails.Трансмиссия)),
            };

                return allTransports;
            }
            catch (InitializationException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            catch (AddException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public static void Add(Transport transport)
        {
            var transports = GetTransport();
            if (transport.NameTransport == "Водитель")
            {
                throw new AddException("Ошибка! Невозможно добавить авто!");
            }
            else
            {
                transports.Add(transport);
            }
        }

        public static List<Transport> GetAutoByParameter(string parameter, string value)
        {
            var alltranspotrs = GetTransport();
            var transportWithParameter = new List<Transport>();
            foreach (var vehicle in alltranspotrs)
            {
                var properties = vehicle.GetType().GetProperties();

                foreach (var property in properties)
                {
                    var propertyValue = property.GetValue(vehicle);
                    var valueType = propertyValue.GetType();
                    if (valueType == typeof(Chassis) || valueType == typeof(Engine) || valueType == typeof(Transmission))
                    {
                        var innerProperties = valueType.GetProperties();
                        foreach (var innerProperty in innerProperties)
                        {
                            var innerValue = innerProperty.GetValue(propertyValue);
                            if (innerProperty.Name == parameter && innerValue.ToString() == value)
                            {
                                transportWithParameter.Add(vehicle);
                            }
                        }
                    }
                    else
                    {
                        if (property.Name == parameter && propertyValue.ToString() == value)
                        {
                            transportWithParameter.Add(vehicle);
                        }
                    }
                }
            }
            if (!transportWithParameter.Any())
            {
                throw new GetAutoByParameterException("Невозможно найти машинус такими параметрами!");
            }
            return transportWithParameter;
        }
        public static void UpdateAuto(int id, Transport transport)
        {
            var transports = GetTransport();
            if ((id < 0) || (id > transports.Count))
            {
                throw new UpdateAutoException("Ошибка! Невозможно заменить авто!");
            }
            else
            {
                transports[id] = transport;
            }
        }

        public static void RemoveAuto(int id)
        {
            var transports = GetTransport();
            if ((id < 0) || (id > transports.Count))
            {
                throw new RemoveAutoException("Ошибка! Невозможно удалить авто");
            }
            else
            {
                transports.Remove(transports[id]);
            }
        }
    }
}
