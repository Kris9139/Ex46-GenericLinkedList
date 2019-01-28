using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adt
{

    public class Node
    {
        public object Data { get; set; }
        public Node Next { get; set; } = null;
        public Node Prev { get; set; } = null;

        public Node(object data)
        {
            Data = data;
        }
    }
}
