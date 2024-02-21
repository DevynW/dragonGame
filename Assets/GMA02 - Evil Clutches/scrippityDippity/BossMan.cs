using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMan : MonoBehaviour
{
    [SerializeField] float speed = 3.2f;
    [SerializeField] float maxY = 5f;
    [SerializeField] float minY = -5f;
    [SerializeField] int limitDemon = 70;
    [SerializeField] GameObject babyPrefab;
    [SerializeField] GameObject baddiePrefab;
    bool goingUp = true;      //td = true if up, false if down
    //[SerializeField] int limSpit = 50;
    [SerializeField] float fireRate = .5f;
    float nextFire = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (goingUp == true) 
        {
            transform.Translate(speed * Time.deltaTime * Vector3.up, Space.World);
        }
        if (goingUp == false) 
        {
            transform.Translate(speed * Time.deltaTime * Vector3.down, Space.World);
        }
        if (transform.position.y > maxY) 
        {
            goingUp = false;        
        }
        if (transform.position.y < minY)
        {
            goingUp = true;
        }
        //int spitRand = Random.Range(0, 100);
        if (Time.time >= nextFire)
        {
            nextFire = Time.time + fireRate;
            int random = Random.Range(1, 400);
            if (random >= limitDemon)
            {
                Instantiate(babyPrefab, transform.position, transform.rotation);
            }
            else
            {
                Instantiate(baddiePrefab, transform.position, transform.rotation);
            }

            //These two do the same thing, top is just simpler
            /*GameObject obj;
            obj = Instantiate(babyPrefab);
            obj.transform.position = transform.position;*/
        }
    }
}
