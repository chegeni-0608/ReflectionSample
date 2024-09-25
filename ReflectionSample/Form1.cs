using ReflectionSample.CustomeAttribute;
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
    }
}
    

