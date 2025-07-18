using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorSample
{
    public class ConcreteCollection : IAbstractCollection<Elempoyee>
    {
        //The following collection object is going to hold a list of items or elements
        private List<Elempoyee> listEmployees = new List<Elempoyee>();
        //Implementing the CreateIterator method of the IAbstractCollection interface
        //The following method is going to Create and return the Iterator Object
        //Later we will implement the Iterator
        public IAbstractIterator<Elempoyee> CreateIterator()
        {
            return new Iterator(this);
        }

        // The following method is going to return the count of the elements present in the collection
        public int Count
        {
            get { return listEmployees.Count; }
        }
        //Add items to the collection
        public void AddEmployee(Elempoyee employee)
        {
            listEmployees.Add(employee);
        }
        //Get items from the collection based on the Index Position
        //Index is started from 0
        public Elempoyee GetEmployee(int IndexPosition)
        {
            return listEmployees[IndexPosition];
        }
    }
}
