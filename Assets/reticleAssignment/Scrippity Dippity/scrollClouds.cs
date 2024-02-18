using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrollClouds : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float endScreen;
    [SerializeField] float startScreen;
    [SerializeField] GameObject cloudPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime * Vector3.left, Space.World);
        if (transform.position.x <= endScreen)
        {
            transform.position = new Vector3(startScreen, transform.position.y, 0f);
        }
    }
}
