using JetBrains.Annotations;
using UnityEngine;

public class PlayerTanque : MonoBehaviour
{
    public int speed = 4;
    private CharacterController cc;

    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    void Update()
    {
        MovePlayer();
    }

    public void MovePlayer()
    {
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(xInput, 0f, yInput);
        cc.Move(move * Time.deltaTime);
    }
}
