using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    private float spinSpeed = 10.6f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Object spins on the Z axis for the speed value
        transform.Rotate(0,0,spinSpeed);
    }
}
