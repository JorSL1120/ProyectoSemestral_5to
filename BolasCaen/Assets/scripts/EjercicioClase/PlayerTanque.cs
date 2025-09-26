using JetBrains.Annotations;
using UnityEngine;

public class PlayerTanque : MonoBehaviour
{
    public int speed;
    public int speedRotation;
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
        float inputRotate = Input.GetAxis("Horizontal2");
        transform.Rotate(Vector3.up * inputRotate * (speedRotation * Time.deltaTime));
        Vector3 move = (transform.right * xInput) + (transform.forward * yInput);
        cc.Move(move * (speed * Time.deltaTime));
    }
}
