using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private Balance balanceScript;
    private MapGeneration mapGen;
    private CameraFollow camFollow;

    [SerializeField]
    private int score;
    private int highscore;

    private GameObject spawnPlayer;
    [SerializeField]
    private GameObject playerShip;


    IEnumerator SpawnGame()
    {
        yield return new WaitForSeconds(1f);

        //TEMPORÁRIO, PODE SOFRER MUDANÇAS FUTURAS
        Instantiate(playerShip, spawnPlayer.transform.position, Quaternion.identity);

        mapGen.DestroyAllTerrains();
        DestroyAllCubes();

        mapGen.SpawnBaseTerrain();

        camFollow.FindMyTarget();        

        yield return new WaitForSeconds(0.3f);

        //GameObject.FindGameObjectWithTag("MotherShip").GetComponent<FlightMoviment>().canMove = true;
    }




    // Start is called before the first frame update
    void Start()
    {
        balanceScript = GameObject.FindGameObjectWithTag("GameController").GetComponent<Balance>();
        spawnPlayer = GameObject.FindGameObjectWithTag("PlayerSpawn");
        mapGen = GetComponent<MapGeneration>();
        camFollow = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraFollow>();

        //TEMPORÁRIO
        StartCoroutine("SpawnGame");

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public int AddScorePoints(int scorePoint)
    {
        score += scorePoint;
        return score;
    }
    
    private void DestroyAllCubes()
    {
        GameObject[] cubesToDestroy = GameObject.FindGameObjectsWithTag("CubeExplosion");
        for(int i = 0; i < cubesToDestroy.Length; i++)
        {
            Destroy(cubesToDestroy[i]);
        }
    }

   



}
