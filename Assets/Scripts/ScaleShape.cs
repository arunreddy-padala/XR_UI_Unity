using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class ScaleShape : MonoBehaviour 
{

    public InputActionReference inputActionReference;
    public float speed = 4f;

    // Start is called before the first frame update
    void Start()
    {

     
    }

    // Update is called once per frame
    void Update()
    {


        if (GetComponent<XRGrabInteractable>().isSelected)
        {
            if (inputActionReference.action.ReadValue<Vector2>().y > 0)
            {

                transform.localScale = Vector3.Min(
                    new Vector3(0.6f, 0.6f, 0.6f), transform.localScale * (1 + speed * Time.deltaTime));
            }
            else if (inputActionReference.action.ReadValue<Vector2>().y < 0)
            {
                transform.localScale = Vector3.Max(
                   new Vector3(0.075f, 0.075f, 0.075f), transform.localScale / (1 + speed * Time.deltaTime));
            }
        }

    
    }
}
