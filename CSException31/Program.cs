using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSException31
{
    internal class Program
    {

        class Box
        {
            private int width;
            public int Width
            {
                get { return width; }
                set
                {
                    if (value <= 0)
                        throw new Exception("너비는 0보다 커야 합니다.");
                    width = value;
                }
            }

            private int height;
            public int Height
            {
                get { return height; }
                set
                {
                    if (value <= 0)
                        throw new Exception("높이는 0보다 커야 합니다.");
                    height = value;
                }
            }

            public Box(int width, int height)
            {
                Width = width;
                Height = height;
            }

            // 박스의 넓이를 계산하는 속성
            public int Area
            {
                get
                {
                    return width * height;
                }
            }

        }

        static void Main(string[] args)
        {
            Box b1 = new Box(10, 10);
            Console.WriteLine("Area: {0}", b1.Area);
            b1.Width = 0;

        }
    }
}
