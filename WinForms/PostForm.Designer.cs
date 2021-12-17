
namespace WinForms
{
    partial class PostForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewPosts = new System.Windows.Forms.DataGridView();
            this.dataGridViewComments = new System.Windows.Forms.DataGridView();
            this.dataGridViewLikes = new System.Windows.Forms.DataGridView();
            this.labelPostID = new System.Windows.Forms.Label();
            this.textBoxPostID = new System.Windows.Forms.TextBox();
            this.textBoxPostText = new System.Windows.Forms.TextBox();
            this.labelPostText = new System.Windows.Forms.Label();
            this.labelUserIDCommentAuthor = new System.Windows.Forms.Label();
            this.textBoxCommentAuthorID = new System.Windows.Forms.TextBox();
            this.textBoxCommentText = new System.Windows.Forms.TextBox();
            this.buttonAddCommment = new System.Windows.Forms.Button();
            this.buttonDeleteComment = new System.Windows.Forms.Button();
            this.labelLikeAuthorID = new System.Windows.Forms.Label();
            this.textBoxLikeAuthorID = new System.Windows.Forms.TextBox();
            this.buttonDeleteLike = new System.Windows.Forms.Button();
            this.buttonAddLike = new System.Windows.Forms.Button();
            this.labelComments = new System.Windows.Forms.Label();
            this.labelLikes = new System.Windows.Forms.Label();
            this.labelPosts = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPosts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLikes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPosts
            // 
            this.dataGridViewPosts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPosts.Location = new System.Drawing.Point(12, 40);
            this.dataGridViewPosts.Name = "dataGridViewPosts";
            this.dataGridViewPosts.Size = new System.Drawing.Size(267, 509);
            this.dataGridViewPosts.TabIndex = 0;
            this.dataGridViewPosts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPosts_CellClick);
            // 
            // dataGridViewComments
            // 
            this.dataGridViewComments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewComments.Location = new System.Drawing.Point(322, 141);
            this.dataGridViewComments.Name = "dataGridViewComments";
            this.dataGridViewComments.Size = new System.Drawing.Size(189, 186);
            this.dataGridViewComments.TabIndex = 1;
            this.dataGridViewComments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewComments_CellClick);
            // 
            // dataGridViewLikes
            // 
            this.dataGridViewLikes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLikes.Location = new System.Drawing.Point(322, 379);
            this.dataGridViewLikes.Name = "dataGridViewLikes";
            this.dataGridViewLikes.Size = new System.Drawing.Size(189, 170);
            this.dataGridViewLikes.TabIndex = 2;
            this.dataGridViewLikes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLikes_CellClick);
            // 
            // labelPostID
            // 
            this.labelPostID.AutoSize = true;
            this.labelPostID.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPostID.Location = new System.Drawing.Point(329, 30);
            this.labelPostID.Name = "labelPostID";
            this.labelPostID.Size = new System.Drawing.Size(48, 19);
            this.labelPostID.TabIndex = 3;
            this.labelPostID.Text = "PostID";
            // 
            // textBoxPostID
            // 
            this.textBoxPostID.Location = new System.Drawing.Point(391, 30);
            this.textBoxPostID.Name = "textBoxPostID";
            this.textBoxPostID.Size = new System.Drawing.Size(100, 20);
            this.textBoxPostID.TabIndex = 4;
            // 
            // textBoxPostText
            // 
            this.textBoxPostText.Location = new System.Drawing.Point(562, 27);
            this.textBoxPostText.Multiline = true;
            this.textBoxPostText.Name = "textBoxPostText";
            this.textBoxPostText.Size = new System.Drawing.Size(226, 131);
            this.textBoxPostText.TabIndex = 5;
            // 
            // labelPostText
            // 
            this.labelPostText.AutoSize = true;
            this.labelPostText.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPostText.Location = new System.Drawing.Point(656, 5);
            this.labelPostText.Name = "labelPostText";
            this.labelPostText.Size = new System.Drawing.Size(34, 19);
            this.labelPostText.TabIndex = 6;
            this.labelPostText.Text = "Text";
            // 
            // labelUserIDCommentAuthor
            // 
            this.labelUserIDCommentAuthor.AutoSize = true;
            this.labelUserIDCommentAuthor.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUserIDCommentAuthor.Location = new System.Drawing.Point(616, 176);
            this.labelUserIDCommentAuthor.Name = "labelUserIDCommentAuthor";
            this.labelUserIDCommentAuthor.Size = new System.Drawing.Size(132, 19);
            this.labelUserIDCommentAuthor.TabIndex = 7;
            this.labelUserIDCommentAuthor.Text = "Comment Author ID";
            // 
            // textBoxCommentAuthorID
            // 
            this.textBoxCommentAuthorID.Location = new System.Drawing.Point(606, 198);
            this.textBoxCommentAuthorID.Name = "textBoxCommentAuthorID";
            this.textBoxCommentAuthorID.Size = new System.Drawing.Size(139, 20);
            this.textBoxCommentAuthorID.TabIndex = 8;
            // 
            // textBoxCommentText
            // 
            this.textBoxCommentText.Location = new System.Drawing.Point(562, 224);
            this.textBoxCommentText.Multiline = true;
            this.textBoxCommentText.Name = "textBoxCommentText";
            this.textBoxCommentText.Size = new System.Drawing.Size(226, 103);
            this.textBoxCommentText.TabIndex = 9;
            // 
            // buttonAddCommment
            // 
            this.buttonAddCommment.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddCommment.Location = new System.Drawing.Point(702, 347);
            this.buttonAddCommment.Name = "buttonAddCommment";
            this.buttonAddCommment.Size = new System.Drawing.Size(86, 27);
            this.buttonAddCommment.TabIndex = 10;
            this.buttonAddCommment.Text = "Comment";
            this.buttonAddCommment.UseVisualStyleBackColor = true;
            this.buttonAddCommment.Click += new System.EventHandler(this.buttonAddCommment_Click);
            // 
            // buttonDeleteComment
            // 
            this.buttonDeleteComment.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteComment.Location = new System.Drawing.Point(562, 347);
            this.buttonDeleteComment.Name = "buttonDeleteComment";
            this.buttonDeleteComment.Size = new System.Drawing.Size(107, 27);
            this.buttonDeleteComment.TabIndex = 11;
            this.buttonDeleteComment.Text = "Delete";
            this.buttonDeleteComment.UseVisualStyleBackColor = true;
            this.buttonDeleteComment.Click += new System.EventHandler(this.buttonDeleteComment_Click);
            // 
            // labelLikeAuthorID
            // 
            this.labelLikeAuthorID.AutoSize = true;
            this.labelLikeAuthorID.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLikeAuthorID.Location = new System.Drawing.Point(629, 408);
            this.labelLikeAuthorID.Name = "labelLikeAuthorID";
            this.labelLikeAuthorID.Size = new System.Drawing.Size(99, 19);
            this.labelLikeAuthorID.TabIndex = 12;
            this.labelLikeAuthorID.Text = "Like Author ID";
            // 
            // textBoxLikeAuthorID
            // 
            this.textBoxLikeAuthorID.Location = new System.Drawing.Point(606, 430);
            this.textBoxLikeAuthorID.Name = "textBoxLikeAuthorID";
            this.textBoxLikeAuthorID.Size = new System.Drawing.Size(139, 20);
            this.textBoxLikeAuthorID.TabIndex = 13;
            // 
            // buttonDeleteLike
            // 
            this.buttonDeleteLike.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteLike.Location = new System.Drawing.Point(562, 483);
            this.buttonDeleteLike.Name = "buttonDeleteLike";
            this.buttonDeleteLike.Size = new System.Drawing.Size(107, 29);
            this.buttonDeleteLike.TabIndex = 14;
            this.buttonDeleteLike.Text = "Delete";
            this.buttonDeleteLike.UseVisualStyleBackColor = true;
            this.buttonDeleteLike.Click += new System.EventHandler(this.buttonDeleteLike_Click);
            // 
            // buttonAddLike
            // 
            this.buttonAddLike.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddLike.Location = new System.Drawing.Point(702, 483);
            this.buttonAddLike.Name = "buttonAddLike";
            this.buttonAddLike.Size = new System.Drawing.Size(86, 29);
            this.buttonAddLike.TabIndex = 15;
            this.buttonAddLike.Text = "Like";
            this.buttonAddLike.UseVisualStyleBackColor = true;
            this.buttonAddLike.Click += new System.EventHandler(this.buttonAddLike_Click);
            // 
            // labelComments
            // 
            this.labelComments.AutoSize = true;
            this.labelComments.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelComments.Location = new System.Drawing.Point(372, 107);
            this.labelComments.Name = "labelComments";
            this.labelComments.Size = new System.Drawing.Size(75, 19);
            this.labelComments.TabIndex = 16;
            this.labelComments.Text = "Comments";
            // 
            // labelLikes
            // 
            this.labelLikes.AutoSize = true;
            this.labelLikes.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLikes.Location = new System.Drawing.Point(387, 349);
            this.labelLikes.Name = "labelLikes";
            this.labelLikes.Size = new System.Drawing.Size(42, 19);
            this.labelLikes.TabIndex = 17;
            this.labelLikes.Text = "Likes";
            // 
            // labelPosts
            // 
            this.labelPosts.AutoSize = true;
            this.labelPosts.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPosts.Location = new System.Drawing.Point(110, 9);
            this.labelPosts.Name = "labelPosts";
            this.labelPosts.Size = new System.Drawing.Size(50, 23);
            this.labelPosts.TabIndex = 18;
            this.labelPosts.Text = "Posts";
            // 
            // PostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.labelPosts);
            this.Controls.Add(this.labelLikes);
            this.Controls.Add(this.labelComments);
            this.Controls.Add(this.buttonAddLike);
            this.Controls.Add(this.buttonDeleteLike);
            this.Controls.Add(this.textBoxLikeAuthorID);
            this.Controls.Add(this.labelLikeAuthorID);
            this.Controls.Add(this.buttonDeleteComment);
            this.Controls.Add(this.buttonAddCommment);
            this.Controls.Add(this.textBoxCommentText);
            this.Controls.Add(this.textBoxCommentAuthorID);
            this.Controls.Add(this.labelUserIDCommentAuthor);
            this.Controls.Add(this.labelPostText);
            this.Controls.Add(this.textBoxPostText);
            this.Controls.Add(this.textBoxPostID);
            this.Controls.Add(this.labelPostID);
            this.Controls.Add(this.dataGridViewLikes);
            this.Controls.Add(this.dataGridViewComments);
            this.Controls.Add(this.dataGridViewPosts);
            this.Name = "PostForm";
            this.Text = "PostForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPosts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLikes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPosts;
        private System.Windows.Forms.DataGridView dataGridViewComments;
        private System.Windows.Forms.DataGridView dataGridViewLikes;
        private System.Windows.Forms.Label labelPostID;
        private System.Windows.Forms.TextBox textBoxPostID;
        private System.Windows.Forms.TextBox textBoxPostText;
        private System.Windows.Forms.Label labelPostText;
        private System.Windows.Forms.Label labelUserIDCommentAuthor;
        private System.Windows.Forms.TextBox textBoxCommentAuthorID;
        private System.Windows.Forms.TextBox textBoxCommentText;
        private System.Windows.Forms.Button buttonAddCommment;
        private System.Windows.Forms.Button buttonDeleteComment;
        private System.Windows.Forms.Label labelLikeAuthorID;
        private System.Windows.Forms.TextBox textBoxLikeAuthorID;
        private System.Windows.Forms.Button buttonDeleteLike;
        private System.Windows.Forms.Button buttonAddLike;
        private System.Windows.Forms.Label labelComments;
        private System.Windows.Forms.Label labelLikes;
        private System.Windows.Forms.Label labelPosts;
    }
}