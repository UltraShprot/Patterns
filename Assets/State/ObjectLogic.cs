using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectLogic : MonoBehaviour
{
    private StateMachine _stateMachine;
    private float timer;
    public float speed = 1.5f;
    private void Start()
    {
        _stateMachine= new StateMachine();
        _stateMachine.InitState(new rotateState(gameObject));
    }
    public void Destroy()
    {
        Destroy(gameObject, 10f);
    }
    private void Update()
    {
        _stateMachine.state.Update();
        timer += Time.deltaTime;
        transform.position -= transform.forward * Time.deltaTime * speed;
        switch (timer)
        {
            case (> 5f):
                _stateMachine.ChangeState(new pickState(gameObject)); 
                break;
            case (> 2.5f):
                _stateMachine.ChangeState(new changeposState(gameObject)); 
                break;
        }
    }
}
