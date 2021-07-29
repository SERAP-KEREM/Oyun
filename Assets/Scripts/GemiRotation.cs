using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemiRotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

       
        transform.rotation = Quaternion.Euler(-20*y, transform.rotation.eulerAngles.y, -45*x);
        
    }
}
