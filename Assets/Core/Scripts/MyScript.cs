using R3;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{
  
    CompositeDisposable disposables = new CompositeDisposable();
    private void Awake()
    {
        Observable.EveryUpdate().Subscribe(_ => hidePanel()).AddTo(disposables);
    }
    private void hidePanel()
    {
        if(Input.GetMouseButtonDown(0)) 
         gameObject.SetActive(false);
    }
    private void OnDisable()
    {
        disposables.Dispose();
    }
}
