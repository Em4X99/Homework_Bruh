using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.SceneManagement;

public class Game_Manager : MonoBehaviour
{
    //Varibles
    //make it a singleton!
    public static Game_Manager instance;

    public TextMeshProUGUI score;

    public int sc_num;

    public TextMeshProUGUI p3score;

    public int p3sc_num;

    private bool restart = true;

    //awake is called on spawn of this script before start

    private void Awake()
    {
        //a singleton must only have one instance, check to make sure this the only instance
        //if it is, make sure it is not destroyed, if it's not destroy this instance.
        if (instance == null)
        {
            DontDestroyOnLoad(gameObject);
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

    }


    // Start is called before the first frame update
    void Start()
    {
        //Make the score 0
        sc_num = 0;
        p3sc_num = 0;
       
    }

    // Update is called once per frame
    void Update()
    {
        p3score.text = "Score: " + p3sc_num;
        score.text = "score: " + sc_num;


    }
    public void StartGame() 
    {
        
    if (restart)
        {
            SceneManager.LoadScene("game_scene");
            restart = false;
        }
    }

}
