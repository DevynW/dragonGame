using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMan : MonoBehaviour
{
    [SerializeField] float speed = .01f;
    [SerializeField] float maxY = 5f;
    [SerializeField] float minY = -5f;
    [SerializeField] GameObject babyPrefab;
    [SerializeField] GameObject baddiePrefab;
    bool goingUp = true;      //td = true if up, false if down
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (goingUp == true) 
        {
            transform.Translate(speed * Time.deltaTime * Vector3.up);
        }
        if (goingUp == false) 
        {
            transform.Translate(speed * Time.deltaTime * Vector3.down);
        }
        if (transform.position.y > maxY) 
        {
            goingUp = false;        
        }
        if (transform.position.y < minY)
        {
            goingUp = true;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(babyPrefab, transform.position, transform.rotation);
            //These two do the same thing, top is just simpler
            /*GameObject obj;
            obj = Instantiate(babyPrefab);
            obj.transform.position = transform.position;*/
        }
    }
}
