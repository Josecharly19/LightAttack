# LightAttack

A student Unity/C# prototype exploring third-person character movement, a basic melee attack, enemy health, and trigger-based camera switching.

## Implemented features

- Character movement relative to the active camera, with rotation, jump, and gravity handling.
- A light attack triggered by the left mouse button, with a configurable range, radius, damage amount, and cooldown.
- Enemy health that decreases when hit and removes the enemy object when health reaches zero.
- Camera switching through trigger volumes when the player enters them.
- A sample Unity scene and project render settings are included.

These features are described from the scripts and assets in the repository. The scene has not been independently tested, and the presence of scripts does not guarantee every feature is fully wired or playable.

## Technologies

- Unity **6000.3.9f1** (version recorded in `ProjectSettings/ProjectVersion.txt`)
- C#
- Unity Input System package and Universal Render Pipeline (listed in `Packages/manifest.json`)

## Open the project

1. Install Unity Hub and the Unity Editor version **6000.3.9f1**.
2. Clone or download this repository.
3. In Unity Hub, choose **Add** / **Add project from disk** and select the repository folder.
4. Open the project and allow Unity to import its assets and packages.
5. Open `Assets/Scenes/SampleScene.unity` and press **Play**.

Movement and attack behavior depend on the scene's component references, colliders, layers, and input configuration. Check these in the Inspector if something does not respond as expected.

## Status and limitations

This is a learning prototype, not a finished or released game. The repository includes a sample scene and experimental gameplay scripts, but no packaged build or detailed play instructions. Runtime behavior and build compatibility have not been verified here.

## Learning project

This project is shared as a record of student practice with Unity and C#. Expect rough edges and future changes as the prototype develops.
