C# Word Counter Week 2 Code Review

This webpage is my Independent Code Review Project for Epicodus C# Programming course. (6/2/2017)

By Andrew Dalton, Epicodus

Description

An application that allows the user to check how many times a specified word appears in a provided string of words.

Setup/Installation Requirements

Go to https://github.com/drewlinn/shiny-enigma using your web browser and click the Clone or download button. If doing so through a console or powershell, make certain all necessary git scripts and software are properly installed and use the "git clone" command followed by the repository web address and press enter. Type and perform a 'dnu restore' and a 'dnu build' command and then follow that with a 'dnx kestrel' and access the application at the 'localhost:5004' web address.

Specifications

| Behavior | Input | Output | Description |
|:---------|:------|:-------|:------------|
| Checks for a word in a string. | "TestWord" | "TestWord appears 1 time" | TestWord is clearly identifiable as an easily testable and memorable string. |
| Counts instances of word in a string. | "Testword, This is a TestWord.", "TestWord" | "TestWord appears 2 times." | The chosen word occurs twice so as to see that the counter is counting appropriately. |
| Counts only instances of the word that match the full word. | "TestString, This is a TestString" | "TestWord appears 0 times." | Words in the string share similar characters to the TestWord, but not all of them. |

Known Bugs



Support and contact details

If you notice any issues with my page or my code, please contact me at expandrew@gmail.com.

Technologies Used

This page was created in C# and HTML using Atom, Git, and the Windows Powershell.

License

This software is licensed under the GPL license.

Copyright (c) 2015 Andrew Dalton, Epicodus
