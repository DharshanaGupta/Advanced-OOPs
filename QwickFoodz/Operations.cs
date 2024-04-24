using System;
using System.Collections;

namespace QwickFoodz
{
    public static class Operations
    {
        static CustomerDetails currentUser;
        public static CustomList<CustomerDetails> customerList=new CustomList<CustomerDetails>();
        public static CustomList<FoodDetails> foodList=new CustomList<FoodDetails>();
        public static CustomList<OrderDetails> orderList=new CustomList<OrderDetails>();
        public static CustomList<ItemDetails> itemList=new CustomList<ItemDetails>();

        public static void MainMenu()
        {
            System.Console.WriteLine("*******MainMenu*********");
            string mainOption="yes";
            do{
                System.Console.WriteLine("1.Customer Registration \n2.Customer Login \n3.Exit");
                int mainChoice=int.Parse(Console.ReadLine());
                switch(mainChoice)
                {
                    case 1:
                    {
                        System.Console.WriteLine("*****Customer Registration******");
                        CustomerRegistration();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("******Customer Login******");
                        CustomerLogin();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("Application Exited Successfully");
                        mainOption="no";
                        break;
                    }
                }
            }while(mainOption=="yes");
        }

        //Customer registration
        public static void CustomerRegistration()
        {
            System.Console.Write("Enter your Name: ");
            string name=Console.ReadLine();
            System.Console.Write("Enter your FatherName: ");
            string fatherName=Console.ReadLine();
            System.Console.Write("Enter Your Gender: ");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
            System.Console.Write("Enter your Mobile Number: ");
            string mobile=Console.ReadLine();
            System.Console.Write("Enter your Date Of Birth in (dd/MM/yyyy): ");
            DateTime dob=DateTime.Parse(Console.ReadLine());
            System.Console.Write("Enter your MailID: ");
            string mailID=Console.ReadLine();
            System.Console.Write("Enter Location: ");
            string location=Console.ReadLine();
            System.Console.Write("Enter your Wallet balance: ");
            double walletBalance=double.Parse(Console.ReadLine());

            CustomerDetails customers=new CustomerDetails(name,fatherName,gender,mobile,dob,mailID,location,walletBalance);
            customerList.Add(customers);

            System.Console.WriteLine("Customer registration successful Your Customer ID: "+customers.CustomerID);
        }

        //Customer registration ends

        //customer login
        public static void CustomerLogin()
        {
            //get customer id and validate
            System.Console.Write("Enter your Customer ID: ");
            string customerID=Console.ReadLine().ToUpper();
            bool flag=true;
            foreach(CustomerDetails customer in customerList)
            {
                if(customerID.Equals(customer.CustomerID))
                {
                    currentUser=customer;
                    flag=false;
                    SubMenu();
                    
                }
            }
            if(flag)
            {
                Console.WriteLine("Invalid UserID");
            }

        }
        //customer login ends

        //submenu
        public static void SubMenu()
        {
            System.Console.WriteLine("******SubMenu******");
            string subOption="";
            do{
                System.Console.WriteLine("1.Show Profile \n2.Order food \n3.Cancel order \n4.Modify order \n5.Order History \n6.Recharge Wallet \n7.Show Wallet Balance \n8.Exit");
                int subChoice=int.Parse(Console.ReadLine());
                switch(subChoice)
                {
                    case 1:
                    {
                        System.Console.WriteLine("*****Show Profile*****");
                        ShowProfile();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("******Order food*****");
                        OrderFood();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("*****cancel Order****");
                        CancelOrder();
                        break;
                    }
                    case 4:
                    {
                        System.Console.WriteLine("******Modify Order*****");
                        ModifyOrder();
                        break;
                    }
                    case 5:
                    {
                        System.Console.WriteLine("*******Order History*******");
                        OrderHistory();
                        break;
                    }
                    case 6:
                    {
                        System.Console.WriteLine("*****Recharge Wallet*******");
                        RechargeWallet();
                        break;
                    } 
                    case 7:
                    {
                        System.Console.WriteLine("******Show Wallet Balance**********");
                        ShowWalletBalance();
                        break;
                    }
                    case 8:
                    {
                        System.Console.WriteLine("Taking back to Main Menu");
                        subOption="no";
                        break;
                    }
                }
            }while(subOption=="yes");
        }
        //submenu ends

