using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.FilePathAttribute;

public class mover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float rotation = Random.Range(-10, 10);
        gameObject.transform.Rotate(0f, 0f, rotation);
    }

    // Update is called once per frame
    void Update()
    {
        float speed;
        float randspeed = Random.Range(2, 6);
        speed = randspeed;
        transform.Translate(speed * Time.deltaTime * Vector3.up, Space.Self);
        Destroy(gameObject, 5.5f);


    }
}
