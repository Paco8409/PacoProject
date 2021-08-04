using OnlineShop.Models.Products.Components;
using OnlineShop.Models.Products.Computers;
using OnlineShop.Models.Products.Peripherals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace OnlineShop.Core
{
    public class Controller : IController
    {
        private List<Computer> computers;

        public Controller()
        {
            computers = new List<Computer>();
        }

        public string AddComponent(int computerId, int id, string componentType, string manufacturer, string model, decimal price, double overallPerformance, int generation)
        {
            Computer computer = computers.FirstOrDefault(x => x.Id == computerId);

            if (computer == null)
            {
                throw new ArgumentException("Computer with this id does not exist.");
            }
            else
            {
                if (componentType == "CentralProcessingUnit")
                {
                    CentralProcessingUnit component = new CentralProcessingUnit(id, manufacturer, model, price, overallPerformance, generation);

                    if (computer.Components.Any(x => x.Id == id))
                    {
                        throw new ArgumentException("Component with this id already exists.");
                    }
                    else
                    {
                        computer.AddComponent(component);
                        return $"Component {component.GetType().Name} with id {id} added successfully in computer with id {computerId}.";
                    }
                }
                else if (componentType == "Motherboard")
                {
                    Motherboard component = new Motherboard(id, manufacturer, model, price, overallPerformance, generation);

                    if (computer.Components.Any(x => x.Id == id))
                    {
                        throw new ArgumentException("Component with this id already exists.");
                    }
                    else
                    {
                        computer.AddComponent(component);
                        return $"Component {component.GetType().Name} with id {id} added successfully in computer with id {computerId}.";
                    }
                }
                else if (componentType == "PowerSupply")
                {
                    PowerSupply component = new PowerSupply(id, manufacturer, model, price, overallPerformance, generation);

                    if (computer.Components.Any(x => x.Id == id))
                    {
                        throw new ArgumentException("Component with this id already exists.");
                    }
                    else
                    {
                        computer.AddComponent(component);
                        return $"Component {component.GetType().Name} with id {id} added successfully in computer with id {computerId}.";
                    }
                }
                else if (componentType == "SolidStateDrive")
                {
                    SolidStateDrive component = new SolidStateDrive(id, manufacturer, model, price, overallPerformance, generation);

                    if (computer.Components.Any(x => x.Id == id))
                    {
                        throw new ArgumentException("Component with this id already exists.");
                    }
                    else
                    {
                        computer.AddComponent(component);
                        return $"Component {component.GetType().Name} with id {id} added successfully in computer with id {computerId}.";
                    }
                }
                else if (componentType == "VideoCard")
                {
                    VideoCard component = new VideoCard(id, manufacturer, model, price, overallPerformance, generation);

                    if (computer.Components.Any(x => x.Id == id))
                    {
                        throw new ArgumentException("Component with this id already exists.");
                    }
                    else
                    {
                        computer.AddComponent(component);
                        return $"Component {component.GetType().Name} with id {id} added successfully in computer with id {computerId}.";
                    }
                }
                else if (componentType == "RandomAccessMemory")
                {
                    RandomAccessMemory component = new RandomAccessMemory(id, manufacturer, model, price, overallPerformance, generation);

                    if (computer.Components.Any(x => x.Id == id))
                    {
                        throw new ArgumentException("Component with this id already exists.");
                    }
                    else
                    {
                        computer.AddComponent(component);
                        return $"Component {component.GetType().Name} with id {id} added successfully in computer with id {computerId}.";
                    }
                }
                else
                {
                    throw new ArgumentException("Component type is invalid.");
                }
            }

            
        }

        public string AddComputer(string computerType, int id, string manufacturer, string model, decimal price)
        {
            if (computerType == "Laptop")
            {
                Computer computer = new Laptop(id, manufacturer, model, price);

                if (computers.Any(x=>x.Id == id))
                {
                    throw new ArgumentException("Computer with this id already exists.");
                }
                else
                {
                    computers.Add(computer);
                    return $"Computer with id {id} added successfully.";
                }
            }
            else if (computerType == "DesktopComputer")
            {
                Computer computer = new DesktopComputer(id, manufacturer, model, price);

                if (computers.Any(x => x.Id == id))
                {
                    throw new ArgumentException("Computer with this id already exists.");
                }
                else
                {
                    computers.Add(computer);
                    return $"Computer with id {id} added successfully.";
                }
            }
            else
            {
                throw new ArgumentException("Computer type is invalid.");
            }
        }

        public string AddPeripheral(int computerId, int id, string peripheralType, string manufacturer, string model, decimal price, double overallPerformance, string connectionType)
        {
            Computer computer = computers.FirstOrDefault(x => x.Id == computerId);

            if (computer == null)
            {
                throw new ArgumentException("Computer with this id does not exist.");
            }
            else
            {
                if (peripheralType == "Headset")
                {
                    Headset peripheral = new Headset(id, manufacturer, model, price, overallPerformance, connectionType);

                    if (computer.Peripherals.Any(x=>x.Id == id))
                    {
                        throw new ArgumentException("Peripheral with this id already exists.");
                    }
                    else
                    {
                        computer.AddPeripheral(peripheral);
                        return $"Peripheral {peripheral.GetType().Name} with id {id} added successfully in computer with id {computerId}.";
                    }
                }
                else if (peripheralType == "Keyboard")
                {
                    Keyboard peripheral = new Keyboard(id, manufacturer, model, price, overallPerformance, connectionType);

                    if (computer.Peripherals.Any(x => x.Id == id))
                    {
                        throw new ArgumentException("Peripheral with this id already exists.");
                    }
                    else
                    {
                        computer.AddPeripheral(peripheral);
                        return $"Peripheral {peripheral.GetType().Name} with id {id} added successfully in computer with id {computerId}.";
                    }
                }
                else if (peripheralType == "Monitor")
                {
                    Monitor peripheral = new Monitor(id, manufacturer, model, price, overallPerformance, connectionType);

                    if (computer.Peripherals.Any(x => x.Id == id))
                    {
                        throw new ArgumentException("Peripheral with this id already exists.");
                    }
                    else
                    {
                        computer.AddPeripheral(peripheral);
                        return $"Peripheral {peripheral.GetType().Name} with id {id} added successfully in computer with id {computerId}.";
                    }
                }
                else if (peripheralType == "Mouse")
                {
                    Mouse peripheral = new Mouse(id, manufacturer, model, price, overallPerformance, connectionType);

                    if (computer.Peripherals.Any(x => x.Id == id))
                    {
                        throw new ArgumentException("Peripheral with this id already exists.");
                    }
                    else
                    {
                        computer.AddPeripheral(peripheral);
                        return $"Peripheral {peripheral.GetType().Name} with id {id} added successfully in computer with id {computerId}.";
                    }
                }
                else
                {
                    throw new ArgumentException("Peripheral type is invalid.");
                }
            }
        }

        public string BuyBest(decimal budget)
        {
            var computer = computers.Where(x => x.Price <= budget).OrderByDescending(x => x.OverallPerformance).FirstOrDefault();

            if (computer == null)
            {
                throw new ArgumentException($" Can't buy a computer with a budget of ${budget}.");
            }
            else
            {
                computers.Remove(computer);
                return computer.ToString();
            }
        }

        public string BuyComputer(int id)
        {
            var computer = computers.FirstOrDefault(x => x.Id == id);

            if (computer == null)
            {
                throw new ArgumentException("Computer with this id does not exist.");
            }
            else
            {
                computers.Remove(computer);
                return computer.ToString();
            } 
        }

        public string GetComputerData(int id)
        {
            var computer = computers.FirstOrDefault(x => x.Id == id);

            if (computer == null)
            {
                throw new ArgumentException("Computer with this id does not exist.");
            }
            else
            {              
                return computer.ToString();
            }
        }

        public string RemoveComponent(string componentType, int computerId)
        {
            var computer = computers.FirstOrDefault(x => x.Id == computerId);

            if (computer == null)
            {
                throw new ArgumentException("Computer with this id does not exist.");
            }
            else
            {
                if (computer.RemoveComponent(componentType) != null)
                {
                    computer.RemoveComponent(componentType);
                    return $"Successfully removed {componentType} with id {computer.RemoveComponent(componentType).Id}.";
                }
                return "";
            }
        }

        public string RemovePeripheral(string peripheralType, int computerId)
        {
            var computer = computers.FirstOrDefault(x => x.Id == computerId);

            if (computer == null)
            {
                throw new ArgumentException("Computer with this id does not exist.");
            }
            else
            {
                if (computer.RemovePeripheral(peripheralType) != null)
                {
                    computer.RemovePeripheral(peripheralType);
                    return $"Successfully removed {peripheralType} with id {computer.RemovePeripheral(peripheralType).Id}.";
                }
                return "";
            }
        }
    }
}
