using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float life;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if(life <= 0)
        {
            gameObject.GetComponent<ExplosionCubes>().Explode();
            Destroy(gameObject);
        }                
    }
}
