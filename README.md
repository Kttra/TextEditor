# Text Editor
A text editor that is used to replace words in the text, make it into a list form, or clean it up. The program is made using C# and .NET 6.

The purpose of this program is to replace the text in the top textbox with whatever the user inputs. This program focuses on fixing a list of things. Additionally, the program will clean up the text by looking at specific unwanted patterns.

**Layout & Replace**
-------------
Below is an image of how the program looks. In the center, we have two textboxes that represent the string to be replaced and the string that will replace it. The textbox on top is the original text taken while the textbox on the bottom will show the new edited result. Hitting replace will execute these steps. Replace is case sensitive. I may plan to change this in the future.

<p align="center">
<img src="https://user-images.githubusercontent.com/100814612/165432174-54418059-b75b-46a0-9d05-0f3aa2b41ce7.png"><img>
</p>

**Overwrite**
-------------
The Overwrite button is a simple function that will copy and paste the "New text" to the "Original Text" box. This is useful for continuous replacements or text editing.

<p align="center">
<img src="https://user-images.githubusercontent.com/100814612/165432599-9230739d-e65c-4f5c-a9d6-9b8e52da9d4d.png"><img>
</p>

**Clean**
---------
The Clean button does a variety of things that should be edited to suit your needs. In my case, I built the clean button to clean up text in the event that I am copying and pasting a list of albumns or tracks. Generally when copying tracks, problems arise such as accidentally copying track times or having random characters. This function is made to clean up those unwanted characters.

- Removes any strings with a time like pattern (Ex: 12:43 or (11:70))
- Removes any quotations, parentheses, commas, "!", "?", "...", "~", "\[", "\]", "●", "★", "Track", "Truck", and "☆"
- Adds a '.' to after the first found numbers (Ex: 1 -> 1., then 2 -> 2., etc)
- Trims each line
- Removes lines that are empty
- Removes unncessary spaces between words (vital to use after character removal)
- Replaces the word "ex " with "Bonus. "

<p align="center">
<img src="https://user-images.githubusercontent.com/100814612/165434777-50f1cc17-f5de-430c-a4e9-aae3eb431fd2.png"><img>
</p>


**Trim**
---------
The trim button is a spacing/line editing function that works similar to clean except it only looks at spacing. It will remove any newlines and unncessary spacing. The purpose is to format the text in a paragraph in the event your text is not properly formatted and has a lot of random unintentional spacing.

<p align="center">
<img src="https://user-images.githubusercontent.com/100814612/165631543-e882ef6f-22b9-4762-8091-649bd08a7066.png"><img>
</p>

**Number**
---------
The number button is meant to be used only after the replacing, cleaning, or trimming functions (as it edits the new text instead of the original). It will remove any existing numbers in the new text box and will append to the start of each line a number.

<p align="center">
<img src="https://user-images.githubusercontent.com/100814612/165632502-02e4ecf8-6a4c-46c3-9528-c269fa81010f.png"><img>
</p>


Additionally, when you press the number button a prompt will pop up asking for what number do you want the list to start at. If it is given no value, the program will assume you want to start at 1.

<p align="center">
<img src="https://user-images.githubusercontent.com/100814612/165632531-5a52ee49-77a5-42fc-8ff0-1cb2d4d71666.png"><img>
</p>

**Targets & Outputs**
---------
Each button targets and outputs to a different textbox. Below is the targetting specifications:
- Replace:    
  - Original Text -> New Text
- Overwrite:
  - New Text -> Original Text
- Clean:
  - Original Text -> New Text
- Trim:
  - Original Text -> New Text
- Number:
  - New Text -> New Text
