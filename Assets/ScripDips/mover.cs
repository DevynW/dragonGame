using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class mover : MonoBehaviour
{
    float speed;
    // Start is called before the first frame update
    void Start()
    {
        float rotation = Random.Range(-10, 10);
        gameObject.transform.Rotate(0f, 0f, rotation);
        float randspeed = Random.Range(4.5f, 10);
        speed = randspeed;
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(speed * Time.deltaTime * Vector3.up, Space.Self);
        Destroy(gameObject, 6f);


    }
}
