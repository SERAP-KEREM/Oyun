using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5;
    public GameObject button;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        transform.Translate(x * Time.deltaTime*speed, y * Time.deltaTime*speed, 0);
        if (transform.position.x > 30)
        {
            transform.position = new Vector3(30, transform.position.y, transform.position.z);
        }else if (transform.position.x < -30)
        {
            transform.position = new Vector3(-30, transform.position.y, transform.position.z);
        }

        if (transform.position.y > 30)
        {
            transform.position = new Vector3(transform.position.x, 30, transform.position.z);
        }
        else if (transform.position.y < -30)
        {
            transform.position = new Vector3(transform.position.x, -30, transform.position.z);
        }

        
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("trig Girdi");
        Time.timeScale = 0;
        button.SetActive(true);
    }


}
