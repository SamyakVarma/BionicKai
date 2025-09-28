1. Clone the Repository
git clone https://github.com/SamyakVarma/BionicKai.git


This will create a folder named BionicKai containing the Blender model and the sample script.

2. Import Blender Model into Unity

Open your Unity project.

Drag and drop human hand.blend from the cloned repository into your Assets folder.

3. Add the Sample Script

Locate hand_script.cs in the cloned repository.

Copy it into your Unity Assets folder.

Select the imported hand model in the Hierarchy.

Attach the script to the model by either:

Right-click → Add Component → select hand_script.cs, or

Drag the script onto the Inspector panel of the model.

4. Assign Bone References

Click the hand model in the Hierarchy.

In the Inspector, under the script component, assign the correct bones:

Drag indexFinger1, thumbFinger1, etc., from the Hierarchy or Scene view into the corresponding slots.

5. Run & Control the Hand Model

Press the Play button in Unity.

Use the following keyboard keys to control fingers in real time:

Finger	Keys
Index Finger	I, O, P
Other Fingers	Q, W, E, etc.

Observe the hand model move interactively as you press the keys.
