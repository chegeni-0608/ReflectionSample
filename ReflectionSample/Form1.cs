using ReflectionSample.CustomeAttribute;
using ReflectionSample.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReflectionSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetClassListWithReflection_Click(object sender, EventArgs e)
        {
            lstClassList.Items.Clear();
            var assembly = Assembly.GetExecutingAssembly();
            var ry = assembly.GetTypes();

            foreach (var type in ry)
            {
                lstClassList.Items.Add(type.FullName);
            }

        }

        private void btnGetClassWithCustomAttributeFilterReflection_Click(object sender, EventArgs e)
        {
            lstClassList.Items.Clear();
            var assembly = Assembly.GetExecutingAssembly();
            var ry = assembly.GetTypes().
                Where(q => q.GetCustomAttributes().Any(a => a.GetType() == typeof(CustomAuthorizeAttribute)));          
            

            foreach (var type in ry)
            {
                lstClassList.Items.Add(type.Name);
            }
        }

        private void btnPropertyWithReflection_Click(object sender, EventArgs e)
        {
            var typeName = lstClassList.SelectedItem.ToString();
            lstProperty.Items.Clear();

            var assembly = Assembly.GetExecutingAssembly();
            var type = assembly.GetTypes().FirstOrDefault(q => q.Name == typeName); 
            var props = type.GetProperties();

            foreach (var item in props)
            {
                lstProperty.Items.Add(item.Name);
            }
        }

        private void btnGetMethod_Click(object sender, EventArgs e)
        {
            var typeName = lstClassList.SelectedItem.ToString();
            lstProperty.Items.Clear();

            var assembly = Assembly.GetExecutingAssembly();
            var type = assembly.GetTypes().FirstOrDefault(q => q.Name == typeName);
            var Methods = type.GetMethods();

            foreach (var item in Methods)
            {
                lstProperty.Items.Add(item.Name);
            }
        }

         #region Recursive - TreeView
        private void btnGenerateTree_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            var basePath = txtFolderPath.Text;
            var directories = System.IO.Directory.GetDirectories(basePath);

            foreach (var d in directories)
            {
                var array = d.Split('\\');
                var foldeName = array[array.Length - 1];

                TreeNode node = new TreeNode(foldeName);
                node.Text = foldeName;
                node.Tag = d;

                Recursive(node, d);

                treeView1.Nodes.Add(node);
            }
        }

        private TreeNode Recursive(TreeNode parentNode, string folderPath)
        {
            
            var directories = System.IO.Directory.GetDirectories(folderPath);

            foreach (var d in directories)
            {
                var array = d.Split('\\');
                var foldeName = array[array.Length - 1];

                TreeNode node = new TreeNode();
                node.Text = foldeName;
                node.Tag = d;
                parentNode.Nodes.Add(node);

                Recursive(node, d);
            }

            return parentNode;
        }
        #endregion

        List<Category> _categories = new List<Category>();
        private void btnGenerateProductCategory_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            using (var db = new OnlineStoreEntities())
            {
                _categories = db.Categories.ToList();
            }
            var topCategories = _categories.Where(q => q.ParentId == null);
            foreach (var item in topCategories)
            {
                var node = new TreeNode();
                node.Text = item.CategoryName;
                RecursiveCategory(node, item.Id);
                treeView1.Nodes.Add(node);
            }
        }

        private TreeNode RecursiveCategory(TreeNode parentNode, int parentNodeId)
        {
            var children = _categories.Where(q => q.ParentId == parentNodeId);  
            foreach(var item in children)
            {
                var node = new TreeNode();
                node.Text = item.CategoryName;
                RecursiveCategory(node, item.Id);
                parentNode.Nodes.Add(node);

            }
            return parentNode;
        }
    }
}
    

