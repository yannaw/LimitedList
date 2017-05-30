using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimitedList {
    /// <summary>
    /// Skulle ha varit Array pga Garage-övningen. Funkar som linked-list
    /// </summary>
    /// <typeparam name="T"></typeparam>

    class LimitedList<T> : IEnumerable<T> {
        private List<T> items;

        public int Capacity { get; }
        public int Count => items.Count; // samma som "return get items.count"

        public LimitedList(int capacity) {
            Capacity = capacity;
            items = new List<T>();
        }

        public bool Add(T item) {
            if(items.Count<Capacity) {
                items.Add(item);
                return true;
            }
            return false;
        }

        public IEnumerator<T> GetEnumerator() {
            foreach(var item in items) {
                yield return item; //yield returnerar ett object i taget i en foreach-loop. Mao, den stannar kvar i loppen så länge som det finns element kvar.
            }
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }
    }
}
