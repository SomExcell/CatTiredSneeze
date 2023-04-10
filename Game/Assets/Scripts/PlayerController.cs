using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public bool facingRight = true;
    public Animator animator;
    private Vector2  direction;
    private Vector2 mousePos;

    private Rigidbody2D rb;
    public Camera cam;

    public Transform firePoint;
    public GameObject bulletPrefab;

    public float bulletForce = 5f;
    public float FireRate = 0.5f;
    private float nextShoot = 0.0f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.y = Input.GetAxisRaw("Vertical");
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

        animator.SetFloat("Horizontal", direction.x);
        animator.SetFloat("Vertical", direction.y);
        animator.SetFloat("Speed", direction.sqrMagnitude);

        if((Input.GetButton("Fire1") || Input.GetButton("Fire2")) && Time.time > nextShoot)
        {
            nextShoot = Time.time + FireRate;
            Shoot();
        }

    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + direction * speed * Time.fixedDeltaTime);
        float h = Input.GetAxis("Horizontal");
        if (h > 0 && !facingRight)
            Flip();
        else if (h < 0 && facingRight)
            Flip();
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theSacle = transform.localScale;
        theSacle.x *= -1;
        transform.localScale = theSacle;
    }

    void Shoot()
    {
        bool up = Input.GetKey(KeyCode.UpArrow);
        bool down = Input.GetKey(KeyCode.DownArrow);
        bool left = Input.GetKey(KeyCode.LeftArrow);
        bool right = Input.GetKey(KeyCode.RightArrow);
        Vector2 force;
        if(down)
        {
            force = -firePoint.up;
        }
        else if (up)
        {
            force = firePoint.up;
        }
        else if (left)
        {
            force = -firePoint.right;
        }
        else
        {
            force = firePoint.right;
        }
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rbBullet = bullet.GetComponent<Rigidbody2D>();
        rbBullet.AddForce(force * bulletForce, ForceMode2D.Impulse);
    }
}