        //show profile
        public static void ShowProfile()
        {
            Console.WriteLine("|CustomerID|Name|FatherName|Gender|Mobile|DOB|MailID|Location|WalletBalance|");
            foreach(CustomerDetails customers in customerList)
            {
                if(currentUser.CustomerID.Equals(customers.CustomerID))
                {
                    System.Console.WriteLine($"|{customers.CustomerID}|{customers.Name}|{customers.FatherName}|{customers.Gender}|{customers.Mobile}|{customers.MailID}|{customers.Location}|{customers.WalletBalance}|");
                    
                }
            }
        }

        //show profile ends

        public static void OrderFood()
        {
            //create orderdetail object
            OrderDetails order1=new OrderDetails(currentUser.CustomerID,0,DateTime.Now,OrderStatus.Initiated);
            //create localItemList
            CustomList<ItemDetails> localItemList=new CustomList<ItemDetails>();
            //display the food details
            string orderAgain="";
            double totalAmount=0;
            do
            {
                Console.WriteLine("|FoodID|FoodName|PricePerQuantity|QuantityAvailable|");
            
            
                foreach (FoodDetails food in foodList)
                {
                    Console.WriteLine($"|{food.FoodID}|{food.FoodName}|{food.PricePerQuantity}|{food.QuantityAvailable}|");
                }
                //get food id and quantity
                System.Console.WriteLine("Enter the Food ID you want");
                string foodID = Console.ReadLine().ToUpper();
                System.Console.WriteLine("Enter quantity you need");
                int quantity = int.Parse(Console.ReadLine());
                //validate food id and quantity
                bool flag = true;

                foreach (FoodDetails food in foodList)
                {
                    if (foodID.Equals(food.FoodID))
                    {
                        flag = false;
                        if (food.QuantityAvailable >= quantity)
                        {
                            //create itemdetails object and store in local item list
                            ItemDetails item=new ItemDetails(order1.OrderID,foodID,quantity,food.PricePerQuantity*quantity);
                            localItemList.Add(item);
                            totalAmount += item.PriceOfOrder;
                            //ask the user to order again
                            System.Console.WriteLine("Do you wish to order again (Yes/No): ");
                            orderAgain = Console.ReadLine();
                            if(orderAgain=="no")
                            {
                                //ask to confirm purchase
                                System.Console.WriteLine("Do you want to confirm purchase(yes/no): ");
                                string confirmPurchase=Console.ReadLine().ToLower();
                                string recharge="";
                                if(confirmPurchase=="yes")
                                {
                                    do{
                                    if(currentUser.WalletBalance>=totalAmount)
                                    {
                                        order1.TotalPrice=totalAmount;
                                        order1.OrderStatus=OrderStatus.Ordered;
                                        currentUser.DeductBalance(totalAmount);
                                        food.QuantityAvailable-=quantity;
                                        //adding locallist to itemlist
                                        foreach(ItemDetails localItems in localItemList)
                                        {
                                            itemList.Add(localItems);
                                        }
                                        System.Console.WriteLine("Purchase Successful");
                                    }
                                    else{
                                        System.Console.WriteLine("You have Insufficient Balance");
                                        System.Console.WriteLine("Whether you wish to recharge (yes/no)");
                                        recharge=Console.ReadLine().ToLower();
                                        if(recharge=="no")
                                        {
                                            foreach (ItemDetails localItems in localItemList)
                                            {
                                                food.QuantityAvailable += localItems.PurchaseCount;
                                            }
                                        }
                                        else{
                                            RechargeWallet();
                                        }
                                    }
                                    }while(recharge=="yes");
                                }
                                else{
                                    foreach(ItemDetails localItems in localItemList)
                                    {
                                        food.QuantityAvailable+=localItems.PurchaseCount;
                                    }
                                }


                            }

                        }
                        else
                        {
                            System.Console.WriteLine("Food Quantity unavailable");
                        }
                        
                    }
                }
                if (flag)
                {
                    Console.WriteLine("Invalid Food ID");
                }
            } while (orderAgain == "yes");

        }
        public static void CancelOrder()
        {
            //diplay the order details
            System.Console.WriteLine("|OrderID|CustomerID|TotalPrice|DateOfOrder|OrderStatus|");
            foreach(OrderDetails orders in orderList)
            {
                if(currentUser.CustomerID.Equals(orders.CustomerID) && orders.OrderStatus.Equals(OrderStatus.Ordered))
                {
                    System.Console.WriteLine($"|{orders.OrderID}|{orders.CustomerID}|{orders.TotalPrice}|{orders.DateOfOrder}|{orders.OrderStatus}|");
                }
            }
            System.Console.WriteLine("Enter the order Id that you want to cancel: ");
            string orderID=Console.ReadLine().ToUpper();
            bool flag1=true;
            foreach(ItemDetails items in itemList)
            {
                if(orderID.Equals(items.OrderID) )
                {
                    flag1=false;
                    Console.WriteLine($"|{items.ItemID}|{items.OrderID}|{items.FoodID}|{items.PurchaseCount}|{items.PriceOfOrder}");
                }
            }
            if(flag1)
            {
                System.Console.WriteLine("Invalid Order ID");
            }
            
            bool flag=true;
            foreach(ItemDetails item in itemList)
            {
                if(orderID.Equals(item.OrderID))
                {
                    //refund to the balance
                    currentUser.WalletRecharge(item.PriceOfOrder);
                    foreach(FoodDetails food in foodList)
                    {
                        //updating food count
                        if(item.FoodID.Equals(food.FoodID))
                        {
                            food.QuantityAvailable+=item.PurchaseCount;
                            foreach(OrderDetails order in orderList)
                            {
                                if (item.OrderID.Equals(order.OrderID))
                                {
                                    flag=false;
                                    order.OrderStatus = OrderStatus.Cancelled;
                                    
                                }
                            }
                            
                        }
                        
                    }
                }
                
            }
            if(!flag)
            {
                System.Console.WriteLine("Cancelled Successfully");
            }



        }
        public static void ModifyOrder()
        {
            //order details of current user
            foreach(OrderDetails orders in orderList)
            {
                if(currentUser.CustomerID.Equals(orders.CustomerID) && orders.OrderStatus.Equals(OrderStatus.Ordered))
                {
                    Console.WriteLine($"|{orders.OrderID}|{orders.CustomerID}|{orders.TotalPrice}|{orders.DateOfOrder}|{orders.OrderStatus}|");
                }
            }
            //ask the orderid
            System.Console.WriteLine("Enter the orderid to modify");;
            string orderID=Console.ReadLine().ToUpper();
            double total=0;
            double newPrice=0;
            //validate orderid
            foreach(OrderDetails order in orderList)
            {
                if(orderID.Equals(order.OrderID) &&currentUser.CustomerID.Equals(order.CustomerID) && order.OrderStatus.Equals(OrderStatus.Ordered))
                {
                    foreach(ItemDetails items in itemList)
                    {
                        if (orderID.Equals(items.OrderID) )
                        {
                            Console.WriteLine($"|{items.ItemID}|{items.OrderID}|{items.FoodID}|{items.PurchaseCount}|{items.PriceOfOrder}");
                        }

                    }
                    Console.WriteLine("enter itemID");
                    string itemID=Console.ReadLine().ToUpper();
                    string recharge="";
                    foreach(ItemDetails item in itemList)
                    {
                        if(itemID.Equals(item.ItemID))
                        {
                            System.Console.WriteLine("Enter new quantity");
                            int quantity=int.Parse(Console.ReadLine());
                            
                            foreach(FoodDetails food in foodList)
                            {
                                if(item.FoodID.Equals(food.FoodID))
                                {
                                    newPrice=food.PricePerQuantity*quantity;
                                    item.PriceOfOrder=newPrice;
                                }
                            }
                            if(item.PurchaseCount<quantity)
                            {
                                do{
                                    if (currentUser.WalletBalance > item.PriceOfOrder)
                                    {
                                        currentUser.DeductBalance(item.PriceOfOrder);
                                        item.PurchaseCount=quantity;
                                        System.Console.WriteLine($"Order successfully Modified for {order.OrderID} ");
                                    }
                                    else
                                    {
                                        System.Console.WriteLine("Recharge with " + item.PriceOfOrder);

                                        currentUser.WalletRecharge(item.PriceOfOrder);
                                        recharge = "done";

                                    }
                                } while(recharge=="done");
                            }
                            else{
                                int newQuantity=item.PurchaseCount-quantity;
                                double returnPrice=item.PriceOfOrder*newQuantity;
                                currentUser.WalletRecharge(returnPrice);
                                item.PurchaseCount=quantity;

                            }
                            
                            foreach(ItemDetails item1 in itemList)
                            {
                                if(orderID.Equals(item1.OrderID))
                                {
                                total+=item1.PriceOfOrder;
                                order.TotalPrice=total;
                                }
                            }
                           
                        }
                    }
                    
                }
            }
        }
        public static void OrderHistory()
        {
            //display the ordder history of current user
            System.Console.WriteLine("|OrderID|CustomerID|TotalPrice|DateOfOrder|OrderStatus|");
            foreach(OrderDetails orders in orderList)
            {
                if(currentUser.CustomerID.Equals(orders.CustomerID))
                {
                    System.Console.WriteLine($"|{orders.OrderID}|{orders.CustomerID}|{orders.TotalPrice}|{orders.DateOfOrder}|{orders.OrderStatus}|");
                }
            }
        }
        public static void RechargeWallet()
        {
            System.Console.WriteLine("Enter the amount to be Recharged: ");
            double amount=double.Parse(Console.ReadLine());
            Console.WriteLine("Your Updated Balance is: "+currentUser.WalletRecharge(amount));
        }
        public static void ShowWalletBalance()
        {
            Console.WriteLine("Your balance is : "+currentUser.WalletBalance);
        }
    



