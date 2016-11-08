using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
        Display house = new House();
        house.display()
        ((Consoles) house).print();
        }
    }

    public class House : Build, Display {

        int poeple;
        List<Room> rooms;

        void override display() {
            Console.WriteLine("House " + name);
        }

        void print() {
            Console.WriteLine(name);
        }

        private class Room {
        
            public RoomType type;
        }

        enum RoomType {
            
        }

    }

    public abstract class Build : Display {

        private string name {get; set;};

        public void display() {
            Console.WriteLine(name);
        }

    }

    public interface Display {
        void display();
    }

    public interface Consoles {
        void print();
    }

}
