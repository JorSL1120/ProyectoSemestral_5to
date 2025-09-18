using UnityEngine;

public class PlayerEvents : MonoBehaviour
{
    public Weapon weapon;

    public void Update()
    {
        Shoot();
    }

    public void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            weapon?.Attack();
        }
    }
}
