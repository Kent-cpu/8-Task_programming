using System;
using System.Windows.Forms;
using task_8.Presenters;
using task_8.Views;

namespace task_8
{
    public partial class Form1 : Form, IModel
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string firstPathText {
            get {
                return fPath.Text;
            } 
            set {
                fPath.Text = value;
            } 
        }
        public string secondPathText {
            get
            {
                return sPath.Text;
            }
            set {
                sPath.Text = value; 
            }
        }

        public string modifiedText
        {
            get
            {
                return newText.Text;
            }
            set
            {
                newText.Text = value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModelPresenter modelPresenter = new ModelPresenter(this);
            modelPresenter.changingFiles();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ModelPresenter modelPresenter = new ModelPresenter(this);
            modelPresenter.deleteFiles();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ModelPresenter modelPresenter = new ModelPresenter(this);
            modelPresenter.createFiles();
        }
    }
}


