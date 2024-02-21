using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baddie : MonoBehaviour
{
    [SerializeField] float speed = 3f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float randspeed = Random.Range(2, 6);
        speed = randspeed;
        transform.Translate(speed * Time.deltaTime * Vector3.left);
        Destroy(gameObject, 4f);


    }
}
