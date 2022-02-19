using System;
using System.Collections.Generic;
using System.Text;
using E_Commerce.Repositories;


namespace E_Commerce
{
    class MenuMain
    {
        public  static void MainMenu()
        {
            ApplicationContext context =new ApplicationContext();
            AdminRepository adminRepository=new AdminRepository(context); 
            ProductRepository productRepository=new ProductRepository(context,adminRepository);
            OrderRepository orderRepository=new OrderRepository(context,productRepository);
            CustomerRepository customerRepository=new CustomerRepository(context,orderRepository);
            Console.Write("1.To sign up customer\n" +
                              "2To  log in\n" +
                              "3.To Exit\n" +
                              "Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    customerRepository.SignUp();
                    MainMenu();
                    break;
                case 2:
                    LogIn();
                    MainMenu();
                    break;
                case 3:
                    break;
                default:
                    Console.WriteLine("Invalid Input Try again");
                    MainMenu();
                    break;


            }


        }


        public static void LogInCustomer()
        {
            ApplicationContext context =new ApplicationContext();
            AdminRepository adminRepository=new AdminRepository(context);
            ProductRepository productRepository=new ProductRepository(context,adminRepository);
            OrderRepository orderRepository=new OrderRepository(context,productRepository);
            CustomerRepository customerRepository=new CustomerRepository(context,orderRepository);
            LegerRepository legerRepository=new LegerRepository(context);

            Console.Write("Enter Email address: ");
            string email = Console.ReadLine();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();
            var customer = orderRepository.GetCustomer(email, password);
            if (customer != null)
            {
                Console.Write(           
                              "Enter 1.To  Buy \n"             +
                              "Enter 2.To print transaction\n" + 
                              "Enter 3.To Exit\n" +
                              "Enter choice: ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        orderRepository.SelectOrderIds();
                        LogInCustomer();
                        break;
                    case 2:
                      customerRepository.GetOneTransactions();
                        LogInCustomer();
                        break;
                    case 3:
                        MainMenu();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid login");
            }
        }


        public static void Manager()
        {
            ApplicationContext context = new ApplicationContext();
            AdminRepository adminRepository = new AdminRepository(context);
            ProductRepository productRepository = new ProductRepository(context, adminRepository);
            OrderRepository orderRepository = new OrderRepository(context, productRepository);
            CustomerRepository customerRepository = new CustomerRepository(context, orderRepository);
            LegerRepository legerRepository = new LegerRepository(context);
            Console.Write("Enter Email address: ");
            string email = Console.ReadLine();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();
            var admin = adminRepository.GetAdmin(email, password);
            if (admin != null)
            {
                Console.Write("Enter 1.To Register\n" +
              "Enter 2.To  Get one Admin \n" +
              "Enter 3.Print all Admin\n" +
              "Enter 4.To print Transactions\n" +
              "Enter 5.To Add Stock\n" +
              "Enter 6.To Get all product\n" +
              "Enter 7.To Delete product\n" +
              "Enter 8.To update product\n" +
              "Enter 9.To delete Admin\n" +
              "Enter 10.To Update admin\n" +
              "Enter 0.To Exit\n" +
              "Enter choice: ");

                string choice = Console.ReadLine();
                int y;
                bool h = int.TryParse(choice, out y);


                if (h == true)
                {
                        switch (y)
                        {
                            case 1:
                                adminRepository.CreateAdmin();
                                Manager();
                                break;
                            case 2:
                                adminRepository.GetOneAdmin();
                                Manager();
                                break;
                            case 3:
                                adminRepository.GetAllAdmin();
                                Manager();
                                break;
                            case 4:
                                customerRepository.PrintAllLedger();
                                Manager();
                                break;
                            case 5:
                                productRepository.CreateProduct();
                                Manager();
                                break;
                            case 6:
                                productRepository.GetAllProducts();
                                Manager();
                                break;
                            case 7:
                                productRepository.DeleteProducts();
                                Manager();
                                break;
                            case 8:
                                productRepository.UpdateProduct();
                                Manager();
                                break;
                            case 9:
                                adminRepository.DeleteAdmin();
                                Manager();
                                break;
                            case 10:
                                adminRepository.UpdateAdmin();
                                Manager();
                                break;
                            case 0:
                                MainMenu();
                                break;
                            default:
                                Console.WriteLine("Invalid input");
                                Manager();
                                break;
                        }
                }
                else
                {
                    Console.WriteLine("Invalid   Input ");
                }
            }
            else
            {
                Console.WriteLine("Input correct Password ");
                MainMenu();
            }
        }


        public static  void LogIn()
        {
            Console.WriteLine("1.For Customer Log in\n" +
                              "2.For Admin Log in \n" +
                              "3. To exit");

             int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    LogInCustomer();
                    LogIn();
                    break;
                case 2:
                    Manager();
                    LogIn();
                    break;
                case 3:
                    MainMenu();
                    break;
            }
        }
    }
}
