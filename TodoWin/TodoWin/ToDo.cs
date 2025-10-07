using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoWin
{
    public class ToDo
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Body { get; set; }

        public override string ToString()
        {
            
            return $"{Id}: {Title} - {Body}";
        }
    }
}
