using UnityEngine;

namespace CustomDebug
{
    public class TestDebugText : MonoBehaviour
    {
        private void Start()
        {
            for (int i = 0; i < MyDebug.ColorLength; i++)
            {
                MyDebug.Log("TESTDEBUG", "Prueba de texto", i);
                MyDebug.Log("TESTDEBUG", "Prueba de texto", this, i);
                MyDebug.Log("TESTDEBUG", "Prueba de texto", this, i, DebugType.WARN);
                MyDebug.Log("TESTDEBUG", "Prueba de texto", this, i, DebugType.ERROR);
            }
        }
    }
}
