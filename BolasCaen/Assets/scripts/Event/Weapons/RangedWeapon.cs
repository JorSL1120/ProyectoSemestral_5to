using UnityEngine;

public class RangedWeapon : Weapon
{
    [Header("Ranged Weapons Parameters")]
    public int ammo;
    public int clip;
    public Transform pointToShoot;
}
