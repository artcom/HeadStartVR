![Title](Head_Start_VR_02.jpg)
# HeadStartVR
This repository holds everything you need to headstart your own VR project:
* VRTK
* CustomHands with forearm
* overriding avatarmasks which provide real finger movement depening on which button was pressed
* basic grabbing of objects
* highlighting on touch and near touch
* bezier-pointer teleporter
    * where you can toggle between dash and blink teleporter.
* Simulate AR with a tablet
    * An additional camera on the tablet renders 'Everything' + the AR Layer on a rendertexture, which acts as tablet display
* Using the Vive Trackers and have a symbol of it

## Software
* UnityHub
* Unity 2018.2.6f1
* VRTK 3.2.1
* SteamVR Plugin 1.2.3

### Unity Project Organisation

Please keep the project clean and tidy, so noone gets confused to much!
Feel free to add additional basic functionality as feature folder.
The project should be organised as shown below:

* Assets
    * MainApplication
        * Animations
        * Materials
        * Models
        * Scripts
        * Scenes
    * ObjectGrabbing
        * Animations
        * Materials
        * Models
        * Scripts
        * Scenes
    * SimulateAR
        * Animations
        * Materials
        * Models
        * Scripts
        * Scenes    
    * ViveTracker
        * Materials
        * Models
        * Scenes
    * FeatureXYZ
        * Animations
        * Models
        * Materials
        * Scripts
        * Scenes
* ProjectSettings
* UnityPackages

#

## Documentation & Getting Started

Just clone this project to get started immediately with your VR project. You can rename it to transform it in your own project or just demo functionalities. To copy a certain feature duplicate the scene.
This head starts your development by the following features:

### MainApplication

The MainApplication folder holds two features inside, basic bezier curve teleportation and custom hands.

### ObjectGrabbing

This scene gives you an example on how to perform basic object grabbing, touching and using with a simple cube on a table.

### SimulateAR

The SimulateAR scene contains a tablet on a table which gives you to see the world in another eye. The camera on the tablet renders all additional objects which are tagged by the AR layer.

### ViveTracker

The ViveTracker scene increments the SteamVR Controller attribute on the cameraRig by +1 so the GameObject HTC_Vive_Tracker gets tracked and recognized as a vive tracker as long as it has the Steam VR_Tracked Object Script attached to it.

#

Read and follow those rules [Unity Project Organisation](https://unity3d.com/de/learn/tutorials/topics/tips/large-project-organisation).

### Code Styleguide

We try to follow this [Unity C# code styleguide](https://github.com/raywenderlich/c-sharp-style-guide).
Feel free to discuss those guidelines.
