using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGeneration : MonoBehaviour
{
    public Balance balanceScript;

    public GameObject[] terrain;
    public int tamanho;
    public int atualSpot;

    [SerializeField]
    [Range(0, 100)]
    private int randonSize;


    [SerializeField]
    private GameObject[] forestTerrains;
    [SerializeField]
    private GameObject[] urbanTerrains;
    [SerializeField]
    private GameObject[] cemeteryTerrains;
    [SerializeField]
    private GameObject[] headquartersTerrains;

    [SerializeField]
    private bool forestStage;    
    [SerializeField]
    private bool urbanStage;
    [SerializeField]
    private bool cemeteryStage;
    [SerializeField]
    private bool headquartersStage;

    [SerializeField]
    private bool boss;
    [SerializeField]
    private bool normalEnemy;
    [SerializeField]
    private bool bonus;
    [SerializeField]
    private bool neutral;

    [SerializeField]
    private int durationStage;


    // Start is called before the first frame update
    void Start()
    {
        balanceScript = GameObject.FindGameObjectWithTag("GameController").GetComponent<Balance>();
        durationStage = balanceScript.StageDuration;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            CreateNextTerrain();
        }

        if (Input.GetKeyDown(KeyCode.N))
        {
            boss = false;
            normalEnemy = false;
            bonus = false;
            neutral = true;
            durationStage -= 1;
        }

        if (durationStage == 0)
        {
            if (forestStage)
            {
                forestStage = false;
                urbanStage = true;
                durationStage = balanceScript.StageDuration;

            }
            else if (urbanStage)
            {
                urbanStage = false;
                cemeteryStage = true;
                durationStage = balanceScript.StageDuration;
            }
            else if (cemeteryStage)
            {
                cemeteryStage = false;
                headquartersStage = true;
                durationStage = balanceScript.StageDuration;
            }

            // ...Continuação -----------------------------------------------------------------------------------------------------------
        }




        if (durationStage == balanceScript.RoundForBonus[0] || durationStage == balanceScript.RoundForBonus[1]) // BONUS
        {
            boss = false;
            normalEnemy = false;
            bonus = true;
            neutral = false;
        }
        else if (durationStage == balanceScript.RoundForEnemy[0] || durationStage == balanceScript.RoundForEnemy[1] || durationStage == balanceScript.RoundForEnemy[2]) // NORMAL ENEMY
        {
            boss = false;
            normalEnemy = true;
            bonus = false;
            neutral = false;
        }
        else if(durationStage == balanceScript.RoundForBoss) // BOSS
        {
            boss = true;
            normalEnemy = false;
            bonus = false;
            neutral = false;
        }
        else //NEUTRAL
        {
            boss = false;
            normalEnemy = false;
            bonus = false;
            neutral = true;
        }





    }

    //public void CreateNextTerrain()
    //{
    //    int random = Random.Range(0, randonSize);
    //    Vector3 temp = new Vector3(0, -20, atualSpot);
    //    Instantiate(terrain[random], temp, transform.rotation);
    //    atualSpot += 20;
    //}

    public void CreateNextTerrain()
    {
        if (forestStage)
        {            
            if(boss)
            {
                //int random = Random.Range(0, randonSize);
                Vector3 temp = new Vector3(0, -20, atualSpot);
                Instantiate(forestTerrains[0], temp, transform.rotation);
                atualSpot += 20;
            }
            else if(normalEnemy)
            {
                //int random = Random.Range(0, randonSize);
                Vector3 temp = new Vector3(0, -20, atualSpot);
                Instantiate(forestTerrains[1], temp, transform.rotation);
                atualSpot += 20;
            }
            else if(neutral)
            {
                //int random = Random.Range(0, randonSize);
                Vector3 temp = new Vector3(0, -20, atualSpot);
                Instantiate(forestTerrains[2], temp, transform.rotation);
                atualSpot += 20;
                durationStage -= 1;
            }
            else if (bonus)
            {
                //int random = Random.Range(0, randonSize);
                Vector3 temp = new Vector3(0, -20, atualSpot);
                Instantiate(forestTerrains[3], temp, transform.rotation);
                atualSpot += 20;
                durationStage -= 1;
            }
        }
        if (urbanStage)
        {
            if (boss)
            {
                //int random = Random.Range(0, randonSize);
                Vector3 temp = new Vector3(0, -20, atualSpot);
                Instantiate(urbanTerrains[0], temp, transform.rotation);
                atualSpot += 20;
            }
            else if (normalEnemy)
            {
                //int random = Random.Range(0, randonSize);
                Vector3 temp = new Vector3(0, -20, atualSpot);
                Instantiate(urbanTerrains[1], temp, transform.rotation);
                atualSpot += 20;
            }
            else if (neutral)
            {
                //int random = Random.Range(0, randonSize);
                Vector3 temp = new Vector3(0, -20, atualSpot);
                Instantiate(urbanTerrains[2], temp, transform.rotation);
                atualSpot += 20;
                durationStage -= 1;
            }
            else if (bonus)
            {
                //int random = Random.Range(0, randonSize);
                Vector3 temp = new Vector3(0, -20, atualSpot);
                Instantiate(urbanTerrains[3], temp, transform.rotation);
                atualSpot += 20;
                durationStage -= 1;
            }
        }
        if (cemeteryStage)
        {
            if (boss)
            {
                //int random = Random.Range(0, randonSize);
                Vector3 temp = new Vector3(0, -20, atualSpot);
                Instantiate(cemeteryTerrains[0], temp, transform.rotation);
                atualSpot += 20;
            }
            else if (normalEnemy)
            {
                //int random = Random.Range(0, randonSize);
                Vector3 temp = new Vector3(0, -20, atualSpot);
                Instantiate(cemeteryTerrains[1], temp, transform.rotation);
                atualSpot += 20;
            }
            else if (neutral)
            {
                //int random = Random.Range(0, randonSize);
                Vector3 temp = new Vector3(0, -20, atualSpot);
                Instantiate(cemeteryTerrains[2], temp, transform.rotation);
                atualSpot += 20;
                durationStage -= 1;
            }
            else if (bonus)
            {
                //int random = Random.Range(0, randonSize);
                Vector3 temp = new Vector3(0, -20, atualSpot);
                Instantiate(cemeteryTerrains[3], temp, transform.rotation);
                atualSpot += 20;
                durationStage -= 1;
            }
        }
        if (headquartersStage)
        {
            if (boss)
            {
                //int random = Random.Range(0, randonSize);
                Vector3 temp = new Vector3(0, -20, atualSpot);
                Instantiate(headquartersTerrains[0], temp, transform.rotation);
                atualSpot += 20;
            }
            else if (normalEnemy)
            {
                //int random = Random.Range(0, randonSize);
                Vector3 temp = new Vector3(0, -20, atualSpot);
                Instantiate(headquartersTerrains[1], temp, transform.rotation);
                atualSpot += 20;
            }
            else if (neutral)
            {
                //int random = Random.Range(0, randonSize);
                Vector3 temp = new Vector3(0, -20, atualSpot);
                Instantiate(headquartersTerrains[2], temp, transform.rotation);
                atualSpot += 20;
                durationStage -= 1;
            }
            else if (bonus)
            {
                //int random = Random.Range(0, randonSize);
                Vector3 temp = new Vector3(0, -20, atualSpot);
                Instantiate(headquartersTerrains[3], temp, transform.rotation);
                atualSpot += 20;
                durationStage -= 1;
            }
        }

        // ...Continuação   -----------------------------------------------------------------------------------------------------------

    }




    public void SpawnBaseTerrain()
    {
        atualSpot = 0;
        durationStage = balanceScript.StageDuration;
        for (int i = 0; i < tamanho; i++)
        {
            //int random = Random.Range(0, randonSize);
            Vector3 temp = new Vector3(0, 0, atualSpot);
            Instantiate(forestTerrains[2], temp, transform.rotation);
            atualSpot += 20;
            durationStage -= 1;
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
