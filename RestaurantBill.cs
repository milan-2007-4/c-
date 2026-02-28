using System;

class RestaurantBill
{
    static void Main(string[] args)
    {
        int choice, qty;
        double price = 0, subTotal = 0;
        char more='n';

        // Arrays to store order details
        string[] itemName = new string[50];
        int[] itemQty = new int[50];
        double[] itemTotal = new double[50];
        int index = 0;
        Console.ForegroundColor=ConsoleColor.Green;
        Console.WriteLine("========================================");
		Console.ForegroundColor=ConsoleColor.Yellow;
        Console.WriteLine("        KHODIYAR RESTAURANT");
		Console.ForegroundColor=ConsoleColor.Green;
        Console.WriteLine("========================================");
	
        do
        {   Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("\nMenu Card:");
            Console.WriteLine("1. pizza   				- Rs. 180");
            Console.WriteLine("2. dabeli  				- Rs. 50");
            Console.WriteLine("3. paneer nan(unlimited) - Rs. 30");
            Console.WriteLine("4. plane Dosa            - Rs. 20");
            Console.WriteLine("5. soft drink             - Rs. 40");

            Console.Write("\nEnter your choice (1-5): ");
            choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter quantity: ");
            qty = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Magenta;
            switch (choice)
            {   

                case 1:
                    itemName[index] = "pizza";  
                    price = 180;
                    break;
                case 2:
                    itemName[index] = "dabeli";
                    price = 50;
                    break;
                case 3:
                    itemName[index] = "paneer na(unlimited)";
                    price = 130;
                    break;
                case 4:
                    itemName[index] = "plane Dosa";
                    price = 20;
                    break;
                case 5:
                    itemName[index] = "soft drink";
                    price = 40;
                    break;
                default:
                    Console.WriteLine("Invalid Choice!");
                    price = 0;
                    continue;
            }

            itemQty[index] = qty;
            itemTotal[index] = price * qty;
            subTotal += itemTotal[index];
            index++;
        Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Do you want to order more items? (y/n): ");
            more = Convert.ToChar(Console.ReadLine());

        } while (more=='y'||more=='Y');

        double cgst = subTotal * 0.025;
        double sgst = subTotal * 0.025;
        double grandTotal = subTotal + cgst + sgst;

        // ===== BILL PRINT =====
		        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n========================================");
        Console.WriteLine("Item Name            Qty     Amount");
		sw.WriteLine("Date: " + DateTime.Now);
        Console.WriteLine("----------------------------------------");

        for (int i = 0; i < index; i++)
        {
            Console.WriteLine(
                itemName[i].PadRight(20) + " " +
                itemQty[i].ToString().PadRight(7) +
                itemTotal[i]
            );
        }

        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Sub Total : Rs. " + subTotal);
        Console.WriteLine("CGST 2.5% : Rs. " + cgst);
        Console.WriteLine("SGST 2.5% : Rs. " + sgst);
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Grand Total : Rs. " + grandTotal);
        Console.WriteLine("========================================"
		);

        Console.WriteLine("\n        THANK YOU FOR ORDER");
        Console.WriteLine("        VISIT AGAIN ");

        Console.ReadKey();
    }
}
