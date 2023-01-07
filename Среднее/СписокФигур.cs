using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Среднее
{
    class СписокФигура
    {
        public Фигура this[int index]
        {
            get
            {
                Фигура? знач = масив[index];
                if (знач is not null)
                    return знач;
                else
                    throw new Exception("Значений с этом индексом нету");
            }
            set
            {
                if (index < Количество)
                {
                    масив[index] = value;
                }
                else
                    throw new Exception("Значений с этом индексом нету");
            }
        }



        private Фигура?[] масив= new Фигура?[2];  
        
        public Фигура?[] Массив { get => масив; set => масив = value; }
        public int Количество { get; private set; }

        public int Инциализация { get; init ; }
        public СписокФигура()
        {

        }
        public void Добавить(Фигура value)
        {
            if(Количество+1> масив.Length)
            {
                Фигура?[] новыеЧисла = new Фигура?[масив.Length * 2];
                for (int r = 0; r < масив.Length; r++)
                {
                    новыеЧисла[r] = масив[r];
                }
                масив = новыеЧисла;
            }
            масив[Количество] = value;
            Количество++;
        }

       /* public int Сумма()
        {
            int Сумма = 0;
            for (int i = 0; i < Количество; i++)
            {
                Фигура? Знач = масив[i];
                if (Знач is not null)
                {
                    Сумма = Сумма + Знач;
                }
            }

            return Сумма;
        }*/

       /* public double Среднее()
        {
            double среднее = Сумма() / Количество;
            return среднее;
        }*/


      /*  public int Максимум()
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
        }*/

       /* public int Минимум()
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
        }*/
        public Фигура[] ПолучитьМассив()
        {
            Фигура[] копия = new Фигура[Количество];
            for(int i = 0; i < Количество; i++)
            {
                Фигура? значение = масив[i];
                if(значение is not null)
                {
                    копия[i] = значение;
                }    
            }
            return копия;
        }










    }
}
