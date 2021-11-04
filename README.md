# Advice Giver Application
## Overview
The application displays 'life pieces of advice' in English and Polish. There is accessed API to get each random 'advice' (https://api.adviceslip.com), and then they are translated into Polish (using https://libretranslate.de).
## Structure
There is a solution created in Visual Studio. It consists of two parts:
- Main Application Logic ("*AdviceAppFunctionality*" project) - that provides implementation of API calls, proper receiving of 'advice' data and next translation, different help operations.
- Windows Form GUI ("*WinFormAdviceGiverApp*" project) - that provides interaction with the user, visual diplay of the received 'pieces of advice'.
> Note: All the external links and configuration parameters should be stored in "*config.ini*" file in the solution directory. This data can be used in the application via "*ConfigReader*" class.
## Getting Started
The most convenient way of using this application is to open the solution via Visual Studio. There are provided options of building, running and next deploying. In order to run the application, project "*WinFormAdviceGiverApp*" should be started and compiled. This UI is connected to all other functionality used.
## Git
### Clone the repo
`git clone https://github.com/IgorTelepenkoDev/Advice-Giver`
### Fork the repo
`git clone your_target_git_repository_path`\
`git remote add upstream https://github.com/IgorTelepenkoDev/Advice-Giver`\
`git pull upstream master`
## Author
Ihor Telepenko
