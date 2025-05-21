using UnityEngine;

public abstract class Coin : MonoBehaviour
{
    [HideInInspector] public CoinSprite Sprite;
    private void Start()
    {
        Sprite = GetComponent<CoinSprite>();
    }
    public virtual string GetType()
    {
        return "";
    }
}
