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
        private bool LoadVocabularies()
        {
            lbVocabularies.Items.Clear();

            lbVocabularies.DisplayMember = "Name";

            /*foreach (ESPVocabulary vocabulary in DB.Vocabularies)
            {
                lbVocabularies.Items.Add(vocabulary);
            }*/
            var vocabs = DB.Vocabularies.OrderBy(e => e.Name);
            foreach(ESPVocabulary vocabulary in vocabs)
            {
                lbVocabularies.Items.Add(vocabulary);
            }

            return true;
        }

        private bool ValidateVocabulary(ESPVocabulary vocabulary)
        {
            if ((vocabulary == null) || (vocabulary.Name == string.Empty))
            {
                MessageBox.Show("Invalid information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (Mode == EditorMode.AddNew)
            {
                var existingVocab = DB.Vocabularies.Where(e => e.Name == vocabulary.Name).FirstOrDefault();
                if (null != existingVocab)
                {
                    MessageBox.Show("Already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }

        private bool SaveVocabulary(ESPVocabulary vocabulary)
        {
            try
            {
                if (Mode == EditorMode.AddNew)
                {
                    DB.Vocabularies.Add(vocabulary);
                }
                else
                {
                    var curVocabularies = DB.ChangeTracker.Entries<ESPVocabulary>();
                    var curVocab = curVocabularies.Where(e => e.Entity.Name == vocabulary.Name).Select(e => e.Entity).FirstOrDefault();
                    if (null != curVocab)
                    {
                        curVocab.Name = curVocab.Name;
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


        private bool DeleteVocabulary(ESPVocabulary cls)
        {
            if (null == cls)
                return false;

            try
            {
                var curVocabularies = DB.ChangeTracker.Entries<ESPVocabulary>();
                var curVocab = curVocabularies.Where(e => e.Entity.Name == cls.Name).Select(e => e.Entity).FirstOrDefault();
                if (null != curVocab)
                {
                    DB.Vocabularies.Remove(curVocab);
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
