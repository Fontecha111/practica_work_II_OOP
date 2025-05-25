# practica_work_II_OOP

# Table of Contents

- [Introduction] (#introduction)
- [Description] (#description)
- [Problems] (#problems)
- [Conclusions] (#conclusions)

# Introduction
This document was made for the Practical Work II from the OOP subject.
In this document you can see different sections with some information in each one of them about the description of the project, some problems faced during the development of it and finally a conlusions section.
Most of the project is composed of the practical guided work that we have been done through the duration of this quadrimester. The objective of this project is to create a calculator using the files from the practical guided work, as well as developing a MAUI project using features from C#. 

# Description
For this project we need a Main Page with the title OOP Conversor in which you have to enter your username and your password. If you do not have a user already created you have the option to Register in which the program would ask you for your name, username, email and password. To add you have to check the privacy policy, if not the program will not let you create your user.
After your user is created and you entered the data required, the program will send you to the calculator page where you can enter a number and select a conversion type and the result will show up in the page.



Class Diagram
|------------------|
|       App        |
|------------------|
| +App()           |
|------------------|
| +MainPage: Page  |
|------------------|

|------------------|
|     AppShell     |
|------------------|
| +AppShell()      |
|------------------|
(inherits from Shell)


|-------------------------|
|        MainPage         | (inherits from ContentPage)
|-------------------------|
| +MainPage()             |
| +OnSignInClicked        |
| +OnForgotPasswordTapped |
| +OnGoToRegisterClicked  |
| +OnGoToCalculator       |
|-------------------------|



|--------------------------------------|
|            CalculatorPage            | (inherits from ContentPage)
|--------------------------------------|
| +currentUser: User                   |
| +converter: Converter                |
| +CalculatorPage()                    |
| +OnNumberClicked()                   |
| +OnSymbolClicked()                   |
| +OnClearClicked()                    |
| +OnDecimalToBinaryClicked()          |
| +OnDecimalToOctalClicked()           |
| +OnDecimalToHexadecimalClicked()     |
| +OnDecimalToTwoComplementClicked()   |
| +OnBinaryToDecimalClicked()          |
| +OnOctalToDecimalClicked()           |  
| +OnHexadecimalToDecimalClicked()     |
| +OnTwoComplementToDecimalClicked()   |
| +OnShowUserInfoClicked()             |
|--------------------------------------|



|----------------------|
|      Converter       |
|----------------------|
| +PerformConversion() |
|----------------------|


|----------------------|
|      Operations      | (interface)
|----------------------|
| +setName()           |
| +setUsername()       |
| +setPassword()       |
| +getName()           |
| +getUsername()       |
| +getPassword()       |
| +DisplayUserInfo()   |
| +IncrementOperation()|
|----------------------|


|----------------------|
|        User          |
|----------------------|
| -name: string        |
| -username: string    |
| -password: string    |
| -operationCount: int |
|----------------------|
| +User()              |
| +setName()           |
| +setUsername()       |
| +setPassword()       |
| +getName()           |
| +getUsername()       |
| +getPassword()       |
| +DisplayUserInfo()   |
| +IncrementOperation()|
| +getOperationCount() |
|----------------------|



# Problems
During the development of this project I have faced a series of problems.
One of the main problems I had was implementing the Activity 7 into the practical work II. This is because I was trying to move all the sources from the Activity 7 folder into the folder of the practical work II. This generated some problems and I could not run the project to see the MAUI. Finally I saw that what was causing the problem was implementing some things from the Activity 7 folder that are not meant to be there and finally realized that I only had to pass the .cs from the Activity 7 folder in order to not have problems when running the program.

Another problem that I had to face is, after solving the previous problem, the program still continued to have problems when running it, realizing that all the namespaces from the .cs files had to have the same so I had to change all of them to namespace MAUI.

To add, while doing all the .xaml files for the MAUI, I had some problems in the spacing of every element that appeared in the screen.


Moreover, I had to revise my Activity 7 because I had some errors and for that reason my program was not running in the correct way.

Finally, I could not do the Operations interface.

# Conclusions
Some conclusions I have reached from doing this project are that I have to be careful of how I manage the files through the different projects in order to not have problems when running the projects, as well as taking into account
