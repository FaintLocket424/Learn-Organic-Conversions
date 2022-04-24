using System.Resources;

namespace ChemistryOrganicMechanisms
{
    public partial class Form_Main : Form
    {
        private static Conversion[] AllConversions = Array.Empty<Conversion>();
        private static Conversion[] AlcoholConversions = Array.Empty<Conversion>();
        private static Conversion[] HaloalkaneConversions = Array.Empty<Conversion>();
        private static readonly Random random = new();

        private const int AllConversionsIndex = 0;
        private const int AlcoholConversionsIndex = 1;
        private const int HaloalkaneConversionsIndex = 2;
        private const int CustomConversionsIndex = 3;

        private readonly Form_Edit_Category form_Edit_Category = new();

        public Form_Main()
        {
            InitializeComponent();

            AllConversions = new Conversion[]
            {
                new Conversion("Alcohol to Alkene",                 new string[] { "Conc. H2SO4" },                         new string[] { "Acid Cat." },                           "Elimination",                      Properties.Resources.Alcohol_to_Alkene),
                new Conversion("Alkene to Alcohol",                 new string[] { "Steam", "H2SO4" },                      new string[] { "180c" },                                "Electrophilic Addition",           Properties.Resources.Alkene_to_Alcohol),
                new Conversion("Alcohol to Aldehyde",               new string[] { "Primary Alcohol", "H+/K2Cr2O7" },       new string[] { "Hot", "Distilled" },                    "NA",                               Properties.Resources.Carbon_Icon),
                new Conversion("Aldehyde to Carboxylic Acid",       new string[] { "H+/K2Cr2O7" },                          new string[] { "Reflux", "Hot" },                       "NA",                               Properties.Resources.Carbon_Icon),
                new Conversion("Alcohol to Ketone",                 new string[] { "Secondary Alcohol", "H+/K2Cr2O7" },     new string[] { "Reflux", "Hot" },                       "NA",                               Properties.Resources.Carbon_Icon),
                new Conversion("Alkene to Alkyl Hydrogensulfate",   new string[] { "Conc. H2SO4" },                         new string[] { "NA" },                                  "Electrophilic Addition",           Properties.Resources.Alkene_to_Alkyl_Hydrogensulfate),
                new Conversion("Haloalkane to Alcohol",             new string[] { "Aqueous KOH" },                         new string[] { "Reflux" },                              "Nucleophilic Substitution",        Properties.Resources.Haloalkane_to_Alcohol),
                new Conversion("Alkene to Haloalkane",              new string[] { "HBr" },                                 new string[] { "Room Temp." },                          "Electrophilic Addition",           Properties.Resources.Alkene_to_Haloalkane),
                new Conversion("Haloalkane to Alkene",              new string[] { "KOH" },                                 new string[] { "Alcoholic" },                           "Elimination",                      Properties.Resources.Haloalkane_to_Alkene),
                new Conversion("Alkene to Alkane",                  new string[] { "H2" },                                  new string[] { "Nickel Catalyst" },                     "NA",                               Properties.Resources.Carbon_Icon),
                new Conversion("Alkane to Haloalkane",              new string[] { "Br2" },                                 new string[] { "UV Light" },                            "Free Radical Substitution",        Properties.Resources.Alkane_to_Haloalkane),
                new Conversion("Haloalkane to Nitrile",             new string[] { "KCN" },                                 new string[] { "Ethanolic", "Reflux" },                 "Nucleophilic Substitution",        Properties.Resources.Haloalkane_to_Nitrile),
                new Conversion("Haloalkane to Amine",               new string[] { "NH3" },                                 new string[] { "Alcoholic", "Hot", "Pressurised" },     "Nucleophilic Substitution",        Properties.Resources.Haloalkane_to_Amine),
                new Conversion("Alkene to Dihaloalkane",            new string[] { "Br2" },                                 new string[] { "Room Temp." },                          "Elecrophilic Addition",            Properties.Resources.Alkene_to_Dihaloalkane)
            };

            AlcoholConversions = new Conversion[]
            {
                AllConversions[0],
                AllConversions[1],
                AllConversions[2],
                AllConversions[3],
                AllConversions[4],
                AllConversions[6]
            };

            HaloalkaneConversions = new Conversion[]
            {
                AllConversions[6],
                AllConversions[7],
                AllConversions[8],
                AllConversions[10],
                AllConversions[11],
                AllConversions[12],
                AllConversions[13],
            };
        }

