using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RotateMenu : MonoBehaviour
{
    public InputActionReference inputActionReference;
    public float speed = 2f;

    // Start is called before the first frame update
    void Start() 
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (inputActionReference.action.ReadValue<Vector2>().x > 0)
        {

            transform.Rotate(Vector3.up * speed * Time.deltaTime * 60);
        }
        else if (inputActionReference.action.ReadValue<Vector2>().x < 0)
        {
            transform.Rotate(-Vector3.up * speed * Time.deltaTime * 60);
        }
    }
}
