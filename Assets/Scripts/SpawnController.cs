using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    // Start is called before the first frame update
    public float mesafe = 20;
    public float sıklık = 1;
    public GameObject kapali, delikli;
    bool control = true;
    int count = 0;
    void Start()
    {
        spawn();

    }

    // Update is called once per frame
    void Update()
    {
        if (control)
        {
            control = false;
            Invoke("spawn", sıklık);
        }
    }
    void spawn()
    {
        control = true;
        count++;
        if (count > 17)
        {
            count = 17;
        }
        int kSay, dSay;
        dSay = count % 2;
        kSay = (count - dSay) / 2;

        int[,] array = new int[3, 3];

        int x, y;

        for (int i = 0; i < dSay + kSay; i++)
        {
            bool tekrar = true;
            do
            {
                x = Random.Range(0, 3);
                y = Random.Range(0, 3);
                if (array[x, y] != 1)
                {
                    array[x, y] = 1;
                    if (i==0&&dSay > 0)
                    {
                        Instantiate(delikli, new Vector3(-20 + (x * 20), -20 + (y * 20), mesafe), Quaternion.Euler(-90,0,0));
                        
                    }
                    else
                    {
                        Instantiate(kapali, new Vector3(-20 + (x * 20), -20 + (y * 20), mesafe), Quaternion.Euler(-90,0,0));
                    }
                    tekrar = false;
                }
            } while (tekrar);
        }
    }
}
