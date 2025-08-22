using UnityEngine;
using UnityEngine.InputSystem.Controls;
using UnityEngine.UIElements;

public class Player : Character
{
    /* Este fue mi intento :)
    public CharacterController CC;
    public float speedPlayer = 4;
    public float MaxX = 3f;

    void Start()
    {
        
    }

    void Update()
    {
        Move();
    }

    public void Move()
    {
        float horizontal = Input.GetAxis("Horizontal");

        Vector3 move = transform.right * horizontal;
        CC.Move(move * speedPlayer * Time.deltaTime);

        Vector3 position = transform.position;

        position.x = Mathf.Clamp(position.x, -MaxX, MaxX);

        transform.position = position;
    }*/

    public string axis = "Horizontal";

    public override void Move()
    {
        delta += Input.GetAxis(axis) * Time.deltaTime * speed;
        delta = Mathf.Clamp(delta, -maxDistance, maxDistance);
        transform.position = startPos + (direction * delta);
    }
}
