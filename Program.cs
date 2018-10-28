using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ObjectYouCanDraw
    {

        private string objectCharacter;
        private int objectHeight;
        private int objectWidth;
        private int objectPositionX;
        private int objectPositionY;

        public void SetObjectParameters()
        {
            
            Console.WriteLine("Pick a character of the obcject: ");
            objectCharacter = Console.ReadLine();
            Console.WriteLine("Input height: ");
            objectHeight = int.Parse(Console.ReadLine());
            Console.WriteLine("Input width: ");
            objectWidth = int.Parse(Console.ReadLine());
            Console.WriteLine("Input position X: ");
            objectPositionX = int.Parse(Console.ReadLine());
            Console.WriteLine("Input position Y: ");
            objectPositionY = int.Parse(Console.ReadLine());
        }


        public void DrawYourObject()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < objectWidth; i++)
            {
                Console.SetCursorPosition((objectPositionX + i), objectPositionY);
                Console.Write(objectCharacter);
            }
            for (int i = 1; i < (objectHeight - 1); i++)
            {
                Console.SetCursorPosition(objectPositionX, (objectPositionY + i));
                Console.WriteLine(objectCharacter);
                for (int j = 0; j < objectWidth; j++)
                {
                    if (j == 0 | j == (objectWidth - 1)) Console.ForegroundColor = ConsoleColor.Yellow;
                    else Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.SetCursorPosition((objectPositionX + j), (objectPositionY + i));
                    Console.Write(objectCharacter);
                }
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < objectWidth; i++)
            {
                Console.SetCursorPosition((objectPositionX + i), (objectPositionY + objectHeight - 1));
                Console.Write(objectCharacter);
            }
            if (((objectWidth % 2) == 0) & (objectWidth >= 6))
            {
                Console.SetCursorPosition((objectPositionX + (objectWidth / 2) - 1), (objectPositionY + objectHeight));
                Console.Write(objectCharacter);
                Console.Write(objectCharacter);
                Console.SetCursorPosition((objectPositionX + (objectWidth / 2) - 2), (objectPositionY + objectHeight + 1));
                Console.Write(objectCharacter);
                Console.Write(objectCharacter);
                Console.Write(objectCharacter);
                Console.Write(objectCharacter);
            }
            else if (objectWidth >= 5)
            {
                Console.SetCursorPosition((objectPositionX + (objectWidth / 2)), (objectPositionY + objectHeight));
                Console.Write(objectCharacter);
                Console.SetCursorPosition((objectPositionX + (objectWidth / 2) - 1), (objectPositionY + objectHeight + 1));
                Console.Write(objectCharacter);
                Console.Write(objectCharacter);
                Console.Write(objectCharacter);
            }
        }
    }
    class CurtainYouCanDraw
    {
       private string curtainCharacter;
       private int curtainHeight;
       private int curtainWidth;
       private int curtainPositionX;
       private int curtainPositionY;
       private int curtainStyle;

        public void SetCurtainParameters()
        {
            Console.WriteLine("Pick a character of the Curtain: ");
            curtainCharacter = Console.ReadLine();
            Console.WriteLine("Input height: ");
            curtainHeight = int.Parse(Console.ReadLine());
            Console.WriteLine("Input width: ");
            curtainWidth = int.Parse(Console.ReadLine());
            Console.WriteLine("Input position X: ");
            curtainPositionX = int.Parse(Console.ReadLine());
            Console.WriteLine("Input position Y: ");
            curtainPositionY = int.Parse(Console.ReadLine());
            Console.WriteLine("Select curtain style: 1 - Straight, 2 - Asymatric, 3 - Fancy");
            curtainStyle = int.Parse(Console.ReadLine());
        }


        public void DrawYourCurtain()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int i = 0; i < curtainWidth; i++)
            {
                if (i == 0)
                {
                    Console.SetCursorPosition((curtainPositionX -2 ),(curtainPositionY - 1 ));
                    Console.Write(curtainCharacter);
                    Console.SetCursorPosition((curtainPositionX -2), (curtainPositionY + 1));
                    Console.Write(curtainCharacter);
                    Console.SetCursorPosition((curtainPositionX - 1), (curtainPositionY));
                    Console.Write(curtainCharacter);

                }
                Console.SetCursorPosition((curtainPositionX + i), curtainPositionY);
                Console.Write(curtainCharacter);
                if (i == (curtainWidth - 1))
                {
                    Console.SetCursorPosition((curtainPositionX + i + 2), (curtainPositionY - 1));
                    Console.Write(curtainCharacter);
                    Console.SetCursorPosition((curtainPositionX + i + 2), (curtainPositionY + 1));
                    Console.Write(curtainCharacter);
                    Console.SetCursorPosition((curtainPositionX + i + 1), (curtainPositionY));
                    Console.Write(curtainCharacter);
                }
            }
            for (int i = 1; i < (curtainHeight - 4); i++)
            {
                Console.SetCursorPosition(curtainPositionX, (curtainPositionY + i));
                Console.WriteLine(curtainCharacter);
                for (int j = 0; j < curtainWidth; j++)
                {
                    if (j == 0 | j == (curtainWidth - 1)) Console.ForegroundColor = ConsoleColor.White;
                    else Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition((curtainPositionX + j), (curtainPositionY + i));
                    Console.Write(curtainCharacter);
                }
            }
            if (curtainStyle == 1)
            {
                Console.ForegroundColor = ConsoleColor.White;
                for (int i = 0; i < 5 ; i++)
                {
                    for (int j=0; j < curtainWidth;j++)
                    {
                        Console.SetCursorPosition((curtainPositionX + j), (curtainPositionY + curtainHeight - 5 + i));
                        Console.Write(curtainCharacter);
                    }
                }
            }
            if (curtainStyle == 2)
            {
                Console.ForegroundColor = ConsoleColor.White;
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < curtainWidth; j++)
                    {
                        Console.SetCursorPosition((curtainPositionX + j), (curtainPositionY + (curtainHeight - 5 + i)));
                        Console.Write(curtainCharacter);
                    }
                    curtainWidth = (curtainWidth * 3 / 4);
                }
            }
            if (curtainStyle == 3)
            {
                Console.ForegroundColor = ConsoleColor.White;
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < curtainWidth; j+=2)
                    {
                        Console.SetCursorPosition((curtainPositionX + j), (curtainPositionY + curtainHeight -5 + i));
                        Console.Write(curtainCharacter);
                    }
                }

            }


        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int yourSelection; 
            //
            Console.WriteLine("Welcome in our brand new tool - Object Designer 9000\nThis tool will let you draw an item.\nWe will ask You few questions:\n");
            Console.WriteLine("Select an object: 1 - TV, 2 - Curtain*");
            yourSelection = int.Parse(Console.ReadLine());
            if (yourSelection == 1)
            {
                ObjectYouCanDraw brandNewObject = new ObjectYouCanDraw();
                brandNewObject.SetObjectParameters();
                brandNewObject.DrawYourObject();
            }
            if (yourSelection == 2)
            {
                CurtainYouCanDraw brandNewObject = new CurtainYouCanDraw();
                brandNewObject.SetCurtainParameters();
                brandNewObject.DrawYourCurtain();
            }
            if (yourSelection == 3)
            {

            }
            

            Console.WriteLine("\n\n\n\nFinished, press any key to close Object Designer 9000");
            Console.ReadKey();
        }
    }

}
