using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dir : MonoBehaviour
{
    
    void Update()
    {
        //transform.Rotate(transform.position);
        transform.Rotate(transform.position *Time.deltaTime);
       
    }
}
