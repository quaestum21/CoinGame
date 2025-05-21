using UnityEngine;

public class CoinMover : MonoBehaviour
{
    private bool _isMoving;
    private float _speedOfMoving;
    public bool IsMoving { get => _isMoving; set => _isMoving = value; }
    public float SpeedOfMoving { get => _speedOfMoving; set => _speedOfMoving = value; }

    private void Start()
    {
        
    }
}
