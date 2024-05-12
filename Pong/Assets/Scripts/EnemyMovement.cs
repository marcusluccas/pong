using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    Rigidbody2D myRB;
    GameObject ball;
    float speed = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
        ball = GameObject.FindGameObjectWithTag("Ball");
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        Debug.Log(Mathf.Sign(ball.transform.position.y));
        transform.position = Vector2.MoveTowards(transform.position, new Vector2(transform.position.x, ball.transform.position.y), speed * Time.deltaTime);
    }
}