        //adding default data
        public static void AddDefaultData()
        {
            CustomerDetails customer1=new CustomerDetails("Ravi","Ettapparajan",Gender.Male,"974774646",new DateTime(1999,11,11),"ravi@gmail.com","Chennai",10000);
            CustomerDetails customer2=new CustomerDetails("Baskaran","Sethurajan",Gender.Male,"847575775",new DateTime(1999,11,11),"baskaran@gmail.com","Chennai",15000);
            customerList.Add(customer1);
            customerList.Add(customer2);

            OrderDetails order1=new OrderDetails("CID1001",580,new DateTime(2022,11,26),OrderStatus.Ordered);
            OrderDetails order2=new OrderDetails("CID1002",870,new DateTime(2022,11,26),OrderStatus.Ordered);
            OrderDetails order3=new OrderDetails("CID1001",820,new DateTime(2022,11,26),OrderStatus.Cancelled);
            orderList.Add(order1);
            orderList.Add(order2);
            orderList.Add(order3);


            FoodDetails food1=new FoodDetails("Chicken Briyani 1Kg",100,12);
            FoodDetails food2=new FoodDetails("Mutton Briyani 1Kg",150,10);
            FoodDetails food3=new FoodDetails("Veg Full Meals",80,30);
            FoodDetails food4=new FoodDetails("Noodles",100,40);
            FoodDetails food5=new FoodDetails("Dosa",40,40);
            FoodDetails food6=new FoodDetails("Idly (2 pieces)",20,50);
            FoodDetails food7=new FoodDetails("Pongal",40,20);
            FoodDetails food8=new FoodDetails("Vegetable Briyani",80,15);
            FoodDetails food9=new FoodDetails("Lemon Rice",50,30);
            FoodDetails food10=new FoodDetails("Veg Pulav",120,30);
            FoodDetails food11=new FoodDetails("Chicken 65 (200 Grams)",75,30);
            foodList.Add(food1);
            foodList.Add(food2);
            foodList.Add(food3);
            foodList.Add(food4);
            foodList.Add(food5);
            foodList.Add(food6);
            foodList.Add(food7);
            foodList.Add(food8);
            foodList.Add(food9);
            foodList.Add(food10);
            foodList.Add(food11);

            ItemDetails item1=new ItemDetails("OID3001","FID2001",2,200);
            ItemDetails item2=new ItemDetails("OID3001","FID2002",2,300);
            ItemDetails item3=new ItemDetails("OID3001","FID2003",1,80);
            ItemDetails item4=new ItemDetails("OID3002","FID2001",1,100);
            ItemDetails item5=new ItemDetails("OID3002","FID2002",4,600);
            ItemDetails item6=new ItemDetails("OID3002","FID2010",1,120);
            ItemDetails item7=new ItemDetails("OID3002","FID2009",1,50);
            ItemDetails item8=new ItemDetails("OID3003","FID2002",2,300);
            ItemDetails item9=new ItemDetails("OID3003","FID2008",4,320);
            ItemDetails item10=new ItemDetails("OID3003","FID2001",2,200);
            itemList.Add(item1);
            itemList.Add(item2);
            itemList.Add(item3);
            itemList.Add(item4);
            itemList.Add(item5);
            itemList.Add(item6);
            itemList.Add(item7);
            itemList.Add(item8);
            itemList.Add(item9);
            itemList.Add(item10);

        }
        //adding default data ends
    }
}