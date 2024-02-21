using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factory : MonoBehaviour
{
    [SerializeField] float nextFire = 0f;
    [SerializeField] float fireRate = .5f;
    [SerializeField] float limitBad = 85f;
    [SerializeField] GameObject goodPrefab;
    [SerializeField] GameObject badPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float position = Random.Range(-4, 4);
        Vector3 myvec = new Vector3( 0f, position, 0f);
        if (Time.time >= nextFire)
        {
            nextFire = Time.time + fireRate;
            int random = Random.Range(1, 400);
            if (random >= limitBad)
            {
                Instantiate(badPrefab, transform.position + myvec, transform.rotation);
               
            }
            else
            {
                Instantiate(goodPrefab, transform.position + myvec, transform.rotation);
                
                
            }

            //These two do the same thing, top is just simpler
            /*GameObject obj;
            obj = Instantiate(babyPrefab);
            obj.transform.position = transform.position;*/
        }
    }
}
