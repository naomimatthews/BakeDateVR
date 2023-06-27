# BakeDate VR Project

## Overview

BakeDate is a virtual reality (VR) project that offers a unique and immersive experience for users to create desserts for their dates. In this VR game, users can engage in a variety of interactive activities, such as selecting ingredients, mixing them in a bowl, and baking the perfect dessert in a virtual kitchen environment. The project aims to provide a realistic and enjoyable VR experience for HTC Vive users.

## Constraints

- **Controller Compatibility**: BakeDate currently supports only HTC Vive Controllers. The game has not been tested or integrated with any other controllers at this time.
- **Teleportation Navigation**: Due to technical limitations, the game currently utilizes teleportation as the primary means of movement. While teleportation may not offer the most realistic navigation experience, it ensures user comfort and reduces the risk of motion sickness.
- **Standing Gameplay**: The game is designed to be played in a standing position. Playing while seated may lead to the user accidentally hitting their VR headset during interactions that require reaching and movement.

## Configuration

BakeDate is configured using the following software and frameworks:

- **Unity**: Version 2021.1.17f1
- **OpenXR**: Version 1.2.8
- **XR Plugin Management**: Version 4.0.7
- **XR Interaction Toolkit**: Pre-Release Version 5.3.0
- **Windows XR Plugin**: Version 5.3.0
- **HTC Vive Controller Profile**: Original configuration for HTC Vive controllers

## Components of the 3D Environment

BakeDate incorporates various components within its 3D environment to enhance the user experience. Some of the key components include:

1. **Oven**: The oven is a central element in the game. Users can interact with the oven by opening its door and placing the mixing bowl inside. The oven features a socket location that allows the bowl to snap into place. When the bowl is correctly socketed, a yellow light illuminates to simulate an active oven.

2. **Pouring**: To replicate the process of pouring milk, users can pick up a virtual milk container and rotate it, triggering a milk particle effect. This interaction creates the illusion of pouring milk into the mixing bowl.

3. **Grabbing**: The most frequently used mechanic in the game is grabbing. Users can utilize one of the grab buttons on their HTC Vive controllers to teleport within the game environment and also to pick up the mixing bowl and various ingredients to place them inside the bowl.

4. **User Interface (UI)**: The UI features an ingredients counter that tracks the number of ingredients successfully placed into the mixing bowl. When all three required ingredients are added, a cake will spawn in the bowl. Additional UI elements include the game title at the start and textual instructions displayed on the wall, providing guidance to the user during gameplay.


### Functionality/Concepts

- **Ingredients**: Currently, the user can grab three items tagged as "ingredients." These items are essential for the recipe they are making. The user must pour or place the ingredients inside the mixing bowl. Once the bowl contains all the required ingredients, a cake will spawn inside it.

- **User Interface**: The game currently features limited UI elements. However, two important UI components are present. The first is a text prompt that explains the user's objectives and actions. The second is a text counter that keeps track of the number of ingredients placed into the bowl.

- **Oven**: The oven in the game utilizes a hinge joint on the oven door. When the player grabs the handle and pulls it down, the door opens. The oven also includes a socket inside where the user can place the mixing bowl. If the bowl is correctly socketed, a yellow light turns on inside the oven, indicating its active state.

### Health & Safety

- **Risks**: Motion sickness is a common risk for VR users. Symptoms such as nausea, eye strain, and disorientation can occur. To mitigate this, BakeDate employs teleportation as the primary means of movement instead of free movement. Teleportation helps reduce the risk of motion sickness.

- **Actions Taken**: By implementing teleportation, the project prioritizes user comfort and aims to provide a more enjoyable VR experience. Additionally, it is recommended that users play BakeDate in a standing position in an open space to avoid potential injuries caused by reaching for objects while seated near their PC or desk.

## Assets

- **CoffeeShop Starter Pack by 'Puzzled Wizard'**: This asset pack was used to set up the environment and setting where the player will be immersed. It includes objects for interaction within the game.

- **3D Bakery Object by 'Layer Lab'**: This asset pack provides the milk asset, which users will interact with during recipe preparation.

- **Simple Icon Pastel Tone by 'astr999'**: This icon pack will be used for the UI elements in menu screens and throughout the game, such as volume controls, music options, quitting, restarting, and home buttons.

- *Optional*: **Sweets Icon Pack by 'Persefida'**: This icon pack may be used for the UI when users need to choose the type of food they want to make or as decorative elements on menu screens.

- *Optional*: **Beautiful Progress Bar Free by 'CYKO'**: These progress bar assets may be utilized to indicate the progress of actions such as food baking in the oven or pouring ingredients.

## Environment Design

The virtual environment in BakeDate is designed to resemble a bakery setting. A garage was chosen as the base environment and all internal assets were removed, leaving an empty space for the bakery assets and a table where an AI character will be added.

## Installation and Setup

To install and run the BakeDate VR project, please follow these steps:

1. **Unity Version**: Make sure you have Unity installed on your computer. The project was developed using Unity Version 2021.1.17f1.

2. **HTC Vive Controllers**: Ensure that you have HTC Vive controllers available, as BakeDate is currently compatible only with these controllers.

3. **Download**: Download or clone the BakeDate project files from the project repository.

4. **Open Project**: Open Unity and select "Open Project." Navigate to the downloaded BakeDate project folder and select it to open the project.

5. **Unity XR Plugin Management**: In Unity, go to "Window" > "Package Manager." Select "Unity Registry" from the dropdown menu and search for "XR Plugin Management." Install the XR Plugin Management package (Version 4.0.7).

6. **OpenXR Plugin**: In Unity, go to "Window" > "Package Manager." Select "Unity Registry" from the dropdown menu and search for "OpenXR." Install the OpenXR package (Version 1.2.8).

7. **XR Interaction Toolkit**: In Unity, go to "Window" > "Package Manager." Select "Unity Registry" from the dropdown menu and search for "XR Interaction Toolkit." Install the XR Interaction Toolkit package (Pre-Release Version 5.3.0).

8. **Windows XR Plugin**: In Unity, go to "Window" > "Package Manager." Select "Unity Registry" from the dropdown menu and search for "Windows XR Plugin." Install the Windows XR Plugin package (Version 5.3.0).

9. **Configure Project Settings**: Set up the project settings as necessary, including the target platform, display resolution, and other preferences specific to your setup.

10. **Build and Run**: Connect your HTC Vive headset to your computer and ensure it is set up correctly. In Unity, go to "File" > "Build Settings." Select your target platform, such as Windows, and click on "Build and Run" to build the BakeDate VR project and launch it on your HTC Vive headset.

