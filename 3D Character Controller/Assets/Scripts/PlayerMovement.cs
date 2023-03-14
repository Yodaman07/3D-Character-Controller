using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private InputMaster _inputMaster;
    private void Awake()
    {
        _inputMaster = new InputMaster();
        _inputMaster.Player.Movement.performed += ctx => Move(ctx);
    }

    void Move(InputAction.CallbackContext ctx)
    {
        print(ctx.ReadValue<Vector2>());
        Vector2 pos = ctx.ReadValue<Vector2>();
        transform.Translate(pos.x, 0, pos.y);
    }

    private void OnEnable()
    {
        _inputMaster.Player.Movement.Enable();
    }

    private void OnDisable()
    {
        _inputMaster.Player.Movement.Disable();
    }
}
