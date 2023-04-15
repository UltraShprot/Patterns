using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class pickState : State
{
    private GameObject _gameObject;
    protected HashAnimation anim = new HashAnimation();
    public pickState(GameObject gameObject)
    {
        _gameObject = gameObject;
    }

    public void Enter()
    {
        _gameObject.GetComponent<Animator>().CrossFade(anim.pick, 0);
        _gameObject.GetComponent<ObjectLogic>().speed = 0f;
    }
    public void Exit()
    {
        _gameObject.GetComponent<Animator>().StopPlayback();
        _gameObject.GetComponent<ObjectLogic>().Destroy();
    }
    public void Update()
    {

    }
}
