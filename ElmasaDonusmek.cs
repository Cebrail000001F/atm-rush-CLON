using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElmasaDonusmek : MonoBehaviour
    
{
    public Color dolarRengi;
    public Color elmasRengi;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        void Update()
        {
            gameObject.GetComponent<Renderer>().material.color = (dolarRengi);

            void OnCollisionEnter(Collision collision)
            {
                if (collision.gameObject.tag == "ElmasaDonus")
                {
                    gameObject.GetComponent<Renderer>().material.color = (elmasRengi);
                    //etkile�ime ge�ilen objenin tag'i obje ise yap�lacak
                    // i�lemler bu k�sma yaz�l�r.
                }



            }
        }

                
        
    }
}
