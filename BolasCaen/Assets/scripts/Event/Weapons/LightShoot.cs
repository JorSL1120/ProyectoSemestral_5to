using System.Collections;
using UnityEngine;

public class LightShoot : MonoBehaviour
{
    public static LightShoot instance;
    public Light lightShoot;

    void Start()
    {
        lightShoot.enabled = false;
    }

    [ContextMenu("Simulate Light")]
    public void ActiveLight()
    {
        StartCoroutine(RoutineEnableLight());
    }

    IEnumerator RoutineEnableLight()
    {
        lightShoot.enabled = true;
        yield return new WaitForSeconds(1f);
        lightShoot.enabled = false;
    }
}
