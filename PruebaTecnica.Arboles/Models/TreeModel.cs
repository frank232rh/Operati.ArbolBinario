using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaTecnica.Arboles.Models
{
    public class TreeModel
    {
        public string pNode { get; set; }
        public List<TreeModel> sNode { get; set; }

        public TreeModel(string pNode) {
            this.pNode = pNode;
            sNode = new List<TreeModel>();
        }
    }
}
