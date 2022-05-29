using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class engelCarpısma : MonoBehaviour
{
    private void OnTriggerEnter(Collider asd)
    {
        Animator animator = GetComponentInChildren<Animator>();
        animator.SetBool("yuru",true);
        animator.SetBool("dustu", false);
        animator.SetBool("ayagıyaKalk", false);
        if (asd.CompareTag("engel"))
        {

            animator.SetBool("yuru",false);
            animator.SetBool("dustu",true);
            



        }
    }
     
    
    
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
