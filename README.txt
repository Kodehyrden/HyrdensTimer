# HyrdensTimer

A simple count-down timer for e.g. timeboxed meetings as in scrum or when you want to boil an egg. :-)

The application is written in C# and using the .Net Framework 4.5.

When the application starts up the user is presented with a dialog to set the time. The default value is 15 minutes. Clicking Cancel aborts the application. Clicking OK starts the timer counting down. When the time remaining reaches zero it countinues but the time is now show with a negative sign indicating the meeting overrun the time limit.

When the timer runs you can click in the window or hit the key T (for toggle) and the application will got to full screen mode with a black background and white digits.

Close the application by pressing alt-F4, or close the window.


The application reads the first parameter and if able to be converted into an integer it is used for setting the time. E.g. you have a set of shortcuts on your desktop with a predefined time. When the parameter is defined on the command line the user is 