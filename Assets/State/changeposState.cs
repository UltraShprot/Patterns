using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeposState : State 
{ 
    private GameObject _gameObject;
    protected HashAnimation anim = new HashAnimation();
    public changeposState(GameObject gameObject)
    {
        _gameObject = gameObject;
    }

    public void Enter()
    {
        _gameObject.GetComponent<Animator>().CrossFade(anim.position, 0);
        _gameObject.GetComponent<ObjectLogic>().speed = 1f;
    }
    public void Exit()
    {
        _gameObject.GetComponent<Animator>().StopPlayback();
    }
    public void Update()
    {
        Debug.Log("Update work! Change position!");
    }
}
