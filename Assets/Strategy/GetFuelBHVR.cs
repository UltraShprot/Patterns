using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetFuelBHVR : IGetFuelBHVR
{
    ObjectBase _objectBase;
    public GetFuelBHVR(ObjectBase objectBase)
    {
        this._objectBase = objectBase;
    }
    public void GetFuel()
    {
        Debug.Log("get fuel.");
    }
}
