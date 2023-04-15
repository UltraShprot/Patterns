using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveEnergyBHVR : IWorkBHVR
{
    ObjectBase _objectBase;
    public GiveEnergyBHVR(ObjectBase objectBase) 
    {
        this._objectBase = objectBase;
    }

    public void Work() 
    {
        Debug.Log("give energy");
        _objectBase.audioSource.PlayOneShot(_objectBase.clip);
    }
}
