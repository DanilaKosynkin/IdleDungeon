using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackGround : MonoBehaviour
{
    public GameObject quadGameObject;
    private Renderer quadRenderer;

    float scrollSpeed = 0.025f;

    void Start()
    {
        quadRenderer = quadGameObject.GetComponent<Renderer>();
    }

    void Update()
    {
        Vector2 textureOffset = new Vector2(Time.time*scrollSpeed,0);
        quadRenderer.material.mainTextureOffset = textureOffset;
    }
}
