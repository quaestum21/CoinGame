using R3;
using System;
using UnityEngine;

public sealed class PanelFirstClick : MonoBehaviour
{
    private IDisposable _disposable; 
    
    private void HidePanel()
    {
        if (Input.GetMouseButtonDown(0))
            gameObject.SetActive(false);
    }
    private void OnEnable()
    {
        _disposable = Observable.EveryUpdate().Subscribe(_ => HidePanel());
    }
    private void OnDisable()
    {
        _disposable.Dispose();
    }
}
