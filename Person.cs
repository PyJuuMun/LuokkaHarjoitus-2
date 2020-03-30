using System;
using System.Collections.Generic;
using System.Text;

namespace LuokkaHarjoitus_2
{
    public class Person
    {
        public List<Person> people = new List<Person>();        
        
        public string Name;
        public int Age;
        public int Salary;
        public Person Friend;        

        //tyhjä Person attribuutteja varten Program puolella, muuten koodi valittaa
        public Person()
        {

        }

        //Constructori joka sisältää nimen, iän, palkan ja kaverin
        public Person(string names, int ages, int salaries)
        {
            this.Name = names;
            this.Age = ages;
            this.Salary = salaries;            
        }        
        
    }
}
