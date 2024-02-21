using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class shoot : MonoBehaviour
{
    [SerializeField] GameObject explosion;
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
        GameObject go = GameObject.Find("GameManager");
        Instantiate(explosion, collision.transform.position, collision.transform.rotation);
        Destroy(collision.gameObject);
        Destroy(gameObject);
        if (collision.gameObject.CompareTag("goodGuy") == true)
        {
            gameManager.score -= 5;
        }
        else if (collision.gameObject.CompareTag("badGuy") == false)
        {
            gameManager.score += 1;
        }
        Debug.Log("Shots: " + gameManager.score);
    }
}
