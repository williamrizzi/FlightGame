using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCraft : MonoBehaviour
{
    [SerializeField]
    private float life = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (life <= 0)
        {
            Destroy(gameObject);
        }
    }

    public float Life { get => life; set => life = value; }
}
