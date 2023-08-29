using Polymorphism.Models;

// Say we haven't overrided yet; if we want to reach something from the derived with the base class, only the base class is reachable
// If you want some method to be reachable, you need to override
// With fields though, you need to typecast to the derived class of choice

CarWithoutOverride car1_without_override = new CarWithoutOverride("Vendor", "Model", new DateTime(2021, 11, 11));
AmericanoWithoutOverride car2_without_override = new AmericanoWithoutOverride("Vendor", "Model", new DateTime(2021, 11, 11), 91.23);
CarWithoutOverride car3_without_override = new YaponkaWithoutOverride("Vendor", "Model", new DateTime(2021, 11, 11), true); 

car1_without_override.Print(); // Car class's print method works
car2_without_override.Print(); // Americano class's print method works
car3_without_override.Print(); // Car class's print methods works



// But here, override works and all information is outputted
Car car1 = new Car("Vendor", "Model", new DateTime(2021, 11, 11));
Americano car2 = new Americano("Vendor", "Model", new DateTime(2021, 11, 11), 91.23);
Car car3 = new Yaponka("Vendor", "Model", new DateTime(2021, 11, 11), true);

car1.Print(); // Car class's print method works
car2.Print(); // Americano class's print method works
car3.Print(); // Yaponka class's print methods works