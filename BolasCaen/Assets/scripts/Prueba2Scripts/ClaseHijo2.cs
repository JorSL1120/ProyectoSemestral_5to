using UnityEngine;

public class ClaseHijo2 : ClasePadre
{
    public override void ClasePrueba()
    {
        Debug.Log("Yo soy tu Hijo 2");
        base.ClasePrueba();
    }
}
