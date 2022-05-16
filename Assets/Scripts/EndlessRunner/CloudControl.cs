using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudControl : MonoBehaviour
{
    public float moveSpeed;

    private Rigidbody2D rb;
    private Vector2 moveVelocity;
    private Vector2 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        //DESTROY CLOUD
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, -Screen.height * 2, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(rb.velocity.x, -moveSpeed);

        if(transform.position.y > screenBounds.y)
        {
            Destroy(this.gameObject);
        }
    }
}
