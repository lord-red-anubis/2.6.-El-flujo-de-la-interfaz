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
            // Tu lógica de movimiento actual aquí
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Obstacles"))
        {
            shouldStopMovement = true;
            // Puedes agregar aquí cualquier lógica adicional que desees.
        }
    }

    // Este método puede ser llamado cuando necesitas restablecer el estado (por ejemplo, cuando el personaje sale de la colisión).
    void ResetState()
    {
        shouldStopMovement = false;
    }
}
