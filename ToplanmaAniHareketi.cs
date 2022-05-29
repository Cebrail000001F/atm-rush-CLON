using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToplanmaAniHareketi : MonoBehaviour
{
    public Transform Bagl�OlduguPara; 
    void Update()
    {
        //paran�n hareketi
      transform.position = new Vector3(
      Mathf.Lerp(transform.position.x, Bagl�OlduguPara.position.x,Time.deltaTime * 20),
      Bagl�OlduguPara.position.y,
      Bagl�OlduguPara.position.z + 1);
    }
}
