using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{
    //Фабрика
    [SerializeField] Transform spawnPoint1;
    [SerializeField] Transform spawnPoint2;
    private AbstractFactory _factory;


    //Стратегия
    [SerializeField] ObjectBase _pipe;
    [SerializeField] ObjectBase _generator;

    //Стратегия
    public void GeneratorWorkButton()
    {
        _generator.Work();
    }
    public void PipeWorkButton()
    {
        _pipe.Work();
    }
    public void PipeFuelButton()
    {
        _pipe.GetFuel();
    }
    public void GeneratorFuelButton()
    {
        _generator.GetFuel();
    }



    //Фабрика
    public void CreateDefaultCylinder()
    {
        _factory = new CylinderFactory(spawnPoint1);
        _factory.CreateDefaultObject();
        //  spawnPoint1.position = new Vector3(spawnPoint1.position.x, spawnPoint1.position.y, spawnPoint1.position.z - 2);
    }
    public void CreateModCylinder()
    {
        _factory = new CylinderFactory(spawnPoint1);
        _factory.CreateModifiedObject();
        //   spawnPoint1.position = new Vector3(spawnPoint1.position.x, spawnPoint1.position.y, spawnPoint1.position.z - 2);
    }
    public void CreateDefaultSphere()
    {
        _factory = new SphereFactory(spawnPoint2);
        _factory.CreateDefaultObject();
        //   spawnPoint2.position = new Vector3(spawnPoint2.position.x, spawnPoint2.position.y, spawnPoint2.position.z - 2);
    }
    public void CreateModSphere()
    {
        _factory = new SphereFactory(spawnPoint2);
        _factory.CreateModifiedObject();
        //   spawnPoint2.position = new Vector3(spawnPoint2.position.x, spawnPoint2.position.y, spawnPoint2.position.z - 2);
    }

}
