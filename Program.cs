namespace OOP02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 01
            ///a) What is the difference between a class and a struct?
            // A class is a reference type, while a struct is a value type.
            // This means that when you create an instance of a class,
            // it is stored on the heap and accessed through a reference,
            // while an instance of a struct is stored on the stack and accessed directly.
            // Additionally, classes support inheritance and polymorphism, while structs do not.
            #endregion
            #region Question 02
            ///b) Why are classes more suitable than structs for large applications?
            // Classes are more suitable for large applications because they provide more features and flexibility than structs.
            // Classes support inheritance, polymorphism, and encapsulation, which are important concepts in object-oriented programming.
            // Additionally, classes can have constructors, destructors, and finalizers, which allow for better resource management.
            // Finally, classes can be used to create complex data structures and can be easily extended and modified as the application grows.
            #endregion
            #region Question 03
            ///a) Which class is the parent class?
            // The parent class is The Shipment class
            ///b) Which class is the child class?
            //The child class is The ExpressShipment class
            ///c) What members are inherited by ExpressShipment?
            // TrackingCode
            ///d) Why is inheritance better than duplicating the same code in multiple classes?
            // Inheritance is better than duplicating the same code in multiple classes
            // because it promotes code reusability and maintainability.
            #endregion
            #region Question 04
            ///Part 02 : Practical
            ///Smart Delivery Management System
            DeliveryCenter center = new DeliveryCenter();

            #region Read Center Name
            Console.Write("Enter Center Name: ");
            center.CentreName = Console.ReadLine();
            #endregion
            #region Standard Shipment

            
            Console.WriteLine("\n--- Enter Standard Shipment Data ---");
            Console.Write("Tracking Code: ");
            string trackingCode1 = Console.ReadLine();

            Console.Write("Description: ");
            string description1 = Console.ReadLine();

            Console.Write("Weight: ");
            decimal weight1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Delivery Fee: ");
            decimal fee1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("City: ");
            string city1 = Console.ReadLine();

            Console.Write("Street: ");
            string street1 = Console.ReadLine();

            Console.Write("Building Number: ");
            int building1 = Convert.ToInt32(Console.ReadLine());

            DeliveryAddress address1 =
                new DeliveryAddress(city1, street1, building1);

            StandardShipment standardShipment =
                new StandardShipment(
                    trackingCode1,
                    description1,
                    weight1,
                    fee1,
                    address1);

            center.AddShipment(standardShipment);
            #endregion
            #region Express Shipment
            Console.WriteLine("\n--- Enter Express Shipment Data ---");

            Console.Write("Tracking Code: ");
            string trackingCode2 = Console.ReadLine();

            Console.Write("Description: ");
            string description2 = Console.ReadLine();

            Console.Write("Weight: ");
            decimal weight2 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Delivery Fee: ");
            decimal fee2 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("City: ");
            string city2 = Console.ReadLine();

            Console.Write("Street: ");
            string street2 = Console.ReadLine();

            Console.Write("Building Number: ");
            int building2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Extra Fee: ");
            decimal extraFee = Convert.ToDecimal(Console.ReadLine());

            DeliveryAddress address2 =
                new DeliveryAddress(city2, street2, building2);

            ExpressShipment expressShipment =
                new ExpressShipment(
                    trackingCode2,
                    description2,
                    weight2,
                    fee2,
                    address2,
                    extraFee);

            center.AddShipment(expressShipment);
            #endregion
            #region International Shipment

            Console.WriteLine("\n--- Enter International Shipment Data ---");

            Console.Write("Tracking Code: ");
            string trackingCode3 = Console.ReadLine();

            Console.Write("Description: ");
            string description3 = Console.ReadLine();

            Console.Write("Weight: ");
            decimal weight3 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Delivery Fee: ");
            decimal fee3 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("City: ");
            string city3 = Console.ReadLine();

            Console.Write("Street: ");
            string street3 = Console.ReadLine();

            Console.Write("Building Number: ");
            int building3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Destination Country: ");
            string country = Console.ReadLine();

            Console.Write("Customs Fee: ");
            decimal customsFee = Convert.ToDecimal(Console.ReadLine());

            DeliveryAddress address3 =
                new DeliveryAddress(city3, street3, building3);

            InternationalShipment internationalShipment =
                new InternationalShipment(
                    trackingCode3,
                    description3,
                    weight3,
                    fee3,
                    address3,
                    country,
                    customsFee);

            center.AddShipment(internationalShipment);
            #endregion

            #region Print all shipments
            Console.WriteLine("\n==============================");
            Console.WriteLine("ALL SHIPMENTS");
            Console.WriteLine("==============================");

            center.PrintAllShipments();
            #endregion

            #region Search using tracking code indexer

            
            Console.Write("\nEnter Tracking Code To Search: ");
            string searchCode = Console.ReadLine();

            Shipment foundShipment = center[searchCode];

            if (foundShipment != null)
            {
                Console.WriteLine("\nShipment Found:");
                foundShipment.PrintShipment();
            }
            else
            {
                Console.WriteLine("Shipment Not Found.");
            }
            #endregion

            #region Remove shipment

           
            Console.Write("\nEnter Tracking Code To Remove: ");
            string removeCode = Console.ReadLine();

            bool removed = center.RomoveShipment(removeCode);

            if (removed)
            {
                Console.WriteLine("Shipment Removed Successfully.");
            }
            else
            {
                Console.WriteLine("Shipment Not Found.");
            }
            #endregion

            #region Print remaining shipments

           
            Console.WriteLine("\n==============================");
            Console.WriteLine("REMAINING SHIPMENTS");
            Console.WriteLine("==============================");

            center.PrintAllShipments();
        }
    }
        #endregion

        #endregion
}


