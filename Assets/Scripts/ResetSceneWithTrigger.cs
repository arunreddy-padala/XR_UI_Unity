using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.SceneManagement;

public class ResetSceneWithTrigger : MonoBehaviour
{
    public InputActionReference inputActionReference;

    void Awake()
    {
        // add Cloned and Detached events to action's .started and .canceled states
        inputActionReference.action.started += ResetSceneWithTriggerPressed;
    }

    public void ResetSceneWithTriggerPressed(InputAction.CallbackContext context)
    {
        if (GetComponent<XRSimpleInteractable>().isHovered)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }
    }
}
