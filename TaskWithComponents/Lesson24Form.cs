using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskWithComponents
{
    public partial class Lesson24Form : Form
    {
        public Lesson24Form()
        {
            InitializeComponent();
        }

        private void Lesson24Form_Load(object sender, EventArgs e)
        {
            TreeNode treeNode = treeView1.Nodes.Add("Item1");
            TreeNode treeNode11 = treeNode.Nodes.Add("Item11");
            TreeNode treeNode12 = treeNode.Nodes.Add("Item12");
            treeNode11.Nodes.Add("Item111");
            treeNode11.Nodes.Add("Item112");
            treeNode12.Nodes.Add("Item121");
            treeNode12.Nodes.Add("Item122");
            treeNode.ExpandAll();
        }

        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            SelectAllSubnodes(e.Node);
        }
        private void SelectAllSubnodes(TreeNode tn) 
        {
            foreach (TreeNode node in tn.Nodes)
            {
                node.Checked = tn.Checked;
            }
        }
    }
}
