﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using SidebarDiagnostics.Monitoring;
using SidebarDiagnostics.Windows;

namespace SidebarDiagnostics
{
    /// <summary>
    /// Interaction logic for Graph.xaml
    /// </summary>
    public partial class Graph : DPIAwareWindow
    {
        public Graph(MonitorManager manager)
        {
            InitializeComponent();
            BindData(manager);
            Show();
        }

        public void BindData(MonitorManager manager)
        {

        }
    }
}
