using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidad = 5f;

    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Se esta llamando en cada frame del juego
    void Update()
    {
        //Movimiento del personaje en forma horizontal con las letras "A y D", recordar crear la variable publica float velocidad
       float velocidadX = Input.GetAxis("Horizontal")*Time.deltaTime*velocidad;

       animator.SetFloat("movement", velocidadX*velocidad);

       if (velocidadX < 0)
       {
          transform.localScale = new Vector3(-1, 1,1);
       }
       if (velocidadX > 0)
       {
          transform.localScale = new Vector3(1, 1, 1);
       }

       Vector3 posicion = transform.position;

       transform.position = new Vector3(velocidadX + posicion.x, posicion.y, posicion.z);

    }
}
