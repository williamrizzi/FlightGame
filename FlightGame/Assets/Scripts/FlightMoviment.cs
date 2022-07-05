using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlightMoviment : MonoBehaviour
{
    private GameController gameCtrl;
    private Balance balanceScript;

    public bool canMove;

    [SerializeField]
    private float life;


    public float x, y;

    [Range(0.01f, 12f)]
    public float speedSides;

    [Range(0.01f, 12f)]
    public float speedFront;


    [SerializeField]
    [Range(1f, 100f)]
    float mainThrust = 100f;
    [SerializeField]
    [Range(0.01f, 200f)]
    float rotationThrust = 1f;



    // Start is called before the first frame update
    void Start()
    {
        gameCtrl = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        balanceScript = GameObject.FindGameObjectWithTag("GameController").GetComponent<Balance>();        
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

            if (Input.GetKey(KeyCode.A))
            {
                
            }
            if (Input.GetKey(KeyCode.D))
            {
               
            }
        }

        //Condição caso morra por tiros; Temporário, Ajustar;
        if(life <= 0)
        {
            gameCtrl.StartCoroutine("SpawnGame");
            Destroy(this.gameObject);
        }        
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
            Destroy(this.gameObject);
            
        }
        if (collision.transform.tag == "ScoreGate")
        {
            gameCtrl.StartCoroutine("SpawnGame");
            Destroy(this.gameObject);            
        }
    }


}
