using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Tiles : MonoBehaviour
{
    [SerializeField] private Color _color1, _color2;
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private GameObject HighLight;

    private GameObject LastHovered;
    public void SetColor(bool isDifferent)
    {
        _spriteRenderer.color = isDifferent ? _color1 : _color2;
    }

    void Update()
    {
        Vector2 mousePos = Mouse.current.position.ReadValue(); // mostra a posicao do mouse
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(mousePos); // mostra a posicao do mouse em relação a tela toda


        RaycastHit2D hit = Physics2D.Raycast(worldPos, Vector2.zero);

        if (hit.collider != null) // se tiver colisao...
        {
            if (LastHovered != hit.collider.gameObject)
            {
                if (LastHovered != null)
                {
                    LastHovered.transform.GetChild(0).gameObject.SetActive(false);
                }
                LastHovered = hit.collider.gameObject;
                hit.collider.gameObject.transform.GetChild(0).gameObject.SetActive(true);
            }
        }
        else if (LastHovered != null)
        {
            LastHovered.transform.GetChild(0).gameObject.SetActive(false);
            LastHovered = null;
        }


    }

}
