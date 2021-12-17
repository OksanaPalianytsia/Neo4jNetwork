
namespace WinForms
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewStreamPosts = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonUnFollow = new System.Windows.Forms.Button();
            this.buttonFollow = new System.Windows.Forms.Button();
            this.buttonDeleteFriend = new System.Windows.Forms.Button();
            this.buttonAddFriend = new System.Windows.Forms.Button();
            this.textBoxFollowerUserID = new System.Windows.Forms.TextBox();
            this.textBoxFriendUserID = new System.Windows.Forms.TextBox();
            this.textBoxSelectedUserID = new System.Windows.Forms.TextBox();
            this.dataGridViewFollowers = new System.Windows.Forms.DataGridView();
            this.dataGridViewFriends = new System.Windows.Forms.DataGridView();
            this.labelFollowerID = new System.Windows.Forms.Label();
            this.labelFriendID = new System.Windows.Forms.Label();
            this.labelFollowers = new System.Windows.Forms.Label();
            this.labelFriends = new System.Windows.Forms.Label();
            this.labelSelectedUserID = new System.Windows.Forms.Label();
            this.textBoxFindInput = new System.Windows.Forms.TextBox();
            this.comboBoxFindOptions = new System.Windows.Forms.ComboBox();
            this.labelFindUser = new System.Windows.Forms.Label();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.labelCommon = new System.Windows.Forms.Label();
            this.textBoxCommon = new System.Windows.Forms.TextBox();
            this.textBoxIsFriend = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStreamPosts)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFollowers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFriends)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(999, 540);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Lavender;
            this.tabPage1.Controls.Add(this.dataGridViewStreamPosts);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(991, 508);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Stream";
            // 
            // dataGridViewStreamPosts
            // 
            this.dataGridViewStreamPosts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStreamPosts.Location = new System.Drawing.Point(3, 6);
            this.dataGridViewStreamPosts.Name = "dataGridViewStreamPosts";
            this.dataGridViewStreamPosts.Size = new System.Drawing.Size(780, 403);
            this.dataGridViewStreamPosts.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Lavender;
            this.tabPage2.Controls.Add(this.textBoxIsFriend);
            this.tabPage2.Controls.Add(this.textBoxCommon);
            this.tabPage2.Controls.Add(this.labelCommon);
            this.tabPage2.Controls.Add(this.buttonUnFollow);
            this.tabPage2.Controls.Add(this.buttonFollow);
            this.tabPage2.Controls.Add(this.buttonDeleteFriend);
            this.tabPage2.Controls.Add(this.buttonAddFriend);
            this.tabPage2.Controls.Add(this.textBoxFollowerUserID);
            this.tabPage2.Controls.Add(this.textBoxFriendUserID);
            this.tabPage2.Controls.Add(this.textBoxSelectedUserID);
            this.tabPage2.Controls.Add(this.dataGridViewFollowers);
            this.tabPage2.Controls.Add(this.dataGridViewFriends);
            this.tabPage2.Controls.Add(this.labelFollowerID);
            this.tabPage2.Controls.Add(this.labelFriendID);
            this.tabPage2.Controls.Add(this.labelFollowers);
            this.tabPage2.Controls.Add(this.labelFriends);
            this.tabPage2.Controls.Add(this.labelSelectedUserID);
            this.tabPage2.Controls.Add(this.textBoxFindInput);
            this.tabPage2.Controls.Add(this.comboBoxFindOptions);
            this.tabPage2.Controls.Add(this.labelFindUser);
            this.tabPage2.Controls.Add(this.dataGridViewUsers);
            this.tabPage2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(991, 508);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Users";
            // 
            // buttonUnFollow
            // 
            this.buttonUnFollow.Location = new System.Drawing.Point(803, 434);
            this.buttonUnFollow.Name = "buttonUnFollow";
            this.buttonUnFollow.Size = new System.Drawing.Size(100, 31);
            this.buttonUnFollow.TabIndex = 17;
            this.buttonUnFollow.Text = "Unfollow";
            this.buttonUnFollow.UseVisualStyleBackColor = true;
            this.buttonUnFollow.Click += new System.EventHandler(this.buttonUnFollow_Click);
            // 
            // buttonFollow
            // 
            this.buttonFollow.Location = new System.Drawing.Point(803, 374);
            this.buttonFollow.Name = "buttonFollow";
            this.buttonFollow.Size = new System.Drawing.Size(100, 30);
            this.buttonFollow.TabIndex = 16;
            this.buttonFollow.Text = "Follow";
            this.buttonFollow.UseVisualStyleBackColor = true;
            this.buttonFollow.Click += new System.EventHandler(this.buttonFollow_Click);
            // 
            // buttonDeleteFriend
            // 
            this.buttonDeleteFriend.Location = new System.Drawing.Point(803, 202);
            this.buttonDeleteFriend.Name = "buttonDeleteFriend";
            this.buttonDeleteFriend.Size = new System.Drawing.Size(100, 31);
            this.buttonDeleteFriend.TabIndex = 15;
            this.buttonDeleteFriend.Text = "Delete";
            this.buttonDeleteFriend.UseVisualStyleBackColor = true;
            this.buttonDeleteFriend.Click += new System.EventHandler(this.buttonDeleteFriend_Click);
            // 
            // buttonAddFriend
            // 
            this.buttonAddFriend.Location = new System.Drawing.Point(803, 139);
            this.buttonAddFriend.Name = "buttonAddFriend";
            this.buttonAddFriend.Size = new System.Drawing.Size(100, 33);
            this.buttonAddFriend.TabIndex = 14;
            this.buttonAddFriend.Text = "Add Friend";
            this.buttonAddFriend.UseVisualStyleBackColor = true;
            this.buttonAddFriend.Click += new System.EventHandler(this.buttonAddFriend_Click);
            // 
            // textBoxFollowerUserID
            // 
            this.textBoxFollowerUserID.Location = new System.Drawing.Point(881, 320);
            this.textBoxFollowerUserID.Name = "textBoxFollowerUserID";
            this.textBoxFollowerUserID.Size = new System.Drawing.Size(100, 30);
            this.textBoxFollowerUserID.TabIndex = 13;
            // 
            // textBoxFriendUserID
            // 
            this.textBoxFriendUserID.Location = new System.Drawing.Point(858, 88);
            this.textBoxFriendUserID.Name = "textBoxFriendUserID";
            this.textBoxFriendUserID.Size = new System.Drawing.Size(100, 30);
            this.textBoxFriendUserID.TabIndex = 12;
            // 
            // textBoxSelectedUserID
            // 
            this.textBoxSelectedUserID.Location = new System.Drawing.Point(528, 22);
            this.textBoxSelectedUserID.Name = "textBoxSelectedUserID";
            this.textBoxSelectedUserID.Size = new System.Drawing.Size(56, 30);
            this.textBoxSelectedUserID.TabIndex = 11;
            // 
            // dataGridViewFollowers
            // 
            this.dataGridViewFollowers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFollowers.Location = new System.Drawing.Point(395, 346);
            this.dataGridViewFollowers.Name = "dataGridViewFollowers";
            this.dataGridViewFollowers.Size = new System.Drawing.Size(314, 150);
            this.dataGridViewFollowers.TabIndex = 10;
            this.dataGridViewFollowers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFollowers_CellClick);
            // 
            // dataGridViewFriends
            // 
            this.dataGridViewFriends.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFriends.Location = new System.Drawing.Point(395, 114);
            this.dataGridViewFriends.Name = "dataGridViewFriends";
            this.dataGridViewFriends.Size = new System.Drawing.Size(314, 150);
            this.dataGridViewFriends.TabIndex = 9;
            this.dataGridViewFriends.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFriends_CellClick);
            // 
            // labelFollowerID
            // 
            this.labelFollowerID.AutoSize = true;
            this.labelFollowerID.Location = new System.Drawing.Point(743, 323);
            this.labelFollowerID.Name = "labelFollowerID";
            this.labelFollowerID.Size = new System.Drawing.Size(132, 23);
            this.labelFollowerID.TabIndex = 8;
            this.labelFollowerID.Text = "Follower User ID";
            // 
            // labelFriendID
            // 
            this.labelFriendID.AutoSize = true;
            this.labelFriendID.Location = new System.Drawing.Point(735, 91);
            this.labelFriendID.Name = "labelFriendID";
            this.labelFriendID.Size = new System.Drawing.Size(117, 23);
            this.labelFriendID.TabIndex = 7;
            this.labelFriendID.Text = "Friend User ID ";
            // 
            // labelFollowers
            // 
            this.labelFollowers.AutoSize = true;
            this.labelFollowers.Location = new System.Drawing.Point(481, 292);
            this.labelFollowers.Name = "labelFollowers";
            this.labelFollowers.Size = new System.Drawing.Size(84, 23);
            this.labelFollowers.TabIndex = 6;
            this.labelFollowers.Text = "Followers";
            // 
            // labelFriends
            // 
            this.labelFriends.AutoSize = true;
            this.labelFriends.Location = new System.Drawing.Point(481, 77);
            this.labelFriends.Name = "labelFriends";
            this.labelFriends.Size = new System.Drawing.Size(65, 23);
            this.labelFriends.TabIndex = 5;
            this.labelFriends.Text = "Friends";
            // 
            // labelSelectedUserID
            // 
            this.labelSelectedUserID.AutoSize = true;
            this.labelSelectedUserID.Location = new System.Drawing.Point(391, 25);
            this.labelSelectedUserID.Name = "labelSelectedUserID";
            this.labelSelectedUserID.Size = new System.Drawing.Size(131, 23);
            this.labelSelectedUserID.TabIndex = 4;
            this.labelSelectedUserID.Text = "Selected User ID";
            // 
            // textBoxFindInput
            // 
            this.textBoxFindInput.Location = new System.Drawing.Point(225, 8);
            this.textBoxFindInput.Name = "textBoxFindInput";
            this.textBoxFindInput.Size = new System.Drawing.Size(136, 30);
            this.textBoxFindInput.TabIndex = 3;
            this.textBoxFindInput.TextChanged += new System.EventHandler(this.textBoxFindInput_TextChanged);
            // 
            // comboBoxFindOptions
            // 
            this.comboBoxFindOptions.AutoCompleteCustomSource.AddRange(new string[] {
            "FirstName",
            "LastName"});
            this.comboBoxFindOptions.FormattingEnabled = true;
            this.comboBoxFindOptions.Items.AddRange(new object[] {
            "FirstName",
            "LastName"});
            this.comboBoxFindOptions.Location = new System.Drawing.Point(84, 8);
            this.comboBoxFindOptions.Name = "comboBoxFindOptions";
            this.comboBoxFindOptions.Size = new System.Drawing.Size(121, 31);
            this.comboBoxFindOptions.TabIndex = 2;
            // 
            // labelFindUser
            // 
            this.labelFindUser.AutoSize = true;
            this.labelFindUser.Location = new System.Drawing.Point(16, 12);
            this.labelFindUser.Name = "labelFindUser";
            this.labelFindUser.Size = new System.Drawing.Size(62, 23);
            this.labelFindUser.TabIndex = 1;
            this.labelFindUser.Text = "Find by";
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(7, 42);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.Size = new System.Drawing.Size(354, 463);
            this.dataGridViewUsers.TabIndex = 0;
            this.dataGridViewUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsers_CellClick);
            this.dataGridViewUsers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsers_CellDoubleClick);
            // 
            // labelCommon
            // 
            this.labelCommon.AutoSize = true;
            this.labelCommon.Location = new System.Drawing.Point(743, 25);
            this.labelCommon.Name = "labelCommon";
            this.labelCommon.Size = new System.Drawing.Size(138, 23);
            this.labelCommon.TabIndex = 19;
            this.labelCommon.Text = "Common Friends ";
            // 
            // textBoxCommon
            // 
            this.textBoxCommon.Location = new System.Drawing.Point(887, 22);
            this.textBoxCommon.Name = "textBoxCommon";
            this.textBoxCommon.Size = new System.Drawing.Size(71, 30);
            this.textBoxCommon.TabIndex = 20;
            // 
            // textBoxIsFriend
            // 
            this.textBoxIsFriend.Location = new System.Drawing.Point(625, 22);
            this.textBoxIsFriend.Name = "textBoxIsFriend";
            this.textBoxIsFriend.Size = new System.Drawing.Size(100, 30);
            this.textBoxIsFriend.TabIndex = 21;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 537);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStreamPosts)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFollowers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFriends)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewStreamPosts;
        private System.Windows.Forms.TextBox textBoxFindInput;
        private System.Windows.Forms.ComboBox comboBoxFindOptions;
        private System.Windows.Forms.Label labelFindUser;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Button buttonUnFollow;
        private System.Windows.Forms.Button buttonFollow;
        private System.Windows.Forms.Button buttonDeleteFriend;
        private System.Windows.Forms.Button buttonAddFriend;
        private System.Windows.Forms.TextBox textBoxFollowerUserID;
        private System.Windows.Forms.TextBox textBoxFriendUserID;
        private System.Windows.Forms.TextBox textBoxSelectedUserID;
        private System.Windows.Forms.DataGridView dataGridViewFollowers;
        private System.Windows.Forms.DataGridView dataGridViewFriends;
        private System.Windows.Forms.Label labelFollowerID;
        private System.Windows.Forms.Label labelFriendID;
        private System.Windows.Forms.Label labelFollowers;
        private System.Windows.Forms.Label labelFriends;
        private System.Windows.Forms.Label labelSelectedUserID;
        private System.Windows.Forms.TextBox textBoxIsFriend;
        private System.Windows.Forms.TextBox textBoxCommon;
        private System.Windows.Forms.Label labelCommon;
    }
}