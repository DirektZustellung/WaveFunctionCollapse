using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Texture2D cursorTexture; // Asigna tu textura de cursor personalizada desde el Inspector
    public Vector2 hotSpot = Vector2.zero; // Ajusta el punto caliente del cursor si es necesario

    void Start()
    {
        // Cambia el cursor del ratón al inicio del juego
        SetCustomCursor();
    }

    void SetCustomCursor()
    {
        // Asigna la textura personalizada al cursor del ratón
        Cursor.SetCursor(cursorTexture, hotSpot, CursorMode.Auto);
    }

    // Método opcional para restaurar el cursor predeterminado
    public void ResetCursor()
    {
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
    }
}
