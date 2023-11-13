using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3_21._10_Pytymko_V.L
{
//Створіть клас «Океанаріум» з інформацією про «меш-
//канців» Океанаріуму.Створіть клас для кожної істоти
//Океанаріуму.Вони мають містити інформацію про кожну
//морську істоту.Реалізуйте підтримку ітератора для класу
//«Океанаріум». Протестуйте можливість використання
//foreach для Океанаріуму.
    public class Oceanarium : IEnumerable<SeaCreatur>
    {
        private List<SeaCreatur> inhabitants;
        public Oceanarium()
        {
            inhabitants= new List<SeaCreatur>();
        }
        public void AddInhabitants( string name, string type) 
        {
        SeaCreatur creatur= new SeaCreatur(name, type);
            inhabitants.Add(creatur);
        }
        public IEnumerator<SeaCreatur> GetEnumerator()
        { foreach (var creature in inhabitants) 
            {
                yield return creature;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }

    }
    public class SeaCreatur
    {
        public string _Name { get; set; }
        public string _Type { get; set; }

        public SeaCreatur(string name, string type)
        {
            _Name = name;
            _Type = type;

        }
    }
}
