using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainScript : MonoBehaviour
{
    public GameObject motherShip;
    public GameObject gameCtrl;
    
    // Start is called before the first frame update
    void Start()
    {
        motherShip = GameObject.FindGameObjectWithTag("MotherShip");
        gameCtrl = GameObject.FindGameObjectWithTag("GameController");
    }

    // Update is called once per frame
    void Update()
    {
        if(motherShip.transform.position.z > transform.position.z + 20)
        {
            gameCtrl.GetComponent<MapGeneration>().CreateNextTerrain();
            Destroy(gameObject);
        }

        if(transform.position.y < 0){
            transform.Translate(Vector3.up * GameObject.FindGameObjectWithTag("MotherShip").GetComponent<FlightMoviment>().speedSides / 0.5f * Time.deltaTime);
        }
        else
        {
            Vector3 temp = new Vector3(transform.position.x, 0, transform.position.z);
            transform.position = temp;
        }

    }
}
