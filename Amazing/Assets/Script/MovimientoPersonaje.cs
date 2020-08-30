using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovimientoPersonaje : MonoBehaviour
{
    public Animator anim;
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
        //para que se pueda mover al personaje 
        #region caminar
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(0,velocidad*Time.deltaTime,0);
        }

        if(Input.GetKey(KeyCode.D))
        {
            anim.SetBool("caminar",true);
            transform.Translate(velocidad*Time.deltaTime,0,0);
        }
        else
        {
            anim.SetBool("caminar",false);
        }

        if(Input.GetKey(KeyCode.A))
        {
            anim.SetBool("caminar_izquierda",true);
            transform.Translate((-1*velocidad)*Time.deltaTime,0,0);
        }
        else
        {
            anim.SetBool("caminar_izquierda",false);
        }

        if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(0,(-1*velocidad)*Time.deltaTime,0);
        }
        
        
        contadorTiempo=contadorTiempo+Time.deltaTime;
        #endregion
    }
}
