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
        private bool LoadCategoriesOfParent(ESPCategory parentobj, IQueryable<ESPCategory> categories, ref int level)
        {
            int item = -1;
            level += 4;
            foreach (var cat in categories)
            {
                cat.DisplayName = (new string(' ', level)) + cat.Title;
                cat.ParentObject = parentobj;
                item = cbCategories.Items.Add(cat);
                item = lbCategories.Items.Add(cat);
                var categories2 = DB.Categories.Where(e => e.Parent == cat.Id).OrderBy(e => e.Name);
                LoadCategoriesOfParent(cat, categories2, ref level);
            }
            level -= 4;
            return true;
        }
        private bool LoadCategories()
        {
            cbCategories.Items.Clear();
            lbCategories.Items.Clear();

            cbCategories.DisplayMember = "DisplayName";
            lbCategories.DisplayMember = "DisplayName";
            int level = -4;

            var categories = DB.Categories.Where(e => e.Parent == 0).OrderBy(e => e.Title);
            LoadCategoriesOfParent(null, categories, ref level);

            return true;
        }

        private bool ValidateCategory(ESPCategory category)
        {
            if ((category == null) || (category.Name == string.Empty))
            {
                MessageBox.Show("Invalid information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (category.Id != 0)
            {
                if (category.Parent == category.Id)
                {
                    MessageBox.Show("Invalid parent category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            if(Mode == EditorMode.AddNew)
            {
                var cates = DB.Categories.Where(e => e.Name == category.Name || e.Title == category.Title).FirstOrDefault();
                if(null != cates)
                {
                    MessageBox.Show("Already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }

        private bool SaveCategory(ESPCategory category)
        {
            try
            {
                if (Mode == EditorMode.AddNew)
                {
                    DB.Categories.Add(category);
                }
                else
                {
                    var curCats = DB.ChangeTracker.Entries<ESPCategory>();
                    var curCat = curCats.Where(e => e.Entity.Id == category.Id).Select(e => e.Entity).FirstOrDefault();
                    if (null != curCat)
                    {
                        curCat.Name = category.Name;
                        curCat.Title = category.Title;
                        curCat.Parent = category.Parent;
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


        private bool DeleteCategory(ESPCategory category)
        {
            if (null == category)
                return false;

            try
            {
                var curCats = DB.ChangeTracker.Entries<ESPCategory>();
                var curCat = curCats.Where(e => e.Entity.Name == category.Name).Select(e => e.Entity).FirstOrDefault();
                if (null != curCat)
                {
                    DB.Categories.Remove(curCat);
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
