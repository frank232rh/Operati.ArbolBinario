using PruebaTecnica.Arboles.Methods;
using PruebaTecnica.Arboles.Models;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

public class ProgrammMain
{
    public static List<string> branches { get; set; }
    public static void Main()
    {
        /* "1,2", "2,4", "5,7", "7,2", "9,5" */
        branches = new List<string> {
            "4,6","5,4","3,4","2,3",
            "2,5","1,5","1,2"
        };
        ArbolesB.TreeConstructor(branches);

    }

}