        private void Button_New_Conversion_Click(object sender, EventArgs e)
        {
            TextBox_Mechanism_Answer.BackColor = Color.FromKnownColor(KnownColor.Control);
            TextBox_Conditions_Answer.BackColor = Color.FromKnownColor(KnownColor.Control);
            TextBox_Reactants_Answer.BackColor = Color.FromKnownColor(KnownColor.Control);

            Combo_Mechanism.Text = "";
            TextBox_Conditions.Text = "";
            TextBox_Reactants.Text = "";
            TextBox_Mechanism_Answer.Text = "";
            TextBox_Conditions_Answer.Text = "";
            TextBox_Reactants_Answer.Text = "";

            string prevConversion = TextBox_Conversion.Text;
            TextBox_Conversion.Text = "";

            PictureBox_Mechanism.Image = Properties.Resources.Carbon_Icon;

            switch (Combo_Category.SelectedIndex)
            {
                case -1:
                    //selected nothing
                    TextBox_Conversion.Text = "Pick a category.";
                    break;
                case AllConversionsIndex:
                    //selected All
                    while (true)
                    {
                        string choice = AllConversions[random.Next(0, AllConversions.Length)].ConversionName;
                        if (choice != prevConversion)
                        {
                            TextBox_Conversion.Text = choice;
                            break;
                        }
                    }
                    break;
                case AlcoholConversionsIndex:
                    //selected Alcohols
                    while (true)
                    {
                        string choice = AlcoholConversions[random.Next(0, AlcoholConversions.Length)].ConversionName;
                        if (choice != prevConversion)
                        {
                            TextBox_Conversion.Text = choice;
                            break;
                        }
                    }
                    break;
                case HaloalkaneConversionsIndex:
                    //selected Haloalkanes
                    while (true)
                    {
                        string choice = HaloalkaneConversions[random.Next(0, HaloalkaneConversions.Length)].ConversionName;
                        if (choice != prevConversion)
                        {
                            TextBox_Conversion.Text = choice;
                            break;
                        }
                    }
                    break;
                case CustomConversionsIndex:
                    List<int> indexes = Form_Edit_Category.Checked;
                    if (indexes.Count == 0)
                    {
                        RichTextBox_Debug.Text = "Use the edit button to select some options first.";
                        return;
                    }

                    Conversion[] CustomConversions = new Conversion[indexes.Count];
                    
                    for (int i = 0; i < indexes.Count; i++)
                    {
                        CustomConversions[i] = AllConversions[indexes[i]];
                    }

                    while (true)
                    {
                        string choice = CustomConversions[random.Next(0, CustomConversions.Length)].ConversionName;
                        if ((choice != prevConversion) || (indexes.Count == 1))
                        {
                            TextBox_Conversion.Text = choice;
                            break;
                        }
                    }
                    break;
                default:
                    //something has gone wrong
                    RichTextBox_Debug.Text = "Error in loading. Code 1.";
                    break;
            }

            if (!Label_Conversion.Visible)
            {
                Label_Conversion.Visible = true;
                TextBox_Conversion.Visible = true;
                Label_Reactants.Visible = true;
                TextBox_Reactants.Visible = true;
                Label_Conditions.Visible = true;
                TextBox_Conditions.Visible = true;
                Label_Mechanism.Visible = true;
                Combo_Mechanism.Visible = true;
                Button_Check_Answer.Visible = true;
                Button_Show_Answer.Visible = true;
                Label_Reactants_Answer.Visible = true;
                TextBox_Reactants_Answer.Visible = true;
                Label_Conditions_Answer.Visible = true;
                TextBox_Conditions_Answer.Visible = true;
                Label_Mechanism_Answer.Visible = true;
                TextBox_Mechanism_Answer.Visible = true;
            }
        }

