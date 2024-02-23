using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private bool shouldStopMovement = false;

    void Update()
    {
        if (!shouldStopMovement)
        {
            // Tu l�gica de movimiento actual aqu�
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Obstacles"))
        {
            shouldStopMovement = true;
            // Puedes agregar aqu� cualquier l�gica adicional que desees.
        }
    }

    // Este m�todo puede ser llamado cuando necesitas restablecer el estado (por ejemplo, cuando el personaje sale de la colisi�n).
    void ResetState()
    {
        shouldStopMovement = false;
    }
}
