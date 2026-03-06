namespace Italautomata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ForroItal f1 = new ForroItal("forrócsoki", 200, 1);
            Tea t1 = new Tea("zöld tea",100,2,true);
            Tea t2 = new Tea("barackos tea",190,4,false);
            Kave k1 = new Kave("eszpresszó", 300, 2, "tej nélkül");
			Kave k2 = new Kave("hossszú kávé", 250, 3, "mandula tejjel");
			Kave k3 = new Kave("ristretto", 120, 1, "sok tejjel");
			Console.WriteLine(f1);
			Console.WriteLine(t1);
			Console.WriteLine(t2);
            Console.WriteLine(k1);
			Console.WriteLine(k2);
            Console.WriteLine(k3);

			Console.WriteLine("\n--- 50FT Áremelés után ---");
            f1.Aremeles(50);
			t1.Aremeles(50);
            t2.Aremeles(50);
            k1.Aremeles(50);
			k2.Aremeles(50);
			k3.Aremeles(50);
			Console.WriteLine(f1);
			Console.WriteLine(t1);
			Console.WriteLine(t2);
			Console.WriteLine(k1);
			Console.WriteLine(k2);
			Console.WriteLine(k3);

			Console.WriteLine("\n--- Áremelés után ---");
			f1.Aremeles();
			t1.Aremeles();
			t2.Aremeles();
			k1.Aremeles();
			k2.Aremeles();
			k3.Aremeles();
			Console.WriteLine(f1);
			Console.WriteLine(t1);
			Console.WriteLine(t2);
			Console.WriteLine(k1);
			Console.WriteLine(k2);
			Console.WriteLine(k3);
			Console.WriteLine();

			Capuccino c1 = new Capuccino("mogyorós capuccino", 350, 4, "sok tejjel",true);
			Console.WriteLine(c1);
		}
	}
}
