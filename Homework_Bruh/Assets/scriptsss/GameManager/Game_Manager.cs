using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Game_Manager : MonoBehaviour
{
    //Varibles
    public TextMeshProUGUI score;

    // Start is called before the first frame update
    void Start()
    {
        //Make the score 0
        score.text = "score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
