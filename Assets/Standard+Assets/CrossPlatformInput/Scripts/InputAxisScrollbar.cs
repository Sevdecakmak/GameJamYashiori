using System;
using UnityEngine;

namespace UnityStandardAssets.CrossPlatformInput
{
    public class InputAxisScrollbar1 : MonoBehaviour
    {
        public string axis;

	    void Update() { }

	    public void HandleInput(float value)
        {
            CrossPlatformInputManager.SetAxis(axis, (value*2f) - 1f);
        }
    }
}
