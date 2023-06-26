using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Input
{
    public class ReaderInput : ReaderIInput
    {
        PlayerInput _playerInput;

        public float Horizontal  { get; private set; }

        public ReaderInput(PlayerInput playerInput)
        {
            _playerInput = playerInput;
            _playerInput.currentActionMap.actions[0].performed += OnHorizontalMove;

        }

        private void OnHorizontalMove(InputAction.CallbackContext context)
        {
            Horizontal = context.ReadValue<float>();
        }
    }

}
