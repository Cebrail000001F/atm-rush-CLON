using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToplanmaAniHareketi : MonoBehaviour
{
    public Transform BaglýOlduguPara; 
    void Update()
    {
        //paranýn hareketi
      transform.position = new Vector3(
      Mathf.Lerp(transform.position.x, BaglýOlduguPara.position.x,Time.deltaTime * 20),
      BaglýOlduguPara.position.y,
      BaglýOlduguPara.position.z + 1);
    }
}
