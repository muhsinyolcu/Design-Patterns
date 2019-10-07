using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    class Employee : IPerson, IEnumerable<IPerson>
    {
        List<IPerson> _subordinates = new List<IPerson>();

        public void AddSubordinate(IPerson person)
        {
            _subordinates.Add(person);
        }
        public void RemoveSubordinate(IPerson person)
        {
            _subordinates.Remove(person);
        }

        public IPerson GetSubordinate(int index)
        {
            return _subordinates[index];
        }
        public string Name { get; set; }

        public IEnumerator<IPerson> GetEnumerator()
        {
            foreach (var subordinate in _subordinates)
            {
                yield return subordinate;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
