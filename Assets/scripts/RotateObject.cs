using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float xAngle, yAngle, zAngle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

            gameObject.transform.Rotate(xAngle, yAngle, zAngle, Space.Self);
            //gameObject.transform.Rotate(xAngle, yAngle, zAngle, Space.World);
        
    }
}
