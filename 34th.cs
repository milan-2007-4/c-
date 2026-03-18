using System;
class making
{
    private int[] arrey = new int[5];
    public int this[int index]
    {
        set
        {
            if (value >= 0)
                arrey[index] = value;
            else
                Console.WriteLine("Invalid");
        }
        get
        {
            return arrey[index];
        }
    }
    public void print()
    {
        for (int i = 0; i < arrey.Length; i++)
            Console.WriteLine(arrey[i]);
    }
}
class priva_arrey
{
    static void Main()
    {
        making m = new making();
        for (int i = 0; i < 5; i++)
        {
            int v = Convert.ToInt32(Console.ReadLine());
            m[i] = v;
        }
        m.print();
    }
}
