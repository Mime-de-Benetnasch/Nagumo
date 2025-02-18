using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidad = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Se esta llamando en cada frame del juego
    void Update()
    {
        //Movimiento del personaje en forma horizontal con las letras "A y D", recordar crear la variable publica float velocidad
       float velocidadX = Input.GetAxis("Horizontal")*Time.deltaTime*velocidad;

       Vector3 posicion = transform.position;

       transform.position = new Vector3(velocidadX + posicion.x, posicion.y, posicion.z);

    }
}
