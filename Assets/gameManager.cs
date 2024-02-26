using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor;

public class gameManager : MonoBehaviour
{
    GameObject tresspasser;
    public static int score;
    public static int lives = 3;
    float finTime;
    float timeLeft;
    public TextMeshProUGUI TMPS;
    public TextMeshProUGUI TMPL;
    public TextMeshProUGUI TMPT;
    public TextMeshProUGUI TMPGO;
    [SerializeField] GameObject blackBox;
    [SerializeField] GameObject TMPGo;
    Vector3 origin = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        finTime = Time.time + 60;
        score = 0;  
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft = finTime - Time.time;
        TMPS.text = "Score: " + score;
        TMPL.text = "Lives: " + lives;
        TMPT.text = "Time: " + timeLeft;
        Debug.Log("GM: " + score);
        
        if (timeLeft < 0 || lives <= 0)
        {
            Instantiate(blackBox, origin, transform.rotation);
            TMPGo.SetActive(true);
            TMPGO.text = "Game Over!\nYour score was: " + score + ".\nYou had " + timeLeft + " time left.\nYou had " + lives + " lives left.";

        }
    }
}