        private void Button_Check_Answer_Click(object sender, EventArgs e)
        {
            string debugOutput = "";

            //ingest answers
            string[] reactants = TextBox_Reactants.Text.ToLower().Trim(' ').Split(',');
            string[] conditions = TextBox_Conditions.Text.ToLower().Trim(' ').Split(',');
            string mechanism = Combo_Mechanism.Text.Trim(' ');
            Conversion testedConversion = FindActiveConversion(TextBox_Conversion, RichTextBox_Debug);

            if (mechanism.Equals(testedConversion.Mechanism))
            {
                //they got the mechanism correct
                TextBox_Mechanism_Answer.BackColor = Color.FromArgb(42, 173, 59);
                TextBox_Mechanism_Answer.Text = testedConversion.Mechanism;
            }
            else
            {
                //they got the mechanism wrong
                TextBox_Mechanism_Answer.BackColor = Color.FromArgb(186, 34, 34);
            }

            bool ReactantsMatch = ArraysMatch(reactants, testedConversion.Reactants);

            if (ReactantsMatch)
            {
                TextBox_Reactants_Answer.BackColor = Color.FromArgb(42, 173, 59);
                TextBox_Reactants_Answer.Text = ConvertArrayToStringList(testedConversion.Reactants);
            }
            else
            {
                TextBox_Reactants_Answer.BackColor = Color.FromArgb(186, 34, 34);
            }

            bool ConditionsMatch = ArraysMatch(conditions, testedConversion.Conditions);

            if (ConditionsMatch)
            {
                TextBox_Conditions_Answer.BackColor = Color.FromArgb(42, 173, 59);
                TextBox_Conditions_Answer.Text = ConvertArrayToStringList(testedConversion.Conditions);
            }
            else
            {
                TextBox_Conditions_Answer.BackColor = Color.FromArgb(186, 34, 34);
            }

            RichTextBox_Debug.Text = debugOutput;
        }

        private void Button_Show_Answer_Click(object sender, EventArgs e)
        {
            Conversion testedConversion = FindActiveConversion(TextBox_Conversion, RichTextBox_Debug);

            TextBox_Conditions_Answer.Text = ConvertArrayToStringList(testedConversion.Conditions);
            TextBox_Mechanism_Answer.Text = testedConversion.Mechanism;
            TextBox_Reactants_Answer.Text = ConvertArrayToStringList(testedConversion.Reactants);
            PictureBox_Mechanism.Image = testedConversion.Image;
        }

        private void Button_Edit_Custom_Click(object sender, EventArgs e)
        {
            form_Edit_Category.Show();
        }

        private void Combo_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Button_New_Conversion.Enabled)
            {
                Button_New_Conversion.Enabled = true;
            }
            
            if (Combo_Category.SelectedIndex == CustomConversionsIndex)
            {
                //enable edit button
                Button_Edit_Custom.Enabled = true;
            }
            else
            {
                //disable edit button
                Button_Edit_Custom.Enabled = false;
            }
        }

        private static bool ArraysMatch(string[] array1, string[] array2)
        {
            bool array2ContainsArray1 = true;
            foreach (string element1 in array1)
            {
                bool given = false;
                //a reactant that should be given
                foreach (string element2 in array2)
                {
                    //a reactant given
                    if (element2.Trim(' ').ToLower().Equals(element1.Trim(' ')))
                    {
                        given = true;
                        break;
                    }
                }

                if (!given)
                {
                    array2ContainsArray1 = false;
                }
            }

            bool array1ContainsArray2 = true;
            foreach (string element1 in array2)
            {
                bool given = false;
                //a reactant that should be given
                foreach (string element2 in array1)
                {
                    //a reactant given
                    if (element1.Trim(' ').ToLower().Equals(element2.Trim(' ')))
                    {
                        given = true;
                        break;
                    }
                }

                if (!given)
                {
                    array1ContainsArray2 = false;
                }
            }

            return array2ContainsArray1 && array1ContainsArray2;
        }

        private static Conversion FindActiveConversion(TextBox conversionTextBox, RichTextBox debugTextBox)
        {
            Conversion _conversion = AllConversions[0];
            bool found = false;

            //find out what conversion is being tested
            foreach (Conversion conversion in AllConversions)
            {
                if (conversion.ConversionName.Equals(conversionTextBox.Text))
                {
                    //if this is the one we are testing
                    _conversion = conversion;
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                //if it didn't find any matching conversion
                debugTextBox.Text = "Error Finding Conversion. Code 2";
            }
            return _conversion;
        }

        private static string ConvertArrayToStringList(string[] ary)
        {
            string output = "";
            foreach (string str in ary)
            {
                output += str + ", ";
            }
            return output[0..^2];
        }
    }
}