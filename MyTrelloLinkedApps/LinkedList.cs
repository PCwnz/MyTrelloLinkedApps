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
        public Node FindPre(object element)//Tìm kiếm node trước node đầu vào
        {
            Node current = head;
            while (current.next != null && !current.next.element.ToString().Equals(element.ToString()))
            {
                current = current.next;
            }
            if (current.next == null)
                return null; // Case: Không tìm thấy
            return current;
        }
        public void SwapNodes(Node nodeA, Node nodeB)
        {
            if (nodeA == null || nodeB == null || nodeA == nodeB) return;
            // Lưu trữ các nút trước và sau của nodeA và nodeB

            nodeA = Find(nodeA.element);
            nodeB = Find(nodeB.element);

            Node prevA = FindPre(nodeA.element);
            Node prevB = FindPre(nodeB.element);
            //NodeA đứng trước NodeB
            if (nodeA.next == nodeB)
            {
                if (prevA != null)
                    prevA.next = nodeB;
                else
                    head = nodeB;

                nodeA.next = nodeB.next;
                nodeB.next = nodeA;
                return;
            }
            //NodeB đứng trước NodeA
            else if (nodeB.next == nodeA)
            {
                if (prevB != null)
                    prevB.next = nodeA;
                else
                    head = nodeA;

                nodeB.next = nodeA.next;
                nodeA.next = nodeB;
                return;
            }
            //Case : 2 node không liền kề nhau
            if (prevA != null) prevA.next = nodeB;
            else head = nodeB;

            if (prevB != null) prevB.next = nodeA;
            else head = nodeA;

            // Hoán đổi next
            Node temp = nodeA.next;
            nodeA.next = nodeB.next;
            nodeB.next = temp;
        }
        public void BubbleSortASC()//Bubble Sort theo thứ tự tăng dần
        {
            if (head == null || head.next == null)
                return;

            bool swapped;
            do
            {
                swapped = false;
                Node current = head;
                while (current.next != null)
                {
                    if (string.Compare(current.element.ToString(), current.next.element.ToString()) > 0)
                    {
                        SwapNodes(current, current.next);
                    }
                    current = current.next;
                }
            } while (swapped);
        }
    }
}
