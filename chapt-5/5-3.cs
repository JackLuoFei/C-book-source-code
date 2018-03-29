//
using System;
namespace _5_3
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
        public Card()
        {
            char[] suit = { (char)3, (char)4, (char)5, (char)6 };
            string[] face = { "A","1","2","3","4","5","6","7","8","9","10","J","Q","K"};
            
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
            Console.Write("52张牌发牌次序");
            Console.WriteLine("=====================");
            Console.WriteLine("   甲              乙               丙              丁");
            for(int i=0;i<(int)Number.CARD_NUMBER;i++)
            {
                Console.Write("第{0,2}张:{1}{2}\t", i + 1, deck[i].suit, deck[i].face);
                //Console.WriteLine();
                if ((i + 1) % 4 == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Card obj = new Card();
            obj.shuffle();
            obj.deal();
            Console.ReadKey();
        }
    }
}
