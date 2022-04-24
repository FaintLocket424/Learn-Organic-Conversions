namespace ChemistryOrganicMechanisms
{
    partial class Form_Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.Combo_Category = new System.Windows.Forms.ComboBox();
            this.Label_Category = new System.Windows.Forms.Label();
            this.Button_New_Conversion = new System.Windows.Forms.Button();
            this.TextBox_Conversion = new System.Windows.Forms.TextBox();
            this.Label_Conversion = new System.Windows.Forms.Label();
            this.RichTextBox_Debug = new System.Windows.Forms.RichTextBox();
            this.Label_Debug = new System.Windows.Forms.Label();
            this.TextBox_Conditions = new System.Windows.Forms.TextBox();
            this.Label_Conditions = new System.Windows.Forms.Label();
            this.Label_Mechanism = new System.Windows.Forms.Label();
            this.PictureBox_Mechanism = new System.Windows.Forms.PictureBox();
            this.Button_Check_Answer = new System.Windows.Forms.Button();
            this.TextBox_Conditions_Answer = new System.Windows.Forms.TextBox();
            this.TextBox_Mechanism_Answer = new System.Windows.Forms.TextBox();
            this.Label_Conditions_Answer = new System.Windows.Forms.Label();
            this.Label_Mechanism_Answer = new System.Windows.Forms.Label();
            this.Label_Reactants = new System.Windows.Forms.Label();
            this.TextBox_Reactants = new System.Windows.Forms.TextBox();
            this.Label_Reactants_Answer = new System.Windows.Forms.Label();
            this.TextBox_Reactants_Answer = new System.Windows.Forms.TextBox();
            this.Button_Show_Answer = new System.Windows.Forms.Button();
            this.Combo_Mechanism = new System.Windows.Forms.ComboBox();
            this.Button_Edit_Custom = new System.Windows.Forms.Button();
            this.RichTextBox_Info = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Mechanism)).BeginInit();
            this.SuspendLayout();
            // 
            // Combo_Category
            // 
            this.Combo_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_Category.FormattingEnabled = true;
            this.Combo_Category.Items.AddRange(new object[] {
            "All",
            "Alcohol Related",
            "Haloalkane Related",
            "Custom"});
            this.Combo_Category.Location = new System.Drawing.Point(12, 27);
            this.Combo_Category.Name = "Combo_Category";
            this.Combo_Category.Size = new System.Drawing.Size(148, 23);
            this.Combo_Category.TabIndex = 0;
            this.Combo_Category.SelectedIndexChanged += new System.EventHandler(this.Combo_Category_SelectedIndexChanged);
            // 
            // Label_Category
            // 
            this.Label_Category.AutoSize = true;
            this.Label_Category.Location = new System.Drawing.Point(12, 9);
            this.Label_Category.Name = "Label_Category";
            this.Label_Category.Size = new System.Drawing.Size(55, 15);
            this.Label_Category.TabIndex = 1;
            this.Label_Category.Text = "Category";
            // 
            // Button_New_Conversion
            // 
            this.Button_New_Conversion.Enabled = false;
            this.Button_New_Conversion.Location = new System.Drawing.Point(12, 56);
            this.Button_New_Conversion.Name = "Button_New_Conversion";
            this.Button_New_Conversion.Size = new System.Drawing.Size(68, 23);
            this.Button_New_Conversion.TabIndex = 1;
            this.Button_New_Conversion.Text = "New";
            this.Button_New_Conversion.UseVisualStyleBackColor = true;
            this.Button_New_Conversion.Click += new System.EventHandler(this.Button_New_Conversion_Click);
            // 
            // TextBox_Conversion
            // 
            this.TextBox_Conversion.Location = new System.Drawing.Point(287, 28);
            this.TextBox_Conversion.Name = "TextBox_Conversion";
            this.TextBox_Conversion.ReadOnly = true;
            this.TextBox_Conversion.Size = new System.Drawing.Size(300, 23);
            this.TextBox_Conversion.TabIndex = 3;
            this.TextBox_Conversion.Visible = false;
            // 
            // Label_Conversion
            // 
            this.Label_Conversion.AutoSize = true;
            this.Label_Conversion.Location = new System.Drawing.Point(287, 10);
            this.Label_Conversion.Name = "Label_Conversion";
            this.Label_Conversion.Size = new System.Drawing.Size(67, 15);
            this.Label_Conversion.TabIndex = 4;
            this.Label_Conversion.Text = "Conversion";
            this.Label_Conversion.Visible = false;
            // 
            // RichTextBox_Debug
            // 
            this.RichTextBox_Debug.Location = new System.Drawing.Point(12, 293);
            this.RichTextBox_Debug.Name = "RichTextBox_Debug";
            this.RichTextBox_Debug.ReadOnly = true;
            this.RichTextBox_Debug.Size = new System.Drawing.Size(269, 66);
            this.RichTextBox_Debug.TabIndex = 12;
            this.RichTextBox_Debug.TabStop = false;
            this.RichTextBox_Debug.Text = "";
            // 
            // Label_Debug
            // 
            this.Label_Debug.AutoSize = true;
            this.Label_Debug.Location = new System.Drawing.Point(12, 275);
            this.Label_Debug.Name = "Label_Debug";
            this.Label_Debug.Size = new System.Drawing.Size(42, 15);
            this.Label_Debug.TabIndex = 6;
            this.Label_Debug.Text = "Debug";
            // 
            // TextBox_Conditions
            // 
            this.TextBox_Conditions.Location = new System.Drawing.Point(287, 116);
            this.TextBox_Conditions.Name = "TextBox_Conditions";
            this.TextBox_Conditions.Size = new System.Drawing.Size(300, 23);
            this.TextBox_Conditions.TabIndex = 5;
            this.TextBox_Conditions.Visible = false;
            // 
            // Label_Conditions
            // 
            this.Label_Conditions.AutoSize = true;
            this.Label_Conditions.Location = new System.Drawing.Point(287, 98);
            this.Label_Conditions.Name = "Label_Conditions";
            this.Label_Conditions.Size = new System.Drawing.Size(65, 15);
            this.Label_Conditions.TabIndex = 8;
            this.Label_Conditions.Text = "Conditions";
            this.Label_Conditions.Visible = false;
            // 
            // Label_Mechanism
            // 
            this.Label_Mechanism.AutoSize = true;
            this.Label_Mechanism.Location = new System.Drawing.Point(287, 142);
            this.Label_Mechanism.Name = "Label_Mechanism";
            this.Label_Mechanism.Size = new System.Drawing.Size(69, 15);
            this.Label_Mechanism.TabIndex = 9;
            this.Label_Mechanism.Text = "Mechanism";
            this.Label_Mechanism.Visible = false;
            // 
            // PictureBox_Mechanism
            // 
            this.PictureBox_Mechanism.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PictureBox_Mechanism.Image = global::ChemistryOrganicMechanisms.Properties.Resources.Carbon_Icon;
            this.PictureBox_Mechanism.Location = new System.Drawing.Point(12, 365);
            this.PictureBox_Mechanism.Name = "PictureBox_Mechanism";
            this.PictureBox_Mechanism.Size = new System.Drawing.Size(575, 182);
            this.PictureBox_Mechanism.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox_Mechanism.TabIndex = 10;
            this.PictureBox_Mechanism.TabStop = false;
            // 
            // Button_Check_Answer
            // 
            this.Button_Check_Answer.Location = new System.Drawing.Point(287, 189);
            this.Button_Check_Answer.Name = "Button_Check_Answer";
            this.Button_Check_Answer.Size = new System.Drawing.Size(103, 23);
            this.Button_Check_Answer.TabIndex = 7;
            this.Button_Check_Answer.Text = "Check Answer";
            this.Button_Check_Answer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Button_Check_Answer.UseVisualStyleBackColor = true;
            this.Button_Check_Answer.Visible = false;
            this.Button_Check_Answer.Click += new System.EventHandler(this.Button_Check_Answer_Click);
            // 
            // TextBox_Conditions_Answer
            // 
            this.TextBox_Conditions_Answer.Location = new System.Drawing.Point(287, 293);
            this.TextBox_Conditions_Answer.Name = "TextBox_Conditions_Answer";
            this.TextBox_Conditions_Answer.ReadOnly = true;
            this.TextBox_Conditions_Answer.Size = new System.Drawing.Size(300, 23);
            this.TextBox_Conditions_Answer.TabIndex = 10;
            this.TextBox_Conditions_Answer.Visible = false;
            // 
            // TextBox_Mechanism_Answer
            // 
            this.TextBox_Mechanism_Answer.Location = new System.Drawing.Point(287, 337);
            this.TextBox_Mechanism_Answer.Name = "TextBox_Mechanism_Answer";
            this.TextBox_Mechanism_Answer.ReadOnly = true;
            this.TextBox_Mechanism_Answer.Size = new System.Drawing.Size(300, 23);
            this.TextBox_Mechanism_Answer.TabIndex = 11;
            this.TextBox_Mechanism_Answer.Visible = false;
            // 
            // Label_Conditions_Answer
            // 
            this.Label_Conditions_Answer.AutoSize = true;
            this.Label_Conditions_Answer.Location = new System.Drawing.Point(287, 275);
            this.Label_Conditions_Answer.Name = "Label_Conditions_Answer";
            this.Label_Conditions_Answer.Size = new System.Drawing.Size(65, 15);
            this.Label_Conditions_Answer.TabIndex = 15;
            this.Label_Conditions_Answer.Text = "Conditions";
            this.Label_Conditions_Answer.Visible = false;
            // 
            // Label_Mechanism_Answer
            // 
            this.Label_Mechanism_Answer.AutoSize = true;
            this.Label_Mechanism_Answer.Location = new System.Drawing.Point(287, 319);
            this.Label_Mechanism_Answer.Name = "Label_Mechanism_Answer";
            this.Label_Mechanism_Answer.Size = new System.Drawing.Size(69, 15);
            this.Label_Mechanism_Answer.TabIndex = 16;
            this.Label_Mechanism_Answer.Text = "Mechanism";
            this.Label_Mechanism_Answer.Visible = false;
            // 
            // Label_Reactants
            // 
            this.Label_Reactants.AutoSize = true;
            this.Label_Reactants.Location = new System.Drawing.Point(287, 54);
            this.Label_Reactants.Name = "Label_Reactants";
            this.Label_Reactants.Size = new System.Drawing.Size(58, 15);
            this.Label_Reactants.TabIndex = 17;
            this.Label_Reactants.Text = "Reactants";
            this.Label_Reactants.Visible = false;
            // 
            // TextBox_Reactants
            // 
            this.TextBox_Reactants.Location = new System.Drawing.Point(287, 72);
            this.TextBox_Reactants.Name = "TextBox_Reactants";
            this.TextBox_Reactants.Size = new System.Drawing.Size(300, 23);
            this.TextBox_Reactants.TabIndex = 4;
            this.TextBox_Reactants.Visible = false;
            // 
            // Label_Reactants_Answer
            // 
            this.Label_Reactants_Answer.AutoSize = true;
            this.Label_Reactants_Answer.Location = new System.Drawing.Point(287, 231);
            this.Label_Reactants_Answer.Name = "Label_Reactants_Answer";
            this.Label_Reactants_Answer.Size = new System.Drawing.Size(58, 15);
            this.Label_Reactants_Answer.TabIndex = 19;
            this.Label_Reactants_Answer.Text = "Reactants";
            this.Label_Reactants_Answer.Visible = false;
            // 
            // TextBox_Reactants_Answer
            // 
            this.TextBox_Reactants_Answer.BackColor = System.Drawing.SystemColors.Control;
            this.TextBox_Reactants_Answer.Location = new System.Drawing.Point(287, 249);
            this.TextBox_Reactants_Answer.Name = "TextBox_Reactants_Answer";
            this.TextBox_Reactants_Answer.ReadOnly = true;
            this.TextBox_Reactants_Answer.Size = new System.Drawing.Size(300, 23);
            this.TextBox_Reactants_Answer.TabIndex = 9;
            this.TextBox_Reactants_Answer.Visible = false;
            // 
            // Button_Show_Answer
            // 
            this.Button_Show_Answer.Location = new System.Drawing.Point(396, 189);
            this.Button_Show_Answer.Name = "Button_Show_Answer";
            this.Button_Show_Answer.Size = new System.Drawing.Size(103, 23);
            this.Button_Show_Answer.TabIndex = 8;
            this.Button_Show_Answer.Text = "Show Answer";
            this.Button_Show_Answer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Button_Show_Answer.UseVisualStyleBackColor = true;
            this.Button_Show_Answer.Visible = false;
            this.Button_Show_Answer.Click += new System.EventHandler(this.Button_Show_Answer_Click);
            // 
            // Combo_Mechanism
            // 
            this.Combo_Mechanism.BackColor = System.Drawing.SystemColors.Window;
            this.Combo_Mechanism.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_Mechanism.FormattingEnabled = true;
            this.Combo_Mechanism.Items.AddRange(new object[] {
            "Electrophilic Addition",
            "Nucleophilic Substitution",
            "Elimination",
            "Free Radical Substitution",
            "NA"});
            this.Combo_Mechanism.Location = new System.Drawing.Point(287, 160);
            this.Combo_Mechanism.Name = "Combo_Mechanism";
            this.Combo_Mechanism.Size = new System.Drawing.Size(300, 23);
            this.Combo_Mechanism.TabIndex = 6;
            this.Combo_Mechanism.Visible = false;
            // 
            // Button_Edit_Custom
            // 
            this.Button_Edit_Custom.Enabled = false;
            this.Button_Edit_Custom.Location = new System.Drawing.Point(86, 56);
            this.Button_Edit_Custom.Name = "Button_Edit_Custom";
            this.Button_Edit_Custom.Size = new System.Drawing.Size(74, 23);
            this.Button_Edit_Custom.TabIndex = 2;
            this.Button_Edit_Custom.Text = "Edit";
            this.Button_Edit_Custom.UseVisualStyleBackColor = true;
            this.Button_Edit_Custom.Click += new System.EventHandler(this.Button_Edit_Custom_Click);
            // 
            // RichTextBox_Info
            // 
            this.RichTextBox_Info.BackColor = System.Drawing.SystemColors.Control;
            this.RichTextBox_Info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichTextBox_Info.Location = new System.Drawing.Point(12, 116);
            this.RichTextBox_Info.Name = "RichTextBox_Info";
            this.RichTextBox_Info.ReadOnly = true;
            this.RichTextBox_Info.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RichTextBox_Info.Size = new System.Drawing.Size(269, 146);
            this.RichTextBox_Info.TabIndex = 13;
            this.RichTextBox_Info.TabStop = false;
            this.RichTextBox_Info.Text = "Info:\nCreated By FaintLocket424\n\nNotes:\nAny Halogens will be Bromine\nAny Shortene" +
    "d Words will end with a .\nThe input must exactly match the input to be counted a" +
    "s correct (not case sensitive)";
            // 
            // Form_Main
            // 
            this.AcceptButton = this.Button_Check_Answer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 553);
            this.Controls.Add(this.RichTextBox_Info);
            this.Controls.Add(this.Button_Edit_Custom);
            this.Controls.Add(this.Combo_Mechanism);
            this.Controls.Add(this.Button_Show_Answer);
            this.Controls.Add(this.TextBox_Reactants_Answer);
            this.Controls.Add(this.Label_Reactants_Answer);
            this.Controls.Add(this.TextBox_Reactants);
            this.Controls.Add(this.Label_Reactants);
            this.Controls.Add(this.Label_Mechanism_Answer);
            this.Controls.Add(this.Label_Conditions_Answer);
            this.Controls.Add(this.TextBox_Mechanism_Answer);
            this.Controls.Add(this.TextBox_Conditions_Answer);
            this.Controls.Add(this.Button_Check_Answer);
            this.Controls.Add(this.PictureBox_Mechanism);
            this.Controls.Add(this.Label_Mechanism);
            this.Controls.Add(this.Label_Conditions);
            this.Controls.Add(this.TextBox_Conditions);
            this.Controls.Add(this.Label_Debug);
            this.Controls.Add(this.RichTextBox_Debug);
            this.Controls.Add(this.Label_Conversion);
            this.Controls.Add(this.TextBox_Conversion);
            this.Controls.Add(this.Button_New_Conversion);
            this.Controls.Add(this.Label_Category);
            this.Controls.Add(this.Combo_Category);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Main";
            this.Text = "Organic Chemistry Conversions";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Mechanism)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox Combo_Category;
        private Label Label_Category;
        private Button Button_New_Conversion;
        private TextBox TextBox_Conversion;
        private Label Label_Conversion;
        private RichTextBox RichTextBox_Debug;
        private Label Label_Debug;
        private TextBox TextBox_Conditions;
        private Label Label_Conditions;
        private Label Label_Mechanism;
        private PictureBox PictureBox_Mechanism;
        private Button Button_Check_Answer;
        private TextBox TextBox_Conditions_Answer;
        private TextBox TextBox_Mechanism_Answer;
        private Label Label_Conditions_Answer;
        private Label Label_Mechanism_Answer;
        private Label Label_Reactants;
        private TextBox TextBox_Reactants;
        private Label Label_Reactants_Answer;
        private TextBox TextBox_Reactants_Answer;
        private Button Button_Show_Answer;
        private ComboBox Combo_Mechanism;
        private Button Button_Edit_Custom;
        private RichTextBox RichTextBox_Info;
    }
}