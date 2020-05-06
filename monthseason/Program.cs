using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monthseason
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("달 입력 : ");
            int month = int.Parse(Console.ReadLine());
            String Seasons = null;

            switch (month)
            {
                case 12:              
                case 1:                   
                case 2:
                    Seasons = "겨울";
                    break;
                case 3:              
                case 4:          
                case 5:
                    Seasons = "봄";
                    break;
                case 6:
                case 7:                  
                case 8:
                    Seasons = "여름";
                    break;
                case 9:
                case 10:                    
                case 11:
                    Seasons = "겨울";
                    break;
                default:
                    Console.WriteLine("잘못 입력하셨습니다.");
                    break;
            }

            if (Seasons != null)
            {
                Console.WriteLine("지금 계절은 {0}!", Seasons);
            }
        }
    }
}
