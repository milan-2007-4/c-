using System;
using System.IO;
using System.Diagnostics;

class RestaurantBill_withpdf
{
    static void Main(string[] args)
    {
        Console.BackgroundColor = ConsoleColor.Black;
        Console.Clear();
        // Arrays to store order details

        int choice, qty;
        double price = 0, subTotal = 0;
        char more = 'n';

        string[] itemName = new string[50];
        int[] itemQty = new int[50];
        double[] itemTotal = new double[50];
        int index = 0;

        // ===== HEADER =====
        Console.ForegroundColor=ConsoleColor.Green;
        Console.WriteLine("========================================");
		Console.ForegroundColor=ConsoleColor.Yellow;
        Console.WriteLine("        KHODIYAR RESTAURANT");
		Console.ForegroundColor=ConsoleColor.Green;
        Console.WriteLine("========================================");
        do
        {
            // ===== MENU =====
             Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nMenu Card:");
            Console.WriteLine("1. Pizza                 - Rs. 180");
            Console.WriteLine("2. Dabeli                - Rs. 50");
            Console.WriteLine("3. Paneer Nan (Unlimited)- Rs. 130");
            Console.WriteLine("4. Plain Dosa            - Rs. 20");
            Console.WriteLine("5. Soft Drink            - Rs. 40");
            Console.ResetColor();

            // ===== INPUT =====
            Console.Write("\nEnter your choice (1-5): ");
            choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter quantity: ");
            qty = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Magenta;

            switch (choice)
            {
                case 1:
                    itemName[index] = "Pizza";
                    price = 180;
                    break;
                case 2:
                    itemName[index] = "Dabeli";
                    price = 50;
                    break;
                case 3:
                    itemName[index] = "Paneer Nan (Unlimited)";
                    price = 130;
                    break;
                case 4:
                    itemName[index] = "Plain Dosa";
                    price = 20;
                    break;
                case 5:
                    itemName[index] = "Soft Drink";
                    price = 40;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid Choice!");
                    Console.ResetColor();
                    continue;
            }

            itemQty[index] = qty;
            itemTotal[index] = price * qty;
            subTotal += itemTotal[index];
            index++;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\nDo you want to order more items? (y/n): ");
            more = Convert.ToChar(Console.ReadLine());

          } 
		while (more == 'y' || more == 'Y');

        double cgst = subTotal * 0.025;
        double sgst = subTotal * 0.025;
        double grandTotal = subTotal + cgst + sgst;

        // ===== BILL SUMMARY ON SCREEN =====
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n========================================");
        Console.WriteLine("Grand Total : Rs. " + grandTotal);
        Console.WriteLine("========================================");
        Console.ResetColor();

        // ===== SAVE BILL AS TEXT FILE =====
        string filePath = "Bill_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt";

        using (StreamWriter sw = new StreamWriter(filePath))
        {
            sw.WriteLine("========================================");
            sw.WriteLine("        KHODIYAR RESTAURANT");
            sw.WriteLine("========================================");
            sw.WriteLine("Date: " + DateTime.Now);
            sw.WriteLine("----------------------------------------");

         for (int i = 0; i < index; i++)
        {
            Console.WriteLine(
                itemName[i].PadRight(20) + " " +
                itemQty[i].ToString().PadRight(7) +
                itemTotal[i]
            );
        }

            sw.WriteLine("----------------------------------------");
            sw.WriteLine("Sub Total : Rs. " + subTotal);
            sw.WriteLine("CGST 2.5% : Rs. " + cgst);
            sw.WriteLine("SGST 2.5% : Rs. " + sgst);
            sw.WriteLine("----------------------------------------");
            sw.WriteLine("Grand Total : Rs. " + grandTotal);
            sw.WriteLine("========================================");
            sw.WriteLine("THANK YOU! VISIT AGAIN");
        }

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\nBill saved successfully!");
        Console.WriteLine("File Name: " + filePath);
        Console.ResetColor();

        // Open automatically
        Process.Start("notepad.exe", filePath);

        Console.ReadKey();
    }
}
