using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBackgroundHighlight : MonoBehaviour
{
    public Color highlightColor; 
    MeshRenderer _renderer;
    Color originalColor;
    bool isHighlighted;
    public AudioClip audioClip;

    void Start()
    {
        // get a reference to the MeshRenderer
        // access and store the originalColor
        _renderer = GetComponent<MeshRenderer>();
        originalColor = _renderer.material.color;
    }

    public void Highlight()
    {
        // set isHighlighted true
        // change the material color to highlightColor

        isHighlighted = true;
        _renderer.material.color = highlightColor;

        AudioSource.PlayClipAtPoint(audioClip, transform.position);
    }

    public void Dehighlight()
    {
        // set isHighlighted false
        // change the material color to originalColor
        isHighlighted = false;
        _renderer.material.color = originalColor;
    }

    public Color GetOriginalColor()
    {
        if (_renderer == null)
        {
            return GetComponent<MeshRenderer>().material.color;
        }
        return originalColor;
    }



}
