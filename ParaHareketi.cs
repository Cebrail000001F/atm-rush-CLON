using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParaHareketi : MonoBehaviour
{
    [SerializeField] float ZCoordinatHareketH�z�;
    [SerializeField] float YCoordinatHareketH�z�;
    [SerializeField] float XCoordinatHareketH�z�;
    float Hiz;
    
    void Update()
    {
        //Para Objesinin Hareket Ettirme Komutlari
        Hiz = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(Hiz * XCoordinatHareketH�z� *
            Time.deltaTime, 0, ZCoordinatHareketH�z� * Time.deltaTime));


        


            if (gameObject.tag == "bitisCizgisi")

            {

                Hiz = Input.GetAxis("Vertical");
                transform.Translate(new Vector3( 0, Hiz * XCoordinatHareketH�z� *
            Time.deltaTime,0));
            }

       
        
    }
}
