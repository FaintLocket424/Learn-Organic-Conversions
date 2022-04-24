namespace ChemistryOrganicMechanisms
{
    public partial class Form_Edit_Category : Form
    {
        private static readonly List<int> _checked = new();

        public Form_Edit_Category()
        {
            InitializeComponent();
        }

        private void Button_Exit_Custom_Edit_Click(object sender, EventArgs e)
        {
            CheckBox[] checkBoxes = new CheckBox[]
            {
                CheckBox_Alcohol_To_Aldehyde,
                CheckBox_Alcohol_To_Alkene,
                CheckBox_Alcohol_To_Ketone,
                CheckBox_Aldehyde_To_CarboxylicAcid,
                CheckBox_Alkane_To_Haloalkane,
                CheckBox_Alkene_To_Alcohol,
                CheckBox_Alkene_To_Alkane,
                CheckBox_Alkene_To_Dihaloalkane,
                CheckBox_Alkene_To_Haloalkane,
                CheckBox_Alkene_To_Hydrogensulfate,
                CheckBox_Haloalkane_To_Alcohol,
                CheckBox_Haloalkane_To_Alkene,
                CheckBox_Haloalkane_To_Amine,
                CheckBox_Haloalkane_To_Nitrile
            };

            var map = new Dictionary<CheckBox, int>()
            {
                {CheckBox_Alcohol_To_Aldehyde, 2},
                {CheckBox_Alcohol_To_Alkene, 0},
                {CheckBox_Alcohol_To_Ketone, 4},
                {CheckBox_Aldehyde_To_CarboxylicAcid, 3},
                {CheckBox_Alkane_To_Haloalkane, 10},
                {CheckBox_Alkene_To_Alcohol, 1},
                {CheckBox_Alkene_To_Alkane, 9},
                {CheckBox_Alkene_To_Dihaloalkane, 13},
                {CheckBox_Alkene_To_Haloalkane, 7},
                {CheckBox_Alkene_To_Hydrogensulfate, 5},
                {CheckBox_Haloalkane_To_Alcohol, 6},
                {CheckBox_Haloalkane_To_Alkene, 8},
                {CheckBox_Haloalkane_To_Amine, 12},
                {CheckBox_Haloalkane_To_Nitrile, 11},
            };

            _checked.Clear();
            foreach (CheckBox checkBox in checkBoxes)
            {
                if (checkBox.Checked)
                {
                    _checked.Add(map[checkBox]);
                }
            }

            Hide();
        }

        private void Form_Edit_Category_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        public static List<int> Checked { get => _checked; }
    }
}
