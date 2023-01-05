using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Среднее
{
    class СписокInt
    {
        private int?[] масив= new int?[2];  
        
        public int?[] Массив { get => масив; set => масив = value; }
        public int Количество { get; private set; }
        public СписокInt()
        {

        }
        public void Добавить(int value)
        {
            if(Количество+1> масив.Length)
            {
                int?[] новыеЧисла = new int?[масив.Length * 2];
                for (int r = 0; r < масив.Length; r++)
                {
                    новыеЧисла[r] = масив[r];
                }
                масив = новыеЧисла;
            }
            масив[Количество] = value;
            Количество++;
        }

        public int Сумма()
        {
            int Сумма = 0;
            for (int i = 0; i < Количество; i++)
            {
                int? Знач = масив[i];
                if (Знач.HasValue)
                {
                    Сумма = Сумма + Знач.Value;
                }
            }

            return Сумма;
        }

        public double Среднее()
        {
            double среднее = Сумма() / Количество;
            return среднее;
        }


        public int Максимум()
        {

            int максимум = int.MinValue;
            for (int i = 0; i < Количество; i++)
            {
                int? значение = масив[i];
                if (значение.HasValue && максимум < значение)
                {
                    максимум = значение.Value;
                }
            }
            return максимум;
        }

        public int Минимум()
        {
            int минимум = int.MaxValue;
            for (int i = 0; i < Количество; i++)
            {
                int? значение = масив[i];
                if(значение.HasValue && минимум > значение)
                {
                    минимум = значение.Value;
                }  
                
            }
            return минимум;
        }
        public int[] ПолучитьМассив()
        {
            int[] копия = new int[Количество];
            for(int i = 0; i < Количество; i++)
            {
                int? значение = масив[i];
                if(значение.HasValue)
                {
                    копия[i] = значение.Value;
                }    
            }
            return копия;
        }




        public void Реверс()
        {
            int?[] реверс = new int?[масив.Length];
            int[] БЕЗNULL = ПолучитьМассив();
            for(int i = БЕЗNULL.Length-1, j=0; i>= 0 && j< реверс.Length;  i--, j++)
            {
                реверс[i] = масив[j];
            }
            масив = реверс;
        }

        public static void Test(Double[] value)
        {
            int[] Незнаю = new int[5];


        }

       
       
    }
}
