using UnityEngine;

public class PlayerMoveAddForce : MonoBehaviour
{
    public float force = 10f;
    public float rotationSpeed = 500f;
    private Rigidbody _rb;

    void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(moveHorizontal, 0.0f, moveVertical) * force;
        _rb.AddForce(direction);
        // _rb.velocity = direction;

        // поворот
        if (direction != Vector3.zero)
        {

            Quaternion rotation = Quaternion.LookRotation(direction);
            _rb.rotation = Quaternion.RotateTowards(_rb.rotation, rotation, rotationSpeed * Time.fixedDeltaTime);
        }
    }
}
