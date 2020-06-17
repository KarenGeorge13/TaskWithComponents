using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskWithComponents
{
    public partial class Lesson18_20Form : Form
    {
        public Lesson18_20Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] drivers = Directory.GetLogicalDrives();
            foreach (string d in drivers) 
            {
                TreeNode tn = treeView1.Nodes.Add(d);
                tn.Nodes.Add("");
                tn.Tag = "";
            }
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            NodeExpand(e.Node);
        }
        private void NodeExpand(TreeNode tn)
        {
            if (tn.Nodes.Count != 0) 
            {
                tn.Nodes.RemoveAt(0);
                AddTreeNodes(tn);
                tn.Tag = "+";
            }
        }

        private string GetFullPath(TreeNode tn) 
        {
            TreeNode curNode = tn;
            string fullPath = curNode.Text;
            while (curNode.Parent != null) 
            {
                curNode = curNode.Parent;
                fullPath = curNode.Text + @"\" + fullPath;
            }
            return fullPath + @"\";
        }

        private void AddTreeNodes(TreeNode tn) 
        {
            TreeNode aux;
            DirectoryInfo d = new DirectoryInfo(GetFullPath(tn));
            DirectoryInfo[] ds;
            try
            {
                ds = d.GetDirectories();
                foreach (DirectoryInfo s in ds)
                {
                    aux = tn.Nodes.Add(s.Name);
                    aux.Tag = "";
                    try
                    {
                        if (s.GetDirectories().GetLength(0) != 0)
                        {
                            aux.Nodes.Add("");
                        }
                    }
                    catch (UnauthorizedAccessException) { }
                }
            }
            catch (Exception) { }
        }
    }
}
