using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapePlaysoundOnCollision : MonoBehaviour
{
    public AudioClip _audioClip; 

    private void OnCollisionEnter(Collision collision)
    {
        AudioSource.PlayClipAtPoint(_audioClip, transform.position);
    }
}
