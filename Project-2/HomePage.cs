using System;
using System.Collections.Generic;

namespace Project_2
{
    public class HomePage
    {
        public static Board board = new Board();
        public static TeamMembers team = new TeamMembers();

        public static void Home(){

            Console.WriteLine(" Please, enter the number of the transaction you want to do: ");
            Console.WriteLine("*************************************************************");
            Console.WriteLine("(1) List Board");
            Console.WriteLine("(2) Add Card");
            Console.WriteLine("(3) Delete Card");
            Console.WriteLine("(4) Move Board");
            Console.Write("Choice: ");
            int choice = Int32.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    listBoard();
                    break;
                case 2:
                    addCard();
                    break;
                case 3:
                    deleteCard();
                    break;
                case 4:
                    //moveCard();
                    break;
            }
        }

        public static void printBoard(List<Card> cardList, TeamMembers team){

            foreach (var card in cardList)
            {

                Console.WriteLine($"Title       : {card.Title}");
                Console.WriteLine($"Content     : {card.Content}");
                Console.WriteLine($"Title       : {team.userList.Find(x => x.UserId == card.UserId).UserName}");
                Console.WriteLine($"Size        : {((CardSizeEnum)card.CardSize).ToString()}");
                Console.WriteLine("-------------------------------------------------------------");
            }
        }

        public static void listBoard(){

            Console.WriteLine("TODO LINE");
            Console.WriteLine("*************************************************************");

            if(board.ToDo.Count <= 0)
                Console.WriteLine("--EMPTY--");
            else    
                printBoard(board.ToDo, team);
            
            Console.WriteLine("IN PROGRESS LINE");
            Console.WriteLine("*************************************************************");

            if(board.InProgress.Count <= 0)
                Console.WriteLine("--EMPTY--");
            else    
                printBoard(board.InProgress, team);
            
            Console.WriteLine("DONE LINE");
            Console.WriteLine("*************************************************************");

            if(board.Done.Count <= 0)
                Console.WriteLine("--EMPTY--");
            else    
                printBoard(board.Done, team);
        }

        public static void addCard(){
            Console.WriteLine("*************************************************************");    
            Console.WriteLine("ADDING CARD LINE");
            
            Console.Write($"Card Title                                  : ");
            string cardTitle = Console.ReadLine();

            Console.Write($"Card Content                                : ");
            string cartContent = Console.ReadLine();

            Console.Write($"Card Size XS(1), S(2), M(3), L(4), XL(5)    : ");
            int cardSize = Int32.Parse(Console.ReadLine());

            Console.Write($"Team Member (1-5)                           : ");
            int memberId = Int32.Parse(Console.ReadLine());

            board.ToDo.Add(new Card(cardTitle, cartContent, memberId, cardSize));
        }

        public static void deleteCard(){
            Console.WriteLine("*************************************************************");    
            Console.WriteLine("DELETING CARD LINE");

            Console.Write("Please, enter the title of the card to be deleted    : ");
            string deleteCardTitle = Console.ReadLine();

            int isToDo = board.ToDo.FindIndex(x => x.Title.ToLower() == deleteCardTitle.ToLower());
            int isInProgress = board.InProgress.FindIndex(x => x.Title.ToLower() == deleteCardTitle.ToLower());
            int isDone = board.Done.FindIndex(x => x.Title.ToLower() == deleteCardTitle.ToLower());

            if(isToDo >= 0)
                board.ToDo.RemoveAt(isToDo);
            else if(isInProgress >= 0)
                board.InProgress.RemoveAt(isInProgress);
            else if(isDone >= 0)
                board.Done.RemoveAt(isDone);
            else{
                Console.WriteLine("There is no card with this name !!!");
                HomePage.Home();
            }

            Console.WriteLine("Transaction completed successfully...");
        }

        
        public static void moveCard(){
            // to be coded...
        }
    }
}