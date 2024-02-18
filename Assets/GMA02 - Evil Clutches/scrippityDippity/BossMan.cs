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
    bool travelDirection = true;      //td = true if up, false if down
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (travelDirection == true) 
        {
            transform.Translate(speed * Time.deltaTime * Vector3.up);
        }
        if (travelDirection == false) 
        {
            transform.Translate(speed * Time.deltaTime * Vector3.down);
        }
        if (transform.position.y > maxY) 
        {
            travelDirection = false;        
        }
        if (transform.position.y < minY)
        {
            travelDirection = true;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(babyPrefab);
        }
    }
}
