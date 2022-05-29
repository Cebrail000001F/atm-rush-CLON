using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Animasyon : MonoBehaviour
{
    
    [SerializeField] public Animator animasyon;
   
   

    Animator kontrol;
    void Start()
    {
        kontrol = GetComponentInChildren<Animator>();
       
        
    }
 

    void Update()
    {
        void OnTriggerEnter(Collider collider)
        {

            if (collider.transform.tag == "engel")
            {
                kontrol.SetTrigger("dustu");
            }

        }
   
    }
    
 }
