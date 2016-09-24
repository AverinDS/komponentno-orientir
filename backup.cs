using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOP
{
    public partial class backup : Component
    {
        public backup()
        {
            InitializeComponent();
        }

        public backup(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
