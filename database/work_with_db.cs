using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SQLite;
using System.IO;

namespace KOP.database
{
    public partial class work_with_db : Component
    {
        public work_with_db()
        {
            InitializeComponent();
        }

        public work_with_db(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private string path_to_db
        {
            set { path_to_db = value; }
        }

        private string name_of_table
        {
            set { name_of_table = value; }
        }


    }
}
