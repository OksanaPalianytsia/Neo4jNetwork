using AppDependencies;
using DAL.Concrete;
using DTO;
using LOG;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class MainForm : Form
    {
        Dependencies _d;
        ObjectId current_id;
        string _firstName;
        string _lastName;
        ObjectId user_to_research_id;
        private List<UserDTO> _users;
        private List<PostDTO> _posts;
        private UserDTO _user_selected;

        protected ILogger _log = new Logger(typeof(MainForm));
        public MainForm(Dependencies dependent, ObjectId current)
        {
            _d = dependent;
            current_id = current;
            InitializeComponent();
            RefreshUsers();
            RefreshStream();
            _log.Info("MainForm loaded");
        }

        public void RefreshStream()
        {
            _posts = _d.manager.PostStream();
            dataGridViewStreamPosts.DataSource = _posts;
        }
        public void RefreshUsers()
        {
            _users = _d.manager.AllUsers();
            dataGridViewUsers.DataSource = _users;
        }

        public void FindByFirstName(string firstName)
        {
            _users = _d.manager.UsersByFirstName(firstName);
            dataGridViewUsers.DataSource = _users;
            dataGridViewUsers.Refresh();
        }
        public void FindByLastName(string lastName)
        {
            _users = _d.manager.UsersByLastName(lastName);
            dataGridViewUsers.DataSource = _users;
            dataGridViewUsers.Refresh();
        }
        private void textBoxFindInput_TextChanged(object sender, EventArgs e)
        {
            string property_value = textBoxFindInput.Text;

            switch (comboBoxFindOptions.SelectedIndex)
            {
                case 0:
                    FindByFirstName(property_value);
                    break;
                case 1:
                    FindByLastName(property_value);
                    break;
                default:
                    RefreshUsers();
                    break;

            }
        }

        private void dataGridViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _firstName = dataGridViewUsers.Rows[e.RowIndex].Cells[1].Value.ToString();
            _lastName = dataGridViewUsers.Rows[e.RowIndex].Cells[2].Value.ToString();
            user_to_research_id = _d.manager.GetIdOfCurrentUser(_firstName, _lastName, "SelectedUserOPosts");
            _user_selected = _d.manager.GetUserById(user_to_research_id);
            textBoxSelectedUserID.Text = dataGridViewUsers.Rows[e.RowIndex].Cells[0].Value.ToString();

            if (_d.manager.IsFriends(user_to_research_id, current_id))
            {
                textBoxIsFriend.Text = "Friends";
            }
            else 
            {
                textBoxIsFriend.Clear();
            }
            textBoxCommon.Clear();
            textBoxCommon.Text = _d.manager.CommonPeople(user_to_research_id, current_id).ToString();
            dataGridViewFriends.DataSource = _user_selected.Friends.ToList();
            dataGridViewFriends.Refresh();
            dataGridViewFollowers.DataSource = _user_selected.Subscribers.ToList();
            dataGridViewFollowers.Refresh();
        }

        private void dataGridViewUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _firstName = dataGridViewUsers.Rows[e.RowIndex].Cells[1].Value.ToString();
            _lastName = dataGridViewUsers.Rows[e.RowIndex].Cells[2].Value.ToString();
            user_to_research_id = _d.manager.GetIdOfCurrentUser(_firstName, _lastName, "SelectedUserOPosts");
            PostForm posts = new PostForm(_d, current_id, user_to_research_id);
            posts.Show();
            _log.Info("Go to PostForm (Page of Selected user posts)");
        }

        private void dataGridViewFriends_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxFriendUserID.Text = dataGridViewFriends.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void dataGridViewFollowers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxFollowerUserID.Text = dataGridViewFollowers.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void buttonAddFriend_Click(object sender, EventArgs e)
        {
            _d.manager.AddFriend(_user_selected.Id, current_id);
            _user_selected = _d.manager.GetUserById(user_to_research_id);
            dataGridViewFriends.DataSource = _user_selected.Friends.ToList();
            dataGridViewFriends.Refresh();
            _log.Info($"Now friends  user: {current_id.ToString()} and : {user_to_research_id.ToString()}!");
        }

        private void buttonDeleteFriend_Click(object sender, EventArgs e)
        {
            if (ObjectId.Parse(textBoxFriendUserID.Text) == current_id)
            {
                _d.manager.DeleteFriend(_user_selected.Id, current_id);
                _log.Info($"Not friends user: {current_id.ToString()} and : {user_to_research_id.ToString()}!");
            }
            _user_selected = _d.manager.GetUserById(user_to_research_id);
            dataGridViewFriends.DataSource = _user_selected.Friends.ToList();
            dataGridViewFriends.Refresh();
        }

        private void buttonFollow_Click(object sender, EventArgs e)
        {
            _d.manager.SubscribeToUser(_user_selected.Id, current_id);
            _user_selected = _d.manager.GetUserById(user_to_research_id);
            dataGridViewFollowers.DataSource = _user_selected.Subscribers.ToList();
            dataGridViewFollowers.Refresh();
            _log.Info($"User: {current_id.ToString()} follow : {user_to_research_id.ToString()}!");
        }

        private void buttonUnFollow_Click(object sender, EventArgs e)
        {
            if (ObjectId.Parse(textBoxFriendUserID.Text) == current_id)
            {
                _d.manager.UnSubscribeToUser(_user_selected.Id, current_id);
                _log.Info($"User: {current_id.ToString()} Unfollow : {user_to_research_id.ToString()}!");
            }
            _user_selected = _d.manager.GetUserById(user_to_research_id);
            dataGridViewFollowers.DataSource = _user_selected.Subscribers.ToList();
            dataGridViewFollowers.Refresh();
        }
    }
}
