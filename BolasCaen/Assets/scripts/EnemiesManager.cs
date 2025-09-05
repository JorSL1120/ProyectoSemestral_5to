using UnityEngine;

public class EnemiesManager : MonoBehaviour
{
    public PoolManager poolEnemies;

#if UNITY_EDITOR
    public void OnValidate()
    {
        poolEnemies = FindFirstObjectByType<PoolManager>();
    }
#endif

    void Start()
    {
        CreateEnemies();
    }

    public void CreateEnemies()
    {
        poolEnemies.CreateObject();
    }
}
