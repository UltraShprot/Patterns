using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : ObjectBase
{
    private void Start()
    {
        SetGetFuelBHRV(new CantGetFuelBHVR(this));
        SetWorkBHVR(new TakeWastesBHVR(this));
    }
}

