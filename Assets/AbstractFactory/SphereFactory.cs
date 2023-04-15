using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereFactory : AbstractFactory
{
    private Transform _spawnPoint;
    public SphereFactory(Transform spawnPoint)
    {
        _spawnPoint = spawnPoint;
    }


    public override GameObject CreateDefaultObject()
    {
        var _default = Resources.Load<GameObject>("Sphere");
        return Instantiate(_default, _spawnPoint.position, _spawnPoint.rotation);
    }
    public override GameObject CreateModifiedObject()
    {
        var _modified = Resources.Load<GameObject>("SphereModified");
        return Instantiate(_modified, _spawnPoint.position, _spawnPoint.rotation);
    }
}
