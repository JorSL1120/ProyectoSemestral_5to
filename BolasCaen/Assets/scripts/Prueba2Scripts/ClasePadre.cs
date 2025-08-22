using UnityEngine;

public class ClasePadre : MonoBehaviour
{


    void Start()
    {
        
    }

    void Update()
    {
        ClasePrueba(); 
    }

    public virtual void ClasePrueba()
    {
        Debug.Log("Yo soy tu padre");
    }
}
