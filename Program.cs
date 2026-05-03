namespace ders_bir
{
    internal class Program
    {
        static void Main(string[] args)
        {    //melim bu 3 du 
             //int[] ededler = { 15, 3, 9, 21, 5, 1, 30 };

            //int min = ededler[0];
            //int max = ededler[0];

            //for (int i = 1; i < ededler.Length; i++)
            //{
            //if (ededler[i] < min)
            //{
            //min = ededler[i];
            //}

            //if (ededler[i] > max)
            //{
            //max = ededler[i];
            //}
            //}

            //int cem = min + max;

            //Console.WriteLine("En kicik " + min);
            //Console.WriteLine("En boyuk " + max);
            //Console.WriteLine("Cemi " + cem);




            //buda 1
            //int eded = 7481;
            //int enBoyuk = 0;

            //while (eded > 0)
            //{
            //int qaliq = eded % 10;

            //if (qaliq > enBoyuk)
            //{
            //enBoyuk = qaliq;
            //}

            //eded = eded / 10;
            //}

            // Console.WriteLine("En boyuk reqem: " + enBoyuk);



            //buda iki 
            //int n = 8;
            //     bool quvvetidir = true;

            //    if (n <= 0) quvvetidir = false;

            //     while (n > 1)
            //  {
            //      if (n % 2 != 0)
            //      {
            //         quvvetidir = false;
            //          break;
            //      }
            //       n = n / 2;
            //   }

            //  if (quvvetidir) Console.WriteLine("2-nin quvvetidir");
            //   else Console.WriteLine("2-nin quvveti deyil");



            //Buffer mellim 4du 
            // int[] massiv = { 3, 6, 9, 12, 15, 20 };
            //     int say = 0;
            //      for (int i = 0; i < massiv.Length; i++)
            //      {
            //       if (massiv[i] % 2 != 0 && massiv[i] % 3 == 0)
            ///         {
            //            say++;
            //         }
            //  }


            //  Console.WriteLine("Hem tek, hem de 3-e bolunenlerin sayi: " + say);


            //5ci 
            int[] massiv = { 5, 9, 12, 11 };
            int murekkebSay = 0;

            for (int i = 0; i < massiv.Length; i++)
            {
                int eded = massiv[i];

                if (eded > 1)
                {
                    bool boluneniVar = false;

                    for (int j = 2; j < eded; j++)
                    {
                        if (eded % j == 0)
                        {
                            boluneniVar = true;
                            break; 
                        }
                    }

                    if (boluneniVar == true)
                    {
                        murekkebSay++;
                    }
                }
            }

            Console.WriteLine("Murekkeb ededlerin sayi: " + murekkebSay);


        }

    
    }
}
