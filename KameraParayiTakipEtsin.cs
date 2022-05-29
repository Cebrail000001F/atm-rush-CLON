using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraParayiTakipEtsin : MonoBehaviour
{
    public Transform target; //takip edecegi obje
    public Vector3 offset;   //takip etme mesafe aralýgý
  
    void Update()
    {
        //Lerp-Bir noktadan diger noktaya gitmemizi saglayan fonksiyon.
        //transform.position-kendi pozisyonu
        //target.position-takip edeceði pozisyon
        //offset-mesafe
        transform.position = Vector3.Lerp(transform.position, 
            target.position + offset, Time.deltaTime * 2);
    }
}
