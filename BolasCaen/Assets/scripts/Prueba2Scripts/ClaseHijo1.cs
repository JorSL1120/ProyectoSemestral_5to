using UnityEngine;

public class ClaseHijo1 : ClasePadre
{
    public override void ClasePrueba()
    {
        base.ClasePrueba();
        Debug.Log("Yo soy tu Hijo 1");
    }
}
