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
    [SerializeField] GameObject TMPt;
    [SerializeField] GameObject TMPl;
    [SerializeField] GameObject TMPs;
    [SerializeField] GameObject blackBox;
    [SerializeField] GameObject TMPGo;
    [SerializeField] GameObject whiteBox;
    [SerializeField] GameObject factory;
    [SerializeField] GameObject deadGuy;
    int finalTime;
    bool gameOver = false;
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
        if (gameOver == false)
        {
            timeLeft = (int)finTime - (int)Time.time;
        }
        TMPS.text = "Score: " + score;
        TMPL.text = "Lives: " + lives;
        TMPT.text = "Time: " + timeLeft;
        Debug.Log("GM: " + score);
        
        if (timeLeft < 0 || lives == 0)
        {
            gameOver = true;
            finalTime = (int) timeLeft;
            Instantiate(blackBox, origin, transform.rotation);
            TMPGo.SetActive(true);
            TMPs.SetActive(false);
            TMPt.SetActive(false);
            TMPl.SetActive(false);
            whiteBox.SetActive(false);
            factory.SetActive(false);
            deadGuy.SetActive(false);
            if (lives <= 0)
            {
                TMPGO.text = "Game Over!\nYour score was: " + score + ".\nYou had " + timeLeft + " seconds left.\nYou had " + 0 + " lives left.";
            }
            else if(timeLeft <= 0)
            {
                TMPGO.text = "Game Over!\nYour score was: " + score + ".\nYou had " + 0 + " seconds left.\nYou had " + lives + " lives left.";
            }
        }
    }
}
