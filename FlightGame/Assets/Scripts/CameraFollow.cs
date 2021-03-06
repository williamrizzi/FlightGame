using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public bool follow;

    [SerializeField] 
    private Transform target;

    [SerializeField]
    [Range(0.01f, 1f)]
    private float smoothSpeed = 0.125f;

    [SerializeField]    
    private Vector3 offset;

    private Vector3 velocity = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {        
        
    }

    // Update is called once per frame
    private void LateUpdate()
    {        
        if (follow)
        {
            Vector3 desiredPosition = target.position + offset;
            transform.position = Vector3.SmoothDamp(transform.position, desiredPosition, ref velocity, smoothSpeed);

        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            FindMyTarget();
        }
    }

   public void FindMyTarget()
    {
        target = GameObject.FindGameObjectWithTag("MotherShip").transform;
        follow = true;
    }

    

}
