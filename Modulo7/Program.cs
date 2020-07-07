using Microsoft.VisualBasic;
using System;
using System.Globalization;
using System.Linq.Expressions;

namespace Modulo7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inferência de tipo com var
            var Hello = "Hello Wordl!";
            var C1 = 'A';
            var N1 = 1;
            var D1 = 20.5;
            var F1 = 1.1f;

            Console.WriteLine(Hello);
            Console.WriteLine(C1);
            Console.WriteLine(N1);
            Console.WriteLine(D1);
            Console.WriteLine(F1);

            //Condicional Switch Case
            Console.Write("Digite (1 - Continua / 2- Para): ");
            int N2 = 2;//int.Parse(Console.ReadLine());

            switch (N2)
            {
                case 1:
                    Console.WriteLine("Ele deseja prosseguir!");
                    break;
                case 2:
                    Console.WriteLine("Ele deseja parar!");
                    break;
                default:
                    Console.WriteLine("Valor inválido!");
                    break;
            }

            //Expressão Condicional Ternária
            string TipoValor = (N2 > 0) ? "Número Positivo" : "Número Zero ou Negativo";
            Console.WriteLine(TipoValor);

            //Funções Interessantes Para Strings
            string Original = "abcde FGHIJ ABC abc DEFG    ";
            string S1 = Original.ToUpper();
            string S2 = Original.ToLower();
            string S3 = Original.Trim();
            int N3 = Original.IndexOf("bc");
            int N4 = Original.LastIndexOf("bc");
            string S4 = Original.Substring(5);
            string S5 = Original.Substring(5, 11);
            string S6 = Original.Replace('a', 'z');
            string S7 = Original.Replace("abc", "zxy");
            bool B1 = string.IsNullOrEmpty(Original);
            bool B2 = string.IsNullOrWhiteSpace(Original);

            Console.WriteLine("Original -" + Original + "-");
            Console.WriteLine("ToUpper -" + S1 + "-");
            Console.WriteLine("ToLower -" + S2 + "-");
            Console.WriteLine("Trim -" + S3 + "-");
            Console.WriteLine("IndexOf(bc) -" + N3 + "-");
            Console.WriteLine("LastIndexOf(bc) -" + N4 + "-");
            Console.WriteLine("Substring(5) -" + S4 + "-");
            Console.WriteLine("Substring(5, 11) -" + S5 + "-");
            Console.WriteLine("Replace('a', 'z') -" + S6 + "-");
            Console.WriteLine("Replace(abc, zxy) -" + S7 + "-");
            Console.WriteLine("IsNullOrEmpty -" + B1 + "-");
            Console.WriteLine("IsNullOrWhiteSpace -" + B2 + "-");
            Console.WriteLine("Split -" + Original.Split(" ") + "-");

            //Date Time
            DateTime D2 = DateTime.Now;
            DateTime D3 = new DateTime(2020, 08, 06);
            DateTime D4 = new DateTime(2020, 08, 06, 22, 30, 22);
            DateTime D5 = new DateTime(2020, 08, 06, 22, 33, 10, 500);
            DateTime D6 = DateTime.Today;
            DateTime D7 = DateTime.UtcNow;
            DateTime D8 = DateTime.Parse("2020-07-06 12:12:10");
            DateTime D9 = DateTime.Parse("2020-07-06");
            DateTime D10 = DateTime.Parse("07/07/2020 22:30");
            DateTime D11 = DateTime.ParseExact("06-07-2020", "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime D12 = DateTime.ParseExact("06/07/2020 22:50:05", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            Console.WriteLine(D2);
            Console.WriteLine(D3);
            Console.WriteLine(D4);
            Console.WriteLine(D5);
            Console.WriteLine(D6);
            Console.WriteLine(D7);
            Console.WriteLine(D8);
            Console.WriteLine(D9);
            Console.WriteLine(D10);
            Console.WriteLine(D11);
            Console.WriteLine(D12);

            //Time Span
            TimeSpan T1 = new TimeSpan(0, 1, 30);
            TimeSpan T2 = new TimeSpan();
            TimeSpan T3 = new TimeSpan(900000000L);
            TimeSpan T4 = new TimeSpan(2, 11, 21);
            TimeSpan T5 = new TimeSpan(5, 2, 11, 21);
            TimeSpan T6 = new TimeSpan(5, 2, 11, 21, 321);
            TimeSpan T7 = TimeSpan.FromDays(1.5);
            TimeSpan T8 = TimeSpan.FromHours(6.5);
            TimeSpan T9 = TimeSpan.FromMinutes(2.5);
            TimeSpan T10 = TimeSpan.FromSeconds(2.5);
            TimeSpan T11 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan T12 = TimeSpan.FromTicks(900000000L);

            Console.WriteLine(T1);
            Console.WriteLine(T2);
            Console.WriteLine(T3);
            Console.WriteLine(T4);
            Console.WriteLine(T5);
            Console.WriteLine(T6);
            Console.WriteLine(T7);
            Console.WriteLine(T8);
            Console.WriteLine(T9);
            Console.WriteLine(T10);
            Console.WriteLine(T11);
            Console.WriteLine(T12);

            //Propriedade e Operações com DateTime
            DateTime D13 = DateTime.Parse("2020-07-06 12:12:10");
            Console.WriteLine("1) Date: " + D13.Date);
            Console.WriteLine("2) Day: " + D13.Day);
            Console.WriteLine("3) DayOfWeek: " + D13.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + D13.DayOfYear);
            Console.WriteLine("5) Hour: " + D13.Hour);
            Console.WriteLine("6) Kind: " + D13.Kind);
            Console.WriteLine("7) Millisecond: " + D13.Millisecond);
            Console.WriteLine("8) Minute: " + D13.Minute);
            Console.WriteLine("9) Month: " + D13.Month);
            Console.WriteLine("10) Second: " + D13.Second);
            Console.WriteLine("11) Ticks: " + D13.Ticks);
            Console.WriteLine("12) TimeOfDay: " + D13.TimeOfDay);
            Console.WriteLine("13) Year: " + D13.Year);
            Console.WriteLine(D13.ToLocalTime());
            Console.WriteLine(D13.ToLongDateString());

            //Date Time Kind
            DateTime Data1 = new DateTime(2020, 07, 06, 23, 37, 00, DateTimeKind.Local);
            DateTime Data2 = new DateTime(2020, 07, 06, 23, 37, 00, DateTimeKind.Utc);
            DateTime Data3 = new DateTime(2020, 07, 06, 23, 37, 00);

            Console.WriteLine("Data1 - " + Data1);
            Console.WriteLine("Data1 Kind - " + Data1.Kind);
            Console.WriteLine("Data1 LocalTime - " + Data1.ToLocalTime());
            Console.WriteLine("Data1 UniversalTime - " + Data1.ToUniversalTime());
            Console.WriteLine(Data2);
            Console.WriteLine("Data2 Kind - " + Data2.Kind);
            Console.WriteLine("Data2 LocalTime - " + Data2.ToLocalTime());
            Console.WriteLine("Data2 UniversalTime - " + Data2.ToUniversalTime());
            Console.WriteLine(Data3);
            Console.WriteLine("Data3 Kind - " + Data3.Kind);
            Console.WriteLine("Data3 LocalTime - " + Data3.ToLocalTime());
            Console.WriteLine("Data3 UniversalTime - " + Data3.ToUniversalTime());
        }
    }
}
