using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    Rigidbody2D myRB;
    float speed = 6f;
    ScoreManager scoreManager;

    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();

        MovementRandom();

        scoreManager = FindObjectOfType<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            myRB.velocity = new Vector2(myRB.velocity.x * -1, collision.gameObject.GetComponent<Rigidbody2D>().velocity.y * 0.5f);
        }

        if (collision.gameObject.tag == "Wall")
        {
            myRB.velocity = new Vector2(myRB.velocity.x, myRB.velocity.y * -1);
        }

        if (collision.gameObject.tag == "ScorePointPlayer")
        {
            scoreManager.scoreEnemy++;
            transform.position = Vector3.zero;
            myRB.velocity = Vector3.zero;
            MovementRandom();
        }
        if (collision.gameObject.tag == "ScorePointEnemy")
        {
            scoreManager.scorePlayer++;
            transform.position = Vector3.zero;
            myRB.velocity = Vector3.zero;
            MovementRandom();
        }
    }

    void MovementRandom()
    {
        int direction = Random.Range(0, 4);

        switch (direction) 
        {
            case 0:
                myRB.velocity = new Vector2(speed, speed);
                break;

            case 1:
                myRB.velocity = new Vector2(speed, -speed);
                break;

            case 2:
                myRB.velocity = new Vector2(-speed, -speed);
                break;

            case 3:
                myRB.velocity = new Vector2(-speed, speed);
                break;
        }
    }
}
