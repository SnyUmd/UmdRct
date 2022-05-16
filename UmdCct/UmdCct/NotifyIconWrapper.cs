using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmdCct
{
    public partial class NotifyIconWrapper : Component
    {
        public NotifyIconWrapper()
        {
            InitializeComponent();
        }

        public NotifyIconWrapper(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
