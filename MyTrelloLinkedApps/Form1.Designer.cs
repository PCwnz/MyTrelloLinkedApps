namespace MyTrelloLinkedApps
{
    partial class Form1
    {
        // Biến chứa các thành phần giao diện, dùng để giải phóng tài nguyên khi đóng form
        private System.ComponentModel.IContainer components = null;

        // Hàm giải phóng tài nguyên khi form bị đóng
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        // Hàm khởi tạo và cấu hình các control trên form
        private void InitializeComponent()
        {
            // ListBox hiển thị danh sách các danh sách (List của Trello)
            this.lstLists = new System.Windows.Forms.ListBox();
            // ListBox hiển thị các thẻ (Card) trong danh sách được chọn
            this.lstCards = new System.Windows.Forms.ListBox();
            // Nút thêm danh sách mới
            this.btnAddList = new System.Windows.Forms.Button();
            // Nút xóa danh sách được chọn
            this.btnRemoveList = new System.Windows.Forms.Button();
            // Nút thêm thẻ mới vào danh sách đang chọn
            this.btnAddCard = new System.Windows.Forms.Button();
            // Nút xóa thẻ được chọn
            this.btnRemoveCard = new System.Windows.Forms.Button();
            // Nút lưu trữ (archive) thẻ được chọn
            this.btnArchiveCard = new System.Windows.Forms.Button();
            // Nút sửa thông tin thẻ được chọn
            this.btnEditCard = new System.Windows.Forms.Button();
            // Nút di chuyển thẻ sang danh sách khác
            this.btnMoveCard = new System.Windows.Forms.Button();
            // Label tiêu đề cho danh sách
            this.lblLists = new System.Windows.Forms.Label();
            // Label tiêu đề cho thẻ
            this.lblCards = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstLists
            // 
            // Thiết lập vị trí, kích thước, tên biến cho ListBox danh sách
            this.lstLists.FormattingEnabled = true;
            this.lstLists.ItemHeight = 16;
            this.lstLists.Location = new System.Drawing.Point(16, 36);
            this.lstLists.Name = "lstLists";
            this.lstLists.Size = new System.Drawing.Size(265, 468);
            this.lstLists.TabIndex = 0;
            // 
            // lstCards
            // 
            // Thiết lập vị trí, kích thước, tên biến cho ListBox thẻ
            this.lstCards.FormattingEnabled = true;
            this.lstCards.ItemHeight = 16;
            this.lstCards.Location = new System.Drawing.Point(303, 38);
            this.lstCards.Name = "lstCards";
            this.lstCards.Size = new System.Drawing.Size(265, 468);
            this.lstCards.TabIndex = 1;
            // 
            // btnAddList
            // 
            // Nút thêm danh sách mới
            this.btnAddList.Location = new System.Drawing.Point(16, 512);
            this.btnAddList.Name = "btnAddList";
            this.btnAddList.Size = new System.Drawing.Size(127, 28);
            this.btnAddList.TabIndex = 2;
            this.btnAddList.Text = "Thêm danh sách";
            this.btnAddList.UseVisualStyleBackColor = true;
            // 
            // btnRemoveList
            // 
            // Nút xóa danh sách được chọn
            this.btnRemoveList.Location = new System.Drawing.Point(156, 512);
            this.btnRemoveList.Name = "btnRemoveList";
            this.btnRemoveList.Size = new System.Drawing.Size(127, 28);
            this.btnRemoveList.TabIndex = 3;
            this.btnRemoveList.Text = "Xóa danh sách";
            this.btnRemoveList.UseVisualStyleBackColor = true;
            // 
            // btnAddCard
            // 
            // Nút thêm thẻ mới vào danh sách đang chọn
            this.btnAddCard.Location = new System.Drawing.Point(303, 512);
            this.btnAddCard.Name = "btnAddCard";
            this.btnAddCard.Size = new System.Drawing.Size(125, 28);
            this.btnAddCard.TabIndex = 4;
            this.btnAddCard.Text = "Thêm thẻ";
            this.btnAddCard.UseVisualStyleBackColor = true;
            // 
            // btnRemoveCard
            // 
            // Nút xóa thẻ được chọn
            this.btnRemoveCard.Location = new System.Drawing.Point(436, 512);
            this.btnRemoveCard.Name = "btnRemoveCard";
            this.btnRemoveCard.Size = new System.Drawing.Size(132, 28);
            this.btnRemoveCard.TabIndex = 5;
            this.btnRemoveCard.Text = "Xóa thẻ";
            this.btnRemoveCard.UseVisualStyleBackColor = true;
            // 
            // btnArchiveCard
            // 
            // Nút lưu trữ (archive) thẻ được chọn
            this.btnArchiveCard.Location = new System.Drawing.Point(13, 548);
            this.btnArchiveCard.Name = "btnArchiveCard";
            this.btnArchiveCard.Size = new System.Drawing.Size(130, 28);
            this.btnArchiveCard.TabIndex = 6;
            this.btnArchiveCard.Text = "Lưu trữ thẻ";
            this.btnArchiveCard.UseVisualStyleBackColor = true;
            // 
            // btnEditCard
            // 
            // Nút sửa thông tin thẻ được chọn
            this.btnEditCard.Location = new System.Drawing.Point(156, 548);
            this.btnEditCard.Name = "btnEditCard";
            this.btnEditCard.Size = new System.Drawing.Size(127, 28);
            this.btnEditCard.TabIndex = 7;
            this.btnEditCard.Text = "Sửa thẻ";
            this.btnEditCard.UseVisualStyleBackColor = true;
            // 
            // btnMoveCard
            // 
            // Nút di chuyển thẻ sang danh sách khác
            this.btnMoveCard.Location = new System.Drawing.Point(303, 548);
            this.btnMoveCard.Name = "btnMoveCard";
            this.btnMoveCard.Size = new System.Drawing.Size(123, 28);
            this.btnMoveCard.TabIndex = 8;
            this.btnMoveCard.Text = "Di chuyển thẻ";
            this.btnMoveCard.UseVisualStyleBackColor = true;
            // 
            // lblLists
            // 
            // Label tiêu đề cho danh sách
            this.lblLists.AutoSize = true;
            this.lblLists.Location = new System.Drawing.Point(16, 11);
            this.lblLists.Name = "lblLists";
            this.lblLists.Size = new System.Drawing.Size(71, 16);
            this.lblLists.TabIndex = 9;
            this.lblLists.Text = "Danh sách";
            // 
            // lblCards
            // 
            // Label tiêu đề cho thẻ
            this.lblCards.AutoSize = true;
            this.lblCards.Location = new System.Drawing.Point(300, 11);
            this.lblCards.Name = "lblCards";
            this.lblCards.Size = new System.Drawing.Size(129, 16);
            this.lblCards.TabIndex = 10;
            this.lblCards.Text = "Thẻ trong danh sách";
            // 
            // Form1
            // 
            // Thiết lập các thuộc tính chung cho Form1 (kích thước, tên, tiêu đề, v.v.)
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 573);
            this.Controls.Add(this.lblCards);
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
            this.Name = "Form1";
            this.Text = "Trello LinkedList";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}
