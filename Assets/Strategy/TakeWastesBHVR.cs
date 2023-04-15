using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeWastesBHVR : IWorkBHVR
{
    ObjectBase _objectBase;
    public TakeWastesBHVR(ObjectBase objectBase)
    {
       this._objectBase= objectBase;
    }

    public void Work()
    {
        Debug.Log("take wastes, and create smoke.");
        _objectBase.audioSource.PlayOneShot(_objectBase.clip);
        _objectBase.GetComponent<ParticleSystem>().Play();
    }
}
