using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private Color _baseColor, _offsetColor;
    [SerializeField] private SpriteRenderer _renderer;
    [SerializeField] private GameObject highlight;
 
    public void Init(bool isOffset) 
    {
        _renderer.color = isOffset ? _offsetColor : _baseColor;
    }

    void OnMouseEnter() 
    {
        {
            highlight.SetActive(true);
        }
    }

    void OnMouseExit() 
    {
        {
            highlight.SetActive(false);
        }
    }

}
