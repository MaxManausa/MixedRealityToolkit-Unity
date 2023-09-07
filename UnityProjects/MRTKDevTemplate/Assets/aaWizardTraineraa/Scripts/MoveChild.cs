using System;
using UnityEngine;
using static Microsoft.MixedReality.GraphicsTools.ThemeCollection;

public class MoveChild : MonoBehaviour
{ 
    [SerializeField] private GameObject parentObject1; //TrainingRooms
    [SerializeField] private GameObject parentObject2; //maincamera
    private GameObject childObject; //MovingTrainingRooms

    private void Start()
    {
        // Assuming there's only one child at the start
        childObject = parentObject1.transform.GetChild(0).gameObject;
    }

    // Call this method to switch the child's parent
    public void SwitchChildParent()
    {
        Transform childTransform = childObject.transform;

        // Determine the target parent
        GameObject targetParent = (childTransform.parent == parentObject1.transform) ? parentObject2 : parentObject1;

        childTransform.SetParent(targetParent.transform, true);
        ResetTransform(childTransform); // Reset position and rotation
    }

    private void ResetTransform(Transform transform)
    {
        transform.localPosition = Vector3.zero;
        transform.localRotation = Quaternion.identity;
    }

    public void ResetInFrontOf()
    {
        childObject.transform.SetParent(parentObject2.transform, true);
        ReturnAllToStartingPosition();
        childObject.transform.SetParent(parentObject1.transform, true);
        
    }

    public void UnparentChildFromParent1()
    {
        childObject.transform.SetParent(parentObject2.transform, true);
        ReturnAllToStartingPosition();
        childObject.transform.SetParent(parentObject1.transform, true);
        ResetTransform(childObject.transform);
        gameObject.transform.SetParent(null);
    }

    // Call this method to unparent the child from parentObject2
    public void UnparentChildFromParent2()
    {
        childObject.transform.SetParent(parentObject1.transform, true);
        ReturnAllToStartingPosition(); 
        childObject.transform.SetParent(parentObject2.transform, true);
        ResetTransform(childObject.transform);
        gameObject.transform.SetParent(null);
    }

    public void ReturnAllToStartingPosition()
    {
        ReturnToStartingPosition[] returnScripts = FindObjectsOfType<ReturnToStartingPosition>();

        foreach (ReturnToStartingPosition script in returnScripts)
        {
            script.InstantReturn();
        }
    }

}



