C# Word Counter Week 2 Code Review

This webpage is my Independent Code Review Project for Epicodus C# Programming course. (6/2/2017)

By Andrew Dalton, Epicodus

Description



Setup/Installation Requirements

Go to https://github.com/drewlinn/shiny-enigma using your web browser and click the Clone or download button. If doing so through a console or powershell, make certain all necessary git scripts and software are properly installed and use the "git clone" command followed by the repository web address and press enter. Type and perform a 'dnu restore' and a 'dnu build' command and then follow that with a 'dnx kestrel' and access the application at the 'localhost:5004' web address.

Specifications

| Behavior                                      | Input                           | Output                                    |
|===============================================|=================================|===========================================|
| User inputs a string                          | "This is a Test String"         | "This is a Test String"                   |
| User inputs a word                            | "Test"                          | "Test"                                    |
| User is told how often word appears in string | "This is a Test String", "Test" | "The word 'Test' appears 1 time."         |
| App checks only for Full Word Match           | "This is a Test String", "Is"   | "The word 'Is' appears 1 time"            |

Known Bugs



Support and contact details

If you notice any issues with my page or my code, please contact me at expandrew@gmail.com.

Technologies Used

This page was created in C# and HTML using Atom, Git, and the Windows Powershell.

License

This software is license under the GPL license.

Copyright (c) 2015 Andrew Dalton, Epicodus
