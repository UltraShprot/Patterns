using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class MoveObject : MonoBehaviour
{
    private CompositeDisposable _disposable = new CompositeDisposable();
    public ReactiveCommand SubscribeToUpdate = new ReactiveCommand();
    void Start()
    {
        SubscribeToUpdate.Subscribe(_ => { 
        Observable.EveryUpdate().Subscribe(_ =>
        {
            transform.position += transform.forward * Time.deltaTime;
            if (transform.position.z > 0)
            {
                _disposable.Clear();
            }

        }).AddTo(_disposable);
         }).AddTo(_disposable);
    }
}
