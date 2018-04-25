using System;
using System.Collections.Generic;


namespace ЗаписьНаПрием
{
   class Program
    {
        static void Main(string[] args)
        {
            /////////////
        }

    }
    
    /// <summary>
    /// Запись на прием к стоматологу 
    /// </summary>
    public class AppointmentToTheDentist 
    {
        /// <summary>
        /// Дата и время заполнения
        /// </summary>
        public DateTime FilledTime { get; set; }
        /// <summary>
        /// Информация о человеке
        /// </summary>
        public PersonalData Person { get; set; }
        /// <summary>
        /// Дата и время приема у врача
        /// </summary>
        public AdmissionDate  Admission { get; set; } 
        /// <summary>
        ///Выбор услуги 
        /// </summary>
        public Service Service { get; set; }    
    }
    public class AdmissionDate
    {
        /// <summary>
        /// Время приема
        /// </summary>
        public DateTime Admission { get; set; }
    }
    /// <summary>
    /// Персональные данные
    /// </summary>
    public class PersonalData
    {
       
        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Имя
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Отчество
        /// </summary>
        public string Patronymic { get; set; }
        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime DateBirth { get; set; }
        /// <summary>
        /// Документ
        /// </summary>
        public string Document  { get; set; }
        /// <summary>
        /// Серия документа
        /// </summary>
        public string Series { get; set; }
        /// <summary>
        /// номер документа
        /// </summary>
        public string  Number { get; set; }
    }
    
    public enum Service
    {
        Чистка,
        Консультация,
        Лечение,
    }
 }
