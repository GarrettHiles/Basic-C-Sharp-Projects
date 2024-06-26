﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Deck
    {
        public Deck()
        {
            PlayCards = new List<Card>();
            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Card card = new Card();
                    card.Face = (Face)i;
                    card.Suit = (Suit)j;
                    PlayCards.Add(card);
                }
            }
            
        }
        public List<Card> PlayCards { get; set; }

        public void Shuffle(int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (PlayCards.Count > 0)
                {
                    int randomIndex = random.Next(0, PlayCards.Count);
                    TempList.Add(PlayCards[randomIndex]);
                    PlayCards.RemoveAt(randomIndex);
                }
                PlayCards = TempList;
            }
           
        }

    }
}
