<<<<<<< HEAD
<<<<<<< HEAD
﻿using Fasetto.Word.Core;
using System;
=======
﻿using System;
>>>>>>> 3e3f47c (Custom Window creation)
=======
﻿using System;
>>>>>>> 3e3f47c (Custom Window creation)
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Fasetto.Word
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

<<<<<<< HEAD
<<<<<<< HEAD
            DataContext = new WindowViewModel(this);
        }

        private void AppWindow_Deactivated(object sender, EventArgs e)
        {
            // Show overlay if we lose focus
            (DataContext as WindowViewModel).DimmableOverlayVisible = true;
        }

        private void AppWindow_Activated(object sender, EventArgs e)
        {
            // Hide overlay if we are focused
            (DataContext as WindowViewModel).DimmableOverlayVisible = false;
=======
            this.DataContext = new WindowViewModel(this);
>>>>>>> 3e3f47c (Custom Window creation)
=======
            this.DataContext = new WindowViewModel(this);
>>>>>>> 3e3f47c (Custom Window creation)
        }
    }
}
