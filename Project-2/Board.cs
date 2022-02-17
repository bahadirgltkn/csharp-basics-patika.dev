using System;
using System.Collections.Generic;

namespace Project_2
{
    public class Board
    {
        public List<Card> ToDo = new List<Card>();
        public List<Card> InProgress = new List<Card>();
        public List<Card> Done = new List<Card>();

        public Board(){
            ToDo.Add(new Card("Alışveriş yap", "1 kg elma, 2 kg domates", 2, 3));
            InProgress.Add(new Card("Evi temizle", "Mutfak ve banyo temizlenecek", 1, 3));
            Done.Add(new Card("Yemek", "2 çeşit yemek yapılacak", 3, 3));
        }
    }
}