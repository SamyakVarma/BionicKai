## Import Blender Model into Unity
- Clone or download this repository.  
- Open your Unity project.  
- Drag and drop the provided `human hand.blend` file into the **Assets** folder.  

## Create a C# Script for Control
- In Unity, right-click inside the **Assets** folder → **Create → C# Script**.  
- Name the script (e.g., `HandController.cs`).  
- Open the script and add your logic, or use the sample script provided in this repo.  

## Assign Bones in the Inspector
- Select the GameObject imported from the Blender file.  
- In the **Inspector**, you’ll see public variables (e.g., `thumbFinger1`, `indexFinger2`).  
- Drag the corresponding bones of the hand model into these slots to link them.  

## Test with Sample Code
- Attach the sample script (`SampleHandControl.cs`) from this repo to the model.  
- Enter **Play Mode** in Unity.  
- Use the mapped keys to move fingers and joints.  
