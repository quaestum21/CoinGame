using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class CoinSprite : MonoBehaviour
{
    public void SetupSprite(Sprite sprite)
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = sprite;
    }
}
