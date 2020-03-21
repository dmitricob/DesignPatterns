﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_SingleResponsibility
{
    //include 4 responsibilitis : enter validate create save data
    class Phone
    {
        public string Model { get; set; }
        public int Price { get; set; }
    }

    class MobileStore
    {
        List<Phone> phones = new List<Phone>();
        public void Process()
        {
            Console.WriteLine("Введите модель:");
            string model = Console.ReadLine();
            Console.WriteLine("Введите цену:");
            int price = 0;
            bool result = Int32.TryParse(Console.ReadLine(), out price);

            if (result == false || price <= 0 || String.IsNullOrEmpty(model))
            {
                throw new Exception("Некорректно введены данные");
            }
            else
            {
                phones.Add(new Phone { Model = model, Price = price });
                // сохраняем данные в файл
                using (System.IO.StreamWriter writer = new System.IO.StreamWriter("store.txt", true))
                {
                    writer.WriteLine(model);
                    writer.WriteLine(price);
                }
                Console.WriteLine("Данные успешно обработаны");
            }
        }
    }
}
