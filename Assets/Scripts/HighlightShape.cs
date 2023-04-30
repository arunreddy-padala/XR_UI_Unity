using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class HighlightShape : MonoBehaviour
{
    MeshRenderer _renderer; 
    public Color originalColor;

    bool isHighlighted;

    public AudioClip hoverClip;

    public AudioClip changeColorClip;

    GameObject controllerTip;


    public InputActionReference inputReference;

    void Start()
    {
        // get a reference to the MeshRenderer
        // access and store the originalColor
        _renderer = GetComponent<MeshRenderer>();
        originalColor = _renderer.material.color;

    }


    void Awake()
    {
        // add Cloned and Detached events to action's .started and .canceled states
        inputReference.action.started += ChangeColor;
    }

    private void ChangeColor(InputAction.CallbackContext context)
    {
        if (isHighlighted)
        {
            originalColor = _renderer.material.color;

            AudioSource.PlayClipAtPoint(changeColorClip, transform.position);

        }
    }

    public void HightlightWithControllerTipColor()
    {
        if (controllerTip == null)
        {
            controllerTip = GameObject.FindGameObjectWithTag("Tip");

        }
        AudioSource.PlayClipAtPoint(hoverClip, transform.position);

        _renderer.material.color = controllerTip.GetComponent<MeshRenderer>().material.color;

        isHighlighted = true;
    }

    public void Dehightlight()
    {
        _renderer.material.color = originalColor;

        isHighlighted = false;
    }

    public Color GetOriginalColor()
    {
        return originalColor;
    }


}
