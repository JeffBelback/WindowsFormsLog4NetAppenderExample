using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using log4net;
using log4net.Config;

namespace WindowsFormsLog4NetAppenderExample
{
    public partial class Form1 : Form
    {
        private static readonly ILog _log = LogManager.GetLogger(typeof(Form1));

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            XmlConfigurator.Configure();
            TextBoxAppender.ConfigureTextBoxAppender(LoggingTextBox);

            _log.Info("This is just an example of how this appender works...");
        }
    }
}
