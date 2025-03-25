using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Velocidad = 15f;

    void Start()
    {
      
    }

    void Update()
    {
       float veloX = (Input.GetKey(KeyCode.D) ? 1 : 0) * Time.deltaTime * Velocidad;
        Vector3 posicion = transform.position;
        transform.position = new Vector3(veloX + posicion.x, posicion.y, posicion.z);

        float velox = (Input.GetKey(KeyCode.A) ? -1 : 0) * Time.deltaTime * Velocidad;
        Vector3 posicion2 = transform.position;
        transform.position = new Vector3(velox + posicion.x, posicion.y, posicion.z);
    }
}