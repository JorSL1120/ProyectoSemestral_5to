using UnityEngine;

public class Character : MonoBehaviour
{
    public float speed = 3f;
    public Vector3 direction;
    public float maxDistance = 5f;

    public Vector3 startPos;
    public float delta = 0;

    private void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        Move();
    }

    public virtual void Move()
    {

    }
}
