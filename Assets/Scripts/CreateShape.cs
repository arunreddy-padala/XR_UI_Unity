using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CreateShape : MonoBehaviour
{
    public Transform platform;
    public GameObject particle;
    public AudioClip createSFX;

    // Start is called before the first frame update
    void Start() 
    {
        //createShape();


    }

    public void createShape()
    {


        Color currentColor = GetComponent<ButtonBackgroundHighlight>().GetOriginalColor();
       // Debug.Log(currentColor);

        Instantiate(particle, platform.position, platform.rotation);

        GameObject newShape = Instantiate(gameObject, platform.position + new Vector3(0, 0.6f, 0), platform.rotation);

        newShape.GetComponent<MeshRenderer>().material.color = currentColor;

        newShape.transform.localScale = new Vector3(0.15f, 0.15f, 0.15f);

        newShape.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;

        if (newShape.GetComponent<BoxCollider>() != null)
        {
            newShape.GetComponent<BoxCollider>().isTrigger = false;
        }
        if (newShape.GetComponent<SphereCollider>() != null)
        {
            newShape.GetComponent<SphereCollider>().isTrigger = false;
        }
        if (newShape.GetComponent<MeshCollider>() != null)
        {
            newShape.GetComponent<MeshCollider>().isTrigger = false;
        }
        if (newShape.GetComponent<CapsuleCollider>() != null)
        {
            newShape.GetComponent<CapsuleCollider>().isTrigger = false;
        }


        //        Debug.Log(newShape.GetComponent<MeshRenderer>().material.color);


        newShape.tag = "NewShape";

        Destroy(newShape.GetComponent<XRSimpleInteractable>());


        // Enable relevant scripts for the new shape.
        newShape.GetComponent<HighlightShape>().enabled = true;

        newShape.GetComponent<XRGrabInteractable>().enabled = true;

        newShape.GetComponent<HighlightShape>().enabled = true;

        newShape.GetComponent<DuplicateShape>().enabled = true;

        newShape.GetComponent<DestroyShapeFarAway>().enabled = true;

        newShape.GetComponent<DestroyShape>().enabled = true;

        newShape.GetComponent<ScaleShape>().enabled = true;

        newShape.GetComponent<ShapePlaysoundOnCollision>().enabled = true;

        /// Destroy scripts for the shape on the menu.
        Destroy(newShape.GetComponent<CreateShape>());
        Destroy(newShape.GetComponent<FreezeLocationAndRotation>());
        Destroy(newShape.GetComponent<ButtonBackgroundHighlight>());
        Destroy(newShape.GetComponent<TooltipBehavior>());
        foreach (Transform t in newShape.transform)
        {
            if (t.CompareTag("ToolTip"))
            {
                t.gameObject.SetActive(false);
            }
        }

        // SFX for creating a new shape.
        AudioSource.PlayClipAtPoint(createSFX, transform.position);


    }


}
