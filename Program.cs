using System;
using System.Collections.Generic;
using System.Linq;
namespace Excerise
{
    public interface Drawable
    {
        string GetTopCard();
    }
    public class Deck : Drawable
    {
        List<string> cards;

        public Deck(List<string> cards)
        {
            this.cards = cards;
        }
        public string GetTopCard()
        {
            return cards.Any() ? cards.First() : "No cards available";
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck(new List<string>{"1", "2", "3", "4", "5" });
            Console.WriteLine(deck.GetTopCard());
        }
    }
}