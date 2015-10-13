using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace example_dll_s_22._07._2014
{
    public partial class mainForm : Form
    {

        string str = null;
        Dictionary<string, Type> myFuncs;
        Type actionType;

        double res;
        double x, y;
        bool is_action = false;
        string action;
        public mainForm()
        {


            InitializeComponent();
            string appDirName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string pluginsDirName = Path.Combine(appDirName , "plugins");

            DirectoryInfo pluginDir = new DirectoryInfo(pluginsDirName);
            FileInfo[] plugins = pluginDir.GetFiles("*.dll");

            List<Assembly> funcAssemblies = new List<Assembly>();


            foreach (FileInfo plugin in plugins)
            {
                Assembly funcAssembly = Assembly.LoadFrom(plugin.FullName);
                funcAssemblies.Add(funcAssembly);
               // str += plugin.Name + "\n"; 
            }

            List<Type> funcTypes = new List<Type>();

            foreach (Assembly func in funcAssemblies)
            {
                Type[] assemblyFuncTypes = func.GetExportedTypes();
                funcTypes.AddRange(assemblyFuncTypes);
            }
            myFuncs = new Dictionary<string, Type>();
            foreach (Type t in funcTypes)
            {
                myFuncs.Add(t.Name , t);
               // str += t.Name + "\n"; 
            }

           // actionType = myFuncs["Plus"];
           // object plusFunc = Activator.CreateInstance(actionType);
           //
           //
           // MethodInfo actionMethod = actionType.GetMethod("Value");
           //
           // res = (double)actionMethod.Invoke(plusFunc , new object[] {5.0 , 6.0});
           // 
           //
           //MessageBox.Show(res.ToString());
        }

        private void buttons_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            textBox1.Text += b.Text;

            if (!is_action)
            {
                x = Convert.ToDouble(textBox1.Text);
                label2.Text = x.ToString();
            }
            else
            {
                y = Convert.ToDouble(textBox1.Text);
                label3.Text = y.ToString();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            is_action = true;
            action = "+";
            label1.Text = action;
            textBox1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            switch (action)
            {
                case "+":
               actionType = myFuncs["Plus"];
                     object plusFunc = Activator.CreateInstance(actionType);
                    MethodInfo actionMethod = actionType.GetMethod("Value");
                    res = (double)actionMethod.Invoke(plusFunc , new object[] {x , y});
            
                break;
            }
            is_action = false;
            textBox1.Text = res.ToString();
            
        }
        
    }
}
