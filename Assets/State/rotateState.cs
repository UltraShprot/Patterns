using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateState : State
{
    private GameObject _gameObject;
    protected HashAnimation anim = new HashAnimation();
    public rotateState(GameObject gameObject)
    {
        _gameObject = gameObject;
    }

    public void Enter()
    {
        _gameObject.GetComponent<Animator>().CrossFade(anim.rotate, 0);
        _gameObject.GetComponent<ObjectLogic>().speed = 1.5f;
    }
    public  void Exit()
    {
        _gameObject.GetComponent<Animator>().StopPlayback();
    }
    public  void Update()
    {
        Debug.Log("Update work! Rotate!");
    }
}
