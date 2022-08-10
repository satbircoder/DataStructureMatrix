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
            this.listViewDisplay = new System.Windows.Forms.ListView();
            this.dataStructureName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataStructureCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataStructureType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataStructureDefinition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.textBoxDefinition = new System.Windows.Forms.TextBox();
            this.textBoxStructure = new System.Windows.Forms.TextBox();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.labelStructure = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelDefinition = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.statusStripBar = new System.Windows.Forms.StatusStrip();
            this.SuspendLayout();
            // 
            // listViewDisplay
            // 
            this.listViewDisplay.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listViewDisplay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.dataStructureName,
            this.dataStructureCategory,
            this.dataStructureType,
            this.dataStructureDefinition});
            this.listViewDisplay.HideSelection = false;
            this.listViewDisplay.Location = new System.Drawing.Point(346, 38);
            this.listViewDisplay.Name = "listViewDisplay";
            this.listViewDisplay.Size = new System.Drawing.Size(586, 376);
            this.listViewDisplay.TabIndex = 0;
            this.listViewDisplay.UseCompatibleStateImageBehavior = false;
            this.listViewDisplay.View = System.Windows.Forms.View.Details;
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
            // dataStructureType
            // 
            this.dataStructureType.Text = "Structure";
            this.dataStructureType.Width = 82;
            // 
            // dataStructureDefinition
            // 
            this.dataStructureDefinition.Text = "Definition";
            this.dataStructureDefinition.Width = 258;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(187, 38);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(153, 40);
            this.textBoxSearch.TabIndex = 1;
            // 
            // textBoxDefinition
            // 
            this.textBoxDefinition.Location = new System.Drawing.Point(187, 362);
            this.textBoxDefinition.Multiline = true;
            this.textBoxDefinition.Name = "textBoxDefinition";
            this.textBoxDefinition.Size = new System.Drawing.Size(153, 107);
            this.textBoxDefinition.TabIndex = 2;
            // 
            // textBoxStructure
            // 
            this.textBoxStructure.Location = new System.Drawing.Point(187, 287);
            this.textBoxStructure.Multiline = true;
            this.textBoxStructure.Name = "textBoxStructure";
            this.textBoxStructure.Size = new System.Drawing.Size(153, 40);
            this.textBoxStructure.TabIndex = 3;
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.Location = new System.Drawing.Point(187, 215);
            this.textBoxCategory.Multiline = true;
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.Size = new System.Drawing.Size(153, 40);
            this.textBoxCategory.TabIndex = 4;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(187, 152);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(153, 40);
            this.textBoxName.TabIndex = 5;
            // 
            // labelSearch
            // 
            this.labelSearch.BackColor = System.Drawing.SystemColors.Info;
            this.labelSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Location = new System.Drawing.Point(77, 38);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(93, 40);
            this.labelSearch.TabIndex = 6;
            this.labelSearch.Text = "Search";
            this.labelSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelStructure
            // 
            this.labelStructure.BackColor = System.Drawing.SystemColors.Info;
            this.labelStructure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.labelCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.labelDefinition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDefinition.Location = new System.Drawing.Point(77, 362);
            this.labelDefinition.Name = "labelDefinition";
            this.labelDefinition.Size = new System.Drawing.Size(93, 40);
            this.labelDefinition.TabIndex = 10;
            this.labelDefinition.Text = "Definition";
            this.labelDefinition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonSearch.Location = new System.Drawing.Point(247, 85);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(92, 38);
            this.buttonSearch.TabIndex = 11;
            this.buttonSearch.Text = "SEARCH";
            this.buttonSearch.UseVisualStyleBackColor = false;
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonClear.Location = new System.Drawing.Point(689, 431);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(92, 38);
            this.buttonClear.TabIndex = 12;
            this.buttonClear.Text = "CLEAR";
            this.buttonClear.UseVisualStyleBackColor = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonDelete.Location = new System.Drawing.Point(568, 431);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(92, 38);
            this.buttonDelete.TabIndex = 13;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.UseVisualStyleBackColor = false;
            // 
            // buttonModify
            // 
            this.buttonModify.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonModify.Location = new System.Drawing.Point(458, 431);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(92, 38);
            this.buttonModify.TabIndex = 14;
            this.buttonModify.Text = "MODIFY";
            this.buttonModify.UseVisualStyleBackColor = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonAdd.Location = new System.Drawing.Point(346, 431);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(92, 38);
            this.buttonAdd.TabIndex = 15;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = false;
            // 
            // statusStripBar
            // 
            this.statusStripBar.Location = new System.Drawing.Point(0, 539);
            this.statusStripBar.Name = "statusStripBar";
            this.statusStripBar.Size = new System.Drawing.Size(945, 22);
            this.statusStripBar.TabIndex = 16;
            this.statusStripBar.Text = "statusStrip1";
            // 
            // FormDataStructureMatrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 561);
            this.Controls.Add(this.statusStripBar);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelDefinition);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.labelStructure);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxCategory);
            this.Controls.Add(this.textBoxStructure);
            this.Controls.Add(this.textBoxDefinition);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.listViewDisplay);
            this.Name = "FormDataStructureMatrix";
            this.Text = "Data Structure Matrix";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewDisplay;
        private System.Windows.Forms.ColumnHeader dataStructureName;
        private System.Windows.Forms.ColumnHeader dataStructureCategory;
        private System.Windows.Forms.ColumnHeader dataStructureType;
        private System.Windows.Forms.ColumnHeader dataStructureDefinition;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.TextBox textBoxDefinition;
        private System.Windows.Forms.TextBox textBoxStructure;
        private System.Windows.Forms.TextBox textBoxCategory;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Label labelStructure;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDefinition;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.StatusStrip statusStripBar;
    }
}

