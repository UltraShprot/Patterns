using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class ClientUniRX : MonoBehaviour
{
    CompositeDisposable _disposable = new CompositeDisposable();
    [SerializeField] MoveObject moveObject;
    [SerializeField] UnityEngine.UI.Button button;
    private void Start()
    {
        button.OnClickAsObservable().Subscribe
        (_ =>{
            moveObject.SubscribeToUpdate.Execute();
            _disposable.Clear();
        }).AddTo(_disposable);
    }
}
