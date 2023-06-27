using Input;
using Managers;
using Mover;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Controller
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] float _moveSpeed = 10f;
        [SerializeField] float _jumpForce = 300f;
        [SerializeField] float _moveRoundary = 4.5f;

        HorizontalMover _horizontalMover;
        JumpWithRigidbody _jump;
        ReaderIInput _input;
        float _horizontal;
        bool _isJump;
        bool _isDead = false;
        public float MoveSpeed => _moveSpeed;
        public float MoveRoundary => _moveRoundary;

        private void Awake()
        {
            _horizontalMover = new HorizontalMover(this);
            _jump = new JumpWithRigidbody(this);
            _input = new ReaderInput(GetComponent<PlayerInput>());
        }
        private void Update()
        {
            if (_isDead) return;
            _horizontal = _input.Horizontal;
            if (_input.IsJump)
            {
                _isJump = true;
            }
        }
        private void FixedUpdate()
        {
            _horizontalMover.TickFixed(_horizontal);

            if (_isJump)
            {
                _jump.TickFixed(_jumpForce);
            }
            _isJump = false;
        }
        private void OnTriggerEnter(Collider other)
        {
            EnemyController enemyController = other.GetComponent<EnemyController>();

            if (enemyController != null)
            {
                _isDead = true;
                GameManager.Instance.StopGame();
            }
        }

    }
}
