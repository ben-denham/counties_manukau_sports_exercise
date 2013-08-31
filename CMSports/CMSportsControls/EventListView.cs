using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CMSportsObjects;

namespace CMSportsControls
{
    public partial class EventListView : UserControl
    {
        public EventListView()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            eventsListView.Items.Clear();
        }

        public void Populate(List<Event> events)
        {
            Clear();
            foreach (Event cmsEvent in events)
            {
                ListViewItem listItem = new ListViewItem(cmsEvent.Name);
                if (cmsEvent.Organisation != null)
                {
                    listItem.SubItems.Add(cmsEvent.Organisation.ToString());
                }
                if (cmsEvent.Program != null)
                {
                    listItem.SubItems.Add(cmsEvent.Program.ToString());
                }
                if (cmsEvent.StartTime != null)
                {
                    listItem.SubItems.Add(cmsEvent.StartTime.ToString());
                }
                if (cmsEvent.EndTime != null)
                {
                    listItem.SubItems.Add(cmsEvent.EndTime.ToString());
                }
                eventsListView.Items.Add(listItem);
            }
        }
    }
}
