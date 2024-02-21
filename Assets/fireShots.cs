using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireShots : MonoBehaviour
{
    [SerializeField] float speed = 3.2f;
    [SerializeField] float Maxy = 4;
    [SerializeField] float Miny = -4;
    [SerializeField] GameObject fireballPrefab;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float y = Input.GetAxis("Vertical");
        transform.Translate(speed * Time.deltaTime * y * Vector3.up, Space.World);
        Vector3 myvec = new Vector3(.84f, .44f, 0f);
        Vector3 vec2 = new Vector3(0f, 0f, 0f);

        if (transform.position.y > Maxy)
        {
            transform.position = new Vector3(transform.position.x, Maxy, 0);
        }
        if (transform.position.y < -4)
        {
            transform.position = new Vector3(transform.position.x, Miny, 0); //bounding the movement
        }
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(fireballPrefab, transform.position, transform.rotation);
        }
      
    }
}
