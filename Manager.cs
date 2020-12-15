using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public Boton[] botones;
    public int Posicion = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown (KeyCode.D))
        {
            botones[Posicion].Seleccionado = false;
            Posicion++;

            if(Posicion <0)
            {
                Posicion = botones.Length - 1;
                botones[Posicion].Seleccionado = true;
                return;
            }
            if (Posicion > botones.Length -1)
            {
                Posicion = 0;
                botones[Posicion].Seleccionado = true;
                return;
            }

            botones [Posicion].Seleccionado = true;

        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            botones[Posicion].Seleccionado = false;
            Posicion--;

            if (Posicion < 0)
            {
                Posicion = botones.Length - 1;
                botones[Posicion].Seleccionado = true;
                return;
            }
            if (Posicion > botones.Length - 1)
            {
                Posicion = 0;
                botones[Posicion].Seleccionado = true;
                return;
            }

            botones [Posicion].Seleccionado = true;
        }

        if (botones[0].Seleccionado && Input.GetKeyDown(KeyCode.Space))
        {
            print("arriba");
            
        }

        if (botones[1].Seleccionado && Input.GetKeyDown(KeyCode.Space))
        {
            print("izquierda");

        }

        if (botones[2].Seleccionado && Input.GetKeyDown(KeyCode.Space))
        {
            print("abajo");

        }

        if (botones[3].Seleccionado && Input.GetKeyDown(KeyCode.Space))
        {
            print("derecha");

        }
    }  


}
