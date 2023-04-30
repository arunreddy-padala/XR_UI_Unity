using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class DuplicateShape : MonoBehaviour
{
    public InputActionReference inputReference;
    public AudioClip cloneSFX;


    void Awake() 
    {
        // add Cloned and Detached events to action's .started and .canceled states
        inputReference.action.started += Cloned;
    }


    private void Cloned(InputAction.CallbackContext context)
    {
        // if the object is selected
        // instantiate a copy of the current gameObject in the current position/rotation
        if (GetComponent<XRGrabInteractable>().isSelected)
        {
            Color currentColor = GetComponent<HighlightShape>().GetOriginalColor();

     
            GameObject clonedObj =
                        Instantiate(gameObject, transform.position + new Vector3(0.12f, 0.12f, 0.12f), transform.rotation);

            clonedObj.GetComponent<MeshRenderer>().material.color = currentColor;

            //clonedObj.GetComponent<XRGrabInteractable>().forceGravityOnDetach = true;
            //clonedObj.GetComponent<XRGrabInteractable>().throwOnDetach = true;

            AudioSource.PlayClipAtPoint(cloneSFX, transform.position);

            clonedObj.GetComponent<Rigidbody>().isKinematic = false;
            clonedObj.GetComponent<Rigidbody>().useGravity = false;

        }
     

    }


}
