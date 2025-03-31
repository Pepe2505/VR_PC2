using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float velocidad = 15f; // Cambio a minúscula por convención de nombres en C#

    void Update()
    {
        // Calculamos la dirección en X (1 si presiona D, -1 si presiona A, 0 si no presiona nada)
        float inputX = (Input.GetKey(KeyCode.D) ? 1 : 0) + (Input.GetKey(KeyCode.A) ? -1 : 0);

        // Movemos el objeto sumando el desplazamiento calculado
        transform.position += new Vector3(inputX * Time.deltaTime * velocidad, 0, 0);
    }
}

