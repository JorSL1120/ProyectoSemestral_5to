using UnityEngine;

public class Boton : MonoBehaviour
{
    public GameObject Balls, Cubes;

    void Start()
    {
        
    }

    void Update()
    {
        PressEnter();
    }

    public void PressButton()
    {
        Instantiate(Balls);
    }

    public void PressEnter()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            Instantiate(Cubes);
        }
    }
}
