using UnityEngine;

public class GameStartup : MonoBehaviour
{
    [SerializeField] private GameObject _menuPanel;
    [SerializeField] private GameObject _gamePanel;
    [SerializeField] private GameObject _generalPanel;

    [SerializeField] private CoinCreator _coinCreator;
    private void Awake()
    {
        InitializeMenu();
    }
    public void InitializeMenu()
    {
        SetupPanelsStates();
        _coinCreator.CreateInitialCoin();
    }

    private void SetupPanelsStates()
    {
        _gamePanel.SetActive(false);
        _generalPanel.SetActive(false);
        _menuPanel.SetActive(true);
    }
}
