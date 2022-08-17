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
        

        #region Add Button
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
        #endregion Add Button
        #region Utilities
        private void CLearTextBox()
        {
            textBoxName.Clear();
            textBoxCategory.Clear();
            textBoxStructure.Clear();
            textBoxDefinition.Clear();
            textBoxSearch.Clear();
        }
        #endregion Utilities

        #region Selected Items View
        private void listViewDisplay_MouseClick(object sender, MouseEventArgs e)
        {
            int currentItem = listViewDisplay.SelectedIndices[0];
            textBoxName.Text = ArrayWikiStorage[currentItem, 0];
            textBoxCategory.Text = ArrayWikiStorage[currentItem, 1];
            textBoxStructure.Text = ArrayWikiStorage[currentItem, 2];
            textBoxDefinition.Text = ArrayWikiStorage[currentItem, 3];
            
        }
        #endregion Selected Items View

        private void FormDataStructureMatrix_Load(object sender, EventArgs e)
        {
            ArrayLoader();
            DisplayArrayListViev();
        }
        #region Array Loader
        private void ArrayLoader()
        {
            if (ptr < maxRows)
            {
                try
                {
                    ArrayGetter("Array", "Array", "Linear", "Arrays are used to store multiple values in a single variable, instead of declaring separate variables for each value.");
                    ArrayGetter("Two Dimensional Array", "Array", "Linear", "Two-dimensional (2D) arrays are indexed by two subscripts, one for the row and one for the column. Each element in the 2D array must by the same type, either a primitive type or object type.");
                    ArrayGetter("List", "List", "Linear", "A list is a sequence of elements. In its simplest form, a list can be implemented as an array. However, the term list usually refers to a linked list with each element of the list (called a node) containing pointers to one or more other list items.");
                    ArrayGetter("Linked List","List","Linear", "A linked list is a linear collection of data elements whose order is not given by their physical placement in memory. Instead, each element points to the next. It is a data structure consisting of a collection of nodes which together represent a sequence.");
                    ArrayGetter("Self-Balanced Tree", "Tree", "Non-Linear", "Self-Balancing Trees are height-balanced  trees that automatically keeps height as small as possible when insertion and deletion operations are performed on tree. The height is typically maintained in order of Log n so that all operations take O(Log n) time on average.");
                    ArrayGetter("Heap", "Tree", "Non-Linear", "It is a complete binary tree that satisfies the heap property, where any given node is always greater than its child node/s and the key of the root node is the largest among all other nodes. This property is also called max heap property and reverse to it is known as Min heap property.");
                    ArrayGetter("Binary Search Tree", "Tree", "Non-Linear", "Binary Search Tree		Non-Linear	Binary search tree is a data structure that quickly allows us to maintain a sorted list of numbers.");
                    ArrayGetter("Graph", "Graphs", "Non-Linear", "A graph is a data structure that organizes data according to the relationships of its elements in a geometric space. The elements are usually vertices (points in the graph) and edges (the connections between vertices).");
                    ArrayGetter("Set", "Abstract", "Non-Linear", "A set of collection of objects need not to be in any particular order. It is just applying the mathematical concepts in computer where elements should not be repeated and they should have valid reason to be in the set.");
                    ArrayGetter("Queue", "Abstract", "Linear", "A queue is a sequential collection where elements are added to the end of the queue, and removed from the beginning. It is a FIFO data structure (first in, first out ). It is most efficiently implemented with a doubly-linked list.");
                    ArrayGetter("Stack", "Abstarct", "Liear", "A stack is a sequential collection of elements where only the last element (at the top of the stack) can be modified. A new element can be pushed onto the stack, in which case, it becomes the last element of the stack, and the stack's length increases by 1.");
                    ArrayGetter("Hash Table", "Hash", "Non-Linear", "A hash table or hash map is a type of associative array where the keys are the computed hashes of their values");
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

        }
        private void ArrayGetter(string nameload, string categoryLoad, string structureLoad, string definitionLoad)
        {
            ArrayWikiStorage[ptr, 0] = nameload;
            ArrayWikiStorage[ptr, 1] = categoryLoad;
            ArrayWikiStorage[ptr, 2] = structureLoad;
            ArrayWikiStorage[ptr, 3] = definitionLoad;
            ptr++;
        }

        #endregion Array Loader
    }

}
