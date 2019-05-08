using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CarMaintenanceTracker
{
    static class CarList
    {
        static string CarPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\CarMaintenanceTracker\CarList.xml";

        static List<Car> _carList = new List<Car>();

        public static void Initialize()
        {
            if (!File.Exists(CarPath))
            {
                var xmlTree = new XElement("CarList");
                xmlTree.Save(CarPath);
            }
            else
            {
                try
                {
                    var xmlTree = XElement.Load(CarPath);
                    foreach(var xmlCar in xmlTree.Elements("Car"))
                    {
                        Car car = Car.LoadCar(xmlCar);
                    }
                }
                catch { }
            }
        }

        public static bool AddCar(string name)
        {
            if (_carList.Find(car => car.Name == name) != null)
            {
                return false;
            }
            _carList.Add(new Car(name));
            SaveCarList();
            return true;
        }

        public static bool ContainsCar(string name)
        {
            return _carList.Find(car => car.Name == name) != null;
        }

        public static bool RemoveCar(string name)
        {
            Car removeCar = _carList.Find(car => car.Name == name);
            if (removeCar == null)
            {
                return false;
            }
            _carList.Remove(_carList.Find(car => car.Name == name));
            SaveCarList();
            return true;
        }

        public static void SaveCarList()
        {
            try
            {
                XElement xmlTree = new XElement("CarList");
                foreach (Car car in _carList)
                {
                    xmlTree.Add(car.Save());
                }
                xmlTree.Save(CarPath);
            }
            catch { }
        }

        public static void PopulateComboBox(ComboBox box)
        {
            box.Items.Clear();
            foreach (Car car in _carList)
            {
                box.Items.Add(car.Name);
            }
        }
    }

    class Car
    {
        public string Name { get; set; }

        public Car(string name)
        {
            Name = name;
        }

        public XElement Save()
        {
            XElement xmlCar = new XElement("Car");
            xmlCar.Add(new XElement("Name", Name));

            return xmlCar;
        }

        public static Car LoadCar(XElement xmlCar)
        {
            Car newCar;

            XElement xmlTemp;
            xmlTemp = xmlCar.Element("Name");
            if (xmlTemp != null)
            {
                newCar = new Car(xmlCar.Value);
            }
            else
            {
                //error occurs here
                return new Car("Error car");
            }

            return newCar;
        }
    }
}
