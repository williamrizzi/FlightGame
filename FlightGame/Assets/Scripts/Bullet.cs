using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject motherShip;

    public float timer;
    public float bulletSpeed;
    public float timeToDestroy;
    public Rigidbody rb;

    

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, bulletSpeed + Time.deltaTime);

        timer += Time.deltaTime;
        if(timer >= timeToDestroy)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Obstacle")
        {
            motherShip = GameObject.FindGameObjectWithTag("MotherShip");
            collision.gameObject.GetComponent<Obstacle>().life -= motherShip.GetComponent<Shot>().damage;
            Destroy(gameObject);
        }
    }
}
