using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manDown : MonoBehaviour
{
    [SerializeField] GameObject splosion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("goodGuy") == true || collision.gameObject.CompareTag("badGuy") == true)
        {
            Instantiate(splosion, collision.transform.position, collision.transform.rotation);
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
