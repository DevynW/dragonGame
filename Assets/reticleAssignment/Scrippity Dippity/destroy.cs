using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AudioSource splosionSound = GetComponent<AudioSource>();
        splosionSound.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
        Destroy(gameObject, 1f);
    }
}
