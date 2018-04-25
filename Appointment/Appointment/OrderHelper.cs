
using System.IO;
using System.Xml.Serialization;

namespace ЗаписьНаПрием
{
    public static class OrderHelper
    {
        private static readonly XmlSerializer Xs = new XmlSerializer(typeof(AppointmentToTheDentist));
        public static void WriteToFile(string fileName, AppointmentToTheDentist data)
        {
            using (var fileStream = File.Create(fileName))
            {
                Xs.Serialize(fileStream, data);
            }
        }

        public static AppointmentToTheDentist LoadFromFile(string fileName)
        {
            using (var fileStream = File.OpenRead(fileName))
            {
                return (AppointmentToTheDentist)Xs.Deserialize(fileStream);
            }
        }
    }
}
