using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
    
    //velocidad: es con la velociadad que se va a mover el personaje 
    public float velocidad=5f;
    
    public float contadorTiempo=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //para rotar al personaje 
        #region Rotacion
        if(Input.GetKeyDown(KeyCode.W))
        {
            transform.rotation= Quaternion.Euler(0,0,0);
        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            transform.rotation= Quaternion.Euler(180,0,0);
        }
        if(Input.GetKeyDown(KeyCode.A))
        {
            transform.rotation= Quaternion.Euler(0,0,90);
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            transform.rotation= Quaternion.Euler(0,0,-90);
        }
        #endregion
        
        //para que se pueda mover al personaje 
        #region caminar
        if(
            Input.GetKey(KeyCode.W) || 
            Input.GetKey(KeyCode.S) ||
            Input.GetKey(KeyCode.A) ||
            Input.GetKey(KeyCode.D)
        )
        {
            transform.Translate(0,velocidad*Time.deltaTime,0);
        }
        contadorTiempo=contadorTiempo+Time.deltaTime;
        #endregion
    }
}
