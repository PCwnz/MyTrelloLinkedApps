using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTrelloLinkedApps
{
    // Lớp LinkedList: cài đặt danh sách liên kết đơn giản, dùng cho cả danh sách và thẻ
    public class LinkedList
    {
        // Lớp Node đại diện cho một nút trong danh sách liên kết
        public class Node
        {
            public object element; // Dữ liệu lưu trữ (Card hoặc CardList)
            public Node next;      // Con trỏ tới nút tiếp theo

            public Node(object element)
            {
                this.element = element;
                next = null;
            }
        }

        private Node head; // Nút đầu tiên của danh sách
        private int count; // Số lượng phần tử trong danh sách

        public Node Head => head; // Truy cập nút đầu tiên
        public int Count() => count; // Lấy số lượng phần tử

        // Thêm phần tử mới vào sau phần tử có giá trị previous
        public void Insert(object element, object previous)
        {
            Node newNode = new Node(element);
            if (previous.Equals("Header") || head == null)
            {
                // Thêm vào đầu danh sách nếu previous là "Header" hoặc danh sách rỗng
                newNode.next = head;
                head = newNode;
            }
            else
            {
                Node current = head;
                // Tìm nút có element = previous
                while (current != null && !current.element.ToString().Equals(previous.ToString()))
                    current = current.next;
                if (current != null)
                {
                    // Chèn sau nút tìm được
                    newNode.next = current.next;
                    current.next = newNode;
                }
            }
            count++;
        }

        // Xóa phần tử có giá trị element khỏi danh sách
        public void Remove(object element)
        {
            if (head == null) return;
            if (head.element.ToString().Equals(element.ToString()))
            {
                head = head.next;
                count--;
                return;
            }
            Node current = head;
            while (current.next != null && !current.next.element.ToString().Equals(element.ToString()))
                current = current.next;
            if (current.next != null)
            {
                current.next = current.next.next;
                count--;
            }
        }

        // Tìm node có element bằng giá trị truyền vào
        public Node Find(object element)
        {
            Node current = head;
            while (current != null)
            {
                if (current.element.ToString().Equals(element.ToString()))
                    return current;
                current = current.next;
            }
            return null;
        }

        // Lấy element tại vị trí index (bắt đầu từ 0)
        public object GetAt(int index)
        {
            if (index < 0 || index >= count) return null;
            Node current = head;
            for (int i = 0; i < index && current != null; i++)
                current = current.next;
            return current?.element;
        }
               
        // Hàm hoán đổi hai thẻ trong LinkedList theo index
        private void SwapCards(LinkedList cards, int idx1, int idx2)
        {
            if (cards == null) return;
            var node1 = cards.Head;
            var node2 = cards.Head;
            for (int i = 0; i < idx1 && node1 != null; i++) node1 = node1.next;
            for (int i = 0; i < idx2 && node2 != null; i++) node2 = node2.next;
            if (node1 != null && node2 != null)
            {
                var temp = node1.element;
                node1.element = node2.element;
                node2.element = temp;
            }
        }
}
