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
        private bool LoadClasses()
        {
            lbClasses.Items.Clear();

            lbClasses.DisplayMember = "Title";

            var clses = DB.Classes.OrderBy(e => e.Title);
            foreach(ESPClass cls in clses)
            {
                lbClasses.Items.Add(cls);
            }

            return true;
        }

        private bool ValidateClass(ESPClass cls)
        {
            if ((cls == null) || (cls.Name == string.Empty) || cls.Title == string.Empty)
            {
                MessageBox.Show("Invalid information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if(Mode == EditorMode.AddNew)
            {
                var Classes = DB.Classes.Where(e => e.Name == cls.Name || e.Title == cls.Title).FirstOrDefault();
                if(null != Classes)
                {
                    MessageBox.Show("Already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }

        private bool SaveClass(ESPClass cls)
        {
            try
            {
                if (Mode == EditorMode.AddNew)
                {
                    DB.Classes.Add(cls);
                }
                else
                {
                    var curClses = DB.ChangeTracker.Entries<ESPClass>();
                    var curCls = curClses.Where(e => e.Entity.Id == cls.Id).Select(e => e.Entity).FirstOrDefault();
                    if (null != curCls)
                    {
                        curCls.Name = curCls.Name;
                        curCls.Title = curCls.Title;
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


        private bool DeleteClass(ESPClass cls )
        {
            if (null == cls)
                return false;

            try
            {
                var curClses = DB.ChangeTracker.Entries<ESPClass>();
                var curCls = curClses.Where(e => e.Entity.Id == cls.Id).Select(e => e.Entity).FirstOrDefault();
                if (null != curCls)
                {
                    DB.Classes.Remove(curCls);
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
