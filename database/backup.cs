using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KOP.database
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

        private int interval// property of backups time
        {
            set
            {
                if (value > 0) interval = value;
                else throw new ArgumentOutOfRangeException();
            }
        }

        private string path_to_db
        {
            set { path_to_db = value; }
        }

        private string path_to_backup
        {
            set { path_to_backup = value; }
        }


        private void interval_of_backup_Tick(object sender, EventArgs e)
        {
            // body of backup db
        }
    }
}
