namespace MyTrelloLinkedApps // Khai báo namespace cho dự án
{
    partial class Form1 // Định nghĩa partial class Form1 (phần thiết kế giao diện)
    {
        // Biến chứa các thành phần giao diện, dùng để giải phóng tài nguyên khi đóng form
        private System.ComponentModel.IContainer components = null; // Container cho các control

        // Hàm giải phóng tài nguyên khi form bị đóng
        protected override void Dispose(bool disposing) // Hàm hủy, giải phóng tài nguyên
        {
            if (disposing && (components != null)) // Nếu cần giải phóng và có component
                components.Dispose(); // Giải phóng
            base.Dispose(disposing); // Gọi hàm hủy của lớp cha
        }

        // Hàm khởi tạo và cấu hình các control trên form
        private void InitializeComponent() // Hàm tự động sinh ra, cấu hình giao diện
        {
            this.lstLists = new System.Windows.Forms.ListBox(); // ListBox hiển thị danh sách
            this.lstCards = new System.Windows.Forms.ListBox(); // ListBox hiển thị thẻ
            this.btnAddList = new System.Windows.Forms.Button(); // Nút thêm danh sách
            this.btnRemoveList = new System.Windows.Forms.Button(); // Nút xóa danh sách
            this.btnAddCard = new System.Windows.Forms.Button(); // Nút thêm thẻ
            this.btnRemoveCard = new System.Windows.Forms.Button(); // Nút xóa thẻ
            this.btnArchiveCard = new System.Windows.Forms.Button(); // Nút lưu trữ thẻ
            this.btnEditCard = new System.Windows.Forms.Button(); // Nút sửa thẻ
            this.btnMoveCard = new System.Windows.Forms.Button(); // Nút di chuyển thẻ
            this.lblLists = new System.Windows.Forms.Label(); // Label tiêu đề danh sách
            this.lblCards = new System.Windows.Forms.Label(); // Label tiêu đề thẻ
            this.btnChangeCardColor = new System.Windows.Forms.Button(); // Nút đổi màu thẻ
            this.btnShowArchivedCards = new System.Windows.Forms.Button(); // Nút xem thẻ đã lưu trữ
            this.btnMoveCardUp = new System.Windows.Forms.Button(); // Nút di chuyển thẻ lên
            this.btnMoveCardDown = new System.Windows.Forms.Button(); // Nút di chuyển thẻ xuống
            this.SuspendLayout(); // Bắt đầu cấu hình giao diện
            // 
            // lstLists
            // 
            this.lstLists.FormattingEnabled = true; // Cho phép hiển thị danh sách
            this.lstLists.ItemHeight = 16; // Chiều cao mỗi item
            this.lstLists.Location = new System.Drawing.Point(14, 92); // Vị trí trên form
            this.lstLists.Name = "lstLists"; // Tên biến
            this.lstLists.Size = new System.Drawing.Size(265, 260); // Kích thước
            this.lstLists.TabIndex = 0; // Thứ tự tab
            // 
            // lstCards
            // 
            this.lstCards.FormattingEnabled = true;
            this.lstCards.ItemHeight = 16;
            this.lstCards.Location = new System.Drawing.Point(301, 94);
            this.lstCards.Name = "lstCards";
            this.lstCards.Size = new System.Drawing.Size(265, 212);
            this.lstCards.TabIndex = 1;
            // 
            // btnAddList
            // 
            this.btnAddList.Location = new System.Drawing.Point(14, 367);
            this.btnAddList.Name = "btnAddList";
            this.btnAddList.Size = new System.Drawing.Size(127, 72);
            this.btnAddList.TabIndex = 2;
            this.btnAddList.Text = "Thêm danh sách";
            this.btnAddList.UseVisualStyleBackColor = true;
            // 
            // btnRemoveList
            // 
            this.btnRemoveList.Location = new System.Drawing.Point(152, 367);
            this.btnRemoveList.Name = "btnRemoveList";
            this.btnRemoveList.Size = new System.Drawing.Size(127, 72);
            this.btnRemoveList.TabIndex = 3;
            this.btnRemoveList.Text = "Xóa danh sách";
            this.btnRemoveList.UseVisualStyleBackColor = true;
            // 
            // btnAddCard
            // 
            this.btnAddCard.Location = new System.Drawing.Point(299, 324);
            this.btnAddCard.Name = "btnAddCard";
            this.btnAddCard.Size = new System.Drawing.Size(127, 28);
            this.btnAddCard.TabIndex = 4;
            this.btnAddCard.Text = "Thêm thẻ";
            this.btnAddCard.UseVisualStyleBackColor = true;
            // 
            // btnRemoveCard
            // 
            this.btnRemoveCard.Location = new System.Drawing.Point(434, 324);
            this.btnRemoveCard.Name = "btnRemoveCard";
            this.btnRemoveCard.Size = new System.Drawing.Size(132, 28);
            this.btnRemoveCard.TabIndex = 5;
            this.btnRemoveCard.Text = "Xóa thẻ";
            this.btnRemoveCard.UseVisualStyleBackColor = true;
            // 
            // btnArchiveCard
            // 
            this.btnArchiveCard.Location = new System.Drawing.Point(299, 411);
            this.btnArchiveCard.Name = "btnArchiveCard";
            this.btnArchiveCard.Size = new System.Drawing.Size(127, 28);
            this.btnArchiveCard.TabIndex = 6;
            this.btnArchiveCard.Text = "Lưu trữ thẻ";
            this.btnArchiveCard.UseVisualStyleBackColor = true;
            // 
            // btnEditCard
            // 
            this.btnEditCard.Location = new System.Drawing.Point(434, 411);
            this.btnEditCard.Name = "btnEditCard";
            this.btnEditCard.Size = new System.Drawing.Size(132, 28);
            this.btnEditCard.TabIndex = 7;
            this.btnEditCard.Text = "Sửa thẻ";
            this.btnEditCard.UseVisualStyleBackColor = true;
            // 
            // btnMoveCard
            // 
            this.btnMoveCard.Location = new System.Drawing.Point(299, 367);
            this.btnMoveCard.Name = "btnMoveCard";
            this.btnMoveCard.Size = new System.Drawing.Size(127, 28);
            this.btnMoveCard.TabIndex = 8;
            this.btnMoveCard.Text = "Di chuyển thẻ";
            this.btnMoveCard.UseVisualStyleBackColor = true;
            // 
            // lblLists
            // 
            this.lblLists.AutoSize = true;
            this.lblLists.Location = new System.Drawing.Point(12, 67);
            this.lblLists.Name = "lblLists";
            this.lblLists.Size = new System.Drawing.Size(71, 16);
            this.lblLists.TabIndex = 9;
            this.lblLists.Text = "Danh sách";
            this.lblLists.Click += new System.EventHandler(this.lblLists_Click); // Sự kiện click label
            // 
            // lblCards
            // 
            this.lblCards.AutoSize = true;
            this.lblCards.Location = new System.Drawing.Point(298, 67);
            this.lblCards.Name = "lblCards";
            this.lblCards.Size = new System.Drawing.Size(129, 16);
            this.lblCards.TabIndex = 10;
            this.lblCards.Text = "Thẻ trong danh sách";
            this.lblCards.Click += new System.EventHandler(this.lblCards_Click);
            // 
            // btnChangeCardColor
            // 
            this.btnChangeCardColor.Location = new System.Drawing.Point(434, 367);
            this.btnChangeCardColor.Name = "btnChangeCardColor";
            this.btnChangeCardColor.Size = new System.Drawing.Size(132, 28);
            this.btnChangeCardColor.TabIndex = 11;
            this.btnChangeCardColor.Text = "Đổi màu thẻ";
            this.btnChangeCardColor.UseVisualStyleBackColor = true;
            // 
            // btnShowArchivedCards
            // 
            this.btnShowArchivedCards.Location = new System.Drawing.Point(299, 445);
            this.btnShowArchivedCards.Name = "btnShowArchivedCards";
            this.btnShowArchivedCards.Size = new System.Drawing.Size(126, 28);
            this.btnShowArchivedCards.TabIndex = 12;
            this.btnShowArchivedCards.Text = "Xem thẻ đã lưu trữ";
            this.btnShowArchivedCards.UseVisualStyleBackColor = true;
            this.btnShowArchivedCards.Click += new System.EventHandler(this.btnShowArchivedCards_Click_1);
            // 
            // btnMoveCardUp
            // 
            this.btnMoveCardUp.Location = new System.Drawing.Point(434, 445);
            this.btnMoveCardUp.Name = "btnMoveCardUp";
            this.btnMoveCardUp.Size = new System.Drawing.Size(60, 28);
            this.btnMoveCardUp.TabIndex = 13;
            this.btnMoveCardUp.Text = "↑";
            this.btnMoveCardUp.UseVisualStyleBackColor = true;
            this.btnMoveCardUp.Click += new System.EventHandler(this.btnMoveCardUp_Click_1);
            // 
            // btnMoveCardDown
            // 
            this.btnMoveCardDown.Location = new System.Drawing.Point(506, 445);
            this.btnMoveCardDown.Name = "btnMoveCardDown";
            this.btnMoveCardDown.Size = new System.Drawing.Size(60, 28);
            this.btnMoveCardDown.TabIndex = 14;
            this.btnMoveCardDown.Text = "↓";
            this.btnMoveCardDown.UseVisualStyleBackColor = true;
            this.btnMoveCardDown.Click += new System.EventHandler(this.btnMoveCardDown_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F); // Tỉ lệ tự động
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font; // Chế độ tự động scale
            this.ClientSize = new System.Drawing.Size(696, 600); // Kích thước form
            this.Controls.Add(this.lblCards); // Thêm control vào form
            this.Controls.Add(this.lblLists);
            this.Controls.Add(this.btnMoveCard);
            this.Controls.Add(this.btnEditCard);
            this.Controls.Add(this.btnArchiveCard);
            this.Controls.Add(this.btnRemoveCard);
            this.Controls.Add(this.btnAddCard);
            this.Controls.Add(this.btnRemoveList);
            this.Controls.Add(this.btnAddList);
            this.Controls.Add(this.lstCards);
            this.Controls.Add(this.lstLists);
            this.Controls.Add(this.btnChangeCardColor);
            this.Controls.Add(this.btnShowArchivedCards);
            this.Controls.Add(this.btnMoveCardUp);
            this.Controls.Add(this.btnMoveCardDown);
            this.Name = "Form1"; // Tên form
            this.Text = "Trello LinkedList"; // Tiêu đề form
            this.Load += new System.EventHandler(this.Form1_Load); // Sự kiện load form
            this.ResumeLayout(false); // Kết thúc cấu hình giao diện
            this.PerformLayout(); // Áp dụng layout

        }

