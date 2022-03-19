using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jurnal_Modul4
{
    internal class Penjumlahan
    {

        PenjumlahanGeneric<string> penjumlahan = new PenjumlahanGeneric<string>();
        
        string x = "1302194084";
        penjumlahan.JumlahAngka(x);

        }
}
public class PenjumlahanGeneric<T>
{
    public void JumlahAngka(T x)
    {

        Console.WriteLine("Jumlah Tiga Angka " + x);

    }
}

