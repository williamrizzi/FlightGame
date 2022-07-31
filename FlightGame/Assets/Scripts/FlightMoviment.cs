using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlightMoviment : MonoBehaviour
{
    private GameController gameCtrl;
    private Balance balanceScript;
    private Rigidbody rb;

    public bool canMove;

    [SerializeField]
    private float life;


    public float x, y, z;

    [Range(0f, 50f)]
    public float speedSides;

    [Range(0f, 50f)]
    public float speedFront;

    [SerializeField]
    [Range(0, 25)]
    private int rotAngleX;

    [SerializeField]
    [Range(0, 25)]
    private int rotAngleY;


    // Start is called before the first frame update
    void Start()
    {
        gameCtrl = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        balanceScript = GameObject.FindGameObjectWithTag("GameController").GetComponent<Balance>();
        rb = GetComponent<Rigidbody>();


    }

    // Update is called once per frame
    void Update()
    {
        if(canMove == true)
        {
            x = Input.GetAxis("Horizontal");
            y = Input.GetAxis("Vertical");

            //Vector3 moveVelocity = new Vector3(x, y, speedFront);
            //moveVelocity *= (speedSides) * Time.deltaTime;
            //transform.Translate(moveVelocity);

            rb.velocity = new Vector3(x * speedSides, y * speedSides, speedFront);



            if (x < 0) 
            { 
                transform.GetChild(0).transform.rotation = Quaternion.Euler(0, 0, rotAngleX);
            }
            else if (x > 0)
            {   
                transform.GetChild(0).transform.rotation = Quaternion.Euler(0, 0, -rotAngleX);                
            }
            else
            {     
                transform.GetChild(0).transform.rotation = Quaternion.Euler(0, 0, 0); ;
            }

         
        }

        //Condição caso morra por tiros; Temporário, Ajustar;
        if(life <= 0)
        {
            gameCtrl.StartCoroutine("SpawnGame");
            Destroy(this.gameObject);
        }        
    }

    private void FixedUpdate()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "ScoreGate")
        {
            gameCtrl.AddScorePoints(balanceScript.ScorePointGate);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Obstacle")
        {
            gameCtrl.StartCoroutine("SpawnGame");
            gameObject.GetComponent<ExplosionCubes>().Explode();
            Destroy(this.gameObject);
            
        }
        if (collision.transform.tag == "ScoreGate")
        {
            gameCtrl.StartCoroutine("SpawnGame");
            gameObject.GetComponent<ExplosionCubes>().Explode();
            Destroy(this.gameObject);            
        }
    }


}
