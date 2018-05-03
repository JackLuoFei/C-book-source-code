using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    struct CNode
    {
        public char suit;
        public string face;
    }
    class Card
    {
        enum Number { CARD_NUMBER = 52, SUIT_NUMBER = 4, FACE_NUMBER = 13 };
        private CNode[] deck = new CNode[(int)Number.CARD_NUMBER];
        public string[] wang = { "大王", "小王" };
        public Card()
        {
            char[] suit = { (char)3, (char)4, (char)5, (char)6 };
            string[] face = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
            
            for (int i = 0; i < (int)Number.CARD_NUMBER; i++)
            {
                deck[i].face = face[i % (int)Number.FACE_NUMBER];
                deck[i].suit = suit[i / (int)Number.FACE_NUMBER];
            }
        }

        public void shuffle()
        {
            int j;
            CNode temp;
            Random r = new Random();
            for (int i = 0; i < (int)Number.CARD_NUMBER; i++)
            {
                j = r.Next() % (int)Number.CARD_NUMBER;
                temp = deck[i];
                deck[i] = deck[j];
                deck[j] = temp;
            }
        }
        public void deal()
        {
            Console.Write("=====================");
            Console.Write(" 斗地主 简单版");
            Console.WriteLine("=====================");
            Console.WriteLine("玩家一");
            for (int i = 0; i < 17; i++)
            {
                Console.Write("第{0,2}张:{1}{2}\t", i + 1, deck[i].suit, deck[i].face);                
            }
            Console.WriteLine("\n玩家二");
            for (int i = 17; i < 34; i++)
            {
                Console.Write("第{0,2}张:{1}{2}\t", i + 1, deck[i].suit, deck[i].face);
            }
            Console.WriteLine("\n玩家三");
            for (int i = 34; i < 51; i++)
            {
                Console.Write("第{0,2}张:{1}{2}\t", i + 1, deck[i].suit, deck[i].face);
            }
            Console.WriteLine("\n玩家一是地主，底牌是:{0},{1},{2}{3}", wang[0], wang[1], deck[51].suit, deck[51].face);
            //Console.WriteLine("\n玩家一是地主，底牌是{0},{1}", wang[1], wang[2]);
                      
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Card obj = new Card();
            obj.shuffle();
            obj.deal();
         //   Console.ReadKey();
        }
    }
}
