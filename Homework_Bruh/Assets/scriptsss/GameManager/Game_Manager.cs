using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Game_Manager : MonoBehaviour
{
    //Varibles
    public TextMeshProUGUI score;

    public int sc_num;
    // Start is called before the first frame update
    void Start()
    {
        //Make the score 0
        sc_num = 0; 
        score.text = "score: " + sc_num;
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "score: " + sc_num;
    }
}
