using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Animator _anim;
    [SerializeField] private float _moveSpeed;
    private Rigidbody _rb;

    public void Move(Vector2 direction)
    {
        if(direction.x < 0)
        {
            transform.Rotate(0, Time.deltaTime * -100, 0);
        }
        else if(direction.x > 0)
        {
            transform.Rotate(0, Time.deltaTime * 100, 0);
        }

        if (direction.y != 0)
        {
            if(direction.y > 0)
            {
                _anim.SetBool("IsWalking", true);
                _anim.SetBool("IsWalkingBackwards", false);
                _rb.velocity = transform.forward * -_moveSpeed;
            }
            else
            {
                _anim.SetBool("IsWalking", false);
                _anim.SetBool("IsWalkingBackwards", true);
                _rb.velocity = transform.forward * _moveSpeed;
            }
        }
        else
        {
            _anim.SetBool("IsWalking", false);
            _anim.SetBool("IsWalkingBackwards", false);
        }
    }

    public void Jump()
    {
        _anim.SetTrigger("Jump");
    }

    private void Start()
    {
        Initialize();
    }

    private void Initialize()
    {
        _rb = GetComponent<Rigidbody>();
    }
}
