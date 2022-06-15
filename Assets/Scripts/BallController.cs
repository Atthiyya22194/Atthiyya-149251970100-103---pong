using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    //[SerializeField] float speed;
    public Vector2 speed;
    public Vector2 resetPosition;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = speed;
        //BallMovement();
    }

    private void Update()
    {
        transform.Translate(speed * Time.deltaTime);
    }

    /*private void BallMovement()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(speed * x, speed * y);
<<<<<<< Updated upstream
=======
    }*/

    public void ResetBall()
    {
        transform.position = new Vector3(resetPosition.x, resetPosition.y, 2);
    }

    public void ActivatePUSpeedUp(float magnitude)
    {
        rb.velocity *= magnitude;
    }
}
