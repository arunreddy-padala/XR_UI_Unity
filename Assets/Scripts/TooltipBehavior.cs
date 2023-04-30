using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TooltipBehavior : MonoBehaviour
{
    public GameObject tooltip; 

    public void ToggleVisibility()
    {
        tooltip.SetActive(!tooltip.activeSelf);
    }
}
