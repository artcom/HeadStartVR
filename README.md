![Title](Head_Start_VR_02.jpg)
# HeadStartVR
This repository holds everything you need to headstart your own VR project:
* VRTK
* CustomHands with forearm
* overriding avatarmasks which provide real finger movement depening on which button was pressed
* basic grabbing of objects
* highlighting on touch and near touch
* bezier-pointer teleporter
** where you can toggle between dash and blink teleporter.

## Software
* UnityHub
* Unity 2018.2.6f1
* VRTK 3.2.1
* SteamVR Plugin

### Unity Project Organisation

Please keep the project clean and tidy, so noone gets confused to much!
Feel free to add additional basic functionality as feature folder.
The project should be organised as shown below:

* Assets
    * MainApplication
        * Animations
        * Models
        * Materials
        * Scripts
        * Scenes
    * ObjectGrabbing
        * Animations
        * Models
        * Materials
        * Scripts
        * Scenes
    * SimulateAR
        * Animations
        * Models
        * Materials
        * Scripts
        * Scenes
    * FeatureXYZ
        * Animations
        * Models
        * Materials
        * Scripts
        * Scenes
* ProjectSettings
* UnityPackages

Read and follow those rules [Unity Project Organisation](https://unity3d.com/de/learn/tutorials/topics/tips/large-project-organisation).

### Code Styleguide

We try to follow this [Unity C# code styleguide](https://github.com/raywenderlich/c-sharp-style-guide).
Feel free to discuss those guidelines.
