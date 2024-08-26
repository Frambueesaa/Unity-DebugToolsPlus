# Unity - Formatted Debug Texts
A minimal customizable library to be able to launch messages to formatted consoles (Colors, headers, messages...)

# UNITY CONSOLE PREVIEW

![image](https://github.com/user-attachments/assets/a9059836-55c4-42b0-af80-7dc5460299b7)


A simple library infinitely customizable by entering the simple code that serves as a shortcut to create more readable and intuitive debugging messages.

This allows you to differentiate your messages by color and thus find errors faster or work without thinking about UI or GUI.

# How do I import it?

You have three ways to import it, using the attached UnityPackage or import manually.

## 1 Unity Custom Git Package

Navigate to the Package Manager window within the Editor, once inside select the option "Add package from git URL" and paste this: https://github.com/franforge/unity-formatted-debug-texts.git#main

## 2 Unity Package

Download the package and drag/select import into the Unity editor.

## 3 Import Manually

Donwload the archives and drag/select import into the Unity editor.

# How do I use it?

You just have to call MyDebug.Log() and fill in its fields (string title, string message, int color...).

![image](https://github.com/user-attachments/assets/e3a83088-dabf-4a11-baed-23f07d93192a)



# How do I edit the colors or add different ones?

Simply change the color codes to your own with hexadecimal format or add another case to the switch that I show you below.

![image](https://github.com/user-attachments/assets/8ed9379b-39e4-4960-bda9-9653b45aa590)


Then use the testing script (Don't delete it, it doesn't bother you) to check how your messages would look in the console.

![image](https://github.com/user-attachments/assets/c7dfad2d-5929-457b-96a0-9e14a03bf69d)


