namespace for_loop;
class Program
{
    static void Main(string[] args)
    {
        //klavyeden girilen sayıya kadar olan tek sayılar
        Console.Write("Bir sayı giriniz");
        int sayac= int.Parse(Console.ReadLine());
        for (int i = 1; i < sayac; i++)
        {
            if(i%2 == 1){
                Console.WriteLine(i);
            }
        }
        //1 ile 1000 arasındaki tek ve çift sayıların toplamları
        int tektoplam=0,cifttoplam= 0;
        for (int i = 1; i <= 1000; i++)
        {
            if (i%2==1)
            {
                tektoplam +=i;
            }
            else{
                cifttoplam+=i;
            }
            
        }
        Console.WriteLine("Tek toplam: "+ tektoplam);
        Console.WriteLine("Çift toplam: "+ cifttoplam);

        //Break,Continue
        for (int i = 0; i < 10; i++)
        {
            if (i==4)
            {
                break;
            }
            Console.WriteLine(i);
        }

           for (int i = 0; i < 10; i++)
        {
            if (i==4)
            {
                continue;
            }
            Console.WriteLine(i);
        }
    }
}
