using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataStructureMatrix
{
    public partial class FormDataStructureMatrix : Form
    {
        public FormDataStructureMatrix()
        {
            InitializeComponent();
        }
        private static int maxRows = 12;
        private static int maxAttributes = 4;
        private int ptr = 0;
        private string[,] ArrayWikiStorage = new string [maxRows, maxAttributes];

        private void DisplayArrayListViev()
        {
            listViewDisplay.Items.Clear();
            for(int i = 0; i < maxRows; i++)
            {
                
                    ListViewItem lvItem = new ListViewItem(ArrayWikiStorage[i,0]);
                    lvItem.SubItems.Add(ArrayWikiStorage[i,1]);
                    listViewDisplay.Items.Add(lvItem);
                   
            }

        }

        private void buttonAdd_MouseClick(object sender, MouseEventArgs e)
        {
            if(ptr < maxRows)
            {
                try
                {
                    ArrayWikiStorage[ptr, 0] = textBoxName.Text;
                    ArrayWikiStorage[ptr, 1] = textBoxCategory.Text;
                    ArrayWikiStorage[ptr, 2] = textBoxStructure.Text;
                    ArrayWikiStorage[ptr, 3] = textBoxDefinition.Text;
                    ptr++;
                    toolStripStatusLabel1.Text = "Record Added";  
                }
                
                catch
                {
                    MessageBox.Show("Did not Work");
                }
            }
            else
            {
                MessageBox.Show("No Space");
            }
            CLearTextBox();
            DisplayArrayListViev();
            
        }
        private void CLearTextBox()
        {
            textBoxName.Clear();
            textBoxCategory.Clear();
            textBoxStructure.Clear();
            textBoxDefinition.Clear();
            textBoxSearch.Clear();
        }

        private void listViewDisplay_MouseClick(object sender, MouseEventArgs e)
        {
            int currentItem = listViewDisplay.SelectedIndices[0];
            textBoxName.Text = ArrayWikiStorage[currentItem, 0];
            textBoxCategory.Text = ArrayWikiStorage[currentItem, 1];
            textBoxStructure.Text = ArrayWikiStorage[currentItem, 2];
            textBoxDefinition.Text = ArrayWikiStorage[currentItem, 3];
            
        }
    }
    
}
