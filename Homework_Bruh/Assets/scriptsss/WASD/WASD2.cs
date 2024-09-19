using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASD2 : MonoBehaviour
{
    //Variables 
    public float forceamt = 10f;
    private int i = 8;
    private Rigidbody2D square;
    private Color defaultColor = Color.yellow;
    public GameObject pl2;
    private bool spawn = true;
    public Game_Manager gamemanager; 
    private void Awake()
    {

        pl2 = this.gameObject;
        gamemanager = FindObjectOfType<Game_Manager>();
    }

    private void Start()
    {
        //Find the Rigidbody on the object this script is on
       // square = GetComponent<Rigidbody2D>();

    }
    


    // Update is called once per frame
    void Update()
    {
        /*
        //If statement to move Right on screen by using D
        if (Input.GetKey(KeyCode.L))
        {
            //make square move right
            square.AddForce(Vector2.right * forceamt);
        }

        //If statement to move right on screen by using A 
        if (Input.GetKey(KeyCode.J))
        {
            //make square move left
            square.AddForce(Vector2.left * forceamt);
        }

        //If statement to move down on screen by usind S 
        if (Input.GetKey(KeyCode.K))
        {
            //make square move down
            square.AddForce(Vector2.down * forceamt);
        }

        //If statement to move up on screen by using W
        if (Input.GetKey(KeyCode.I))
        {

            //make square move up
            square.AddForce(Vector2.up * forceamt);
        }
        */

    }

    private void OnCollisionEnter2D(Collision2D collision)  
        
    {
        if (spawn)
        {

            spawn = false;
            if (collision.transform.tag == "Player1")
            {

                gamemanager.sc_num++;
            } else if (collision.transform.tag == "Player3")
            {
                gamemanager.p3sc_num
            }
            
              var pos = new Vector2(Random.Range(-9, 9), Random.Range(-2, 4));

            Instantiate(pl2, pos, Quaternion.identity);
            //Destroy player
            Destroy(this.gameObject);
            spawn = true;
        }
    }
    //-9.47 and 9.41 X     -2.58 and 4.22 Y
}

