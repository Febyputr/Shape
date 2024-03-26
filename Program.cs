/*using System;

namespace SistemMenggambar
{



    // Interface untuk bentuk
    interface IShape
    {
        void Draw();
    }

    // Kelas dasar Shape
    class Shape : IShape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Menggambar bentuk umum...");
        }
    }

    // Kelas Segitiga
    class Segitiga : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Menggambar segitiga...");
            Console.WriteLine("   *");
            Console.WriteLine("  ***");
            Console.WriteLine(" *****");
            Console.WriteLine("*******");
        }
    }

    // Kelas Lingkaran
    class Lingkaran : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Menggambar lingkaran...");
            Console.WriteLine("    * *  *");
            Console.WriteLine("  *        *");
            Console.WriteLine(" *           *");
            Console.WriteLine("*             *");
            Console.WriteLine("*             *");
            Console.WriteLine(" *            *");
            Console.WriteLine("  *         * ");
            Console.WriteLine("     *  *");
        }
    }

    // Kelas Persegi
    class Persegi : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Menggambar persegi...");
            Console.WriteLine("******");
            Console.WriteLine("*    *");
            Console.WriteLine("*    *");
            Console.WriteLine("*    *");
            Console.WriteLine("******");
        }
    }

    // Kelas Persegi Panjang
    class PersegiPanjang : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Menggambar persegi panjang...");
            Console.WriteLine("********");
            Console.WriteLine("*      *");
            Console.WriteLine("********");
        }
    }

    // Kelas Jajar Genjang
    class JajarGenjang : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Menggambar jajar genjang...");
            Console.WriteLine("   **********");
            Console.WriteLine("  *        *");
            Console.WriteLine(" *        *");
            Console.WriteLine(" **********");
        }
    }

    class program
    {
        static void main(string[] args)
        {
            static void Main()
            {
                Console.WriteLine("Pilih Media mu : \n A. Kertas Canvas \n B. Batu");
                string canvas = Console.ReadLine();
                if (canvas.ToUpper() == "A")
                {
                    Console.WriteLine("Kamu Ingin Menggambar apa? \n 1. Segitiga \n 2. Lingkaran \n 3. Persegi \n 4. Persegi Panjang \n 5. Jajargenjang");
                    string pilih = Console.ReadLine();
                    Shape shape = null;
                    switch (pilih)
                    {
                        case "1":
                            shape = new Segitiga();
                            break;
                        case "2":
                            shape = new Lingkaran();
                            break;
                        case "3":
                            shape = new Persegi();
                            break;
                        case "4":
                            shape = new PersegiPanjang();
                            break;
                        case "5":
                            shape = new JajarGenjang();
                            break;
                        default:
                            Console.WriteLine("Invalid choice");
                            break;
                    }
                    shape.Draw();
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
        }
    }
}
            // Kelas utama
*//*class Program
{
    static void Main(string[] args)
    {
        // Contoh penggunaan
        IShape[] shapes = {
        new Triangle(),
        new Circle(),
        new Square(),
        new Rectangle(),
        new JajajrGenjang()
    };

        foreach (var shape in shapes)
        {
            shape.Draw();
        }
    }
}*/


using System;

namespace SistemMenggambar
{
    // Interface untuk bentuk
    interface IShape
    {
        void Draw();
    }

    // Kelas dasar Shape
    class Shape : IShape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Menggambar bentuk umum...");
        }
    }

    // Kelas Segitiga
    class Segitiga : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Menggambar segitiga...");
            Console.WriteLine("   *");
            Console.WriteLine("  ***");
            Console.WriteLine(" *****");
            Console.WriteLine("*******");
        }
    }

    // Kelas Lingkaran
    class Lingkaran : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Menggambar lingkaran...");
            Console.WriteLine("    * *  *");
            Console.WriteLine("  *        *");
            Console.WriteLine(" *           *");
            Console.WriteLine("*             *");
            Console.WriteLine("*             *");
            Console.WriteLine(" *            *");
            Console.WriteLine("  *         * ");
            Console.WriteLine("     *  *");
        }
    }

    // Kelas Persegi
    class Persegi : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Menggambar persegi...");
            Console.WriteLine("******");
            Console.WriteLine("*    *");
            Console.WriteLine("******");
        }
    }

    // Kelas Persegi Panjang
    class PersegiPanjang : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Menggambar persegi panjang...");
            Console.WriteLine("********");
            Console.WriteLine("*      *");
            Console.WriteLine("********");
        }
    }

    // Kelas Jajar Genjang
    class JajarGenjang : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Menggambar jajar genjang...");
            Console.WriteLine("   **********");
            Console.WriteLine("  *        *");
            Console.WriteLine(" *        *");
            Console.WriteLine(" **********");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pilih Media mu : \n 1.Kertas Canvas ");
            string canvas = Console.ReadLine();
            if (canvas.ToUpper() == "1")
            {
                Console.WriteLine("pilih gambar yang kalian inginkan.. \n 1. Segitiga \n 2. Lingkaran \n 3. Persegi \n 4. Persegi Panjang \n 5. Jajar Genjang");
                string pilih = Console.ReadLine();
                Shape shape = null;
                switch (pilih)
                {
                    case "1":
                        shape = new Segitiga();
                        break;
                    case "2":
                        shape = new Lingkaran();
                        break;
                    case "3":
                        shape = new Persegi();
                        break;
                    case "4":
                        shape = new PersegiPanjang();
                        break;
                    case "5":
                        shape = new JajarGenjang();
                        break;
                    default:
                        Console.WriteLine("coba lagi..pilihan yang anda pilih zonk");
                        break;
                }
                shape.Draw();
            }
            else
            {
                Console.WriteLine("Invalid guys");
            }
        }
    }
}

