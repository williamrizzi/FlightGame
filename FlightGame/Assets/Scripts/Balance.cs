using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balance : MonoBehaviour
{
    [SerializeField]
    private int scorePointGate = 3;

    //MotherShip
    [SerializeField]
    private float motherShipDamage;
    private float motherBaseDamage;    

    //EnemyCraft
    [SerializeField]
    private float enemyCraftLife;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public int ScorePointGate { get => scorePointGate; }
    public float MotherShipDamage { get => motherShipDamage; }
    public float EnemyCraftLife { get => enemyCraftLife; }
}
