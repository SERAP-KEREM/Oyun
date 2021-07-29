using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed : MonoBehaviour
{
    // Start is called before the first frame update
    public static float speed = 10;
    public float _speed = 10;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed = _speed;
        transform.Translate(0, speed * Time.deltaTime, 0);
    }
}
