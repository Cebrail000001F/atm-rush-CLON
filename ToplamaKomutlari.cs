using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToplamaKomutlari : MonoBehaviour
{
    //trigera degdigi zaman calisacak
    private void OnTriggerEnter(Collider CarpilanObje)
    {

        if (CarpilanObje.gameObject.CompareTag("Toplananacak"))
        {
            //forward-�art��� objeyi �n�nde s�r�kleme komutu
            //objenin Onunde obje yoksa...carpan objenin onune koy 
            
                CarpilanObje.gameObject.transform.position = transform.position + Vector3.forward;
            
           

            //Onundeki objeyi suruklemeye basladiktan sonra bu scrip
            //dosyasini mevcut objeden kaldiririr
           Destroy(gameObject.GetComponent<ToplamaKomutlari>());

            //Suruklemeye basladigi objeye bu scripti ekler
            CarpilanObje.gameObject.AddComponent<ToplamaKomutlari>();

            //Ondeki Obje daha sonra etkile�ime girecegi obje ile etkilesmesi icin;
            //isTrigger kapatilir
            CarpilanObje.gameObject.GetComponent<BoxCollider>().isTrigger = false;

            CarpilanObje.gameObject.AddComponent<ToplanmaAniHareketi>();
            CarpilanObje.gameObject.GetComponent<ToplanmaAniHareketi>().Bagl�OlduguPara = transform;


            //Tag degistirme komutu
            CarpilanObje.gameObject.tag ="Toplanan";
        }
    }
}
