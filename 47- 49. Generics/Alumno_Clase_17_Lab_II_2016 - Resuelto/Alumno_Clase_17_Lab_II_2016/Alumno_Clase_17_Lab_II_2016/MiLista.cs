using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumno_Clase_17_Lab_II_2016
{
    public class MiLista<T>:IEnumerable<T>
    {
        T[] miAtributo;

        public MiLista()
        {
            this.miAtributo.Initialize();
        }

        public int Count
        {
            get
            {
                return this.miAtributo.Count<T>();
            }
        }

        public void Add(T item)
        {
            int size = this.miAtributo.Length;
            Array.Resize<T>(ref this.miAtributo,size + 1);
            this.miAtributo.SetValue(item, size);
        }

        public void Remove(T item)
        {
            int size = this.miAtributo.Length;
            int i = Array.IndexOf(this.miAtributo, item);
            // Array.Clear(this.miAtributo, i, 1);

            Array.Copy(this.miAtributo, i + 1, this.miAtributo, i, size - (i-1) );
            Array.Resize<T>(ref this.miAtributo, size - 1);

            /*
            T[] aux = new T[size-1];
            Array.Copy(this.miAtributo, aux, i-1);
            Array.Copy(this.miAtributo, i + 1, aux, i, size - 1);
            this.miAtributo = aux;
            */
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

    }
}
