using System;
using UnityEngine;
namespace GameInput
{
    public class UserInput : MonoBehaviour
    {
        public event Action OnAKeyPressedAction;
        public event Action OnDKeyPressedAction;
        public event Action OnSpaceKeyPressedAction;
        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.A))
            {
                OnAKeyPressedAction?.Invoke();
            }

            if(Input.GetKeyDown(KeyCode.D))
            {
                OnDKeyPressedAction?.Invoke();
            }

            if(Input.GetKeyDown(KeyCode.Space))
            {
                OnSpaceKeyPressedAction?.Invoke();
            }
        }
    }

}

