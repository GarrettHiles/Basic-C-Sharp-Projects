using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Casino
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.PlayCards.First());
            string card = string.Format(Deck.PlayCards.First().ToString() + "\n");
            Console.WriteLine(card);
            using (StreamWriter file = new StreamWriter(@"C:\Users\Garrett Hiles\OneDrive\Documents\GitHub\Tech-Academy-Projects\Basic_C#_Projects\Basic_C#_Programs\Text\log.txt", true))
            {
                file.WriteLine(DateTime.Now);
                file.WriteLine(card);
            }
            Deck.PlayCards.RemoveAt(0);
        }
    }
}
