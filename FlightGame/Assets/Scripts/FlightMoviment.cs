using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlightMoviment : MonoBehaviour
{    
    public bool canMove;

    public float x, y;

    [Range(0.01f, 12f)]
    public float speedSides;

    [Range(0.01f, 12f)]
    public float speedFront;

    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = transform.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if(canMove == true)
        {
            x = Input.GetAxis("Horizontal");
            y = Input.GetAxis("Vertical");

            Vector3 moveVelocity = new Vector3(x, y, speedFront);
            moveVelocity *= (speedSides) * Time.deltaTime;
            transform.Translate(moveVelocity);
        }
        

        //transform.Translate(Vector3.forward * speed * Time.deltaTime);

        //.velocity = new Vector3(rb.velocity.x, rb.velocity.y, rb.velocity.z * speed * Time.deltaTime);
        

    }
}
