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
            var assembly = Assembly.GetExecutingAssembly();
            var ry = assembly.GetTypes();

            foreach (var type in ry)
            {
                lstClassList.Items.Add(type.FullName);
            }

        }
    }
}
    

