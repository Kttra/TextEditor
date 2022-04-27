/*  The purpose of this program is to replace the text in the top textbox
    with whatever the user inputs. This program focuses more on fixing a list
    of things.

    Additionally, the program will clean up the text by looking at specific
    unwanted patterns.

    Replace:
    Normal replace function that replaces words

    Overwrite:
    Copies the top textbox's text to the bottom textbox

    Clean:
    Removes any strings with a time like pattern (Ex: 12:43 or (11:70))
    Adds a '.' to after the first found numbers (Ex: 1 -> 1., then 2 -> 2., etc)
    Trims each line
    Removes lines that are empty
    Replaces the word "ex " with "Bonus. "
    Removes any quotations, parentheses, commas, "!", "?", "...", "~", "[", "]", "Åú", "Åö", "Track", "Truck", and "Åô"
    
    Number:
    Removes any numbers in the text and then starts to number each line
*/

using System.Text.RegularExpressions; //regex
//using System.Diagnostics; //stopwatch

namespace textEditor
{
    public partial class textEditor : Form
    {
        public textEditor()
        {
            InitializeComponent();
        }
        //Replaces specific characters with input given by the user
        private void ReplaceBtn_Click(object sender, EventArgs e)
        {
            Replace();
        }
        //Enter is pressed in the "with" textbox
        private void ReplaceWithBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Replace();
            }
        }
        //Replaces the text from the textbox given the string to replace and the string that's going to replace it
        private void Replace()
        {
            string replace = ReplaceCharBox.Text;
            string replaceWith = ReplaceWithBox.Text;
            string originalText = UserInputBox.Text;

            //If the replace textbox is not empty, continue
            if (!String.IsNullOrEmpty(ReplaceCharBox.Text))
            {
                EditedTextBox.Text = originalText.Replace(replace, replaceWith);
            }
        }
        //Overwrites the top textbox with text from the bottom
        private void OverwriteBtn_Click(object sender, EventArgs e)
        {
            UserInputBox.Text = EditedTextBox.Text;
        }
        //Removes specific character patterns deemed to be useless
        private void CleanBtn_Click(object sender, EventArgs e)
        {
            string editedText = UserInputBox.Text;

            //Remove all 0's
            //editedText = editedText.Replace("0", "");

            //Replace any pattern that represents a time (Ex: (12:43)), also trims the space before it and at the end of the string
            editedText = Regex.Replace(editedText, @"\s[(][0-9]{1,2}[:][0-9]{1,2}[)]", "");

            //Replace any pattern that represents a time (Ex: 12:43), also trims the space before it and at the end of the string
            editedText = Regex.Replace(editedText, @"\s[0-9]{1,2}[:][0-9]{1,2}", "");

            //Add or remove elements from the array to change what will be removed
            var charsToRemove = new string[] { "\"", "!", "?", ")", "(", "...", "~", "[", "]", "Åú", "Åö", "Track", "Truck", "Åô", "," };
            editedText = RemoveString(charsToRemove, editedText);

            //Add a dot after each number
            for (int i = 0; i <= UserInputBox.Lines.Length + 1; i++)
            {
                //Since 0 and 1 generally don't have a newline before it, we don't check for newline
                if(i == 1 || i == 0)
                {
                    editedText = Regex.Replace(editedText, $@"{i}\s", $"{i}. ");
                }
                //We're assuming there'll be newlines after each track
                else
                {
                    editedText = Regex.Replace(editedText, $@"\n{i}\s", $"\n{i}. ");
                }

                /*//The below does the same thing but is more error prone
                //Convert i into an integer (1 -> '1')
                int index = editedText.IndexOf((char)(i + 48));

                //If the number exists and we are not checking the last index, insert a dot after this index
                if (index != -1 && editedText.Length - 1 != index && editedText[index + 1] != '.')
                {
                    editedText = editedText.Insert(index + 1, ".");
                }
                */
            }

            //Replaces "ex " with "Bonus. ", need to add a newline before b/c it get's removed
            editedText = Regex.Replace(editedText, @"\s[e][x]\s", "\nBonus. ");

            //Trim each line, helpful for removing unwanted spaces after the character removal
            editedText = string.Join(Environment.NewLine, editedText.Split(new[] { Environment.NewLine }, StringSplitOptions.None).Select(l => l.Trim()));

            //Removes empty lines, does not account for the last line
            //editedText = Regex.Replace(editedText, @"^\s+$[\r\n]*", string.Empty, RegexOptions.Multiline);

            //Update the textbox
            EditedTextBox.Text = editedText;

            //Better removal of empty lines
            var lines = editedText.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            //Removes extra spaces, helpful to fix spacing after character removal
            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = Regex.Replace(lines[i], " {2,}", " ");
            }

            //Updates the textbox with all the changes
            EditedTextBox.Lines = lines;
        }

        //Add Numbers to each line 
        private void NumBtn_Click(object sender, EventArgs e)
        {
            using var form = new startIndex();
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                //Our starting listing number
                int startingIndex = form.ReturnValue1;

                //Removes any existing numbers
                EditedTextBox.Text = Regex.Replace(EditedTextBox.Text, @"[0-9][.]", ""); //Removes #. (Ex: 1.)
                EditedTextBox.Text = Regex.Replace(EditedTextBox.Text, @"[0-9]", ""); //Removes #'s

                string[] lines = EditedTextBox.Lines;
                for (int i = 0; i < lines.Length; i++, startingIndex++)
                {
                    lines[i] = (startingIndex) + ". " + lines[i].Trim();
                }
                EditedTextBox.Lines = lines;
            }
        }
        //Trims user's input
        private void RemoveNewlines_Click(object sender, EventArgs e)
        {

            //Trim each line, helpful for removing unwanted spaces
            EditedTextBox.Text = string.Join(Environment.NewLine, UserInputBox.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.None).Select(l => l.Trim()));

            //Removes any empty lines
            var lines = EditedTextBox.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            //Removes extra spaces, helpful to fix spacing after character removal
            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = Regex.Replace(lines[i], " {2,}", " ");
            }

            EditedTextBox.Lines = lines;

            //Last step, replace each newline with a space instead
            EditedTextBox.Text = Regex.Replace(EditedTextBox.Text, @"\r\n?|\n", " ");
        }

        //Remove specific strings
        public static string RemoveString(string[] charsToRemove, string str)
        {
            /* //Stop watch for debugging
            Stopwatch sw = new Stopwatch();
            sw.Start();
            sw.Stop();
            Console.WriteLine("ArrayList:\tMilliseconds = {0},\tTicks = {1}", sw.ElapsedMilliseconds, sw.ElapsedTicks);
            */

            //For each string in the string array replace
            foreach (string c in charsToRemove)
            {
                str = str.Replace(c, string.Empty);
            }

            return str;
        }
    }
}