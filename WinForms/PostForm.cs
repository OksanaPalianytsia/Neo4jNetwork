using AppDependencies;
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
    public partial class PostForm : Form
    {
        Dependencies _d;
        ObjectId current_id;
        ObjectId user_to_research_id;
        string _post_id_selected;
        private List<PostDTO> _posts;
        private PostDTO _post;

        protected ILogger _log = new Logger(typeof(PostForm));
        public PostForm(Dependencies dependent, ObjectId current, ObjectId selected)
        {
            _d = dependent;
            current_id = current;
            user_to_research_id = selected;
            InitializeComponent();
            RefreshPosts();
            _log.Info("PostForm loaded");
        }

        public void RefreshPosts()
        {
            _posts = _d.manager.GetPostsOfSelectedUser(user_to_research_id);
            dataGridViewPosts.DataSource = _posts;
            dataGridViewPosts.Refresh();
        }

        private void dataGridViewPosts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _post_id_selected = dataGridViewPosts.Rows[e.RowIndex].Cells[0].Value.ToString();
            _post = _d.manager.GetPostById(ObjectId.Parse(_post_id_selected));
            textBoxPostID.Text = dataGridViewPosts.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxPostText.Text = dataGridViewPosts.Rows[e.RowIndex].Cells[2].Value.ToString();
            dataGridViewComments.DataSource = _post.Comments;
            dataGridViewComments.Refresh();
            dataGridViewLikes.DataSource = _post.Likes;
            dataGridViewLikes.Refresh();
        }

        private void dataGridViewComments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxCommentAuthorID.Text = dataGridViewComments.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxCommentText.Text = dataGridViewComments.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void dataGridViewLikes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxLikeAuthorID.Text = dataGridViewLikes.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void buttonAddCommment_Click(object sender, EventArgs e)
        {
            _d.manager.AddCommentToPost(_post.Id, current_id, textBoxCommentText.Text);
            _post = _d.manager.GetPostById(_post.Id);
            dataGridViewComments.DataSource = _post.Comments;
            dataGridViewComments.Refresh();
            _log.Info($"Comment added from  user: {current_id.ToString()} text : {textBoxCommentText.Text}!");
        }

        private void buttonDeleteComment_Click(object sender, EventArgs e)
        {
            if (ObjectId.Parse(textBoxCommentAuthorID.Text) == current_id)
            {
                _d.manager.DeleteCommentToPost(_post.Id, current_id, textBoxCommentText.Text);
                _log.Info($"Comment deleted from user: {current_id.ToString()} text : {textBoxCommentText.Text}!");
            }
            _post = _d.manager.GetPostById(_post.Id);
            dataGridViewComments.DataSource = _post.Comments;
            dataGridViewComments.Refresh();
            
        }

        private void buttonAddLike_Click(object sender, EventArgs e)
        {
            _d.manager.AddLikeToPost(_post.Id, current_id);
            _post = _d.manager.GetPostById(_post.Id);
            dataGridViewLikes.DataSource = _post.Likes;
            dataGridViewLikes.Refresh();
            _log.Info($"Like added deleted from user: {current_id.ToString()}!");
        }

        private void buttonDeleteLike_Click(object sender, EventArgs e)
        {
            if (ObjectId.Parse(textBoxLikeAuthorID.Text) == current_id)
            {
                _d.manager.DeleteLikeToPost(_post.Id, current_id);
                _log.Info($"Like deleted deleted from user: {current_id.ToString()}!");
            }
            _post = _d.manager.GetPostById(_post.Id);
            dataGridViewLikes.DataSource = _post.Likes;
            dataGridViewLikes.Refresh();
        }
    }
}
