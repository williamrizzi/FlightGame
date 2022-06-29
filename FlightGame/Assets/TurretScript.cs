using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretScript : MonoBehaviour
{

    public int life;

    public GameObject turretHead;

    public bool hasTarget;
    public GameObject target;
    



    // Start is called before the first frame update
    void Start()
    {
        hasTarget = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(hasTarget == true)
        {
            Vector3 dir = target.transform.position - turretHead.transform.position;
            Quaternion lookRot = Quaternion.LookRotation(dir);
            lookRot.x = 0; lookRot.z = 0;
            turretHead.transform.rotation = Quaternion.Slerp(transform.rotation, lookRot, Mathf.Clamp01(3.0f * Time.maximumDeltaTime));
        }
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "MotherShip")
        {
            hasTarget = true;
            target = other.gameObject;
        }
    }

}