        // Khai báo các biến thành viên cho các control trên form
        private System.Windows.Forms.ListBox lstLists; // ListBox hiển thị danh sách
        private System.Windows.Forms.ListBox lstCards; // ListBox hiển thị thẻ
        private System.Windows.Forms.Button btnAddList; // Nút thêm danh sách
        private System.Windows.Forms.Button btnRemoveList; // Nút xóa danh sách
        private System.Windows.Forms.Button btnAddCard; // Nút thêm thẻ
        private System.Windows.Forms.Button btnRemoveCard; // Nút xóa thẻ
        private System.Windows.Forms.Button btnArchiveCard; // Nút lưu trữ thẻ
        private System.Windows.Forms.Button btnEditCard; // Nút sửa thẻ
        private System.Windows.Forms.Button btnMoveCard; // Nút di chuyển thẻ
        private System.Windows.Forms.Label lblLists; // Label tiêu đề danh sách
        private System.Windows.Forms.Label lblCards; // Label tiêu đề thẻ
        private System.Windows.Forms.Button btnChangeCardColor; // Nút đổi màu thẻ
        private System.Windows.Forms.Button btnShowArchivedCards; // Nút xem thẻ đã lưu trữ
        private System.Windows.Forms.Button btnMoveCardUp; // Nút di chuyển thẻ lên
        private System.Windows.Forms.Button btnMoveCardDown; // Nút di chuyển thẻ xuống
    }
}



