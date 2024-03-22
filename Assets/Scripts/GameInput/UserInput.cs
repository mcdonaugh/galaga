using System;
using UnityEngine;

namespace Galaga.GameInput
{
    public class UserInput : MonoBehaviour
    {
        public event Action OnLeftKeyPressed;
        public event Action OnRightKeyPressed;
        public event Action OnFireKeyPressed;
        private void Update()
        {
            if(Input.GetKey(KeyCode.A))
            {
                OnLeftKeyPressed?.Invoke();
            }

            if(Input.GetKey(KeyCode.D))
            {
                OnRightKeyPressed?.Invoke();
            }

            if(Input.GetKeyDown(KeyCode.Space))
            {
                OnFireKeyPressed?.Invoke();
            }
        }
    }

}

