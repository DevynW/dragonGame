using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveReticle : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] bool reticleLine;
    [SerializeField] float Maxy;
    [SerializeField] float Miny;
    [SerializeField] float Maxx;
    [SerializeField] float Minx;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (reticleLine == true)
        {
            float y = Input.GetAxis("Vertical");
            transform.Translate(speed * Time.deltaTime * y * Vector3.up, Space.World);
            if (transform.position.y > Maxy)
            {
                transform.position = new Vector3(transform.position.x, Maxy, 0);
            }
            if (transform.position.y < Miny)
            {
                transform.position = new Vector3(transform.position.x, Miny, 0); //bounding the movement
            }
        }
        if (reticleLine == false)
        {
            float x = Input.GetAxis("Horizontal");
            transform.Translate(speed * Time.deltaTime * x * Vector3.right, Space.World);
            if (transform.position.x > Maxx)
            {
                transform.position = new Vector3(Maxx, transform.position.y, 0);
            }
            if (transform.position.x < Minx)
            {
                transform.position = new Vector3(Minx, transform.position.y, 0); //bounding the movement
            }
        }
        if (Input.GetButtonDown("Fire1"))
        {
            AudioSource audioSource = GetComponent<AudioSource>();
            audioSource.Play();
        }

    }

}
