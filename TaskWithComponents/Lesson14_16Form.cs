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
	public partial class Lesson14_16Form : Form
	{
		public Lesson14_16Form()
		{
			InitializeComponent();
		}



		private void Lesson14_16Form_Click(object sender, EventArgs e)
		{
			treeView1.SelectedNode = null;
		}

		private void addButton_Click(object sender, EventArgs e)
		{
			TreeNode node = treeView1.SelectedNode;
			if (node == null)
			{
				treeView1.Nodes.Add(addNodeTextBox.Text);
			}
			else 
			{
				node.Nodes.Add(addNodeTextBox.Text);
			}
			addNodeTextBox.Text = "";
			addNodeTextBox.Focus();
		}

		private void removeButton_Click(object sender, EventArgs e)
		{
			TreeNode node = treeView1.SelectedNode;
			if (node != null)
			{
				treeView1.Nodes.Remove(node);
			}
			else
			{
				MessageBox.Show("Ничего не выделено");
			}
		}

		private void removeAllButton_Click(object sender, EventArgs e)
		{
			treeView1.Nodes.Clear();
		}

		private void findButton_Click(object sender, EventArgs e)
		{
			treeView1.SelectedNode = null;
			TreeNode tn = FindNode(treeView1.Nodes, findNodeTextBox.Text);
			if (tn != null)
			{
				treeView1.SelectedNode = tn;
				treeView1.Focus();
			}

		}
		private TreeNode FindNode(TreeNodeCollection tnc, string name) 
		{
			foreach (TreeNode tn in tnc) 
			{
				if (tn.Text == name) 
				{
					return tn;
				}
			}
			TreeNode node;
			foreach (TreeNode tn in tnc) 
			{
				node = FindNode(tn.Nodes, name);
				if (node != null) 
				{
					return node;
				}
			}
			return null;
		}
	}
}
