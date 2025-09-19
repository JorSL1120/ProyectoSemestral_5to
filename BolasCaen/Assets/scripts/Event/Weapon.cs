using UnityEngine;

public class Weapon : MonoBehaviour
{
    [Header("Damage stats")]
    public int damage;

    public virtual void Attack()
    {
        Debug.Log("k gaste");
    }
}
