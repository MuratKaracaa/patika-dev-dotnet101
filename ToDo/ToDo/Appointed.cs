using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo
{
    internal class Appointed
    {
        private static List<Appointed> appointedList;
        private int id;
        private string name;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public Appointed(int id, string name)
        {
            this.Id = id;
            this.Name = name;
            appointedList.Add(this);
        }
        static Appointed()
        {
            appointedList = new List<Appointed>();
            for (int i = 1; i <= 5; i++) appointedList.Add((new Appointed(i, $"Appointed {i}")));
        }

        public static void checkIfAppointedExists(int i)
        {
            Appointed a = appointedList.Find(x => x.Id.Equals(i));
            try
            {
                a.GetType();
            }
            catch (Exception)
            {
                throw new Exception(Enums_Constants.Constants.AppointedPersonDoesNotExist);
            }
        }
    }
}
