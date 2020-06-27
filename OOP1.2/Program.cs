using System;

namespace OOP1._2
{
    class Program
    {
        class abonent
        {
            internal int ID;
            public string FAMILIA;
            public string IM9;
            public string OT4ESTVO;
            internal string ADRES;*-
        }
        static void Main(string[] args)
        {
            {
                abonent clas = new abonent();
                Console.Write("Введите 'ID' абонента: ");
                clas.ID = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите фамилию абонента: ");
                clas.FAMILIA = Convert.ToString(Console.ReadLine());

                Console.Write("Введите имя абонента: ");
                clas.IM9 = Convert.ToString(Console.ReadLine());

                Console.Write("Введите отчество абонента: ");
                clas.OT4ESTVO = Convert.ToString(Console.ReadLine());

                Console.Write("Введите адрес абонента: ");
                clas.ADRES = Convert.ToString(Console.ReadLine());


                Console.WriteLine("__________________________");
                Console.WriteLine(clas.ID + " " + clas.FAMILIA + " " + clas.IM9 + " " + clas.OT4ESTVO + " " + clas.ADRES + " ");
                Console.ReadLine();
            }
        }
    }
}
