using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBase : MonoBehaviour
{
    [SerializeField] public ParticleSystem particleSystem;
    [SerializeField] public AudioSource audioSource;
    [SerializeField] public AudioClip clip;
    


    protected IGetFuelBHVR _getFuelBHVR;
    protected IWorkBHVR _workBHVR;


    public void SetWorkBHVR(IWorkBHVR workBHVR)
    {
        _workBHVR= workBHVR;
    }
    public void SetGetFuelBHRV(IGetFuelBHVR getFuelBHVR)
    {
        _getFuelBHVR= getFuelBHVR;
    }

    public void Work()
    {
        _workBHVR.Work();
    }
    public void GetFuel()
    {
        _getFuelBHVR.GetFuel();
    }
}
