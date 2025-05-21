using UnityEngine;

public class CoinCreator : MonoBehaviour
{
    [SerializeField] private Coin _initialCoinPrefab;
    [SerializeField] private Transform _pointForInitialInstance;

    private GameObject _createdInitialCoin;

    public void CreateInitialCoin() 
    {
        _createdInitialCoin = Instantiate(_initialCoinPrefab.gameObject, _pointForInitialInstance.position, Quaternion.identity);
    }
}
