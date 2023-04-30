using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class PaintControllerTip : MonoBehaviour
{
    GameObject controllerTip;
    MeshRenderer meshRenderer; 

    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();

    }

    public void PaintControllerPointerTip()
    {
        controllerTip = GameObject.FindGameObjectWithTag("Tip");

        if (controllerTip != null) {
            controllerTip.GetComponent<MeshRenderer>().material.color = meshRenderer.material.color;
        }


    }


}
