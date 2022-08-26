using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Satbir Singh
//Student ID 30048567
// Data Structure Matrix using Two Dimensional Array
// Date 03/August/2022
// Can Load Data in Array on form Load if enabled (in region Array Loader)
//PR12: This Form Application has suitable Messageboxes, Dialog Boxes, tool tips for feedbacks. 
namespace DataStructureMatrix
{
    public partial class FormDataStructureMatrix : Form
    {
        public FormDataStructureMatrix()
        {
            InitializeComponent();
        }
        // PR1: Create a global 2D string array, use static variables for the dimensions (row, column) 

        #region Array Declaration
        private static int maxRows = 12;
        private static int maxAttributes = 4;
        private int ptr = 0;
        private string[,] ArrayWikiStorage = new string [maxRows, maxAttributes];
        private string defaultFileName = "definitions.bin";// default name of the file declared
        #endregion

        //PR2: Create an ADD button that will store the information from the 4 text boxes into the 2D array 
        // Add Button Will only work if all text boxes have data in it
        #region Add Button
        private void ButtonAdd_MouseClick(object sender, MouseEventArgs e)
        {
            if (TextBoxName.Text != "" && TextBoxCategory.Text != "" && TextBoxStructure.Text != "" && TextBoxDefinition.Text != "")
            {
                if(DuplicateCheck() == false)// Check for duplicate entry
                {
                    for (int i = 0; i < maxRows; i++)
                    {
                       if (ArrayWikiStorage[i, 0] == "~")
                        {
                            try
                            {

                                ArrayWikiStorage[i, 0] = TextBoxName.Text;
                                ArrayWikiStorage[i, 1] = TextBoxCategory.Text;
                                ArrayWikiStorage[i, 2] = TextBoxStructure.Text;
                                ArrayWikiStorage[i, 3] = TextBoxDefinition.Text;
                                toolStripStatusLabel1.Text = "Record Added Successfully";
                                break;
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Something went wrong please try again", "System Information");
                                break;
                            }
                        }
                        else
                        {
                            MessageBox.Show("No Space for Adding Record Please delete some records ", "System Information");
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Data Structure already in the list", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
                
                
            }
            else
            {
                MessageBox.Show("Please Enter data in text boxes to add ", "System Information");
            }

            
            InitiliseArray();
            CLearTextBox();
        }
        #endregion Add Button

        //PR3: Create an EDIT button that will allow the user to modify any information from the 4 text boxes into the 2D array
        // Modify button will work only if Data is selected from list view
        #region Editing
        private void ButtonModify_Click(object sender, EventArgs e)
        {
            if (ListViewDisplay.SelectedItems != null && TextBoxName.Text != "" && TextBoxCategory.Text != "" && TextBoxStructure.Text != "" && TextBoxDefinition.Text != "")
            {
                var indx = ListViewDisplay.FocusedItem.Index;//find the index of selected item
                var confirmation = MessageBox.Show("Are you sure you want to edit the selected record previous record can not be retrieved " +
                    "after modification", "System Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmation == DialogResult.Yes)//Replace with User Data
                {
                    if(DuplicateCheck() == false)// Warning if no modification is done
                    {
                        try
                        {
                            ArrayWikiStorage[indx, 0] = TextBoxName.Text;
                            ArrayWikiStorage[indx, 1] = TextBoxCategory.Text;
                            ArrayWikiStorage[indx, 2] = TextBoxStructure.Text;
                            ArrayWikiStorage[indx, 3] = TextBoxDefinition.Text;
                            toolStripStatusLabel1.Text = "Record has been changed";
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Something went wrong please try again");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No Modification has been Done ", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                else
                {
                    toolStripStatusLabel1.Text = "User has canceled editing process";
                }

            }
            else
            {
                MessageBox.Show("Please select the data from list to edit it");
            }
            InitiliseArray();
            CLearTextBox();
        }
        #endregion Editing

        //PR4: Create a DELETE button that removes all the information from a single entry of the array; the user must be prompted before the final deletion occurs
        // Delete Button only works if data is selected from the list View
        #region Delete
        private void ButtonDelete_Click(object sender, EventArgs e)
        {

            if (ListViewDisplay.SelectedItems != null && TextBoxName.Text != "" && TextBoxCategory.Text != "" && TextBoxStructure.Text != "" && TextBoxDefinition.Text != "")
            {
                var indx = ListViewDisplay.FocusedItem.Index;// Find the Index of the selected Item
                
                var confirmation = MessageBox.Show("Are You sure for delete the selected item ", "System Information ",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmation == DialogResult.Yes)// Delete the item if returned Yes
                {
                    try
                    {
                        ArrayWikiStorage[indx, 0] = "";
                        ArrayWikiStorage[indx, 1] = "";
                        ArrayWikiStorage[indx, 2] = "";
                        ArrayWikiStorage[indx, 3] = "";
                        
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Something went wrong please try again ");
                    }
                }
                else
                {
                    toolStripStatusLabel1.Text = "User has Canceled deletion";
                }
            }
            else
            {
                MessageBox.Show("Please select the data from the list to delete it");
            }

            InitiliseArray(); 
            CLearTextBox();
        }
        #endregion Delete

        //PR5: Create a CLEAR method to clear the four text boxes so a new definition can be added 
        // Duplicate Check Method
        // tooltip text control
        #region Utilities
        private void ButtonClear_Click(object sender, EventArgs e)
        {
            if(TextBoxName.Text != "" || TextBoxCategory.Text != "" || TextBoxStructure.Text != "" || TextBoxDefinition.Text != "")
            {
                CLearTextBox();
            }
            else
            {
                toolStripStatusLabel1.Text = "Nothing to Clear"; 
            }
            
        }

        private void CLearTextBox()
        {
            TextBoxName.Clear();
            TextBoxCategory.Clear();
            TextBoxStructure.Clear();
            TextBoxDefinition.Clear();
            TextBoxSearch.Clear();
        }

        private void FormDataStructureMatrix_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = "";

        }
        private void ListViewDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            CLearTextBox();
             
        }
        private bool DuplicateCheck()// Function to stop duplicate value in the Array
        {
            bool found = false;
            for(int i = 0; i < ArrayWikiStorage.GetLength(0); i++)
            {
                if (ArrayWikiStorage[i, 0] == TextBoxName.Text && ArrayWikiStorage[i,1] == TextBoxCategory.Text && ArrayWikiStorage[i,2] == TextBoxStructure.Text && ArrayWikiStorage[i,3] == TextBoxDefinition.Text)
                {
                    
                    found = true;
                    break;
                }
                else
                {
                    found = false;
                }
            }
            return found;
        }

        #endregion Utilities

        //PR6: Write the code for a Bubble Sort method to sort the 2D array by Name ascending, ensure you use a separate swap method that passes the array element to be swapped
        //Swap Method using an array to swap elements
        #region Sorting
        private void Swap(int x, int y)
        {
            string[] temp = new string[4];
            temp[0] = ArrayWikiStorage[x, 0];
            temp[1] = ArrayWikiStorage[x, 1];
            temp[2] = ArrayWikiStorage[x, 2];
            temp[3] = ArrayWikiStorage[x, 3];
            ArrayWikiStorage[x, 0] = ArrayWikiStorage[y, 0];
            ArrayWikiStorage[x, 1] = ArrayWikiStorage[y, 1];
            ArrayWikiStorage[x, 2] = ArrayWikiStorage[y, 2];
            ArrayWikiStorage[x, 3] = ArrayWikiStorage[y, 3];
            ArrayWikiStorage[y, 0] = temp[0];
            ArrayWikiStorage[y, 1] = temp[1];
            ArrayWikiStorage[y, 2] = temp[2];
            ArrayWikiStorage[y, 3] = temp[3];


        }
        private void Sort()
        {

            for (int i = 0; i < maxRows - 1; i++)
            {
                for (int j = i + 1; j < maxRows; j++)
                {
                    if (String.Compare(ArrayWikiStorage[i, 0], ArrayWikiStorage[j, 0]) > 0)
                    {
                        Swap(i, j);
                    }
                   

                }
            }
            
        }
        #endregion Sorting

        //PR7: Write the code for a Binary Search for the Name in the 2D array and display the information in the other textboxes when found,
        //add suitable feedback if the search in not successful and clear the search textbox
        // Search Method Works only if Data is in the text box.
        #region Search
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxSearch.Text))
            {
                bool found = false;
                int min = 0;
                int mid = 0;
                int max = maxRows-1;
                string target = TextBoxSearch.Text;


                while (min <= max)// Always find the mid of the Array untill its Equal
                {
                    try
                    {
                        mid = (min + max) / 2;
                        if (target.CompareTo(ArrayWikiStorage[mid, 0]) == 0)// if searched item found
                        {
                            found = true;
                            break;
                        }
                        else if (target.CompareTo(ArrayWikiStorage[mid, 0]) < 0)// if searched item is in lower side of the array than previous mid
                        {
                            max = mid - 1;
                        }
                        else
                        {
                            min = mid + 1;
                        }
                    }
                    catch(Exception)
                    {
                        MessageBox.Show("Something Went Wrong ", "System Information ",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    
                }

                if (!found)
                {
                    MessageBox.Show(target + " is not in the List", "System Information", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Success: " + target + " was found in line " +(mid+1),"System Information", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please Enter data in text box to search ", "System Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            TextBoxSearch.Clear();
        }
        #endregion Search

        //PR8: Create a display method that will show the following information in a ListView: Name and Category 
        #region Display
        private void InitiliseArray()
        {

            for (int i = 0; i < maxRows; i++)
            {
                if (String.IsNullOrEmpty(ArrayWikiStorage[i, 0]))
                {
                    ArrayWikiStorage[i, 0] = "~";
                    ArrayWikiStorage[i, 1] = "~";
                    ArrayWikiStorage[i, 2] = "~";
                    ArrayWikiStorage[i, 3] = "~";

                }
            }
            
            DisplayArrayListViev();

        }
        private void DisplayArrayListViev()
        {
            Sort();
            ListViewDisplay.Items.Clear();
            for (int i = 0; i < maxRows; i++)
            {
                ListViewItem lvItem = new ListViewItem(ArrayWikiStorage[i, 0]);
                lvItem.SubItems.Add(ArrayWikiStorage[i, 1]);
                ListViewDisplay.Items.Add(lvItem);
            }
        }
        #endregion Display

        //PR9: Create a method so the user can select a definition (Name) from the ListView and all the information is displayed in the appropriate Textboxes
        #region Selected Items View
        private void ListViewDisplay_MouseClick(object sender, MouseEventArgs e)
        {
            int currentItem = ListViewDisplay.FocusedItem.Index;
            TextBoxName.Text = ArrayWikiStorage[currentItem, 0];
            TextBoxCategory.Text = ArrayWikiStorage[currentItem, 1];
            TextBoxStructure.Text = ArrayWikiStorage[currentItem, 2];
            TextBoxDefinition.Text = ArrayWikiStorage[currentItem, 3];

        }

        #endregion Selected Items View


        //PR10: Create a SAVE button so the information from the 2D array can be written into a binary file called definitions.dat which is sorted by Name,
        //ensure the user has the option to select an alternative file. Use a file stream and BinaryWriter to create the file.
        #region SaveFile
        private void SaveBinFile(string saveFileName)
        {
            try
            {
                using (Stream stream = File.Open(saveFileName, FileMode.Create))
                {
                    using (var writer = new BinaryWriter(stream, Encoding.UTF8, false))
                    {
                        for (int i = 0; i < maxRows; i++)
                        {
                            for (int j = 0; j < maxAttributes; j++)
                            {
                                writer.Write(ArrayWikiStorage[i, j]);
                            }
                        }
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "bin file|*.bin";
                saveFileDialog.Title = "Save A Binary File";
                saveFileDialog.InitialDirectory = Application.StartupPath;
                saveFileDialog.DefaultExt = "bin";
                saveFileDialog.ShowDialog();
                string fileName = saveFileDialog.FileName;
                if (saveFileDialog.FileName != "")
                {
                    SaveBinFile(fileName);
                    MessageBox.Show("File Has been Saved", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    SaveBinFile(defaultFileName);
                    MessageBox.Show("User has canceled to save data but file saved under name Definition.bin", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something Went Wrong Please Try Again later ", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        #endregion SaveFile

        //PR11: Create a LOAD button that will read the information from a binary file called definitions.dat into the 2D array,
        //ensure the user has the option to select an alternative file.Use a file stream and BinaryReader to complete this task.
        //Open the saved file using Binary Reader and load it into the list view
        #region OpenFIle
        private void OpenBinFile(string openFileName)
        {
            try
            {
                using(Stream stream = File.Open(openFileName, FileMode.Open))
                {
                    using (var reader = new BinaryReader(stream, Encoding.UTF8, false))
                    {
                        int x = 0;
                        Array.Clear(ArrayWikiStorage, 0, ArrayWikiStorage.Length);
                        while(stream.Position < stream.Length)
                        {
                            for(int y = 0; y < maxAttributes; y++)
                            {
                                ArrayWikiStorage[x, y] = reader.ReadString();
                            }
                            x++;
                        }
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            DisplayArrayListViev();
        }
        private void ButtonOpen_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = Application.StartupPath;
                openFileDialog.Filter = "BIN FILES|*.bin";
                openFileDialog.Title = "Open A Binary File";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    OpenBinFile(openFileDialog.FileName);
                    toolStripStatusLabel1.Text = "File has been uploaded Successfully";
                }
                else
                {
                    toolStripStatusLabel1.Text = "User has canceled to open file";
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Something Went Wrong Please Try Again later ", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        #endregion OpenFile
        
        // This function will load the data in to the list view on form load if enabled
        #region Form Load

        private void FormDataStructureMatrix_Load(object sender, EventArgs e)
        {
            ArrayLoader();
            InitiliseArray();
            toolTip1.SetToolTip(ButtonAdd, "Click To Add Record");
            toolTip1.SetToolTip(ButtonSearch, "Click To Search Record");
            toolTip1.SetToolTip(ButtonModify, "Click To Edit Record");
            toolTip1.SetToolTip(ButtonDelete, "Click To Delete Record");
            toolTip1.SetToolTip(ButtonClear, "Click To Clear Text Boxes Record");
            toolTip1.SetToolTip(ButtonOpen, "Click To Load Data");
            toolTip1.SetToolTip(ButtonSave, "Click To Save Record");
            toolTip1.SetToolTip(TextBoxName, "Display The Name of the Data Structure Once Selected");
            toolTip1.SetToolTip(TextBoxCategory, "Display and add Data Structure Category using this box");
            toolTip1.SetToolTip(TextBoxStructure, "Display and add Data Structure type using this box");
            toolTip1.SetToolTip(TextBoxDefinition, "Display and add Data Structure Definition using this box");
            toolTip1.SetToolTip(TextBoxSearch, "Enter data to search in the list");
            toolTip1.SetToolTip(ListViewDisplay, "Click to select a row and click in empty region to clear text boxes and deselect an item");
        }
        private void ArrayLoader()
        {

             try
                {
                    ArrayGetter("Array", "Array", "Linear", "Arrays are used to store multiple values in a single variable, instead of declaring separate variables for each value.");
                    ArrayGetter("2D Dimensional Array", "Array", "Linear", "Two-dimensional (2D) arrays are indexed by two subscripts, one for the row and one for the column. Each element in the 2D array must by the same type, either a primitive type or object type.");
                    ArrayGetter("List", "List", "Linear", "A list is a sequence of elements. In its simplest form, a list can be implemented as an array. However, the term list usually refers to a linked list with each element of the list (called a node) containing pointers to one or more other list items.");
                    ArrayGetter("Linked List","List","Linear", "A linked list is a linear collection of data elements whose order is not given by their physical placement in memory. Instead, each element points to the next. It is a data structure consisting of a collection of nodes which together represent a sequence.");
                    ArrayGetter("Self-Balanced Tree", "Tree", "Non-Linear", "Self-Balancing Trees are height-balanced  trees that automatically keeps height as small as possible when insertion and deletion operations are performed on tree. The height is typically maintained in order of Log n so that all operations take O(Log n) time on average.");
                    ArrayGetter("Heap", "Tree", "Non-Linear", "It is a complete binary tree that satisfies the heap property, where any given node is always greater than its child node/s and the key of the root node is the largest among all other nodes. This property is also called max heap property and reverse to it is known as Min heap property.");
                    ArrayGetter("Binary Search Tree", "Tree", "Non-Linear", "Binary Search Tree		Non-Linear	Binary search tree is a data structure that quickly allows us to maintain a sorted list of numbers.");
                    ArrayGetter("Graph", "Graphs", "Non-Linear", "A graph is a data structure that organizes data according to the relationships of its elements in a geometric space. The elements are usually vertices (points in the graph) and edges (the connections between vertices).");
                    ArrayGetter("Set", "Abstract", "Non-Linear", "A set of collection of objects need not to be in any particular order. It is just applying the mathematical concepts in computer where elements should not be repeated and they should have valid reason to be in the set.");
                    ArrayGetter("Queue", "Abstract", "Linear", "A queue is a sequential collection where elements are added to the end of the queue, and removed from the beginning. It is a FIFO data structure (first in, first out ). It is most efficiently implemented with a doubly-linked list.");
                    ArrayGetter("Stack", "Abstarct", "Linear", "A stack is a sequential collection of elements where only the last element (at the top of the stack) can be modified. A new element can be pushed onto the stack, in which case, it becomes the last element of the stack, and the stack's length increases by 1.");
                    ArrayGetter("Hash Table", "Hash", "Non-Linear", "A hash table or hash map is a type of associative array where the keys are the computed hashes of their values");
                }
                catch
                {
                    MessageBox.Show("Something Went Wrong Please Try Again ", "System Information");
                }
        }

        private void ArrayGetter(string nameload, string categoryLoad, string structureLoad, string definitionLoad)// load the data into the Array by using these parameters
        {
            
            if(ptr < maxRows)
            {
                ArrayWikiStorage[ptr, 0] = nameload;
                ArrayWikiStorage[ptr, 1] = categoryLoad;
                ArrayWikiStorage[ptr, 2] = structureLoad;
                ArrayWikiStorage[ptr, 3] = definitionLoad;
                ptr++;
            }
            if(ptr >= maxRows)
            {
                toolStripStatusLabel1.Text = "Array is Full";
            }
                        
        }


        #endregion Form Load

       
    }
}
