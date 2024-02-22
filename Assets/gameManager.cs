using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gameManager : MonoBehaviour
{
    GameObject tresspasser;
    public static int score;
    public TextMeshProUGUI TMP;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;  
    }

    // Update is called once per frame
    void Update()
    {
        TMP.text = "Score: " + score;
        Debug.Log("GM: " + score);
    }
}
