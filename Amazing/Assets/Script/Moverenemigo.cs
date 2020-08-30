using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moverenemigo : MonoBehaviour
{
    public float visionRadio;
    public float ataqueRadio;
    public float velociadad;
    
    public GameObject player;
    Vector3 pocicionInicial;
    Rigidbody2D rigidbody2D;
    void Start()
    {
        player=GameObject.FindGameObjectWithTag("Personaje");
        pocicionInicial=transform.position;
        //rigidbody2D=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 target=pocicionInicial;
        float distancia= Vector3.Distance(player.transform.position,transform.position);
        if(distancia<visionRadio)
        {
            target=player.transform.position;
        }
        float fixedVelocidad=velociadad*Time.deltaTime;
        transform.position=Vector3.MoveTowards(transform.position,target,fixedVelocidad);
        
        Debug.DrawLine(transform.position,target, Color.green);
    }
    private void OnDrawGizmos() {
        Gizmos.color=Color.yellow;
        Gizmos.DrawWireSphere(transform.position, visionRadio);
        Gizmos.DrawWireSphere(transform.position, ataqueRadio);
    }
}
