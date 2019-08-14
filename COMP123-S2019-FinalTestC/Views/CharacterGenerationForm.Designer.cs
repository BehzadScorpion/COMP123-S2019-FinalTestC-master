namespace COMP123_S2019_FinalTestC.Views
{
    partial class CharacterGenerationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.IdentityPage = new System.Windows.Forms.TabPage();
            this.IdentityTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.GenerateNameButton = new System.Windows.Forms.Button();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameDataLabel = new System.Windows.Forms.Label();
            this.LastNameDataLabel = new System.Windows.Forms.Label();
            this.AbilityPage = new System.Windows.Forms.TabPage();
            this.AbilitiesTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.StrengthDataLabel = new System.Windows.Forms.Label();
            this.DexterityLabel = new System.Windows.Forms.Label();
            this.StrengthLabel = new System.Windows.Forms.Label();
            this.GenerateAbilitiesButton = new System.Windows.Forms.Button();
            this.EnduranceLabel = new System.Windows.Forms.Label();
            this.IntellectLabel = new System.Windows.Forms.Label();
            this.EducationLabel = new System.Windows.Forms.Label();
            this.SocialStandingLabel = new System.Windows.Forms.Label();
            this.DexterityDataLabel = new System.Windows.Forms.Label();
            this.EnduranceDataLabel = new System.Windows.Forms.Label();
            this.IntellectDataLabel = new System.Windows.Forms.Label();
            this.EducationDataLabel = new System.Windows.Forms.Label();
            this.SocialStandingDataLabel = new System.Windows.Forms.Label();
            this.SkillsPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SkillsLabel1 = new System.Windows.Forms.Label();
            this.SkillsLabel2 = new System.Windows.Forms.Label();
            this.SkillsLabel3 = new System.Windows.Forms.Label();
            this.SkillsLabel4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.GenerateSkillsButton = new System.Windows.Forms.Button();
            this.CharacterSheetPage = new System.Windows.Forms.TabPage();
            this.CharachterSheetTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SheetStrengthDataLabel = new System.Windows.Forms.Label();
            this.SheetDexterityDataLabel = new System.Windows.Forms.Label();
            this.SheetEnduranceDataLabel = new System.Windows.Forms.Label();
            this.SheetIntellectDataLabel = new System.Windows.Forms.Label();
            this.SheetEducationDataLabel = new System.Windows.Forms.Label();
            this.SheetSocialStandingDataLabel = new System.Windows.Forms.Label();
            this.SheetStrengthLabel = new System.Windows.Forms.Label();
            this.SheetDexterityLabel = new System.Windows.Forms.Label();
            this.SheetEnduranceLabel = new System.Windows.Forms.Label();
            this.SheetIntellectLabel = new System.Windows.Forms.Label();
            this.SheetEducationLabel = new System.Windows.Forms.Label();
            this.SheetSocialStandingLabel = new System.Windows.Forms.Label();
            this.SheetFirstNameLabel = new System.Windows.Forms.Label();
            this.SheetLastNameLabel = new System.Windows.Forms.Label();
            this.SheetFirstNameDataLabel = new System.Windows.Forms.Label();
            this.SheetLastNameDataLabel = new System.Windows.Forms.Label();
            this.SheetSkillsLabel = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.MainTabControl.SuspendLayout();
            this.IdentityPage.SuspendLayout();
            this.IdentityTableLayoutPanel.SuspendLayout();
            this.AbilityPage.SuspendLayout();
            this.AbilitiesTableLayoutPanel.SuspendLayout();
            this.SkillsPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.CharacterSheetPage.SuspendLayout();
            this.CharachterSheetTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.IdentityPage);
            this.MainTabControl.Controls.Add(this.AbilityPage);
            this.MainTabControl.Controls.Add(this.SkillsPage);
            this.MainTabControl.Controls.Add(this.CharacterSheetPage);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(686, 405);
            this.MainTabControl.TabIndex = 0;
            // 
            // IdentityPage
            // 
            this.IdentityPage.Controls.Add(this.IdentityTableLayoutPanel);
            this.IdentityPage.Location = new System.Drawing.Point(4, 38);
            this.IdentityPage.Name = "IdentityPage";
            this.IdentityPage.Padding = new System.Windows.Forms.Padding(3);
            this.IdentityPage.Size = new System.Drawing.Size(678, 363);
            this.IdentityPage.TabIndex = 0;
            this.IdentityPage.Text = "Identity";
            this.IdentityPage.UseVisualStyleBackColor = true;
            // 
            // IdentityTableLayoutPanel
            // 
            this.IdentityTableLayoutPanel.ColumnCount = 4;
            this.IdentityTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IdentityTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IdentityTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IdentityTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IdentityTableLayoutPanel.Controls.Add(this.FirstNameLabel, 0, 0);
            this.IdentityTableLayoutPanel.Controls.Add(this.GenerateNameButton, 2, 3);
            this.IdentityTableLayoutPanel.Controls.Add(this.LastNameLabel, 0, 1);
            this.IdentityTableLayoutPanel.Controls.Add(this.FirstNameDataLabel, 1, 0);
            this.IdentityTableLayoutPanel.Controls.Add(this.LastNameDataLabel, 1, 1);
            this.IdentityTableLayoutPanel.Location = new System.Drawing.Point(6, 6);
            this.IdentityTableLayoutPanel.Name = "IdentityTableLayoutPanel";
            this.IdentityTableLayoutPanel.RowCount = 4;
            this.IdentityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IdentityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IdentityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IdentityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IdentityTableLayoutPanel.Size = new System.Drawing.Size(663, 291);
            this.IdentityTableLayoutPanel.TabIndex = 0;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstNameLabel.Location = new System.Drawing.Point(3, 0);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(159, 72);
            this.FirstNameLabel.TabIndex = 0;
            this.FirstNameLabel.Text = "First Name";
            this.FirstNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GenerateNameButton
            // 
            this.GenerateNameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IdentityTableLayoutPanel.SetColumnSpan(this.GenerateNameButton, 2);
            this.GenerateNameButton.Location = new System.Drawing.Point(333, 219);
            this.GenerateNameButton.Name = "GenerateNameButton";
            this.GenerateNameButton.Size = new System.Drawing.Size(327, 69);
            this.GenerateNameButton.TabIndex = 1;
            this.GenerateNameButton.Text = "Generate Name";
            this.GenerateNameButton.UseVisualStyleBackColor = true;
            this.GenerateNameButton.Click += new System.EventHandler(this.GenerateNameButton_Click);
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LastNameLabel.Location = new System.Drawing.Point(3, 72);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(159, 72);
            this.LastNameLabel.TabIndex = 1;
            this.LastNameLabel.Text = "Last Name";
            this.LastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FirstNameDataLabel
            // 
            this.FirstNameDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstNameDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FirstNameDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IdentityTableLayoutPanel.SetColumnSpan(this.FirstNameDataLabel, 3);
            this.FirstNameDataLabel.Location = new System.Drawing.Point(168, 0);
            this.FirstNameDataLabel.Name = "FirstNameDataLabel";
            this.FirstNameDataLabel.Size = new System.Drawing.Size(492, 72);
            this.FirstNameDataLabel.TabIndex = 0;
            this.FirstNameDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LastNameDataLabel
            // 
            this.LastNameDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LastNameDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LastNameDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IdentityTableLayoutPanel.SetColumnSpan(this.LastNameDataLabel, 3);
            this.LastNameDataLabel.Location = new System.Drawing.Point(168, 72);
            this.LastNameDataLabel.Name = "LastNameDataLabel";
            this.LastNameDataLabel.Size = new System.Drawing.Size(492, 72);
            this.LastNameDataLabel.TabIndex = 0;
            this.LastNameDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AbilityPage
            // 
            this.AbilityPage.Controls.Add(this.AbilitiesTableLayoutPanel);
            this.AbilityPage.Location = new System.Drawing.Point(4, 38);
            this.AbilityPage.Name = "AbilityPage";
            this.AbilityPage.Padding = new System.Windows.Forms.Padding(3);
            this.AbilityPage.Size = new System.Drawing.Size(678, 363);
            this.AbilityPage.TabIndex = 1;
            this.AbilityPage.Text = "Abilities";
            this.AbilityPage.UseVisualStyleBackColor = true;
            // 
            // AbilitiesTableLayoutPanel
            // 
            this.AbilitiesTableLayoutPanel.ColumnCount = 4;
            this.AbilitiesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.AbilitiesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.AbilitiesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.AbilitiesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.AbilitiesTableLayoutPanel.Controls.Add(this.StrengthDataLabel, 1, 0);
            this.AbilitiesTableLayoutPanel.Controls.Add(this.DexterityLabel, 0, 1);
            this.AbilitiesTableLayoutPanel.Controls.Add(this.StrengthLabel, 0, 0);
            this.AbilitiesTableLayoutPanel.Controls.Add(this.GenerateAbilitiesButton, 2, 7);
            this.AbilitiesTableLayoutPanel.Controls.Add(this.EnduranceLabel, 0, 2);
            this.AbilitiesTableLayoutPanel.Controls.Add(this.IntellectLabel, 0, 3);
            this.AbilitiesTableLayoutPanel.Controls.Add(this.EducationLabel, 0, 4);
            this.AbilitiesTableLayoutPanel.Controls.Add(this.SocialStandingLabel, 0, 5);
            this.AbilitiesTableLayoutPanel.Controls.Add(this.DexterityDataLabel, 1, 1);
            this.AbilitiesTableLayoutPanel.Controls.Add(this.EnduranceDataLabel, 1, 2);
            this.AbilitiesTableLayoutPanel.Controls.Add(this.IntellectDataLabel, 1, 3);
            this.AbilitiesTableLayoutPanel.Controls.Add(this.EducationDataLabel, 1, 4);
            this.AbilitiesTableLayoutPanel.Controls.Add(this.SocialStandingDataLabel, 1, 5);
            this.AbilitiesTableLayoutPanel.Location = new System.Drawing.Point(11, 6);
            this.AbilitiesTableLayoutPanel.Name = "AbilitiesTableLayoutPanel";
            this.AbilitiesTableLayoutPanel.RowCount = 8;
            this.AbilitiesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AbilitiesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AbilitiesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AbilitiesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AbilitiesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AbilitiesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AbilitiesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AbilitiesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AbilitiesTableLayoutPanel.Size = new System.Drawing.Size(658, 353);
            this.AbilitiesTableLayoutPanel.TabIndex = 0;
            // 
            // StrengthDataLabel
            // 
            this.StrengthDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StrengthDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.StrengthDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StrengthDataLabel.Location = new System.Drawing.Point(233, 0);
            this.StrengthDataLabel.Name = "StrengthDataLabel";
            this.StrengthDataLabel.Size = new System.Drawing.Size(125, 44);
            this.StrengthDataLabel.TabIndex = 2;
            this.StrengthDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DexterityLabel
            // 
            this.DexterityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DexterityLabel.Location = new System.Drawing.Point(3, 44);
            this.DexterityLabel.Name = "DexterityLabel";
            this.DexterityLabel.Size = new System.Drawing.Size(224, 44);
            this.DexterityLabel.TabIndex = 6;
            this.DexterityLabel.Text = "Dexterity";
            this.DexterityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StrengthLabel
            // 
            this.StrengthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StrengthLabel.Location = new System.Drawing.Point(3, 0);
            this.StrengthLabel.Name = "StrengthLabel";
            this.StrengthLabel.Size = new System.Drawing.Size(224, 44);
            this.StrengthLabel.TabIndex = 2;
            this.StrengthLabel.Text = "Strength";
            this.StrengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GenerateAbilitiesButton
            // 
            this.GenerateAbilitiesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AbilitiesTableLayoutPanel.SetColumnSpan(this.GenerateAbilitiesButton, 2);
            this.GenerateAbilitiesButton.Location = new System.Drawing.Point(364, 311);
            this.GenerateAbilitiesButton.Name = "GenerateAbilitiesButton";
            this.GenerateAbilitiesButton.Size = new System.Drawing.Size(291, 39);
            this.GenerateAbilitiesButton.TabIndex = 2;
            this.GenerateAbilitiesButton.Text = "Generate Abilities";
            this.GenerateAbilitiesButton.UseVisualStyleBackColor = true;
            this.GenerateAbilitiesButton.Click += new System.EventHandler(this.GenerateAbilitiesButton_Click);
            // 
            // EnduranceLabel
            // 
            this.EnduranceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnduranceLabel.Location = new System.Drawing.Point(3, 88);
            this.EnduranceLabel.Name = "EnduranceLabel";
            this.EnduranceLabel.Size = new System.Drawing.Size(224, 44);
            this.EnduranceLabel.TabIndex = 7;
            this.EnduranceLabel.Text = "Endurance";
            this.EnduranceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // IntellectLabel
            // 
            this.IntellectLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IntellectLabel.Location = new System.Drawing.Point(3, 132);
            this.IntellectLabel.Name = "IntellectLabel";
            this.IntellectLabel.Size = new System.Drawing.Size(224, 44);
            this.IntellectLabel.TabIndex = 3;
            this.IntellectLabel.Text = "Intellect";
            this.IntellectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EducationLabel
            // 
            this.EducationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EducationLabel.Location = new System.Drawing.Point(3, 176);
            this.EducationLabel.Name = "EducationLabel";
            this.EducationLabel.Size = new System.Drawing.Size(224, 44);
            this.EducationLabel.TabIndex = 4;
            this.EducationLabel.Text = "Education";
            this.EducationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SocialStandingLabel
            // 
            this.SocialStandingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SocialStandingLabel.Location = new System.Drawing.Point(3, 220);
            this.SocialStandingLabel.Name = "SocialStandingLabel";
            this.SocialStandingLabel.Size = new System.Drawing.Size(224, 44);
            this.SocialStandingLabel.TabIndex = 5;
            this.SocialStandingLabel.Text = "Social Standing";
            this.SocialStandingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DexterityDataLabel
            // 
            this.DexterityDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DexterityDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DexterityDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DexterityDataLabel.Location = new System.Drawing.Point(233, 44);
            this.DexterityDataLabel.Name = "DexterityDataLabel";
            this.DexterityDataLabel.Size = new System.Drawing.Size(125, 44);
            this.DexterityDataLabel.TabIndex = 8;
            this.DexterityDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EnduranceDataLabel
            // 
            this.EnduranceDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnduranceDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EnduranceDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EnduranceDataLabel.Location = new System.Drawing.Point(233, 88);
            this.EnduranceDataLabel.Name = "EnduranceDataLabel";
            this.EnduranceDataLabel.Size = new System.Drawing.Size(125, 44);
            this.EnduranceDataLabel.TabIndex = 9;
            this.EnduranceDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // IntellectDataLabel
            // 
            this.IntellectDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IntellectDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.IntellectDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IntellectDataLabel.Location = new System.Drawing.Point(233, 132);
            this.IntellectDataLabel.Name = "IntellectDataLabel";
            this.IntellectDataLabel.Size = new System.Drawing.Size(125, 44);
            this.IntellectDataLabel.TabIndex = 10;
            this.IntellectDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EducationDataLabel
            // 
            this.EducationDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EducationDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EducationDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EducationDataLabel.Location = new System.Drawing.Point(233, 176);
            this.EducationDataLabel.Name = "EducationDataLabel";
            this.EducationDataLabel.Size = new System.Drawing.Size(125, 44);
            this.EducationDataLabel.TabIndex = 11;
            this.EducationDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SocialStandingDataLabel
            // 
            this.SocialStandingDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SocialStandingDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SocialStandingDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SocialStandingDataLabel.Location = new System.Drawing.Point(233, 220);
            this.SocialStandingDataLabel.Name = "SocialStandingDataLabel";
            this.SocialStandingDataLabel.Size = new System.Drawing.Size(125, 44);
            this.SocialStandingDataLabel.TabIndex = 12;
            this.SocialStandingDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SkillsPage
            // 
            this.SkillsPage.Controls.Add(this.tableLayoutPanel1);
            this.SkillsPage.Location = new System.Drawing.Point(4, 38);
            this.SkillsPage.Name = "SkillsPage";
            this.SkillsPage.Size = new System.Drawing.Size(678, 363);
            this.SkillsPage.TabIndex = 2;
            this.SkillsPage.Text = "Skills";
            this.SkillsPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.SkillsLabel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.SkillsLabel2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.SkillsLabel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.SkillsLabel4, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.GenerateSkillsButton, 2, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(658, 357);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // SkillsLabel1
            // 
            this.SkillsLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SkillsLabel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SkillsLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.SkillsLabel1, 2);
            this.SkillsLabel1.Location = new System.Drawing.Point(3, 89);
            this.SkillsLabel1.Name = "SkillsLabel1";
            this.SkillsLabel1.Size = new System.Drawing.Size(322, 89);
            this.SkillsLabel1.TabIndex = 19;
            this.SkillsLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SkillsLabel2
            // 
            this.SkillsLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SkillsLabel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SkillsLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.SkillsLabel2, 2);
            this.SkillsLabel2.Location = new System.Drawing.Point(331, 89);
            this.SkillsLabel2.Name = "SkillsLabel2";
            this.SkillsLabel2.Size = new System.Drawing.Size(324, 89);
            this.SkillsLabel2.TabIndex = 20;
            this.SkillsLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SkillsLabel3
            // 
            this.SkillsLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SkillsLabel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SkillsLabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.SkillsLabel3, 2);
            this.SkillsLabel3.Location = new System.Drawing.Point(3, 178);
            this.SkillsLabel3.Name = "SkillsLabel3";
            this.SkillsLabel3.Size = new System.Drawing.Size(322, 89);
            this.SkillsLabel3.TabIndex = 21;
            this.SkillsLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SkillsLabel4
            // 
            this.SkillsLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SkillsLabel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SkillsLabel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.SkillsLabel4, 2);
            this.SkillsLabel4.Location = new System.Drawing.Point(331, 178);
            this.SkillsLabel4.Name = "SkillsLabel4";
            this.SkillsLabel4.Size = new System.Drawing.Size(324, 89);
            this.SkillsLabel4.TabIndex = 22;
            this.SkillsLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.label5, 4);
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(652, 89);
            this.label5.TabIndex = 23;
            this.label5.Text = "Skills";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GenerateSkillsButton
            // 
            this.GenerateSkillsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.GenerateSkillsButton, 2);
            this.GenerateSkillsButton.Location = new System.Drawing.Point(331, 270);
            this.GenerateSkillsButton.Name = "GenerateSkillsButton";
            this.GenerateSkillsButton.Size = new System.Drawing.Size(324, 84);
            this.GenerateSkillsButton.TabIndex = 24;
            this.GenerateSkillsButton.Text = "Generate Skills";
            this.GenerateSkillsButton.UseVisualStyleBackColor = true;
            this.GenerateSkillsButton.Click += new System.EventHandler(this.GenerateSkillsButton_Click);
            // 
            // CharacterSheetPage
            // 
            this.CharacterSheetPage.Controls.Add(this.CharachterSheetTableLayoutPanel);
            this.CharacterSheetPage.Location = new System.Drawing.Point(4, 38);
            this.CharacterSheetPage.Name = "CharacterSheetPage";
            this.CharacterSheetPage.Size = new System.Drawing.Size(678, 363);
            this.CharacterSheetPage.TabIndex = 3;
            this.CharacterSheetPage.Text = "Character Sheet";
            this.CharacterSheetPage.UseVisualStyleBackColor = true;
            // 
            // CharachterSheetTableLayoutPanel
            // 
            this.CharachterSheetTableLayoutPanel.ColumnCount = 4;
            this.CharachterSheetTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.45596F));
            this.CharachterSheetTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.45596F));
            this.CharachterSheetTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.54404F));
            this.CharachterSheetTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.54404F));
            this.CharachterSheetTableLayoutPanel.Controls.Add(this.SheetStrengthDataLabel, 3, 0);
            this.CharachterSheetTableLayoutPanel.Controls.Add(this.SheetDexterityDataLabel, 3, 1);
            this.CharachterSheetTableLayoutPanel.Controls.Add(this.SheetEnduranceDataLabel, 3, 2);
            this.CharachterSheetTableLayoutPanel.Controls.Add(this.SheetIntellectDataLabel, 3, 3);
            this.CharachterSheetTableLayoutPanel.Controls.Add(this.SheetEducationDataLabel, 3, 4);
            this.CharachterSheetTableLayoutPanel.Controls.Add(this.SheetSocialStandingDataLabel, 3, 5);
            this.CharachterSheetTableLayoutPanel.Controls.Add(this.SheetStrengthLabel, 2, 0);
            this.CharachterSheetTableLayoutPanel.Controls.Add(this.SheetDexterityLabel, 2, 1);
            this.CharachterSheetTableLayoutPanel.Controls.Add(this.SheetEnduranceLabel, 2, 2);
            this.CharachterSheetTableLayoutPanel.Controls.Add(this.SheetIntellectLabel, 2, 3);
            this.CharachterSheetTableLayoutPanel.Controls.Add(this.SheetEducationLabel, 2, 4);
            this.CharachterSheetTableLayoutPanel.Controls.Add(this.SheetSocialStandingLabel, 2, 5);
            this.CharachterSheetTableLayoutPanel.Controls.Add(this.SheetFirstNameLabel, 0, 0);
            this.CharachterSheetTableLayoutPanel.Controls.Add(this.SheetLastNameLabel, 1, 0);
            this.CharachterSheetTableLayoutPanel.Controls.Add(this.SheetFirstNameDataLabel, 0, 1);
            this.CharachterSheetTableLayoutPanel.Controls.Add(this.SheetLastNameDataLabel, 1, 1);
            this.CharachterSheetTableLayoutPanel.Controls.Add(this.SheetSkillsLabel, 0, 2);
            this.CharachterSheetTableLayoutPanel.Location = new System.Drawing.Point(10, 7);
            this.CharachterSheetTableLayoutPanel.Name = "CharachterSheetTableLayoutPanel";
            this.CharachterSheetTableLayoutPanel.RowCount = 6;
            this.CharachterSheetTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.CharachterSheetTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.CharachterSheetTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.CharachterSheetTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.CharachterSheetTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.CharachterSheetTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.CharachterSheetTableLayoutPanel.Size = new System.Drawing.Size(658, 353);
            this.CharachterSheetTableLayoutPanel.TabIndex = 0;
            // 
            // SheetStrengthDataLabel
            // 
            this.SheetStrengthDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SheetStrengthDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SheetStrengthDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SheetStrengthDataLabel.Location = new System.Drawing.Point(557, 0);
            this.SheetStrengthDataLabel.Name = "SheetStrengthDataLabel";
            this.SheetStrengthDataLabel.Size = new System.Drawing.Size(98, 58);
            this.SheetStrengthDataLabel.TabIndex = 9;
            this.SheetStrengthDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SheetDexterityDataLabel
            // 
            this.SheetDexterityDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SheetDexterityDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SheetDexterityDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SheetDexterityDataLabel.Location = new System.Drawing.Point(557, 58);
            this.SheetDexterityDataLabel.Name = "SheetDexterityDataLabel";
            this.SheetDexterityDataLabel.Size = new System.Drawing.Size(98, 58);
            this.SheetDexterityDataLabel.TabIndex = 10;
            this.SheetDexterityDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SheetEnduranceDataLabel
            // 
            this.SheetEnduranceDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SheetEnduranceDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SheetEnduranceDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SheetEnduranceDataLabel.Location = new System.Drawing.Point(557, 116);
            this.SheetEnduranceDataLabel.Name = "SheetEnduranceDataLabel";
            this.SheetEnduranceDataLabel.Size = new System.Drawing.Size(98, 58);
            this.SheetEnduranceDataLabel.TabIndex = 11;
            this.SheetEnduranceDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SheetIntellectDataLabel
            // 
            this.SheetIntellectDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SheetIntellectDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SheetIntellectDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SheetIntellectDataLabel.Location = new System.Drawing.Point(557, 174);
            this.SheetIntellectDataLabel.Name = "SheetIntellectDataLabel";
            this.SheetIntellectDataLabel.Size = new System.Drawing.Size(98, 58);
            this.SheetIntellectDataLabel.TabIndex = 12;
            this.SheetIntellectDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SheetEducationDataLabel
            // 
            this.SheetEducationDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SheetEducationDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SheetEducationDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SheetEducationDataLabel.Location = new System.Drawing.Point(557, 232);
            this.SheetEducationDataLabel.Name = "SheetEducationDataLabel";
            this.SheetEducationDataLabel.Size = new System.Drawing.Size(98, 58);
            this.SheetEducationDataLabel.TabIndex = 13;
            this.SheetEducationDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SheetSocialStandingDataLabel
            // 
            this.SheetSocialStandingDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SheetSocialStandingDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SheetSocialStandingDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SheetSocialStandingDataLabel.Location = new System.Drawing.Point(557, 290);
            this.SheetSocialStandingDataLabel.Name = "SheetSocialStandingDataLabel";
            this.SheetSocialStandingDataLabel.Size = new System.Drawing.Size(98, 63);
            this.SheetSocialStandingDataLabel.TabIndex = 14;
            this.SheetSocialStandingDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SheetStrengthLabel
            // 
            this.SheetStrengthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SheetStrengthLabel.Location = new System.Drawing.Point(455, 0);
            this.SheetStrengthLabel.Name = "SheetStrengthLabel";
            this.SheetStrengthLabel.Size = new System.Drawing.Size(96, 58);
            this.SheetStrengthLabel.TabIndex = 3;
            this.SheetStrengthLabel.Text = "Str.";
            this.SheetStrengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SheetDexterityLabel
            // 
            this.SheetDexterityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SheetDexterityLabel.Location = new System.Drawing.Point(455, 58);
            this.SheetDexterityLabel.Name = "SheetDexterityLabel";
            this.SheetDexterityLabel.Size = new System.Drawing.Size(96, 58);
            this.SheetDexterityLabel.TabIndex = 4;
            this.SheetDexterityLabel.Text = "Dex.";
            this.SheetDexterityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SheetEnduranceLabel
            // 
            this.SheetEnduranceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SheetEnduranceLabel.Location = new System.Drawing.Point(455, 116);
            this.SheetEnduranceLabel.Name = "SheetEnduranceLabel";
            this.SheetEnduranceLabel.Size = new System.Drawing.Size(96, 58);
            this.SheetEnduranceLabel.TabIndex = 5;
            this.SheetEnduranceLabel.Text = "End.";
            this.SheetEnduranceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SheetIntellectLabel
            // 
            this.SheetIntellectLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SheetIntellectLabel.Location = new System.Drawing.Point(455, 174);
            this.SheetIntellectLabel.Name = "SheetIntellectLabel";
            this.SheetIntellectLabel.Size = new System.Drawing.Size(96, 58);
            this.SheetIntellectLabel.TabIndex = 6;
            this.SheetIntellectLabel.Text = "Int.";
            this.SheetIntellectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SheetEducationLabel
            // 
            this.SheetEducationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SheetEducationLabel.Location = new System.Drawing.Point(455, 232);
            this.SheetEducationLabel.Name = "SheetEducationLabel";
            this.SheetEducationLabel.Size = new System.Drawing.Size(96, 58);
            this.SheetEducationLabel.TabIndex = 7;
            this.SheetEducationLabel.Text = "Ed.";
            this.SheetEducationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SheetSocialStandingLabel
            // 
            this.SheetSocialStandingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SheetSocialStandingLabel.Location = new System.Drawing.Point(455, 290);
            this.SheetSocialStandingLabel.Name = "SheetSocialStandingLabel";
            this.SheetSocialStandingLabel.Size = new System.Drawing.Size(96, 63);
            this.SheetSocialStandingLabel.TabIndex = 8;
            this.SheetSocialStandingLabel.Text = "Soc.";
            this.SheetSocialStandingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SheetFirstNameLabel
            // 
            this.SheetFirstNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SheetFirstNameLabel.Location = new System.Drawing.Point(3, 0);
            this.SheetFirstNameLabel.Name = "SheetFirstNameLabel";
            this.SheetFirstNameLabel.Size = new System.Drawing.Size(220, 58);
            this.SheetFirstNameLabel.TabIndex = 15;
            this.SheetFirstNameLabel.Text = "First Name";
            this.SheetFirstNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SheetLastNameLabel
            // 
            this.SheetLastNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SheetLastNameLabel.Location = new System.Drawing.Point(229, 0);
            this.SheetLastNameLabel.Name = "SheetLastNameLabel";
            this.SheetLastNameLabel.Size = new System.Drawing.Size(220, 58);
            this.SheetLastNameLabel.TabIndex = 16;
            this.SheetLastNameLabel.Text = "Last Name";
            this.SheetLastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SheetFirstNameDataLabel
            // 
            this.SheetFirstNameDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SheetFirstNameDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SheetFirstNameDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SheetFirstNameDataLabel.Location = new System.Drawing.Point(3, 58);
            this.SheetFirstNameDataLabel.Name = "SheetFirstNameDataLabel";
            this.SheetFirstNameDataLabel.Size = new System.Drawing.Size(220, 58);
            this.SheetFirstNameDataLabel.TabIndex = 17;
            this.SheetFirstNameDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SheetLastNameDataLabel
            // 
            this.SheetLastNameDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SheetLastNameDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SheetLastNameDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SheetLastNameDataLabel.Location = new System.Drawing.Point(229, 58);
            this.SheetLastNameDataLabel.Name = "SheetLastNameDataLabel";
            this.SheetLastNameDataLabel.Size = new System.Drawing.Size(220, 58);
            this.SheetLastNameDataLabel.TabIndex = 18;
            this.SheetLastNameDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SheetSkillsLabel
            // 
            this.SheetSkillsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CharachterSheetTableLayoutPanel.SetColumnSpan(this.SheetSkillsLabel, 2);
            this.SheetSkillsLabel.Location = new System.Drawing.Point(3, 116);
            this.SheetSkillsLabel.Name = "SheetSkillsLabel";
            this.SheetSkillsLabel.Size = new System.Drawing.Size(446, 58);
            this.SheetSkillsLabel.TabIndex = 19;
            this.SheetSkillsLabel.Text = "Skills";
            this.SheetSkillsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(552, 425);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(120, 57);
            this.NextButton.TabIndex = 1;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(14, 425);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(120, 57);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // CharacterGenerationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.ClientSize = new System.Drawing.Size(686, 493);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.MainTabControl);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CharacterGenerationForm";
            this.Text = "Character Generator";
            this.Load += new System.EventHandler(this.CharacterGenerationForm_Load);
            this.MainTabControl.ResumeLayout(false);
            this.IdentityPage.ResumeLayout(false);
            this.IdentityTableLayoutPanel.ResumeLayout(false);
            this.AbilityPage.ResumeLayout(false);
            this.AbilitiesTableLayoutPanel.ResumeLayout(false);
            this.SkillsPage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.CharacterSheetPage.ResumeLayout(false);
            this.CharachterSheetTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage IdentityPage;
        private System.Windows.Forms.TabPage AbilityPage;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TabPage SkillsPage;
        private System.Windows.Forms.TableLayoutPanel IdentityTableLayoutPanel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Button GenerateNameButton;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label FirstNameDataLabel;
        private System.Windows.Forms.Label LastNameDataLabel;
        private System.Windows.Forms.TableLayoutPanel AbilitiesTableLayoutPanel;
        private System.Windows.Forms.Label StrengthDataLabel;
        private System.Windows.Forms.Label DexterityLabel;
        private System.Windows.Forms.Label StrengthLabel;
        private System.Windows.Forms.Button GenerateAbilitiesButton;
        private System.Windows.Forms.Label EnduranceLabel;
        private System.Windows.Forms.Label IntellectLabel;
        private System.Windows.Forms.Label EducationLabel;
        private System.Windows.Forms.Label SocialStandingLabel;
        private System.Windows.Forms.Label DexterityDataLabel;
        private System.Windows.Forms.Label EnduranceDataLabel;
        private System.Windows.Forms.Label IntellectDataLabel;
        private System.Windows.Forms.Label EducationDataLabel;
        private System.Windows.Forms.Label SocialStandingDataLabel;
        private System.Windows.Forms.TabPage CharacterSheetPage;
        private System.Windows.Forms.TableLayoutPanel CharachterSheetTableLayoutPanel;
        private System.Windows.Forms.Label SheetStrengthLabel;
        private System.Windows.Forms.Label SheetDexterityLabel;
        private System.Windows.Forms.Label SheetEnduranceLabel;
        private System.Windows.Forms.Label SheetIntellectLabel;
        private System.Windows.Forms.Label SheetEducationLabel;
        private System.Windows.Forms.Label SheetSocialStandingLabel;
        private System.Windows.Forms.Label SheetStrengthDataLabel;
        private System.Windows.Forms.Label SheetDexterityDataLabel;
        private System.Windows.Forms.Label SheetEnduranceDataLabel;
        private System.Windows.Forms.Label SheetIntellectDataLabel;
        private System.Windows.Forms.Label SheetEducationDataLabel;
        private System.Windows.Forms.Label SheetSocialStandingDataLabel;
        private System.Windows.Forms.Label SheetFirstNameLabel;
        private System.Windows.Forms.Label SheetLastNameLabel;
        private System.Windows.Forms.Label SheetFirstNameDataLabel;
        private System.Windows.Forms.Label SheetLastNameDataLabel;
        private System.Windows.Forms.Label SheetSkillsLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label SkillsLabel1;
        private System.Windows.Forms.Label SkillsLabel2;
        private System.Windows.Forms.Label SkillsLabel3;
        private System.Windows.Forms.Label SkillsLabel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button GenerateSkillsButton;
    }
}
