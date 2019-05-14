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
    public static class CarList
    {
        static string CarPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\CarMaintenanceTracker\CarList.xml";

        static List<Car> _carList = new List<Car>();

        /// <summary>
        /// Initialize the car list class, read the CarList.xml file in the local application data folder
        /// </summary>
        /// <returns>True if the list is empty, false otherwise</returns>
        public static bool Initialize()
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
                        _carList.Add(Car.LoadCar(xmlCar));
                    }
                }
                catch { }
            }
            return _carList.Count == 0; //want to return true if the car list is empty on start
        }

        /// <summary>
        /// Add a new car to the car list
        /// </summary>
        /// <param name="name">The name of the car to add</param>
        /// <returns>True if successful, false otherwise</returns>
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

        /// <summary>
        /// Check if the car list contains a car
        /// </summary>
        /// <param name="name">The name of the car to check</param>
        /// <returns>True if the car is in the list, false otherwise</returns>
        public static bool ContainsCar(string name)
        {
            return _carList.Find(car => car.Name == name) != null;
        }

        /// <summary>
        /// Remove a car from the system/car list
        /// </summary>
        /// <param name="name">The name of the car</param>
        /// <returns>True if successful, false otherwise</returns>
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

        /// <summary>
        /// Calls save on each car in the car list, saving them to an xml file
        /// </summary>
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

        /// <summary>
        /// Populates a combobox with a list of cars
        /// </summary>
        /// <param name="box">The combobox to be populated</param>
        public static void PopulateComboBox(ComboBox box)
        {
            box.Items.Clear();
            foreach (Car car in _carList)
            {
                box.Items.Add(car.Name);
            }
        }

        /// <summary>
        /// Always want one car in the list, this property can be used to see if there's more than one car
        /// </summary>
        public static bool AllowDelete => _carList.Count > 1;

        /// <summary>
        /// Returns a car from the list
        /// </summary>
        /// <param name="name">The name of the car to get</param>
        /// <returns>The car from the list, null if it doesn't exist</returns>
        public static Car GetCar(string name)
        {
            return _carList.Find(car => car.Name == name);
        }

        /// <summary>
        /// Gets the default car (first element)
        /// </summary>
        /// <returns>The name of the default car</returns>
        public static string GetDefaultCar()
        {
            return _carList.ElementAt(0).Name;
        }
    }

    public class Car //I was thinking of embedding this class in CarList and requiring methods to access the Car class but figured with the use in main form and settings form it was too much nesting
    {
        public string Name { get; set; }

        //the car's mileage
        public int CarMileage { get; set; }

        public int MonthlyMilesEstimate { get; set; }
        
        public int MilesSinceOilChange { get; set; }
        public int RecommendedOilChangeMiles { get; set; }

        public int MilesSinceTireRotation { get; set; }
        public int RecommendedTireRotationMiles { get; set; }

        public Car(string name)
        {
            Name = name;
        }

        public XElement Save()
        {
            XElement xmlCar = new XElement("Car");
            xmlCar.Add(new XElement("Name", Name));
            xmlCar.Add(new XElement("Mileage", CarMileage));
            xmlCar.Add(new XElement("MonthlyMilesEstimate", MonthlyMilesEstimate));

            XElement xmlOilChange = new XElement("OilChangeSettings");
            xmlOilChange.Add(new XElement("MilesSince", MilesSinceOilChange));
            xmlOilChange.Add(new XElement("RecommendedMiles", RecommendedOilChangeMiles));
            xmlCar.Add(xmlOilChange);

            XElement xmlTireRotation = new XElement("TireChangeSettings");
            xmlTireRotation.Add(new XElement("MilesSince", MilesSinceTireRotation));
            xmlTireRotation.Add(new XElement("RecommendedMiles", RecommendedTireRotationMiles));
            xmlCar.Add(xmlTireRotation);

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
