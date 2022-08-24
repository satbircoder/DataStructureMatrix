namespace DataStructureMatrix
{
    partial class FormDataStructureMatrix
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
            this.components = new System.ComponentModel.Container();
            this.ListViewDisplay = new System.Windows.Forms.ListView();
            this.dataStructureName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataStructureCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.TextBoxDefinition = new System.Windows.Forms.TextBox();
            this.TextBoxStructure = new System.Windows.Forms.TextBox();
            this.TextBoxCategory = new System.Windows.Forms.TextBox();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.LabelSearch = new System.Windows.Forms.Label();
            this.labelStructure = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelDefinition = new System.Windows.Forms.Label();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonModify = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.statusStripBar = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonOpen = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStripBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListViewDisplay
            // 
            this.ListViewDisplay.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ListViewDisplay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.dataStructureName,
            this.dataStructureCategory});
            this.ListViewDisplay.FullRowSelect = true;
            this.ListViewDisplay.HideSelection = false;
            this.ListViewDisplay.Location = new System.Drawing.Point(346, 38);
            this.ListViewDisplay.Name = "ListViewDisplay";
            this.ListViewDisplay.Size = new System.Drawing.Size(484, 376);
            this.ListViewDisplay.TabIndex = 0;
            this.ListViewDisplay.UseCompatibleStateImageBehavior = false;
            this.ListViewDisplay.View = System.Windows.Forms.View.Details;
            this.ListViewDisplay.SelectedIndexChanged += new System.EventHandler(this.ListViewDisplay_SelectedIndexChanged);
            this.ListViewDisplay.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListViewDisplay_MouseClick);
            
            // 
            // dataStructureName
            // 
            this.dataStructureName.Text = "Data Structure Name";
            this.dataStructureName.Width = 113;
            // 
            // dataStructureCategory
            // 
            this.dataStructureCategory.Text = "Category";
            this.dataStructureCategory.Width = 78;
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSearch.Location = new System.Drawing.Point(187, 38);
            this.TextBoxSearch.Multiline = true;
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(153, 40);
            this.TextBoxSearch.TabIndex = 1;
            // 
            // TextBoxDefinition
            // 
            this.TextBoxDefinition.Location = new System.Drawing.Point(187, 346);
            this.TextBoxDefinition.Multiline = true;
            this.TextBoxDefinition.Name = "TextBoxDefinition";
            this.TextBoxDefinition.Size = new System.Drawing.Size(153, 142);
            this.TextBoxDefinition.TabIndex = 2;
            // 
            // TextBoxStructure
            // 
            this.TextBoxStructure.Location = new System.Drawing.Point(187, 287);
            this.TextBoxStructure.Multiline = true;
            this.TextBoxStructure.Name = "TextBoxStructure";
            this.TextBoxStructure.Size = new System.Drawing.Size(153, 40);
            this.TextBoxStructure.TabIndex = 3;
            // 
            // TextBoxCategory
            // 
            this.TextBoxCategory.Location = new System.Drawing.Point(187, 215);
            this.TextBoxCategory.Multiline = true;
            this.TextBoxCategory.Name = "TextBoxCategory";
            this.TextBoxCategory.Size = new System.Drawing.Size(153, 40);
            this.TextBoxCategory.TabIndex = 4;
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(187, 152);
            this.TextBoxName.Multiline = true;
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(153, 40);
            this.TextBoxName.TabIndex = 5;
            // 
            // LabelSearch
            // 
            this.LabelSearch.BackColor = System.Drawing.SystemColors.Info;
            this.LabelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSearch.Location = new System.Drawing.Point(77, 38);
            this.LabelSearch.Name = "LabelSearch";
            this.LabelSearch.Size = new System.Drawing.Size(93, 40);
            this.LabelSearch.TabIndex = 6;
            this.LabelSearch.Text = "Search";
            this.LabelSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelStructure
            // 
            this.labelStructure.BackColor = System.Drawing.SystemColors.Info;
            this.labelStructure.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelStructure.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStructure.Location = new System.Drawing.Point(77, 287);
            this.labelStructure.Name = "labelStructure";
            this.labelStructure.Size = new System.Drawing.Size(93, 40);
            this.labelStructure.TabIndex = 7;
            this.labelStructure.Text = "Structure";
            this.labelStructure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCategory
            // 
            this.labelCategory.BackColor = System.Drawing.SystemColors.Info;
            this.labelCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCategory.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategory.Location = new System.Drawing.Point(77, 215);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(93, 40);
            this.labelCategory.TabIndex = 8;
            this.labelCategory.Text = "Category";
            this.labelCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelName
            // 
            this.labelName.BackColor = System.Drawing.SystemColors.Info;
            this.labelName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(77, 152);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(93, 40);
            this.labelName.TabIndex = 9;
            this.labelName.Text = "Name";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDefinition
            // 
            this.labelDefinition.BackColor = System.Drawing.SystemColors.Info;
            this.labelDefinition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDefinition.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDefinition.Location = new System.Drawing.Point(77, 362);
            this.labelDefinition.Name = "labelDefinition";
            this.labelDefinition.Size = new System.Drawing.Size(93, 40);
            this.labelDefinition.TabIndex = 10;
            this.labelDefinition.Text = "Definition";
            this.labelDefinition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ButtonSearch.Location = new System.Drawing.Point(247, 85);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(92, 38);
            this.ButtonSearch.TabIndex = 11;
            this.ButtonSearch.Text = "SEARCH";
            this.ButtonSearch.UseVisualStyleBackColor = false;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // ButtonClear
            // 
            this.ButtonClear.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ButtonClear.Location = new System.Drawing.Point(248, 494);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(92, 38);
            this.ButtonClear.TabIndex = 12;
            this.ButtonClear.Text = "CLEAR";
            this.ButtonClear.UseVisualStyleBackColor = false;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ButtonDelete.Location = new System.Drawing.Point(542, 431);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(92, 38);
            this.ButtonDelete.TabIndex = 13;
            this.ButtonDelete.Text = "DELETE";
            this.ButtonDelete.UseVisualStyleBackColor = false;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonModify
            // 
            this.ButtonModify.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ButtonModify.Location = new System.Drawing.Point(444, 431);
            this.ButtonModify.Name = "ButtonModify";
            this.ButtonModify.Size = new System.Drawing.Size(92, 38);
            this.ButtonModify.TabIndex = 14;
            this.ButtonModify.Text = "MODIFY";
            this.ButtonModify.UseVisualStyleBackColor = false;
            this.ButtonModify.Click += new System.EventHandler(this.ButtonModify_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ButtonAdd.Location = new System.Drawing.Point(346, 431);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(92, 38);
            this.ButtonAdd.TabIndex = 15;
            this.ButtonAdd.Text = "ADD";
            this.ButtonAdd.UseVisualStyleBackColor = false;
            this.ButtonAdd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonAdd_MouseClick);
            // 
            // statusStripBar
            // 
            this.statusStripBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStripBar.Location = new System.Drawing.Point(0, 535);
            this.statusStripBar.Name = "statusStripBar";
            this.statusStripBar.Size = new System.Drawing.Size(945, 22);
            this.statusStripBar.TabIndex = 16;
            this.statusStripBar.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(53, 17);
            this.toolStripStatusLabel1.Text = "Message";
            // 
            // ButtonSave
            // 
            this.ButtonSave.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ButtonSave.Location = new System.Drawing.Point(640, 431);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(92, 38);
            this.ButtonSave.TabIndex = 17;
            this.ButtonSave.Text = "SAVE";
            this.ButtonSave.UseVisualStyleBackColor = false;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonOpen
            // 
            this.ButtonOpen.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ButtonOpen.Location = new System.Drawing.Point(738, 431);
            this.ButtonOpen.Name = "ButtonOpen";
            this.ButtonOpen.Size = new System.Drawing.Size(92, 38);
            this.ButtonOpen.TabIndex = 18;
            this.ButtonOpen.Text = "OPEN";
            this.ButtonOpen.UseVisualStyleBackColor = false;
            this.ButtonOpen.Click += new System.EventHandler(this.ButtonOpen_Click);
            // 
            // FormDataStructureMatrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 557);
            this.Controls.Add(this.ButtonOpen);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.statusStripBar);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.ButtonModify);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.labelDefinition);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.labelStructure);
            this.Controls.Add(this.LabelSearch);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.TextBoxCategory);
            this.Controls.Add(this.TextBoxStructure);
            this.Controls.Add(this.TextBoxDefinition);
            this.Controls.Add(this.TextBoxSearch);
            this.Controls.Add(this.ListViewDisplay);
            this.Name = "FormDataStructureMatrix";
            this.Text = "Data Structure Matrix";
            this.Load += new System.EventHandler(this.FormDataStructureMatrix_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormDataStructureMatrix_MouseMove);
            this.statusStripBar.ResumeLayout(false);
            this.statusStripBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ListViewDisplay;
        private System.Windows.Forms.ColumnHeader dataStructureName;
        private System.Windows.Forms.ColumnHeader dataStructureCategory;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.TextBox TextBoxDefinition;
        private System.Windows.Forms.TextBox TextBoxStructure;
        private System.Windows.Forms.TextBox TextBoxCategory;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label LabelSearch;
        private System.Windows.Forms.Label labelStructure;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDefinition;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonModify;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.StatusStrip statusStripBar;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonOpen;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

