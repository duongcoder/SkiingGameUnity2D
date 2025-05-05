using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField] float torque = 1;
    [SerializeField] float boostSpeed = 10f;
    [SerializeField] float normalSpeed = 5f;

    public bool check = true;

    Rigidbody2D rb;

    SurfaceEffector2D surfaceEffector2D;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (check)
        {
            Rotate();
            BoostSpeed();
        }
    }

    public void StopMove()
    {
        check = false;
    }

    private void BoostSpeed()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            surfaceEffector2D.speed = boostSpeed;
        }
        else
        {
            surfaceEffector2D.speed = normalSpeed;
        }
    }

    void Rotate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddTorque(torque);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddTorque(-torque);
        }
    }
}
