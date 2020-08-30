using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VidasPersonaje : MonoBehaviour
{
    public static int vidasJ=3;
    public int vidaJ;
    public bool puedeHacerDano = true;
    public string tag;
    bool estamuerto =false;
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        vidaJ=vidasJ;
    }
    void OnTriggerEnter(Collider other) 
    {
        tag=other.tag;
        if(!puedeHacerDano)
            {
                return;
            }
            if (other.tag == "Enemigo")
            {
                puedeHacerDano = false;
                Invoke ("ActivarDano",1);
                vidasJ-=1;

                if(vidasJ<=0)
                {
                    //valorAlfaDeseadoTelaNegra=1;
                }
            }
    }
    void ActivarDano()
    {
        puedeHacerDano = true;
    }
}
