using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SkorController : MonoBehaviour
{
    // Start is called before the first frame update
    bool control = true;
    int scoreCount = 0;
    Text score_;
    
    void Start()
    {
        score_ = GetComponent<Text>();
        score();
    }

    // Update is called once per frame
    void Update()
    {
        if (control)
        {
            control = false;
            Invoke("score", 0.5f);
        }
    }
    void score()
    {
        control = true;
        scoreCount++;
        score_.text= "Score: " + scoreCount.ToString();
    }

    
}
