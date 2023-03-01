using OOP2;

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.CustomerNumber = "12345";
customer1.Name = "Engin";
customer1.Surname = "Demiroğ";
customer1.IdentityNumber = "12345678910";

CoorporateCustomer customer2 = new CoorporateCustomer();
customer2.Id = 2;
customer2.CustomerNumber = "54321";
customer2.CompanyName = "Kodlama.io";
customer2.TaxNumber = "1234567890";

Customer customer3 = new IndividualCustomer();
Customer customer4 = new CoorporateCustomer();

CustomerManager customerManager = new CustomerManager();
customerManager.Add(customer1);
customerManager.Add(customer2);