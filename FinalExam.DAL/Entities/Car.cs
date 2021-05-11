using System;
using System.Collections.Generic;
using System.Text;

namespace FinalExam.DAL.Entities
{
    public class Car
    {
        public int CarId { get; set; } // id машины
        public string CarName { get; set; } // название машины
        public string Description { get; set; } // описание машины
        public string Marka { get; set; } // марка машины
        public string Image { get; set; } // имя файла изображения
    }
}
