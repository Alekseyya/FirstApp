using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    public class SuperNode
    {
        public SuperNode()
        {
            Children = new List<SuperNode>();
        }
        public string Name { get; set; }
        public List<SuperNode> Children { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
