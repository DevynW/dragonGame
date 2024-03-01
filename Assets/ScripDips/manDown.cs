using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manDown : MonoBehaviour
{
    [SerializeField] GameObject splosion;
    [SerializeField] GameObject self;
    Vector3 ogPos = new Vector3 (-8f, 0f, 0f);
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
            gameManager.lives -= 1;
            Instantiate(splosion, collision.transform.position, collision.transform.rotation);
            if (gameManager.lives > 0)
            {
                Instantiate(self, ogPos, transform.rotation);
            }
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
