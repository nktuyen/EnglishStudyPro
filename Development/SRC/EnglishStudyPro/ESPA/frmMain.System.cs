using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESPA
{
    public partial class frmMain : Form
    {
        private bool LoadSystem()
        {
            lvwSystem.Items.Clear();
            foreach (ESPSystem system in DB.System)
            {
                ListViewItem item = lvwSystem.Items.Add((lvwSystem.Items.Count + 1).ToString());
                item.Tag = system;
                item.SubItems.Add(system.Name);
                item.SubItems.Add(system.Version.ToString());
                item.SubItems.Add(system.Description);
                item.SubItems.Add(new string('*', system.PIN.Length));
                item.SubItems.Add(system.Date.ToString());
            }
            return true;
        }

        private bool ValidateSystem(ESPSystem system)
        {
            return system != null && system.Name != string.Empty;
        }

        private bool SaveSystem(ESPSystem system)
        {
            try
            {
                if (Mode == EditorMode.AddNew)
                {
                    DB.System.Add(system);
                }
                else
                {
                    var curSystems = DB.ChangeTracker.Entries<ESPSystem>();
                    var curSystem = curSystems.Where(e => e.Entity.Name == system.Name).Select(e => e.Entity).FirstOrDefault();
                    if (null != curSystem)
                    {
                        curSystem.Name = system.Name;
                        curSystem.Version = system.Version;
                        curSystem.Description = system.Description;
                        curSystem.PIN = system.PIN;
                    }
                }
                DB.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }

        private bool DeleteSystem(ESPSystem system)
        {
            if (null == system)
                return false;

            try
            {
                var curSystems = DB.ChangeTracker.Entries<ESPSystem>();
                var curSystem = curSystems.Where(e => e.Entity.Name == system.Name).Select(e => e.Entity).FirstOrDefault();
                if (null != curSystem)
                {
                    DB.System.Remove(curSystem);
                    DB.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

            return true;
        }
    }
}
