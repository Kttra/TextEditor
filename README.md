# Text Editor
A text editor that is used to replace words in the text, make it into a list form, or clean it up. The program is made using C# and .NET 6.

The purpose of this program is to replace the text in the top textbox with whatever the user inputs. This program focuses on fixing a list of things. Additionally, the program will clean up the text by looking at specific unwanted patterns.

**Layout & Replace**
-------------
Below is an image of how the program looks. In the center, we have two textboxes that represent the string to be replaced and the string that will replace it. The textbox on top is the original text taken while the textbox on the bottom will show the new edited result. Hitting replace will execute these steps.

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
- Adds a '.' to after the first found numbers (Ex: 1 -> 1., then 2 -> 2., etc)
- Trims each line
- Removes lines that are empty
- Replaces the word "ex " with "Bonus. "
- Removes any quotations, parentheses, commas, "!", "?", "...", "~", "\[", "\]", "●", "★", "Track", "Truck", and "☆"

<p align="center">
<img src="https://user-images.githubusercontent.com/100814612/165434777-50f1cc17-f5de-430c-a4e9-aae3eb431fd2.png"><img>
</p>
