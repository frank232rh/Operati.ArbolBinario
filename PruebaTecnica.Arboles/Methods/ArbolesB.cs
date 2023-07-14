using PruebaTecnica.Arboles.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace PruebaTecnica.Arboles.Methods
{
    public class ArbolesB
    {
        public List<string> strArr { get; set; }

        public static void TreeConstructor(List<string> strArr)
        {
            bool isCorrect = true;
            List<TreeModel> tree = new List<TreeModel>();
            foreach (var item in strArr)
            {
                string[] array = item.Split(',');
                bool has = tree.Any(d => d.pNode == array[1]);
                if (!has) {
                    TreeModel newBranch = new TreeModel(array[1]);
                    TreeModel leaf = new TreeModel(array[0]);
                    newBranch.sNode.Add(leaf);
                    tree.Add(newBranch);
                }
                else
                {
                        int index = tree.FindIndex(d => d.pNode.Equals(array[1], StringComparison.Ordinal));
                        int indexS = tree.FindIndex(d => d.pNode.Equals(array[0], StringComparison.Ordinal));

                    //Si el secundario se encuentra ya como primario
                    if (indexS >= 0) {
                        if (tree[index].sNode.Count < 2)
                            tree[index].sNode.Add(tree[indexS]);
                        else
                        {
                            isCorrect = false;
                        }
                    }
                    else
                    {
                        if (tree[index].sNode.Count < 2)
                        {
                            TreeModel leaf = new TreeModel(array[0]);
                            tree[index].sNode.Add(leaf);
                        }
                        else
                        {
                            isCorrect = false; 
                        }
                    }
                }
            }
            if (isCorrect)
            {
                Console.WriteLine(isCorrect);
                drawTree(tree);
            }
            else
            {
                Console.WriteLine(isCorrect + " no es arbol binario");
            }
        }

        public static void drawTree(List<TreeModel> arbolesB, string sangria = "")
        {
            if (arbolesB != null)
            {
                foreach (var item in arbolesB)
                {
                    Console.WriteLine(item.pNode + sangria + "\t");
                    foreach (var rama in item.sNode)
                    {
                        Console.WriteLine(sangria + "\t" + rama.pNode);
                    }
                }
            }
        }
    }
}
