using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_1302223027
{
    class Program
    {
        static void Main(string[] args)
        {
            KodePos kodePos = new KodePos();

            //menampilkan kode pos dari Kujasari
            Console.WriteLine("kode pos dari "+ KodePos.Kelurahan.Kujangsari+ " adalah " + KodePos.getKodePos(KodePos.Kelurahan.Kujangsari));
            //menampilkan kode pos dari Wates
            Console.WriteLine("kode pos dari " + KodePos.Kelurahan.Wates + " adalah " + KodePos.getKodePos(KodePos.Kelurahan.Wates));
            //menampilkan kode pos dari Maleer
            Console.WriteLine("kode pos dari " + KodePos.Kelurahan.Maleer + " adalah " + KodePos.getKodePos(KodePos.Kelurahan.Maleer));



           

            DoorMachine doorMachine = new DoorMachine();
            doorMachine.RunState();

        }
    }
}
