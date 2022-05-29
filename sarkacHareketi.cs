using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sarkacHareketi : MonoBehaviour
{
    float baslamaZmani = 0f;
    float sarkacHizi = 2f;
    int sarkmaAralýgý = 0;
    void FixedUpdate()
    {
        baslamaZmani += Time.fixedDeltaTime;
        if (baslamaZmani > 1f)
        {
            sarkmaAralýgý++;
            sarkmaAralýgý %= 4;
            baslamaZmani = 0f;
        }

        switch (sarkmaAralýgý)
        {
            case 0:
                transform.Rotate(0f, 0f, sarkacHizi * (1 - baslamaZmani));
                break;
            case 1:
                transform.Rotate(0f, 0f, -sarkacHizi * baslamaZmani);
                break;
            case 2:
                transform.Rotate(0f, 0f, -sarkacHizi * (1 - baslamaZmani));
                break;
            case 3:
                transform.Rotate(0f, 0f, sarkacHizi * baslamaZmani);
                break;
        }
    }
}
