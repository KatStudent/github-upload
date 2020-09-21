using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new Vector3 (22.98f, 3.07f, 14.03f);
   
    
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //putting the camera beside the plane
        transform.position = plane.transform.position + offset;
        
       
    }

}
