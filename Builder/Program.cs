using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Models;
using Builder.Director;
using Builder.Builder;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Form1 interfaz = new Form1();
            interfaz.ShowDialog();

            /*var key = new ConsoleKeyInfo();
            while (!(key.Key == ConsoleKey.D9 || key.Key == ConsoleKey.NumPad9))
            {
                var cocina = new Cocina();
                Hamburguesa hamburguesa = null;
                key = ShowMenu();
                switch (key.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        hamburguesa = cocina.CocinarHamburguesa(new SencillaBuilder(TipoPanEnum.Sin_Semilla, TipoCarneEnum.Res)); //20
                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        hamburguesa = cocina.CocinarHamburguesa(new SencillaConQuesoBuilder(TipoPanEnum.Sin_Semilla, TipoCarneEnum.Res)); //25
                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        hamburguesa = cocina.CocinarHamburguesa(new McPolloBuilder(TipoPanEnum.Con_Semilla, TipoCarneEnum.Pollo)); //30
                        break;

                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        hamburguesa = cocina.CocinarHamburguesa(new DobleConQuesoBuilder(TipoPanEnum.Sin_Semilla, TipoCarneEnum.Doble_Res)); //45
                        break;

                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        hamburguesa = cocina.CocinarHamburguesa(new CuartoDeLibraBuilder(TipoPanEnum.Con_Semilla, TipoCarneEnum.Res)); //45
                        break;

                    case ConsoleKey.D6:
                    case ConsoleKey.NumPad6:
                        hamburguesa = cocina.CocinarHamburguesa(new McnificaBuilder(TipoPanEnum.Con_Semilla, TipoCarneEnum.Res)); //50
                        break;

                    case ConsoleKey.D7:
                    case ConsoleKey.NumPad7:
                        hamburguesa = cocina.CocinarHamburguesa(new CuartoDeLibraDobleConQuesoBuilder(TipoPanEnum.Con_Semilla, TipoCarneEnum.Doble_Res)); //65
                        break;

                    case ConsoleKey.D8:
                    case ConsoleKey.NumPad8:
                        hamburguesa = cocina.CocinarHamburguesa(new BigMacBuilder(TipoPanEnum.Con_Semilla, TipoCarneEnum.Doble_Res)); //80
                        break;
                }
                if (key.Key != ConsoleKey.D9 && key.Key != ConsoleKey.NumPad9 && key.Key != ConsoleKey.Escape)
                {
                    Console.WriteLine();
                    Console.WriteLine(hamburguesa.ToString());
                    Wait();
                }

            }
        }

            private static ConsoleKeyInfo ShowMenu()
            {
                Console.Clear();
                Console.WriteLine("1. Sencilla");
                Console.WriteLine("2. Sencilla con queso");
                Console.WriteLine("3. Mc Pollo");
                Console.WriteLine("4. Doble con queso");
                Console.WriteLine("5. Cuarto de Libra");
                Console.WriteLine("6. McNifica");
                Console.WriteLine("7. Cuarto de Libra doble con queso");
                Console.WriteLine("8. Big Mac");
                Console.WriteLine("9. Exit");
                return Console.ReadKey();
            }

            private static void Wait()
            {
                Console.WriteLine("Press ESC to continue...");
                while (Console.ReadKey().Key != ConsoleKey.Escape)
                {
                }
            }*/
        }
    }
 }
