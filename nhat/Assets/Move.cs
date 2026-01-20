using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(moveX, moveY, 0);
        transform.Translate(direction * speed * Time.deltaTime);

        Debug.Log("Move X: " + moveX + " | Move Y: " + moveY);
    }
}