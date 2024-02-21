using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingMomma : MonoBehaviour
{
    [SerializeField] float speed;
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
        transform.Translate(speed * Time.deltaTime * y * Vector3.up);
        Vector3 myvec = new Vector3(.84f, .44f, 0f);

        if (transform.position.y > Maxy)
        { 
            transform.position = new Vector3 (transform.position.x, Maxy, 0);
        }
        if (transform.position.y < -4)
        {
            transform.position = new Vector3(transform.position.x, Miny, 0); //bounding the movement
        }
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(fireballPrefab, transform.position + myvec, transform.rotation);
        }
        /*if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(speed * Vector3.up);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(speed * Vector3.down);
        }*/
        /*if (transform.position.y > maxY)
        {
            travelDirection = false;
        }
        if (transform.position.y < minY)
        {
            travelDirection = true;
        }*/
    }
}
