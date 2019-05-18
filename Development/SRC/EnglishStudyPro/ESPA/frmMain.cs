using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESPA
{
    public partial class frmMain : Form
    {
        private readonly ESPDatabase DB = null;
        private enum EditorMode { None,AddNew,Edit};
        private EditorMode Mode { get; set; }
        private string HierachicalName { get; set; }

        public frmMain(ESPDatabase db = null)
        {
            InitializeComponent();
            Mode = EditorMode.None;

            DB = db ?? new ESPDatabase();
        }
        

        

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadSystem();
            btnSystem_New.Enabled = lvwSystem.Items.Count == 0;

            LoadCategories();
            LoadClasses();
            LoadVocabularies();
        }

        private void btnSystem_New_Click(object sender, EventArgs e)
        {
            Mode = EditorMode.AddNew;

            txtSystem_Name.Text = string.Empty;
            txtSystem_Version.Text = string.Empty;
            txtSystem_Desc.Text = string.Empty;
            txtSystem_PIN.Text = string.Empty;
            txtSystem_Date.Text = string.Empty;

            txtSystem_Name.ReadOnly = (Mode == EditorMode.None);
            txtSystem_Version.ReadOnly = (Mode == EditorMode.None);
            txtSystem_Desc.ReadOnly = (Mode == EditorMode.None);
            txtSystem_PIN.ReadOnly = (Mode == EditorMode.None);
            txtSystem_Date.ReadOnly = (Mode == EditorMode.None);

            AcceptButton = btnSystem_Save;
            txtSystem_Name.Focus();
        }

        private void btnSystem_Save_Click(object sender, EventArgs e)
        {
            ESPSystem system = new ESPSystem(txtSystem_Name.Text, long.Parse(txtSystem_Version.Text), txtSystem_Desc.Text, txtSystem_PIN.Text, int.Parse(txtSystem_Date.Text));
            if(!ValidateSystem(system))
            {
                txtSystem_Name.Focus();
                return;
            }

            if (!SaveSystem(system))
            {
                return;
            }
            MessageBox.Show("Saved!", "System information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Mode = EditorMode.None;
            btnSystem_Save.Enabled = false;

            txtSystem_Name.ReadOnly = (Mode == EditorMode.None);
            txtSystem_Version.ReadOnly = (Mode == EditorMode.None);
            txtSystem_Desc.ReadOnly = (Mode == EditorMode.None);
            txtSystem_PIN.ReadOnly = (Mode == EditorMode.None);
            txtSystem_Date.ReadOnly = (Mode == EditorMode.None);

            LoadSystem();
            btnSystem_New.Enabled = lvwSystem.Items.Count == 0;
            btnSystem_New.Focus();
        }

        private void txtSystem_Name_TextChanged(object sender, EventArgs e)
        {
            if(Mode != EditorMode.None)
            {
                btnSystem_Save.Enabled = (txtSystem_Name.Text.Length > 0 ||
                    txtSystem_Desc.Text.Length > 0 ||
                    txtSystem_Version.Text.Length > 0 ||
                    txtSystem_PIN.Text.Length > 0);
            }
        }

        private void txtSystem_Version_TextChanged(object sender, EventArgs e)
        {
            if (Mode != EditorMode.None)
            {
                btnSystem_Save.Enabled = (txtSystem_Name.Text.Length > 0 ||
                    txtSystem_Desc.Text.Length > 0 ||
                    txtSystem_Version.Text.Length > 0 ||
                    txtSystem_PIN.Text.Length > 0);
            }
        }

        private void txtSystem_Desc_TextChanged(object sender, EventArgs e)
        {
            if (Mode != EditorMode.None)
            {
                btnSystem_Save.Enabled = (txtSystem_Name.Text.Length > 0 ||
                    txtSystem_Desc.Text.Length > 0 ||
                    txtSystem_Version.Text.Length > 0 ||
                    txtSystem_PIN.Text.Length > 0);
            }
        }

        private void txtSystem_PIN_TextChanged(object sender, EventArgs e)
        {
            if (Mode != EditorMode.None)
            {
                btnSystem_Save.Enabled = (txtSystem_Name.Text.Length > 0 ||
                    txtSystem_Desc.Text.Length > 0 ||
                    txtSystem_Version.Text.Length > 0 ||
                    txtSystem_PIN.Text.Length > 0);
            }
        }

        private void lvwSystem_DoubleClick(object sender, EventArgs e)
        {
            if (lvwSystem.SelectedItems.Count <= 0)
                return;

            ListViewItem selItem = lvwSystem.SelectedItems[0];
            if (null == selItem)
                return;

            ESPSystem system = selItem.Tag as ESPSystem;
            if (null == system)
                return;

            Mode = EditorMode.Edit;

            txtSystem_Name.ReadOnly = true;
            txtSystem_Version.ReadOnly = (Mode == EditorMode.None);
            txtSystem_Desc.ReadOnly = (Mode == EditorMode.None);
            txtSystem_PIN.ReadOnly = (Mode == EditorMode.None);
            txtSystem_Date.ReadOnly = (Mode == EditorMode.None);

            txtSystem_Name.Text = system.Name;
            txtSystem_Version.Text = system.Version.ToString();
            txtSystem_Desc.Text = system.Description;
            txtSystem_PIN.Text = system.PIN;
            txtSystem_Date.Text = system.Date.ToString();

            txtSystem_Name.Focus();
        }

        private void lvwSystem_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete:
                {
                    if (lvwSystem.SelectedItems.Count <= 0)
                        return;

                    bool bChanged = false;
                    foreach (ListViewItem item in lvwSystem.SelectedItems)
                    {
                        if (DeleteSystem(item.Tag as ESPSystem))
                        {
                            lvwSystem.Items.Remove(item as ListViewItem);
                            bChanged = true;
                        }
                    }

                    if (!bChanged)
                        return;

                    Mode = EditorMode.None;
                    btnSystem_Save.Enabled = false;

                    txtSystem_Name.ReadOnly = (Mode == EditorMode.None);
                    txtSystem_Version.ReadOnly = (Mode == EditorMode.None);
                    txtSystem_Desc.ReadOnly = (Mode == EditorMode.None);
                    txtSystem_PIN.ReadOnly = (Mode == EditorMode.None);

                    LoadSystem();
                    btnSystem_New.Enabled = lvwSystem.Items.Count == 0;
                }
                break;
                default:
                    break;
            }
        }

        private void lvwSystem_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mode = EditorMode.None;

            txtSystem_Name.Text = string.Empty;
            txtSystem_Version.Text = string.Empty;
            txtSystem_Desc.Text = string.Empty;
            txtSystem_PIN.Text = string.Empty;
            txtSystem_Date.Text = string.Empty;

            txtSystem_Name.ReadOnly = (Mode == EditorMode.None);
            txtSystem_Version.ReadOnly = (Mode == EditorMode.None);
            txtSystem_Desc.ReadOnly = (Mode == EditorMode.None);
            txtSystem_PIN.ReadOnly = (Mode == EditorMode.None);
            txtSystem_Date.ReadOnly = (Mode == EditorMode.None);

            btnSystem_Save.Enabled = false;

            if (lvwSystem.SelectedItems.Count <= 0)
                return;

            ListViewItem selItem = lvwSystem.SelectedItems[0];
            if (null == selItem)
                return;

            ESPSystem system = selItem.Tag as ESPSystem;
            if (null == system)
                return;

            txtSystem_Name.Text = system.Name;
            txtSystem_Version.Text = system.Version.ToString();
            txtSystem_Desc.Text = system.Description;
            txtSystem_PIN.Text = system.PIN;
            txtSystem_Date.Text = system.Date.ToString();
        }

        private void btnCategory_New_Click(object sender, EventArgs e)
        {
            Mode = EditorMode.AddNew;

            //cbCategories.SelectedIndex = -1;
            //txtCategoryName.Text = string.Empty;
            txtCategoryTitle.Text = string.Empty;

            txtCategoryName.ReadOnly = (Mode == EditorMode.None);
            txtCategoryTitle.ReadOnly = (Mode == EditorMode.None);
            cbCategories.Enabled = (Mode != EditorMode.None);

            cbCategories_SelectedIndexChanged(cbCategories, new EventArgs());

            AcceptButton = btnCategory_Save;
            txtCategoryTitle.Focus();
        }

        private void btnCategory_Save_Click(object sender, EventArgs e)
        {
            long parentid = 0;
            ESPCategory parentCategory = cbCategories.SelectedItem as ESPCategory;
            if(null!= parentCategory)
            {
                parentid = parentCategory.Id;
            }

            ESPCategory category = new ESPCategory(txtCategoryName.Text, txtCategoryTitle.Text, parentid);
            if(Mode == EditorMode.Edit)
            {
                category.Id = long.Parse(txtCategoryID.Text);
            }

            if (!ValidateCategory(category))
            {
                txtCategoryTitle.Focus();
                return;
            }

            if (!SaveCategory(category))
            {
                return;
            }
            MessageBox.Show("Saved!","Category information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Mode = EditorMode.None;
            btnCategory_Save.Enabled = false;

            txtCategoryName.ReadOnly = (Mode == EditorMode.None);
            txtCategoryTitle.ReadOnly = (Mode == EditorMode.None);
            cbCategories.Enabled = (Mode != EditorMode.None);

            LoadCategories();
            btnCategory_New.Focus();
        }

        private void tabCtrlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mode = EditorMode.None;
            btnSystem_Save.Enabled = false;
            btnCategory_Save.Enabled = false;
        }

        private string RemoveTone(string input)
        {
            StringBuilder stringBuilder = new StringBuilder(input.ToLower());
            stringBuilder.Replace(" ", string.Empty);
            Dictionary<string, string> dic = new Dictionary<string, string> {
                { "à","a"},{ "á","a"},{ "ả","a"},{ "ã","a"},{ "ạ","a"}
                ,{ "ă","a"},{ "ằ","a"},{ "ắ","a"},{ "ẳ","a"},{"ẵ","a"},{ "ặ","a"}
                ,{ "â","a"},{ "ầ","a"},{ "ấ","a"},{ "ẩ","a"},{ "ẫ","a"},{ "ậ","a"}
                ,{"đ","d"}
                ,{ "è","e"},{ "é","e"},{ "ẻ","e"},{ "ẽ","e"},{ "ẹ","e"}
                ,{ "ê","e"},{ "ề","e"},{ "ế","e"},{ "ể","e"},{ "ễ","e"},{ "ệ","e"}
                ,{ "ì","i"},{ "í","i"},{ "ỉ","i"},{ "ĩ","i"},{ "ị","i"}
                ,{ "ò","o"},{ "ó","o"},{ "ỏ","o"},{ "õ","o"},{ "ọ","o"}
                ,{ "ô","o"},{ "ồ","o"},{ "ố","o"},{ "ổ","o"},{ "ỗ","o"},{ "ộ","o"}
                ,{ "ơ","o"},{ "ờ","o"},{ "ớ","o"},{ "ở","o"},{ "ỡ","o"},{ "ợ","o"}
                ,{ "ù","u"},{ "ú","u"},{ "ủ","u"},{ "ũ","u"},{ "ụ","u"}
                ,{ "ư","u"},{ "ừ","u"},{ "ứ","u"},{ "ử","u"},{ "ữ","u"},{ "ự","u"}
                ,{ "ỳ","y"},{ "ý","y"},{ "ỷ","y"},{ "ỹ","y"},{ "ỵ","y"}
            };

            foreach(char s in input)
            {
                string str = s.ToString().ToLower();
                if (dic.ContainsKey(str))
                {
                    stringBuilder.Replace(str, dic[str]);
                }
            }

            return stringBuilder.ToString();
        }
        private void cbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            HierachicalName = string.Empty;
            if (null != cbCategories.SelectedItem)
            {
                ESPCategory category = cbCategories.SelectedItem as ESPCategory;
                if (null == category)
                    return;

                HierachicalName = category.Name;
            }

            if (HierachicalName != string.Empty)
                txtCategoryName.Text = HierachicalName + "-" + RemoveTone(txtCategoryTitle.Text);
            else
                txtCategoryName.Text = RemoveTone(txtCategoryTitle.Text);

            if (Mode != EditorMode.None)
            {
                btnCategory_Save.Enabled = (txtCategoryName.Text.Length > 0 ||
                    txtCategoryTitle.Text.Length > 0);
            }

        }

        private void txtCategoryTitle_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCategoryName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mode = EditorMode.None;
            btnCategory_Save.Enabled = false;

            cbCategories.SelectedIndex = -1;
            txtCategoryName.Text = string.Empty;
            txtCategoryTitle.Text = string.Empty;
            txtCategoryID.Text = "0";

            txtCategoryName.ReadOnly = (Mode == EditorMode.None);
            txtCategoryTitle.ReadOnly = (Mode == EditorMode.None);
            cbCategories.Enabled = (Mode != EditorMode.None);

            if (null == lbCategories.SelectedItem)
                return;

            ESPCategory selCat = lbCategories.SelectedItem as ESPCategory;
            if (selCat == null)
                return;

            ESPCategory parentCat = selCat.ParentObject;
            if (null != parentCat)
                cbCategories.SelectedIndex = cbCategories.FindStringExact(parentCat.DisplayName);

            txtCategoryID.Text = selCat.Id.ToString();
            txtCategoryName.Text = selCat.Name;
            txtCategoryTitle.Text = selCat.Title;
        }

        private void lbCategories_DoubleClick(object sender, EventArgs e)
        {
            Mode = EditorMode.Edit;
            btnCategory_Save.Enabled = false;

            txtCategoryName.ReadOnly = (Mode == EditorMode.None);
            txtCategoryTitle.ReadOnly = (Mode == EditorMode.None);
            cbCategories.Enabled = (Mode != EditorMode.None);

            txtCategoryName.Focus();
        }

        private void txtCategoryTitle_KeyUp(object sender, KeyEventArgs e)
        {
            if (HierachicalName != string.Empty)
                txtCategoryName.Text = HierachicalName + "-" + RemoveTone(txtCategoryTitle.Text);
            else
                txtCategoryName.Text = RemoveTone(txtCategoryTitle.Text);

            if (Mode != EditorMode.None)
            {
                btnCategory_Save.Enabled = (txtCategoryName.Text.Length > 0 ||
                    txtCategoryTitle.Text.Length > 0);
            }
        }

        private void lvwSystem_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void lbCategories_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    {
                        if (null == lbCategories.SelectedItems)
                            return;

                        bool bChanged = false;
                        foreach(var obj in lbCategories.SelectedItems)
                        {
                            ESPCategory category = obj as ESPCategory;
                            if (DeleteCategory(category))
                            {
                                bChanged = true;
                            }
                        }

                        if (!bChanged)
                            return;

                        Mode = EditorMode.None;
                        btnCategory_Save.Enabled = false;

                        cbCategories.SelectedIndex = -1;
                        txtCategoryName.ReadOnly = (Mode == EditorMode.None);
                        txtCategoryTitle.ReadOnly = (Mode == EditorMode.None);

                        LoadCategories();
                    }
                    break;
                default:
                    break;
            }
        }

        private void lbClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mode = EditorMode.None;
            btnClass_Save.Enabled = false;

            txtClassName.Text = string.Empty;
            txtClassTitle.Text = string.Empty;
            txtClassId.Text = "0";

            txtClassName.ReadOnly = (Mode == EditorMode.None);
            txtClassTitle.ReadOnly = (Mode == EditorMode.None);

            if (null == lbClasses.SelectedItem)
                return;

            ESPClass selCat = lbClasses.SelectedItem as ESPClass;
            if (selCat == null)
                return;

            txtClassId.Text = selCat.Id.ToString();
            txtClassName.Text = selCat.Name;
            txtClassTitle.Text = selCat.Title;
        }

        private void txtClassName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtClassTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClass_New_Click(object sender, EventArgs e)
        {
            Mode = EditorMode.AddNew;

            txtClassName.Text = string.Empty;
            txtClassTitle.Text = string.Empty;

            txtClassName.ReadOnly = (Mode == EditorMode.None);
            txtClassTitle.ReadOnly = (Mode == EditorMode.None);

            AcceptButton = btnClass_Save;
            txtClassName.Focus();
        }

        private void btnClass_Save_Click(object sender, EventArgs e)
        {
            ESPClass cls = new ESPClass(txtClassName.Text, txtClassTitle.Text);
            if (Mode == EditorMode.Edit)
            {
                cls.Id = long.Parse(txtClassId.Text);
            }

            if (!ValidateClass(cls))
            {
                txtClassName.Focus();
                return;
            }

            if (!SaveClass(cls))
            {
                return;
            }
            MessageBox.Show("Saved!", "Class information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Mode = EditorMode.None;
            btnClass_Save.Enabled = false;

            txtClassName.ReadOnly = (Mode == EditorMode.None);
            txtClassTitle.ReadOnly = (Mode == EditorMode.None);

            LoadClasses();
            btnClass_New.Focus();
        }

        private void lbClasses_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    {
                        if (null == lbClasses.SelectedItems)
                            return;

                        bool bChanged = false;
                        foreach (var obj in lbClasses.SelectedItems)
                        {
                            ESPClass cls = obj as ESPClass;
                            if (DeleteClass(cls))
                            {
                                bChanged = true;
                            }
                        }

                        if (!bChanged)
                            return;

                        Mode = EditorMode.None;
                        btnClass_Save.Enabled = false;

                        txtClassName.ReadOnly = (Mode == EditorMode.None);
                        txtClassTitle.ReadOnly = (Mode == EditorMode.None);

                        LoadClasses();
                    }
                    break;
                default:
                    break;
            }
        }

        private void txtClassName_KeyUp(object sender, KeyEventArgs e)
        {
            btnClass_Save.Enabled = (
                txtClassName.Text != string.Empty
                && txtClassTitle.Text != string.Empty
                );
        }

        private void txtClassTitle_KeyUp(object sender, KeyEventArgs e)
        {
            btnClass_Save.Enabled = (
                txtClassName.Text != string.Empty
                && txtClassTitle.Text != string.Empty
                );
        }

        private void txtCategoryName_KeyUp(object sender, KeyEventArgs e)
        {
            if (Mode != EditorMode.None)
            {
                btnCategory_Save.Enabled = (txtCategoryName.Text.Length > 0 ||
                    txtCategoryTitle.Text.Length > 0);
            }
        }

        private void lbClasses_DoubleClick(object sender, EventArgs e)
        {
            Mode = EditorMode.Edit;
            btnClass_Save.Enabled = false;

            txtClassName.ReadOnly = (Mode == EditorMode.None);
            txtClassTitle.ReadOnly = (Mode == EditorMode.None);
            txtClassName.Focus();
        }

        private void btnVocab_New_Click(object sender, EventArgs e)
        {
            Mode = EditorMode.AddNew;

            txtVocabName.Text = string.Empty;
            
            txtVocabName.ReadOnly = (Mode == EditorMode.None);

            AcceptButton = btnVocab_Save;
            txtVocabName.Focus();
        }

        private void btnVocab_Save_Click(object sender, EventArgs e)
        {
            ESPVocabulary vocab  = new ESPVocabulary(txtVocabName.Text);
            if (Mode == EditorMode.Edit)
            {
                MessageBox.Show("Invalid edit mode.");
                return;
            }

            if (!ValidateVocabulary(vocab))
            {
                txtVocabName.Focus();
                return;
            }

            if (!SaveVocabulary(vocab))
            {
                return;
            }
            MessageBox.Show("Saved!", "Vocabulary information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Mode = EditorMode.None;
            btnVocab_Save.Enabled = false;

            txtVocabName.ReadOnly = (Mode == EditorMode.None);

            LoadVocabularies();
            btnVocab_New.Focus();
        }

        private void txtVocabName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbVocabularies_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mode = EditorMode.None;

            txtVocabName.Text = string.Empty; 
            txtVocabName.ReadOnly = (Mode == EditorMode.None);
            btnVocab_Save.Enabled = false;

            if (null == lbVocabularies.SelectedItem)
                return;

            ESPVocabulary vocabulary = lbVocabularies.SelectedItem as ESPVocabulary;
            if (null == vocabulary)
                return;

            txtVocabName.Text = vocabulary.Name;
        }

        private void lbVocabularies_DoubleClick(object sender, EventArgs e)
        {

        }

        private void lbVocabularies_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txtVocabName_KeyUp(object sender, KeyEventArgs e)
        {
            btnVocab_Save.Enabled = txtVocabName.Text != string.Empty;
        }

        private void lbVocabularies_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    {
                        if (null == lbVocabularies.SelectedItems)
                            return;

                        bool bChanged = false;
                        foreach (var obj in lbVocabularies.SelectedItems)
                        {
                            ESPVocabulary vocab = obj as ESPVocabulary;
                            if (DeleteVocabulary(vocab))
                            {
                                bChanged = true;
                            }
                        }

                        if (!bChanged)
                            return;

                        Mode = EditorMode.None;
                        btnVocab_Save.Enabled = false;

                        txtVocabName.ReadOnly = (Mode == EditorMode.None);

                        LoadVocabularies();
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
