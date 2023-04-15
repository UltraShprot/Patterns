using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderFactory : AbstractFactory
{
    private Transform _spawnPoint;
    public CylinderFactory(Transform spawnPoint)
    {
        _spawnPoint = spawnPoint;
    }


    public override GameObject CreateDefaultObject()
    {
        var _cylinderDefault = Resources.Load<GameObject>("Cylinder");
        return Instantiate(_cylinderDefault, _spawnPoint.position, _spawnPoint.rotation);
    }
    public override GameObject CreateModifiedObject()
    {
        var _cylinderModified = Resources.Load<GameObject>("CylinderModified");
        return Instantiate(_cylinderModified, _spawnPoint.position, _spawnPoint.rotation);
    }
}
