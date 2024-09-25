using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSException31
{
    internal class Program
    {
        class BoxWrongWidthException : Exception
        {
            public BoxWrongWidthException(string message) : base(message)
            {
            }
        }

        class BoxWrongHeightException : Exception
        {
            public BoxWrongHeightException(string message) : base(message)
            {
            }
        }

        class Box
        {
            private int width;
            public int Width
            {
                get { return width; }
                set
                {
                    if (value <= 0)
                        throw new BoxWrongWidthException("너비는 0보다 커야 합니다.");
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
                        throw new BoxWrongHeightException("높이는 0보다 커야 합니다.");
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

            try
            {
                Box b1 = new Box(10, 10);
                Console.WriteLine("Area: {0}", b1.Area);
                b1.Width = 0;
            }
            catch(BoxWrongWidthException e)
            {
                Console.WriteLine("아 쫌 너비값 자연수!!");
            }
            catch (BoxWrongHeightException e)
            {
                Console.WriteLine("아 쫌 높이값 자연수!!");
            }   
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("프로그램 종료");

            }
        } 
    }
}
