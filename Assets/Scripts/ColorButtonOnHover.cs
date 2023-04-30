using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorButtonOnHover : MonoBehaviour
{
    public Transform buttonBackground; 


    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void HighlightBackground()
    {

        buttonBackground.gameObject.GetComponent<ButtonBackgroundHighlight>().Highlight();
    }

    public void DehighlightBackground()
    {


        buttonBackground.gameObject.GetComponent<ButtonBackgroundHighlight>().Dehighlight();
    }

}
