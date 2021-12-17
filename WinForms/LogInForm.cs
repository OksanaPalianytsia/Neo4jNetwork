using AppDependencies;
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
    public partial class LogInForm : Form
    {
        Dependencies _d;
        ObjectId current_id;

        protected ILogger _log = new Logger(typeof(LogInForm));
        public LogInForm(Dependencies dependent)
        {
            _d = dependent;
            InitializeComponent();
            textBoxLogInPassword.PasswordChar = '*';
            _log.Info("LogInForm loaded");
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            if (_d.manager.Login(textBoxLogInEmail.Text, textBoxLogInPassword.Text))
            {
                current_id =_d.manager.GetIdOfCurrentUser(textBoxLogInEmail.Text, textBoxLogInPassword.Text, "CurrentSessionUser");
                MainForm form_m = new MainForm(_d, current_id);
                form_m.Show();
                _log.Info("Go to MainForm window(User Page)");
            }
        }

        private void LogInForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //_d.manager.ClearCache();
            _log.Info("logInForm closed and Cache cleared!");
        }
    }
}
