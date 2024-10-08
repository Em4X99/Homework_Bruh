using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASD3 : MonoBehaviour
{
    //Variables 
    public float forceamt = 10f;
    private int i = 8;
    private Rigidbody2D square;
    private Color defaultColor = Color.yellow;

    // Start is called before the first frame update
    void Start()
    {
        //Find the Rigidbody on the object this script is on
        square = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //If statement to move Right on screen by using D
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //make square move right
            square.AddForce(Vector2.right * forceamt);
        }

        //If statement to move right on screen by using A 
        if (Input.GetKey(KeyCode.LeftArrow)) 
        {
            //make square move left
            square.AddForce(Vector2.left * forceamt);
        }

        //If statement to move down on screen by usind S 
        if (Input.GetKey(KeyCode.DownArrow)) 
        {
            //make square move down
            square.AddForce(Vector2.down * forceamt);
        }
    
        //If statement to move up on screen by using W
        if (Input.GetKey(KeyCode.UpArrow)) 
        {
            
            //make square move up
            square.AddForce(Vector2.up * forceamt);
        }


    }
    //on collisionenter2D happens when two 2D obbjects with colliders hit each other
    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        //make the cube chanje color when it hits player 2 cube
        if (collision.transform.tag == "Player1")
        {
            GetComponent<SpriteRenderer>().color = Color.magenta;
        }
        //Make the cube change color when it hits player 3 cube 
        if (collision.transform.tag == "Player2")
        {
            GetComponent <SpriteRenderer>().color = Color.red;
        }
    }
    //OnCollisionExit2D, happens when two 2D objects separate
    private void OnCollisionExit2D(Collision2D collision)
    {
     //Every time we exit, we want object to change back to original color
     GetComponent<SpriteRenderer>().color = defaultColor;
    }*/
}
