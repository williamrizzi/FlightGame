using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public bool canShot;

    public GameObject bullet;
    public GameObject[] gunSpots;
    public bool shotType1;
    public float bulletFrequency;
    public float damage;    

    public float timer;


    // Start is called before the first frame update
    void Start()
    {
        gunSpots = GameObject.FindGameObjectsWithTag("GunSpot");
        damage = GameObject.FindGameObjectWithTag("GameController").GetComponent<Balance>().MotherShipDamage;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            canShot = true;
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            canShot = false;
        }



        if(canShot == true)
        {
            timer += Time.deltaTime;
            if (timer >= bulletFrequency)
            {
                for (int i = 0; i < gunSpots.Length; i++)
                {
                    Instantiate(bullet, gunSpots[i].transform.position, transform.rotation);
                }
                timer = 0;
            }
        }
        
    }


}
