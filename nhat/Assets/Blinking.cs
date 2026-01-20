using UnityEngine;

public class Blinking : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
private SpriteRenderer spriteRenderer;

// Start is called before the first frame update
void Start()
{
spriteRenderer = GetComponent<SpriteRenderer>();
}

// Update is called once per frame
void Update()
{
spriteRenderer.enabled = !spriteRenderer.enabled;
}
}
