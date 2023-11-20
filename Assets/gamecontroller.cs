using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class gamecontroller : MonoBehaviour
{  

    public GameObject cube;
    public Transform position;
    public GameObject sphere;
    public Transform sphereposition;
    public Text scoretext; // Reference to the Text element
    public Text healthtext;
    public Text leveltext;

    private int playerscore = 0;
    private float playerhealth = 100.0f;
    private int playerlevel = 0;

    
    // Start is called before the first frame update
    void Start()
    {
        scoretext.text = "Score: " + playerscore;
        healthtext.text = "Health:" + playerhealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            playerscore += 10;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            playerhealth -= 10;
        }


        scoretext.text = "Score: " + playerscore.ToString();
        healthtext.text = "Health:" + playerhealth.ToString();
        leveltext.text = "Level:" + playerlevel.ToString();

        if (playerscore >= 100)
        {
            scoretext.text = "Score:100 (you win, press W to go to next level.)";
            if (Input.GetKeyDown(KeyCode.W))
            {
                playerlevel += 1;
                playerscore -= 100;
            }
        }
        
        if (playerhealth <= 0)
        {
            healthtext.text = "Health:0 (you lose)";
            if (Input.GetKeyDown(KeyCode.W))
            {
                playerscore -= 10;
            }
        }

        if (Input.GetKey(KeyCode.Space))
        {
            Instantiate(cube, position);
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            Instantiate(sphere, sphereposition);
        }



    }
}