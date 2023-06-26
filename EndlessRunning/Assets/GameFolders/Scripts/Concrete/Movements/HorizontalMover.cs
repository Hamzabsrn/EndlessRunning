using Controller;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mover
{
    public class HorizontalMover
    {
        PlayerController _playerController;

        float _moveRoundary;
        float _moveSpeed;
        public HorizontalMover(PlayerController playerController)
        {
            _playerController = playerController;
            _moveSpeed = _playerController.MoveSpeed;
            _moveRoundary = playerController.MoveRoundary;
        }
        public void TickFixed(float horizontal)
        {
            if (horizontal == 0) return;

            _playerController.transform.Translate(Vector3.right * horizontal * Time.deltaTime * _moveSpeed);

            float xBoundary = Mathf.Clamp(_playerController.transform.position.x, -_moveRoundary, _moveRoundary);
            _playerController.transform.position = new Vector3(xBoundary, _playerController.transform.position.y, 0f);
        }

    }

}
