using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class DestroyShape : MonoBehaviour
{
    public InputActionReference inputReference;
    public GameObject particle;
    public AudioClip destroySFX; 

    void Awake()
    {
        // add Cloned and Detached events to action's .started and .canceled states
        inputReference.action.started += CustomDestroy;
    }

    void Start()
    {
        
    }

    private void CustomDestroy(InputAction.CallbackContext context)
    {
        if (GetComponent<XRGrabInteractable>().isSelected)
        {
            Instantiate(particle, transform.position, transform.rotation);

            AudioSource.PlayClipAtPoint(destroySFX, transform.position);

            Destroy(gameObject);


        }

    }

}
