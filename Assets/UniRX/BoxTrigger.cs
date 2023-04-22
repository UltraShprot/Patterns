using System.Collections;
using System.Collections.Generic;
using UniRx;
using UniRx.Triggers;
using UnityEngine;

public class BoxTrigger : MonoBehaviour
{
    private CompositeDisposable _disposable = new CompositeDisposable();
    public Collider trigger;
    [SerializeField] private GameObject capsule;
    // Start is called before the first frame update
    void Start()
    {
        trigger.OnTriggerEnterAsObservable()
            .Where(x => x.gameObject.tag == "Player")
            .Subscribe(_ =>
            {
                Destroy(capsule);
                _disposable.Clear();
                Debug.Log("trigger enter!");
            }).AddTo(_disposable);
    }
}
