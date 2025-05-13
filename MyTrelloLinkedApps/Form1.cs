using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace MyTrelloLinkedApps
{
    // Lớp Form1 là form chính của ứng dụng, kế thừa từ Form
    public partial class Form1 : Form
    {
        // Biến board lưu trữ toàn bộ các danh sách (List) trên bảng Trello
        private Board board = new Board();

        // Hàm khởi tạo form, đăng ký các sự kiện cho các nút và listbox
        public Form1()
        {
            InitializeComponent();

            // Đăng ký các sự kiện click cho các nút
            btnAddList.Click += btnAddList_Click;
            btnRemoveList.Click += btnRemoveList_Click;
            btnAddCard.Click += btnAddCard_Click;
            btnRemoveCard.Click += btnRemoveCard_Click;
            btnArchiveCard.Click += btnArchiveCard_Click;
            btnEditCard.Click += btnEditCard_Click;
            btnMoveCard.Click += btnMoveCard_Click;
            lstLists.SelectedIndexChanged += lstLists_SelectedIndexChanged;

            // Khởi tạo dữ liệu mẫu ban đầu cho ứng dụng
            KhoiTaoDuLieuMau();
            // Cập nhật giao diện danh sách
            CapNhatDanhSach();
        }

        // Hàm tạo dữ liệu mẫu cho ứng dụng (3 danh sách: Việc cần làm, Đang làm, Đã xong)
        private void KhoiTaoDuLieuMau()
        {
            var todo = new CardList("Việc cần làm");
            todo.Cards.Insert(new Card("Học C#", "Ôn lại kiến thức cơ bản", "Header"), "Header");
            todo.Cards.Insert(new Card("Làm bài tập", "Hoàn thành bài tập LinkedList", "Học C#"), "Học C#");

            var doing = new CardList("Đang làm");
            doing.Cards.Insert(new Card("Viết báo cáo", "Báo cáo môn học", "Header"), "Header");

            var done = new CardList("Đã xong");
            done.Cards.Insert(new Card("Nộp bài", "Nộp bài lên LMS", "Header"), "Header");

            // Thêm các danh sách vào board theo thứ tự
            board.Lists.Insert(todo, "Header");
            board.Lists.Insert(doing, "Việc cần làm");
            board.Lists.Insert(done, "Đang làm");
        }

        // Hàm cập nhật giao diện ListBox lstLists với các danh sách hiện có
        private void CapNhatDanhSach()
        {
            lstLists.Items.Clear();
            if (board?.Lists == null) return;

            for (int i = 0; i < board.Lists.Count(); i++)
            {
                var list = board.Lists.GetAt(i) as CardList;
                if (list != null)
                {
                    lstLists.Items.Add(list.Name);
                }
            }
        }

        // Hàm cập nhật giao diện ListBox lstCards với các thẻ trong danh sách đang chọn
        private void CapNhatThe()
        {
            lstCards.Items.Clear();
            if (lstLists.SelectedIndex == -1) return;

            var list = board.Lists.GetAt(lstLists.SelectedIndex) as CardList;
            if (list?.Cards == null) return;

            for (int i = 0; i < list.Cards.Count(); i++)
            {
                var card = list.Cards.GetAt(i) as Card;
                if (card != null && !card.IsArchived)
                {
                    lstCards.Items.Add(card.Title);
                }
            }
        }

        // Sự kiện click nút Thêm danh sách
        private void btnAddList_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại nhập tên danh sách mới
            string name = Interaction.InputBox("Nhập tên danh sách:", "Thêm danh sách");
            if (!string.IsNullOrWhiteSpace(name))
            {
                object last = "Header";
                if (board.Lists.Count() > 0)
                {
                    var lastList = board.Lists.GetAt(board.Lists.Count() - 1) as CardList;
                    if (lastList != null)
                    {
                        last = lastList.Name;
                    }
                }
                // Thêm danh sách mới vào cuối board
                board.Lists.Insert(new CardList(name), last);
                CapNhatDanhSach();
                lstLists.SelectedIndex = lstLists.Items.Count - 1;
            }
        }

        // Sự kiện click nút Xóa danh sách
        private void btnRemoveList_Click(object sender, EventArgs e)
        {
            if (lstLists.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn danh sách cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedList = lstLists.SelectedItem.ToString();
            board.Lists.Remove(selectedList);
            CapNhatDanhSach();
        }

        // Sự kiện click nút Thêm thẻ
        private void btnAddCard_Click(object sender, EventArgs e)
        {
            if (lstLists.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn danh sách trước khi thêm thẻ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Nhập tiêu đề thẻ
            string title = Interaction.InputBox("Nhập tiêu đề thẻ:", "Thêm thẻ");
            if (string.IsNullOrWhiteSpace(title)) return;

            // Nhập mô tả thẻ
            string desc = Interaction.InputBox("Nhập mô tả thẻ:", "Thêm thẻ");

            var list = board.Lists.GetAt(lstLists.SelectedIndex) as CardList;
            if (list == null) return;

            object last = "Header";
            if (list.Cards.Count() > 0)
            {
                var lastCard = list.Cards.GetAt(list.Cards.Count() - 1) as Card;
                if (lastCard != null)
                {
                    last = lastCard.Title;
                }
            }

            // Thêm thẻ mới vào cuối danh sách
            list.Cards.Insert(new Card(title, desc, last), last);
            CapNhatThe();
        }

        // Sự kiện click nút Xóa thẻ
        private void btnRemoveCard_Click(object sender, EventArgs e)
        {
            if (lstLists.SelectedIndex == -1 || lstCards.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn thẻ cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var list = board.Lists.GetAt(lstLists.SelectedIndex) as CardList;
            if (list == null) return;

            string title = lstCards.SelectedItem.ToString();
            list.Cards.Remove(title);
            CapNhatThe();
        }

        // Sự kiện click nút Lưu trữ thẻ
        private void btnArchiveCard_Click(object sender, EventArgs e)
        {
            if (lstLists.SelectedIndex == -1 || lstCards.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn thẻ cần lưu trữ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var list = board.Lists.GetAt(lstLists.SelectedIndex) as CardList;
            if (list == null) return;

            string title = lstCards.SelectedItem.ToString();
            var cardNode = list.Cards.Find(title);
            if (cardNode != null)
            {
                var card = cardNode.element as Card;
                if (card != null)
                {
                    // Đánh dấu thẻ là đã lưu trữ (ẩn khỏi giao diện)
                    card.IsArchived = true;
                    CapNhatThe();
                }
            }
        }

        // Sự kiện click nút Sửa thẻ
        private void btnEditCard_Click(object sender, EventArgs e)
        {
            if (lstLists.SelectedIndex == -1 || lstCards.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn thẻ cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var list = board.Lists.GetAt(lstLists.SelectedIndex) as CardList;
            if (list == null) return;

            string oldTitle = lstCards.SelectedItem.ToString();
            var cardNode = list.Cards.Find(oldTitle);
            if (cardNode == null) return;

            var card = cardNode.element as Card;
            if (card == null) return;

            // Nhập tiêu đề mới cho thẻ
            string newTitle = Interaction.InputBox("Nhập tiêu đề mới:", "Sửa thẻ", card.Title);
            if (string.IsNullOrWhiteSpace(newTitle)) return;

            // Nhập mô tả mới cho thẻ
            string newDesc = Interaction.InputBox("Nhập mô tả mới:", "Sửa thẻ", card.Description);

            card.Title = newTitle;
            card.Description = newDesc;
            CapNhatThe();
        }

        // Sự kiện click nút Di chuyển thẻ sang danh sách khác
        private void btnMoveCard_Click(object sender, EventArgs e)
        {
            if (lstLists.SelectedIndex == -1 || lstCards.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn thẻ cần di chuyển", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo một bản sao của các danh sách hiện có, loại trừ danh sách đang chọn
            var availableLists = new System.Collections.Generic.List<string>();
            foreach (var item in lstLists.Items)
            {
                if (item.ToString() != lstLists.SelectedItem.ToString())
                {
                    availableLists.Add(item.ToString());
                }
            }

            if (availableLists.Count == 0)
            {
                MessageBox.Show("Không có danh sách nào khác để di chuyển", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Sử dụng ListBox mới để chọn danh sách đích
            var listBox = new ListBox();
            listBox.Items.AddRange(availableLists.ToArray());

            using (var form = new Form())
            {
                form.Text = "Chọn danh sách đích";
                var btnOK = new Button() { Text = "OK", DialogResult = DialogResult.OK };

                listBox.Dock = DockStyle.Top;
                btnOK.Dock = DockStyle.Bottom;

                form.Controls.Add(listBox);
                form.Controls.Add(btnOK);
                form.AcceptButton = btnOK;
                form.StartPosition = FormStartPosition.CenterParent;
                form.ClientSize = new Size(300, 200);

                if (form.ShowDialog() == DialogResult.OK && listBox.SelectedIndex != -1)
                {
                    var sourceList = board.Lists.GetAt(lstLists.SelectedIndex) as CardList;
                    var destListName = listBox.SelectedItem.ToString();
                    var destListNode = board.Lists.Find(destListName);
                    var destList = destListNode?.element as CardList;

                    if (sourceList != null && destList != null)
                    {
                        string cardTitle = lstCards.SelectedItem.ToString();
                        var cardNode = sourceList.Cards.Find(cardTitle);
                        if (cardNode != null)
                        {
                            var card = cardNode.element as Card;

                            // Tạo bản sao thẻ trước khi xóa khỏi danh sách nguồn
                            var cardCopy = new Card(card.Title, card.Description, card.Previous)
                            {
                                IsArchived = card.IsArchived
                            };

                            // Xóa thẻ khỏi danh sách nguồn
                            sourceList.Cards.Remove(cardTitle);

                            // Thêm thẻ vào cuối danh sách đích
                            object last = "Header";
                            if (destList.Cards.Count() > 0)
                            {
                                var lastCard = destList.Cards.GetAt(destList.Cards.Count() - 1) as Card;
                                if (lastCard != null)
                                {
                                    last = lastCard.Title;
                                }
                            }

                            destList.Cards.Insert(cardCopy, last);

                            // Cập nhật giao diện: chuyển sang danh sách đích
                            CapNhatThe();
                            lstLists.SelectedIndex = lstLists.Items.IndexOf(destListName);
                        }
                    }
                }
            }
        }

        // Sự kiện khi chọn danh sách khác trên ListBox lstLists
        private void lstLists_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhatThe();
        }
    }

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
        public class Node2
        {
            public object element; // Dữ liệu lưu trữ (Card hoặc CardList)
            public Node2 flink;// Con trỏ tới nút tiếp theo
            public Node2 blink;// Con trỏ tới nút trước đó
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

    // Lớp CardList: đại diện cho một danh sách (List) chứa các thẻ (Card)
    public class CardList
    {
        public string Name { get; set; }              // Tên danh sách
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

    // Lớp Board: đại diện cho bảng Trello, chứa nhiều danh sách (List)
    public class Board
    {
        public LinkedList Lists { get; } = new LinkedList(); // Danh sách các list trên board
    }
}
