using UnityEngine;

public class Player2 : BasePlayerController, IAimable, IMoveable, IAttackable
{
    private IMovement movement;
    private IAttack attack;

    public Vector2 Position
    {
        get
        {
            return _aimPosition;
        }

        set
        {
            _aimPosition = value;
            Debug.Log("Aim from " + this.name);
        }
    }

    protected override void Awake()
    {
        base.Awake();

        movement = GetComponent<Movement3D>();
        attack = GetComponent<ExplosionAttack>();

        Debug.Log("Player2 Awake");
    }

    protected override void Start()
    {
        base.Start();

        Debug.Log("Player2 Start");
    }

    public void Move(Vector2 direction)
    {
        movement.Move(direction);
        Debug.Log("Move from " + this.name);
    }

    public void Attack(Vector2 position)
    {
        attack.Attack(position);
        Debug.Log("Attack from " + this.name);
    }

    private void Update()
    {
        Vector2 inputDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        Move(inputDirection);

        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePosition = Input.mousePosition;
            Attack(mousePosition);
        }
    }
}

