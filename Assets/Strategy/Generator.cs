using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : ObjectBase
{
    void Start() 
    {
        SetWorkBHVR(new GiveEnergyBHVR(this));
        SetGetFuelBHRV(new GetFuelBHVR(this));
    }
}

