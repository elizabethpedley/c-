using System.Collections.Generic;
using System;

namespace deckOfCards
{
    class Program
    {
        static void Main(string[] ars)
        {
            Deck deck = new Deck();
            string[] ranks = {"Ace","2","3","4","5","6","7","8","9","10","J","Q","K"};
            string[] suits = {"Heart","Diamonds","Clubs","Spades"};
            string[] trumps = {"Joker","Joker"};
            deck.buildDeck(suits, ranks, trumps);
            deck.shuffleDeck();
            Player player = new Player();
            player.name = "Teddy";
            Console.WriteLine((player.drawCard(deck)).displayCard());
            Console.WriteLine((player.drawCard(deck)).displayCard());
            Console.WriteLine((player.drawCard(deck)).displayCard());
        }
        class Card{
            public string rank;
            public string suit;
            public bool trump;

            public string displayCard(){
                if(trump == true){
                    return this.rank;
                }else{
                    return $"Rank: {this.rank}, Suit: {this.suit}";
                }
            }
        }
        class Deck{
            public List<Card> deck = new List<Card>{
            };
            private Random rand = new Random();
            public string[] suits;
            public string[] ranks;
            public string[] trumps;
            public void buildDeck(string[] suit,string[] rank, string[] trump){
                this.suits = suit;
                this.ranks = rank;
                this.trumps = trump;
                for(int i=0;i<suit.Length;i++){
                    for(int j=0;j<rank.Length;j++){
                        Card card = new Card();
                        card.suit = suit[i];
                        card.rank = rank[j];
                        card.trump = false;
                        deck.Add(card);
                    };
                };
                foreach(var t in trump){
                    Card card = new Card();
                    card.rank = t;
                    card.trump = true;
                    card.suit = null;
                    deck.Add(card);
                };
            }

            public Card dealCard() {
                Card deal = this.deck[0];
                this.deck.RemoveAt(0);
                return deal;
            }

            public void resetDeck() {
                this.deck = new List<Card>{};
                this.buildDeck(this.suits, this.ranks, this.trumps);
            }

            public void shuffleDeck() {
                for (int i = 0; i < this.deck.Count; i++) {
                    int index = rand.Next(0, this.deck.Count);
                    Card temp = this.deck[i];
                    this.deck[i] = this.deck[index];
                    this.deck[index] = temp;
                };
            }
        }
        class Player {
            public string name;
            public List<Card> hand = new List<Card>{};

            public Card drawCard(Deck deck) {
                Card draw = deck.dealCard();
                this.hand.Add(draw);
                return draw;
            }

            public Card discardCard(int index) {
                Card discard = this.hand[index];
                this.hand.RemoveAt(index);
                return discard;
            }
        }
    }
}
