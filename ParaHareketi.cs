using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParaHareketi : MonoBehaviour
{
    [SerializeField] float ZCoordinatHareketHýzý;
    [SerializeField] float YCoordinatHareketHýzý;
    [SerializeField] float XCoordinatHareketHýzý;
    float Hiz;
    
    void Update()
    {
        //Para Objesinin Hareket Ettirme Komutlari
        Hiz = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(Hiz * XCoordinatHareketHýzý *
            Time.deltaTime, 0, ZCoordinatHareketHýzý * Time.deltaTime));


        


            if (gameObject.tag == "bitisCizgisi")

            {

                Hiz = Input.GetAxis("Vertical");
                transform.Translate(new Vector3( 0, Hiz * XCoordinatHareketHýzý *
            Time.deltaTime,0));
            }

       
        
    }
}
