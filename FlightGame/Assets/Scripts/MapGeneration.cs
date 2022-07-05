using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGeneration : MonoBehaviour
{
    public GameObject[] terrain;
    public int tamanho;
    public int atualSpot;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            CreateNextTerrain();
        }
    }

    public void CreateNextTerrain()
    {
        int random = Random.Range(0, 5);
        Vector3 temp = new Vector3(0, -20, atualSpot);
        Instantiate(terrain[random], temp, transform.rotation);
        atualSpot += 20;
    }

    public void SpawnBaseTerrain()
    {
        atualSpot = 0;
        for (int i = 0; i < tamanho; i++)
        {
            int random = Random.Range(0, 5);
            Vector3 temp = new Vector3(0, 0, atualSpot);
            Instantiate(terrain[random], temp, transform.rotation);
            atualSpot += 20;
        }
    }

    public void DestroyAllTerrains()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Terrain");
        for (int i = 0; i < objs.Length; i++)
        {
            Destroy(objs[i].gameObject);
        }
    }

   

}
