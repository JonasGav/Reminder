using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reminder.DatabaseManagement
{
    interface ControlPanel
    {
        void InsertElement();
        void CreateTable();
        void DeleteElement();
        void DeleteTable();
    }
}
