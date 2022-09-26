using System;

namespace ToDoApp
{
    class Board
    {
            public List<Card> Todo { get;set; }
            public List<Card> Inprogress { get;set; }
            public List<Card> Done { get;set; }
    }
}