//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ПП
{
    using System;
    using System.Collections.Generic;
    
    public partial class Обучающиеся
    {
        public int id { get; set; }
        public Nullable<int> Срок_обучения { get; set; }
        public string Фамилия { get; set; }
        public string Имя { get; set; }
        public string Отчество { get; set; }
        public Nullable<System.DateTime> Дата_рождения { get; set; }
        public Nullable<int> Пол { get; set; }
        public Nullable<int> СНИЛС { get; set; }
        public string Форма_обучения { get; set; }
        public Nullable<int> Финансирования { get; set; }
        public Nullable<int> Форма_образования { get; set; }
    
        public virtual Пол Пол1 { get; set; }
        public virtual Финансирования Финансирования1 { get; set; }
        public virtual Форма_обучения Форма_обучения1 { get; set; }
        public virtual Форма_получения_образования__на_момент_прекращения_образ_отношений Форма_получения_образования__на_момент_прекращения_образ_отношений { get; set; }
    }
}
