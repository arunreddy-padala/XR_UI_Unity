using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyShapeFarAway : MonoBehaviour
{
    GameObject player;
    public AudioClip destroySFX;
    public GameObject particle; 

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(player.transform.position, transform.position);
        if (dist > 10)
        {
            Instantiate(particle, transform.position, transform.rotation);

            AudioSource.PlayClipAtPoint(destroySFX, transform.position);
            Destroy(gameObject);
        }
    }
}
