using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seguidor : MonoBehaviour
{
    
    //objetivo: es el personaje o objeto que va a seguir
    public Transform objetivo;
    //suabidad: con que suabidad se a mover la seguidor 
    public float suabidad=5f;

    void Update()
    {
        //para que la seguidor se mueva donde esta el personaje 
        transform.position=Vector3.Lerp(transform.position,objetivo.position,suabidad*Time.deltaTime);
    }
}
