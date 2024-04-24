using System;
using System.Collections;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace CafeCardmanagement
{
    public static class Operations
    {
        static UserDetails currentLoggedinUser;
        static CustomList<UserDetails> userList=new CustomList<UserDetails>();
        static CustomList<OrderDetails> orderList=new CustomList<OrderDetails>();
        static CustomList<CartItem> cartItemList=new CustomList<CartItem>();
        static CustomList<FoodDetails> foodList=new CustomList<FoodDetails>();
        //main menu
        public static void MainMenu()
        {
            Console.WriteLine("******Cafeteria management*******");
            string mainChoice="yes";
            do{
                Console.WriteLine("1.User Registration \n2.User Login \n3.Exit");
                Console.WriteLine("Enter the option");
                int mainOption=int.Parse(Console.ReadLine());
                switch(mainOption)
                {
                    case 1:
                    {
                        Console.WriteLine("********User Registration********");
                        UserRegistration();
                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine("*********User login*******");
                        Login();
                        break;
                    }
                    case 3:
                    {
                        Console.WriteLine("Application Exited successfully");
                        mainChoice="no";
                        break;
                    }
                }

            }while(mainChoice=="yes");
        }
        //main menu ends
        
        //reistration
        public static void UserRegistration()
        {
            Console.Write("Enter your Name: ");
            string name=Console.ReadLine();
            Console.Write("Enter your FatherName: ");
            string fatherName=Console.ReadLine();
            Console.WriteLine("Enter your Gender:");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
            Console.Write("Enter your Mobile Number:");
            string mobile=Console.ReadLine();
            Console.Write("Enter your MailID:");
            string mail=Console.ReadLine();
            Console.Write("Enter your Balance:");
            double walletBalance=double.Parse(Console.ReadLine());
            Console.Write("Enter your Workstation number:");
            string workStationNumber=Console.ReadLine();
            UserDetails users =new UserDetails(name,fatherName,gender,mobile,mail,walletBalance,workStationNumber);
            userList.Add(users);
            Console.WriteLine("Registration Successful and your UserID is "+users.UserID);
        }
        //registration ends

        public static void Login()
        {
            //need to get userid and check whether the id is present in the list or not
            Console.WriteLine("Enter your UserID: ");
            string id=Console.ReadLine().ToUpper();
            bool flag=true;
            foreach(UserDetails user in userList)
            {
                if(id.Equals(user.UserID))
                {
                    flag=false;
                    currentLoggedinUser=user;
                    Console.WriteLine("LoggedIn Successfully");
                    SubMenu();
                    break;
                }
            }
            if(flag)
            {
                Console.WriteLine("Invalid UserID");
            }
        }
        //submenu
        public static void SubMenu()
        {
            Console.WriteLine("**********SubMenu*********");
            string subChoice="yes";
            do{
                Console.WriteLine("1.Show My Profile \n2.Food Order \n3.Modify Order \n4.Cancel Order \n5.Order History \n6.Wallet Recharge \n7.Show WallwtBalance \n8.Exit");
                int subOption=int.Parse(Console.ReadLine());
                switch(subOption)
                {
                    case 1:
                    {
                        Console.WriteLine("*****show my profile*****");
                        ShowMyProfile();
                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine("*******Food Order*******");
                        FoodOrder();
                        break;
                    }
                    case 3:
                    {
                        Console.WriteLine("******Modify Order*****");
                        ModifyOrder();
                        break;
                    }
                    case 4:
                    {
                        Console.WriteLine("*****Cancel order****");
                        CancelOrder();
                        break;
                    }
                    case 5:
                    {
                        Console.WriteLine("******Order History******");
                        OrderHistory();
                        break;
                    }
                    case 6:
                    {
                        Console.WriteLine("*******Wallet Recharge******");
                        WalletRecharge();
                        break;
                    }
                    case 7:
                    {
                        Console.WriteLine("*****Show WalletBalance*****");
                        ShowWalletBalance();
                        break;
                    }
                    case 8:
                    {
                        Console.WriteLine("Taking back to Main menu");
                        subChoice="no";
                        break;
                    }
                }

            }while(subChoice=="yes");
        }
        //submenu ends


        //show my profile
        public static void ShowMyProfile()
        {
            //need to display the user details
            foreach(UserDetails user in userList)
            {
                if(currentLoggedinUser.UserID.Equals(user.UserID))
                {
                Console.WriteLine($"UserID: {user.UserID} \nUserName: {user.Name} \nFatherName: {user.Fathername} \nMobile: {user.Mobile} \nMailID: {user.Mail} \nGender: {user.Gender} \nWorkstationNumber: {user.WorkStationNumber}");
                }
            }
        }
        //show my profile ends

        //Food order
        public static void FoodOrder()
        {
            //need to create temp cartitem lis
            CustomList<CartItem> localCart=new CustomList<CartItem>();
            //create order object
            OrderDetails orders=new OrderDetails(currentLoggedinUser.UserID,DateTime.Now,0,OrderStatus.Initiated);
            //need to show the foods availabale 
            Console.WriteLine("|FoodID|FoodName|Price|AvailableQuantitty|");
            foreach (FoodDetails food in foodList)
            {
                Console.WriteLine($"|{food.FoodID}|{food.FoodName}|{food.FoodPrice}|{food.AvailableQuantity}|");
            }
            string pickAnother="";
            int quantity;
            do{
                //ask user to pick the food id
                Console.WriteLine("Choose the FoodID: ");
                string foodid = Console.ReadLine().ToUpper();
                //get the quantity 
                Console.WriteLine("Enter the quantity you need: ");
                quantity = int.Parse(Console.ReadLine());

                foreach (FoodDetails food in foodList)
                {
                    if (foodid.Equals(food.FoodID))
                    {
                        if (quantity <= food.AvailableQuantity)
                        {
                            food.FoodPrice *= quantity;
                            food.AvailableQuantity -= quantity;
                            //create CartItems object using the available data.
                            CartItem cartItem = new CartItem(orders.OrderID, food.FoodID, food.FoodPrice, quantity);
                            //add the cartItem object to cartItem list
                            localCart.Add(cartItem);
                            break;

                        }
                    }
                }
                Console.WriteLine("Do you want to pick another product: yes/no");
                pickAnother=Console.ReadLine();
            }while(pickAnother=="yes");

            //ask user to confirm the purchase
            string confirmPurchase="";
            if(pickAnother=="no")
            {
                Console.WriteLine("Whether you need confirm the purchase: yes/no");
                confirmPurchase=Console.ReadLine();
                if(confirmPurchase=="no")
                {
                    //traverse the local cart item
                    foreach(CartItem cartItem in localCart)
                    {
                        foreach (FoodDetails food in foodList)
                        {
                            //if id found return back the ordered quantity to food details list
                            if(cartItem.FoodID.Equals(food.FoodID))
                            {
                                food.AvailableQuantity += cartItem.OrderQuantity;
                            }
                        }
                    }
                }
                //calculate total price using loacl cart
                double total=0; 
                if(confirmPurchase=="yes")
                {
                    foreach(CartItem cartItem in localCart)
                    {
                        total+=cartItem.OrderPrice;
                    }
                    //if recharged
                    string recharge = "";
                    do{
                        //check user has enough balance
                        if (currentLoggedinUser.Walletbalance >= total)
                        {
                            //if user has enough balance deduct amount and add the local cart to cartItemList
                            currentLoggedinUser.DeductAmount(total);
                            foreach (CartItem cartItem in localCart)
                            {
                                CartItem cartItem1 = new CartItem(cartItem.OrderID, cartItem.FoodID, cartItem.OrderPrice, cartItem.OrderQuantity);
                                cartItemList.Add(cartItem1);
                                orders.TotalPrice = total;
                                orders.OrderStatus = OrderStatus.Ordered;
                                orderList.Add(orders);
                                //OrderDetails orders=new OrderDetails(currentLoggedinUser.UserID,DateTime.Now,0,OrderStatus.Initiated);
                                Console.WriteLine("Order Placed Successfully, your order id is " + orders.OrderID);
                                //break;
                                // Console.WriteLine(orders.OrderStatus);
                                // Console.WriteLine(orders.TotalPrice);
                            }
                        }

                        //if user has insufficient balance
                        else
                        {
                            Console.WriteLine("Insufficient Balance");
                            //ask user whether user willing to recharge
                            Console.WriteLine("Are you willing to recharge yes/no");
                            recharge = Console.ReadLine();
                            //if user syas no exit the application and return back the items in localcart to food list
                            if (recharge == "no")
                            {
                                Console.WriteLine("Exiting without Order due to insufficient balance");
                                foreach (CartItem cartItem in localCart)
                                {
                                    foreach (FoodDetails food in foodList)
                                    {
                                        //if id found return back the ordered quantity to food details list
                                        if (cartItem.FoodID.Equals(food.FoodID))
                                        {
                                            food.AvailableQuantity += cartItem.OrderQuantity;
                                        }
                                    }
                                }
                            }
                            //if user said yes
                            else 
                            {
                                currentLoggedinUser.WalletRecharge(total);
                                
                            }
                        }
                    }while(recharge=="yes");
                }

            }


        }
        //food order ends

        //modify order
        public static void ModifyOrder()
        {
            string orderid="";
            //show order details
            
            Console.WriteLine("|OrderID|UserID|TotalPrice|OrderStatus|");
            foreach(OrderDetails order in orderList)
            {
                if(currentLoggedinUser.UserID.Equals(order.UserID) && order.OrderStatus==OrderStatus.Ordered)
                {
                    Console.WriteLine($"|{order.OrderID}|{order.UserID}|{order.OrderDate}|{order.TotalPrice}|{order.OrderStatus}");
                    Console.WriteLine("Enter the order id to modify:");
                    orderid=Console.ReadLine().ToUpper();

                    string itemid="";
                    int quantity;
                    double total=0;
                    if(orderid.Equals(order.OrderID))
                    {
                        foreach (CartItem cartItem in cartItemList)
                        {
                            if (orderid.Equals(cartItem.OrderID))
                            {
                                Console.WriteLine($"{cartItem.ItemID}| {cartItem.OrderID}|{cartItem.FoodID}|{cartItem.OrderPrice}|{cartItem.OrderQuantity}|");
                            }
                        }
                        bool flag=true;
                        Console.WriteLine("Enter the ItemId to modify");
                        itemid = Console.ReadLine().ToUpper();
                        foreach (CartItem cartItem in cartItemList)
                        {
                            if (itemid.Equals(cartItem.ItemID))
                            {
                                flag=false;
                                Console.WriteLine("Enter the new quantity of the food");
                                quantity = int.Parse(Console.ReadLine());
                                total += cartItem.OrderPrice*quantity;
                                order.TotalPrice = total;
                                orderList.Add(order);
                                Console.WriteLine("Order modified Successfully");
                                break;
                            }
                        }
                        if(flag)
                        {
                            Console.WriteLine("Invalid Item id");
                        }
                        break;
                    }
                }
            }
        }

        //cacel order
        public static void CancelOrder()
        {
            string cancelid="";
            Console.WriteLine("|OrderID|UserID|TotalPrice|OrderStatus|");
            foreach(OrderDetails order in orderList)
            {
                if(currentLoggedinUser.UserID.Equals(order.UserID) && order.OrderStatus==OrderStatus.Ordered)
                {
                    Console.WriteLine($"|{order.OrderID}|{order.UserID}|{order.OrderDate}|{order.TotalPrice}|{order.OrderStatus}");
                    Console.WriteLine("Choose the order Id to cancel");
                    cancelid=Console.ReadLine().ToUpper();
                    bool flag=true;
                    if(cancelid.Equals(order.OrderID))
                    {
                        flag=false;
                        currentLoggedinUser.Walletbalance+=order.TotalPrice;
                        order.OrderStatus=OrderStatus.Cancelled;
                        orderList.Add(order);
                        foreach (CartItem cartItem in cartItemList)
                        {
                            foreach (FoodDetails food in foodList)
                            {
                                //if id found return back the ordered quantity to food details list
                                if (cartItem.FoodID.Equals(food.FoodID))
                                {
                                    food.AvailableQuantity += cartItem.OrderQuantity;
                                    Console.WriteLine("Order Cancelled Succesfully");
                                }
                            }
                        }
                    }
                    if(flag)
                    {
                        Console.WriteLine("Invalid Order Id");
                    }
                }
            }
        }
        //cancel order ends

        //order history
        public static void OrderHistory()
        {
            //need to show the order history of currently loggged in user fro orderList
            foreach(OrderDetails order in orderList)
            {
                if(currentLoggedinUser.UserID.Equals(order.UserID))
                {
                    Console.WriteLine($"OrderID: {order.OrderID} \nUserID: {order.UserID} \nOrderDate: {order.OrderDate} \nTotalPrice: {order.TotalPrice} \nOrderStatus: {order.OrderStatus}");
                }
            }
        }
        //order history ends

        //wallet recharge
        static double amount=0;
        public static void WalletRecharge()
        {
            Console.WriteLine("Whether you need to recharge: yes/no ");
            string recharge=Console.ReadLine().ToLower();
            if(recharge=="yes")
            {
                Console.WriteLine("Enter the amount to be recharged: ");
                amount=double.Parse(Console.ReadLine());
                currentLoggedinUser.WalletRecharge(amount);
            }
        }

        //wallet recharge ends
        public static void ShowWalletBalance()
        {
            Console.WriteLine(currentLoggedinUser.Walletbalance);
        }

        
        public static void AddDefaultData()
        {
            UserDetails user1=new UserDetails("Ravichandran","Ettapparajan",Gender.Male,"8857777575","ravi@gmail.com",400,"WS101");
            UserDetails user2=new UserDetails("Baskaran","Sethuranjan",Gender.Male,"9577747744","baskaran@gmail.com",500,"WS105");
            userList.Add(user1);
            userList.Add(user2);
            // foreach(UserDetails user in userList)
            // {
            //     Console.WriteLine(user);
            // }
            OrderDetails order1=new OrderDetails("SF1001",new DateTime(2022,06,15),70,OrderStatus.Ordered);
            OrderDetails order2=new OrderDetails("SF1002",new DateTime(2022,06,15),100,OrderStatus.Ordered);
            orderList.Add(order1);
            orderList.Add(order2);

            CartItem cartItem1=new CartItem("OID1001","FID101",20,1);
            CartItem cartItem2=new CartItem("OID1001","FID101",10,1);
            CartItem cartItem3=new CartItem("OID1001","FID105",40,1);
            CartItem cartItem4=new CartItem("OID1002","FID103",10,1);
            CartItem cartItem5=new CartItem("OID1002","FID104",50,1);
            CartItem cartItem6=new CartItem("OID1002","FID105",40,1); 
            cartItemList.Add(cartItem1);
            cartItemList.Add(cartItem2);
            cartItemList.Add(cartItem3);
            cartItemList.Add(cartItem4);
            cartItemList.Add(cartItem5);
            cartItemList.Add(cartItem6);

            FoodDetails food1=new FoodDetails("Coffee",20,100);
            FoodDetails food2=new FoodDetails("Tea",15,100);
            FoodDetails food3=new FoodDetails("Biscuit",10,100);
            FoodDetails food4=new FoodDetails("Juice",50,100);
            FoodDetails food5=new FoodDetails("Puff",40,100);
            FoodDetails food6=new FoodDetails("Milk",10,100);
            FoodDetails food7=new FoodDetails("Popcorn",20,20);

            foodList.Add(food1);
            foodList.Add(food2);
            foodList.Add(food3);
            foodList.Add(food4);
            foodList.Add(food5);
            foodList.Add(food6);
            foodList.Add(food7);

        } 
    
    }
}