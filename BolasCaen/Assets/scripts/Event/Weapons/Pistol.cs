using UnityEngine;

public class Pistol : RangedWeapon
{
    public override void Attack()
    {
        Ray ray = new Ray(pointToShoot.position, pointToShoot.forward);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            Debug.DrawLine(pointToShoot.position, hit.point, Color.red);
            Debug.Log("Si dispare" + hit.point);
        }
    }
}
