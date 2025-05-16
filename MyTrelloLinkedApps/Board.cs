using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTrelloLinkedApps
{
    // Lớp Board: đại diện cho bảng Trello, chứa nhiều danh sách (List)

    public class Board
    {
        public LinkedList Lists { get; } = new LinkedList(); // Danh sách các list trên board
    }
    
    // Lớp CardList: đại diện cho một danh sách (List) chứa các thẻ (Card)
    
    public class CardList
    {
        public string Name { get; set; }                     // Tên danh sách
        public LinkedList Cards { get; } = new LinkedList(); // Danh sách các thẻ trong list

        public CardList(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }

    // Lớp Card: đại diện cho một thẻ trong danh sách
    
    public class Card
    {
        public string Title { get; set; }        // Tiêu đề thẻ
        public string Description { get; set; }  // Mô tả thẻ
        public object Previous { get; set; }     // Tham chiếu tới thẻ trước đó (dùng khi chèn)
        public bool IsArchived { get; set; }     // Đánh dấu thẻ đã lưu trữ hay chưa

        public Card(string title, string desc, object previous)
        {
            Title = title;
            Description = desc;
            Previous = previous;
            IsArchived = false;
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
