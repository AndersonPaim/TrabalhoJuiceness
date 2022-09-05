using System;
using Coimbra.Services;
using Coimbra.Services.Events;
using UnityEditor;
using UnityEngine;
//using UnityEngine.InputSystem;

namespace _Project.Scripts.Manager
{
    public class InputManager : MonoBehaviour
    {
        //[SerializeField] private PlayerController _player;

        //private PlayerInputActions _input;
        private IEventService _eventService;

        public void OnStart()
        {
            SetupEvents();
            //_input.Enable();
            _eventService = ServiceLocator.Get<IEventService>();
        }

        public void OnUpdate()
        {
            Movement();
        }

        private void OnDestroy()
        {
            DestroyEvents();
        }

        private void SetupEvents()
        {
            //_input = new PlayerInputActions();
            //_input.Player.Jump.performed += Jump;
        }

        private void DestroyEvents()
        {
            //_input.Player.Jump.performed -= Jump;
            //_input.Player.Grab.performed -= Grab;
        }

        private void Movement()
        {
           // _player.Move(_input.Player.Movement.ReadValue<Vector2>());
        }

        /*private void Jump(InputAction.CallbackContext ctx)
        {
           // _player.Jump();
        }*/
    }
}
