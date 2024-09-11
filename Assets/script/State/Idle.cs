using UnityEngine;

public class Idle : Grounded
{
    private float _horizontalInput;

    public Idle(MovementSM stateMachine) : base("Idle", stateMachine) {}

    public override void Enter()
    {
        base.Enter();
        sm.spriteRenderer.color = Color.black; // Character turns black when idle
        _horizontalInput = 0f;
    }

    public override void UpdateLogic()
    {
        base.UpdateLogic();
        _horizontalInput = Input.GetAxis("Horizontal");

        // Transition to Moving state if there is horizontal input
        if (Mathf.Abs(_horizontalInput) > Mathf.Epsilon)
        {
            stateMachine.ChangeState(sm.movingState);
        }
    }
}
