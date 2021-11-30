using System;
namespace EX1
{
    public class Dice
    {
        public int _cursorLeft = 10;
        public int _cursorTop;

        public Dice(){}

        public Dice(int cursorLeft )
        {
            _cursorLeft = cursorLeft;
            
            
        }

        public void DrawOuterFrame()
        {
            Console.CursorLeft = _cursorLeft;
            Console.CursorTop = 0;

            for (int r = 0; r < 7; r++)
            {
                for (int c = 0; c < 7; c++)
                {
                    Console.CursorLeft = _cursorLeft + c;
                    if (r == 0 || r==6)
                    {
                        Console.Write("*");
                    } else
                    {
                        if(c==0 || c == 6)
                        {
                            Console.Write("*");
                        } else
                        {
                            Console.Write(" ");
                        }
                    }  
                }
                Console.Write("\n");
            }   
        }

        public void DrawRandomNumber()
        {
            
            Random random = new Random();
            int diceNr = random.Next(1, 7);
            for(int r= 0; r<3; r++)
            {
                for(int c = 0; c< 3; c++)
                {
                    switch (diceNr)
                    {
                        case 1:
                            DrawOne(r, c);
                            break;
                        case 2:
                            DrawTwo(r, c);
                            break;
                        case 3:
                            DrawThree(r, c);
                            break;
                        case 4:
                            DrawFour(r, c);
                            break;
                        case 5:
                            DrawFive(r, c);
                            break;
                        case 6:
                            DrawSix(r, c);
                            break;
                    }                
                }              
            }          
        }
        private void DrawOne(int r, int c)
        {
            Console.CursorLeft = _cursorLeft+ 2 + c;
            Console.CursorTop = 2 + r;
            if(r==1 && c == 1)
            {
                Console.Write("*");
            } else
            {
                Console.Write(" ");
            }
        }
        private void DrawTwo(int r, int c)
        {
            Console.CursorLeft = _cursorLeft+ 2 + c;
            Console.CursorTop = 2 + r;
            if ((r == 1 && c == 0)|| (r==1 && c==2))
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(" ");
            }
        }

        private void DrawThree(int r, int c)
        {
            Console.CursorLeft = _cursorLeft +2 + c;
            Console.CursorTop = 2 + r;
            if ((r == 0 && c == 0) ||
                (r == 1 && c == 1) ||
                (r == 2 && c == 2))
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(" ");
            }
        }
        private void DrawFour(int r, int c)
        {
            Console.CursorLeft = _cursorLeft+ 2 + c;
            Console.CursorTop = 2 + r;
            if ((r == 0 && c == 0) ||
                (r == 0 && c == 2) ||
                (r == 2 && c == 0) ||
                (r == 2 && c == 2))
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(" ");
            }
        }
        private void DrawFive(int r, int c)
        {
            Console.CursorLeft = _cursorLeft+ 2 + c;
            Console.CursorTop = 2 + r;
            if ((r == 0 && c == 0) ||
                (r == 0 && c == 2) ||
                (r == 1 && c == 1) ||
                (r == 2 && c == 0) ||
                (r == 2 && c == 2))
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(" ");
            }
        }
        private void DrawSix(int r, int c)
        {
            Console.CursorLeft = _cursorLeft+ 2 + c;
            Console.CursorTop = 2 + r;
            if ((r == 0 && c == 0) ||
                (r == 0 && c == 2) ||
                (r == 1 && c == 0) ||
                (r == 1 && c == 2) ||
                (r == 2 && c == 0) ||
                (r == 2 && c == 2))
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(" ");
            }
        }
    }   
}
