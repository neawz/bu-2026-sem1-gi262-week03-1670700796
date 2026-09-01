using UnityEngine;
using UnityEngine.InputSystem;

public class OOPPlayer : Character
{
    private InputAction moveAction;

    public void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
    }

    public void Update()
    {
        Vector2 direction = moveAction.ReadValue<Vector2>();
        if (moveAction.triggered)
        {
            Move(direction);
        }
    }

    public void Attack(OOPEnemy _enemy)
    {
        _enemy.TakeDamage(attackPoint);
    }

    protected override void CheckDead()
    {
        base.CheckDead();
    }
}
