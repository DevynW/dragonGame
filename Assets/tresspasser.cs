using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tresspasser : MonoBehaviour
{
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
        if (collision.gameObject.CompareTag("goodGuy") == true)
        {
            gameManager.score += 5;
        }
        if (collision.gameObject.CompareTag("badGuy") == false)
        {
            gameManager.score -= 1;
        }

        Debug.Log("Tresspassers: " + gameManager.score);
    }
}
