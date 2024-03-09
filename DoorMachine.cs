using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_1302223027
{
    public class DoorMachine
    {
        public enum DoorMachineState { Terkunci, Terbuka};
        public  void RunState()
        {
            //asusmsi state awal terkunci
            DoorMachineState state = DoorMachineState.Terkunci;
            string command;

            string[] screenName = { "Pintu Terkunci","Pintu Tidak Terkunci" };

            for (int i = 0; i < 4; i++)
            {


                Console.WriteLine();
                Console.WriteLine();

                //menampilkan kondisi pintu
                Console.WriteLine(screenName[(int)state]);

                //tracing state saat ini
                Console.WriteLine("state saat ini adalah "+state);
                Console.WriteLine("Enter Command: ");



                command = Console.ReadLine();


                switch (state)
                {
                    case  DoorMachineState.Terkunci:
                        if (command =="KunciPintu")
                        {
                            state = DoorMachineState.Terkunci;
                        }else if(command == "BukaPintu")
                        {
                            state=DoorMachineState.Terbuka;
                        }
                        break;

                    case DoorMachineState.Terbuka:
                        if (command == "KunciPintu")
                        {
                            state = DoorMachineState.Terkunci;
                        }
                        else if (command == "BukaPintu")
                        {
                            state = DoorMachineState.Terbuka;
                        }
                        break;

                }
            }
            Console.WriteLine();
            Console.WriteLine();

            //menampilkan kondisi pintu
            Console.WriteLine(screenName[(int)state]);

            //tracing state saat ini
            Console.WriteLine("state saat ini adalah " + state);
        }
        
    }
}
