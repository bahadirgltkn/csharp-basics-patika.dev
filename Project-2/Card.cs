using System;

namespace Project_2
{
    public class Card
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int UserId { get; set; }
        public int CardSize { get; set; }

        public Card(string title, string content, int userId, int cardSize)
        {
            Title = title;
            Content = content;
            UserId = userId;
            CardSize = cardSize;
        }
    }
}