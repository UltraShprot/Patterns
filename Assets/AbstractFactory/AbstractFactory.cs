using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractFactory : MonoBehaviour 
{
    public abstract GameObject CreateDefaultObject();
    public abstract GameObject CreateModifiedObject();
}