using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balance : MonoBehaviour
{
    [SerializeField]
    private int scorePointGate = 3;


    [SerializeField]
    private int stageDuration;
    [SerializeField]
    private int[] roundForBonus;    
    [SerializeField]
    private int[] roundForEnemy;
    [SerializeField]
    private int roundForBoss;





    //MotherShip
    [SerializeField]
    private float motherShipDamage;
    private float motherBaseDamage;

    [SerializeField]
    private float motheShipBulletSpeed;


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
    public float MotheShipBulletSpeed { get => motheShipBulletSpeed; }
    public int[] RoundForBonus { get => roundForBonus; }
    public int[] RoundForEnemy { get => roundForEnemy; }
    public int RoundForBoss { get => roundForBoss; }
    public int StageDuration { get => stageDuration; }
}
