using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5
{

    public class StoredList<T> : List<T>,IDisposable where T : class
    {

        private static readonly string filePath = "C:\\Users\\moham\\source\\repos\\day2\\day2\\output.txt";

        private readonly TextWriter writer;

        public StoredList()
        {
            writer = new StreamWriter(filePath, true);
        }
        public new void Add(T item)
        {
            base.Add(item);
            writer.WriteLine(item.ToString());


        }

        public void Dispose()
        {
            writer.Dispose();
        }
    }
}
