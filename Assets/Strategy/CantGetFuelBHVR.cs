using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CantGetFuelBHVR : IGetFuelBHVR
{
    ObjectBase _objectBase;
    public CantGetFuelBHVR(ObjectBase objectBase)
    {
        this._objectBase = objectBase;
    }
    public void GetFuel()
    {
        Debug.Log("It cant do this!");
    }
}
