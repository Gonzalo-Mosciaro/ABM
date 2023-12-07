using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Clases
{
    public class Serializadora
    {
        public static List<Empleado> Leer(string path)
        {
            List<Empleado> list = new List<Empleado>();

            using (StreamReader sr = new StreamReader(path))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Empleado>));

                list = serializer.Deserialize(sr) as List<Empleado>;

            }

            return list;

        }


        public static void Escribir(List<Empleado> lista, string path)
        {
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Empleado>));
                serializer.Serialize(sw, lista);
            }

        }


    }
}
