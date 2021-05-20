using System;
using System.Threading;

namespace Question1
{
    interface ITool
    {
        const string key = "do zavtra";

        void Play();
    }

    class Qitara : ITool
    {
        private int chordQuantity;
        public int ChordQuantity
        {
            get
            {
                return chordQuantity;
            }
            set
            {
                chordQuantity = value;
            }
        }

        ITool[] data;

        public Qitara()
        {
            data = new ITool[100];
        }

        public ITool this[int index]
        {
            get
            {
                return data[index];
            }
            set
            {
                data[index] = value;
            }
        }

        public Qitara(int ChordQuantity)
        {
            this.ChordQuantity = ChordQuantity;
        }

        public void Play()
        {
            Console.WriteLine($"\nGuitar is Playing with: {chordQuantity} Chords {ITool.key}\n");
        }
    }

    class Baraban : ITool
    {
        private int size;
        public int Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }

        ITool[] data;

        public Baraban()
        {
            data = new ITool[100];
        }

        public ITool this[int index]
        {
            get
            {
                return data[index];
            }
            set
            {
                data[index] = value;
            }
        }

        public Baraban(int Size)
        {
            this.Size = Size;
        }

        public void Play()
        {
            Console.WriteLine($"\nDrum is Playing with size: {size}\n");
        }
    }

    class Truba : ITool
    {
        private int diametr;
        public int Diametr
        {
            get
            {
                return diametr;
            }
            set
            {
                diametr = value;
            }
        }

        ITool[] data;

        public Truba()
        {
            data = new ITool[100];
        }

        public ITool this[int index]
        {
            get
            {
                return data[index];
            }
            set
            {
                data[index] = value;
            }
        }

        public Truba(int Diametr)
        {
            this.Diametr = Diametr;
        }

        public void Play()
        {
            Console.WriteLine($"\nTrumpet is playing with Diametr: {diametr}\n");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Truba truba = new Truba();
            Qitara qitara = new Qitara();
            Baraban baraban = new Baraban();
            bool a = true;
            int counterForQitar = 0;
            int counterForTruba = 0;
            int counterForBaraban = 0;
            do
            {
                Menu();
                int b = NumberCheckerForSwitch();

                switch (b)
                {
                    case 1:
                        {
                            Console.Write("Enter qitara: ");
                            int c = NumberCheckerForInt();
                            ++counterForQitar;
                            qitara[counterForQitar] = new Qitara { ChordQuantity = c };
                            a = false;

                            Read();
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Enter baraban: ");
                            int d = NumberCheckerForInt();
                            ++counterForBaraban;
                            baraban[counterForBaraban] = new Baraban { Size = d };
                            a = false;

                            Read();
                            break;
                        }
                    case 3:
                        {
                            Console.Write("Enter truba: ");
                            int e = NumberCheckerForInt();
                            ++counterForTruba;
                            truba[counterForTruba] = new Truba { Diametr = e };
                            a = false;

                            Read();
                            break;
                        }
                    case 4:
                        {
                            if (counterForQitar == 0)
                            {
                                Console.WriteLine("\nThis sheet empty");
                            }
                            else
                            {
                                Console.WriteLine("\nQuitar list");
                                for (int i = 0; i <= counterForQitar; i++)
                                {
                                    if (qitara[i] == null)
                                    {
                                        continue;
                                    }
                                    else
                                    {
                                        Qitara qitaraList = (Qitara)qitara[i];
                                        qitaraList.Play();
                                        Sound();
                                    }
                                }
                            }

                            Read();
                            break;
                        }
                    case 5:
                        {
                            if (counterForBaraban == 0)
                            {
                                Console.WriteLine("\nThis sheet empty");
                            }
                            else
                            {
                                Console.WriteLine("\nBaraban list");
                                for (int i = 0; i <= counterForBaraban; i++)
                                {
                                    if (baraban[i] == null)
                                    {
                                        continue;
                                    }
                                    else
                                    {
                                        Baraban barabanList = (Baraban)baraban[i];
                                        barabanList.Play();
                                        Sound();
                                    }
                                }
                            }

                            Read();
                            break;
                        }
                    case 6:
                        {
                            if (counterForTruba == 0)
                            {
                                Console.WriteLine("\nThis sheet empty");
                            }
                            else
                            {
                                Console.WriteLine("\nTruba list");
                                for (int i = 0; i <= counterForTruba; i++)
                                {
                                    if (truba[i] == null)
                                    {
                                        continue;
                                    }
                                    else
                                    {
                                        Truba trubaList = (Truba)truba[i];
                                        trubaList.Play();
                                        Sound();
                                    }
                                }
                            }

                            Read();
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("Have a good day :)");
                            a = true;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("\nYou enter incorrect number, please enter from 1 till 7");
                            a = false;
                            continue;
                        }
                }

            } while (a == false);

            Console.ReadKey();
        }

        public static byte NumberCheckerForSwitch()
        {
            byte number;
            for (; ; )
            {
                string numberInString = Console.ReadLine();
                if (Byte.TryParse(numberInString, out number))
                {
                    return number;
                }
                else
                {
                    Console.Write("You enter not a number, please try again: ");
                }
            }
        }

        public static int NumberCheckerForInt()
        {
            int number;
            for (; ; )
            {
                string numberInString = Console.ReadLine();
                if (Int32.TryParse(numberInString, out number))
                {
                    return number;
                }
                else
                {
                    Console.Write("Incorrect number, please enter again: ");
                }
            }
        }

        public static void Menu()
        {
            Console.WriteLine("1)Quitar\n2)Baraban\n3)Truba\n4)Quitar list\n5)Baraban list\n6)Truba list\n7)Exit");
            Console.Write("Enter witch you want play: ");
        }

        public static void Read()
        {
            Console.Write("\nPress any button...");
            Console.ReadKey();
            Console.WriteLine("\n\n\n");
        }

        public static void Sound()
        {
            Console.Beep(659, 125);
            Console.Beep(659, 125);
            Thread.Sleep(125);
            Console.Beep(659, 125);
            Thread.Sleep(167);
            Console.Beep(523, 125);
            Console.Beep(659, 125);
            Thread.Sleep(125);
            Console.Beep(784, 125);
            Thread.Sleep(375);
            Console.Beep(392, 125);
            Thread.Sleep(375);
            Console.Beep(523, 125);
            Thread.Sleep(250);
            Console.Beep(392, 125);
            Thread.Sleep(250);
            Console.Beep(330, 125);
            Thread.Sleep(250);
            Console.Beep(440, 125);
            Thread.Sleep(125);
            Console.Beep(494, 125);
            Thread.Sleep(125);
            Console.Beep(466, 125);
            Thread.Sleep(42);
            Console.Beep(440, 125);
            Thread.Sleep(125);
            Console.Beep(392, 125);
            Thread.Sleep(125);
            Console.Beep(659, 125);
            Thread.Sleep(125);
            Console.Beep(784, 125);
            Thread.Sleep(125);
            Console.Beep(880, 125);
            Thread.Sleep(125);
            Console.Beep(698, 125);
            Console.Beep(784, 125);
            Thread.Sleep(125);
            Console.Beep(659, 125);
            Thread.Sleep(125);
            Console.Beep(523, 125);
            Thread.Sleep(125);
            Console.Beep(587, 125);
            Console.Beep(494, 125);
            Thread.Sleep(125);
            Console.Beep(523, 125);
            Thread.Sleep(250);
            Console.Beep(392, 125);
            Thread.Sleep(250);
            Console.Beep(330, 125);
            Thread.Sleep(250);
            Console.Beep(440, 125);
            Thread.Sleep(125);
            Console.Beep(494, 125);
            Thread.Sleep(125);
            Console.Beep(466, 125);
            Thread.Sleep(42);
            Console.Beep(440, 125);
            Thread.Sleep(125);
            Console.Beep(392, 125);
            Thread.Sleep(125);
            Console.Beep(659, 125);
            Thread.Sleep(125);
            Console.Beep(784, 125);
            Thread.Sleep(125);
            Console.Beep(880, 125);
            Thread.Sleep(125);
            Console.Beep(698, 125);
            Console.Beep(784, 125);
            Thread.Sleep(125);
            Console.Beep(659, 125);
            Thread.Sleep(125);
            Console.Beep(523, 125);
            Thread.Sleep(125);
            Console.Beep(587, 125);
            Console.Beep(494, 125);
            Thread.Sleep(375);
            Console.Beep(784, 125);
            Console.Beep(740, 125);
            Console.Beep(698, 125);
            Thread.Sleep(42);
            Console.Beep(622, 125);
            Thread.Sleep(125);
            Console.Beep(659, 125);
            Thread.Sleep(167);
            Console.Beep(415, 125);
            Console.Beep(440, 125);
            Console.Beep(523, 125);
            Thread.Sleep(125);
            Console.Beep(440, 125);
            Console.Beep(523, 125);
            Console.Beep(587, 125);
            Thread.Sleep(250);
            Console.Beep(784, 125);
            Console.Beep(740, 125);
            Console.Beep(698, 125);
            Thread.Sleep(42);
            Console.Beep(622, 125);
            Thread.Sleep(125);
            Console.Beep(659, 125);
            Thread.Sleep(167);
            Console.Beep(698, 125);
            Thread.Sleep(125);
            Console.Beep(698, 125);
            Console.Beep(698, 125);
            Thread.Sleep(625);
            Console.Beep(784, 125);
            Console.Beep(740, 125);
            Console.Beep(698, 125);
            Thread.Sleep(42);
            Console.Beep(622, 125);
            Thread.Sleep(125);
            Console.Beep(659, 125);
            Thread.Sleep(167);
            Console.Beep(415, 125);
            Console.Beep(440, 125);
            Console.Beep(523, 125);
            Thread.Sleep(125);
            Console.Beep(440, 125);
            Console.Beep(523, 125);
            Console.Beep(587, 125);
            Thread.Sleep(250);
            Console.Beep(622, 125);
            Thread.Sleep(250);
            Console.Beep(587, 125);
            Thread.Sleep(250);
            Console.Beep(523, 125);
            Thread.Sleep(1125);
            Console.Beep(784, 125);
            Console.Beep(740, 125);
            Console.Beep(698, 125);
            Thread.Sleep(42);
            Console.Beep(622, 125);
            Thread.Sleep(125);
            Console.Beep(659, 125);
            Thread.Sleep(167);
            Console.Beep(415, 125);
            Console.Beep(440, 125);
            Console.Beep(523, 125);
            Thread.Sleep(125);
            Console.Beep(440, 125);
            Console.Beep(523, 125);
            Console.Beep(587, 125);
            Thread.Sleep(250);
            Console.Beep(784, 125);
            Console.Beep(740, 125);
            Console.Beep(698, 125);
            Thread.Sleep(42);
            Console.Beep(622, 125);
            Thread.Sleep(125);
            Console.Beep(659, 125);
            Thread.Sleep(167);
            Console.Beep(698, 125);
            Thread.Sleep(125);
            Console.Beep(698, 125);
            Console.Beep(698, 125);
            Thread.Sleep(625);
            Console.Beep(784, 125);
            Console.Beep(740, 125);
            Console.Beep(698, 125);
            Thread.Sleep(42);
            Console.Beep(622, 125);
            Thread.Sleep(125);
            Console.Beep(659, 125);
            Thread.Sleep(167);
            Console.Beep(415, 125);
            Console.Beep(440, 125);
            Console.Beep(523, 125);
            Thread.Sleep(125);
            Console.Beep(440, 125);
            Console.Beep(523, 125);
            Console.Beep(587, 125);
            Thread.Sleep(250);
            Console.Beep(622, 125);
            Thread.Sleep(250);
            Console.Beep(587, 125);
            Thread.Sleep(250);
            Console.Beep(523, 125);
        }
    }
}
