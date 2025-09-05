using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    public GameObject prefabToCreate;
    public List<GameObject> createdObjects;

    public void CreateObject()
    {
        createdObjects.Add(Instantiate(prefabToCreate));
    }
}
